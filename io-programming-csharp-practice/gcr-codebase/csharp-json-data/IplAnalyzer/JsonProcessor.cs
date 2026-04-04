using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

class JsonProcessor
{
    public static void ProcessJson(string inputPath, string outputPath)
    {
        string json = File.ReadAllText(inputPath);

        List<IPLMatch> matches =
            JsonSerializer.Deserialize<List<IPLMatch>>(json);

        foreach (var m in matches)
        {
            string maskedTeam1 = Censorship.MaskTeam(m.team1);
            string maskedTeam2 = Censorship.MaskTeam(m.team2);

            var newScore = new Dictionary<string, int>();
            foreach (var s in m.score)
            {
                string maskedKey = Censorship.MaskTeam(s.Key);
                newScore[maskedKey] = s.Value;
            }

            m.team1 = maskedTeam1;
            m.team2 = maskedTeam2;
            m.winner = Censorship.MaskTeam(m.winner);
            m.player_of_match = "REDACTED";
            m.score = newScore;
        }

        string censoredJson = JsonSerializer.Serialize(
            matches,
            new JsonSerializerOptions { WriteIndented = true }
        );

        File.WriteAllText(outputPath, censoredJson);
    }
}
