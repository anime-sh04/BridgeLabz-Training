using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserBuddy
{
    internal class BrowserManager
    {
        private Stack<BrowserTab> closedTabs = new Stack<BrowserTab>();
        private BrowserTab currentTab = new BrowserTab();

        public void Visit(string url)
        {
            currentTab.Visit(url);
        }

        public void Back() => currentTab.Back();
        public void Forward() => currentTab.Forward();

        public void CloseTab()
        {
            closedTabs.Push(currentTab);
            currentTab = new BrowserTab();
            Console.WriteLine("Tab closed");
        }

        public void RestoreTab()
        {
            if (closedTabs.Count > 0)
            {
                currentTab = closedTabs.Pop();
                Console.WriteLine("Tab restored");
            }
            else
                Console.WriteLine("No closed tabs to restore");
        }
    }

}
