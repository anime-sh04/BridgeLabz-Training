class Program
{
    static void Main()
    {
        JsonProcessor.ProcessJson(
            "ipl_input.json",
            "ipl_censored.json"
        );

        CsvProcessor.ProcessCsv(
            "ipl_input.csv",
            "ipl_censored.csv"
        );

        System.Console.WriteLine("Censorship Completed Successfully.");
    }
}
