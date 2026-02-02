class Censorship
{
    public static string MaskTeam(string team)
    {
        string[] parts = team.Split(' ');

        if (parts.Length == 2)
            return parts[0] + " ***";

        if (parts.Length >= 3)
            return parts[0] + " *** " + parts[parts.Length - 1];

        return "***";
    }
}
