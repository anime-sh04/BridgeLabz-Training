namespace BrowserBuddy
{
    internal class Program
    {
        static void Main()
        {
            BrowserManager browser = new BrowserManager();

            browser.Visit("google.com");
            browser.Visit("github.com");
            browser.Visit("stackoverflow.com");

            browser.Back();
            browser.Back();
            browser.Forward();

            browser.CloseTab();
            browser.RestoreTab();
        }
    }
}
