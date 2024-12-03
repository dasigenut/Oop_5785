using System;
using System.Text;

namespace OperationTable
{
    internal class ComparerExample
    {
        List<string> list = new List<string>();
        public ComparerExample() 
        {
            list.Add("Isaac");
            list.Add("Jacob");
            list.Add("Moses");
            list.Add("Binyamin");
            list.Add("Avraham");
        }

        static int CompareLength(string a, string b)
        {
            return a.Length - b.Length;
        }

        public void SortByLength()
        {
            list.Sort(CompareLength);
        }

        public void Sort()
        {
            list.Sort();
        }


        public override string ToString()
        {
            // Console.WriteLine($"ToString. list.count={list.Count}");
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                // Console.WriteLine(list[i]);
                stringBuilder.Append(list[i]);
                if (i < list.Count - 1) { 
                    stringBuilder.Append("\n"); 
                }
            }
            return stringBuilder.ToString();
        }
    }
}
