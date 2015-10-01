using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NightLife
{
    static void Main()
    {
        Dictionary<string, SortedDictionary<string, SortedSet<string>>> events = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();
        string input = Console.ReadLine();
        while(input != "END")
        {
            string[] objects = input.Split(';').ToArray();
            if (!events.ContainsKey(objects[0]))
            {
                events[objects[0]] = new SortedDictionary<string, SortedSet<string>>();
            }
            if (!events[objects[0]].ContainsKey(objects[1]))
            {
                events[objects[0]][objects[1]] = new SortedSet<string>();
            }
            events[objects[0]][objects[1]].Add(objects[2]);
            input = Console.ReadLine();
        }
        foreach(var townpair in events)
        {
            Console.WriteLine(townpair.Key);
            foreach(var eventpair in townpair.Value)
            {
                Console.WriteLine("->{0}: {1}", eventpair.Key, string.Join(", ", eventpair.Value));
            }
        }              
        
    }
}
