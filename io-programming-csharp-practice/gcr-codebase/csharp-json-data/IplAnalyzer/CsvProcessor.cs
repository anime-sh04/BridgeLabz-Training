class CsvProcessor
{
    public static void ProcessCsv(string inputPath, string outputPath)
    {
        string[] lines = File.ReadAllLines(inputPath);
        List<string> output = new List<string>();

        output.Add(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            data[1] = Censorship.MaskTeam(data[1]); 
            data[2] = Censorship.MaskTeam(data[2]); 
            data[5] = Censorship.MaskTeam(data[5]); 
            data[6] = "REDACTED";                   
            output.Add(string.Join(",", data));
        }

        File.WriteAllLines(outputPath, output);
    }
}
