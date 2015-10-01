using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountSymbols
{
    static void Main()
    {
        string input = Console.ReadLine();
        SortedDictionary<char, int> dictionary = new SortedDictionary<char, int>();
        foreach(char symbol in input)
        {
            if (dictionary.ContainsKey(symbol))
            {
                dictionary[symbol]++;
            }
            else
            {
                dictionary.Add(symbol, 1);
            }
        }
        foreach(KeyValuePair<char, int> pair in dictionary)
        {
            Console.WriteLine("{0}: {1} time/s", pair.Key, pair.Value);
        }
    }
}
