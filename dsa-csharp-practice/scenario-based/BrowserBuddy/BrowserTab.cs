using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserBuddy
{
    internal class BrowserTab
    {
        private HistoryNode current;

        public void Visit(string url)
        {
            HistoryNode node = new HistoryNode(url);

            if (current != null)
            {
                current.Next = node;
                node.Prev = current;
            }

            current = node;
            Console.WriteLine("Visited: " + url);
        }

        public void Back()
        {
            if (current?.Prev != null)
            {
                current = current.Prev;
                Console.WriteLine("Back to: " + current.Url);
            }
            else
                Console.WriteLine("No back history");
        }

        public void Forward()
        {
            if (current?.Next != null)
            {
                current = current.Next;
                Console.WriteLine("Forward to: " + current.Url);
            }
            else
                Console.WriteLine("No forward history");
        }

        public string GetCurrentPage()
        {
            return current?.Url;
        }
    }

}
