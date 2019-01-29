using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class JournalBad
    {
        private readonly List<string> entries = new List<string>();

        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count; //memento
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

        // This is a bad example because of all the saving and
        // loading functionality which is happening here in JournalBad
        // should be happening in a class of its own.
        public void Save(string filename)
        {
            File.WriteAllText(filename, ToString());
        }

        public static JournalBad Load(string filename)
        {
            return new JournalBad();
        }

        public void Load2(string uri)
        {
        }
    }

    class BadExample
    {
        /*static void Main(string[] args)
        {
            var j = new Journal2();
            j.AddEntry("I cried today");
            j.AddEntry("I ate a bug today");
            Console.WriteLine(j);
        }*/
    }
}
