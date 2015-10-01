using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Phonebook
{
    static void Main()
    {
        Dictionary<string, List<string>> phonebook = new Dictionary<string, List<string>>();
        string input = Console.ReadLine();
        while(input != "search")
        {
            string[] contact = input.Split('-').ToArray();
            if (!phonebook.ContainsKey(contact[0]))
            {
                phonebook[contact[0]] = new List<string>();

            }
            phonebook[contact[0]].Add(contact[1]);
            input = Console.ReadLine();
        }
        string searchword = Console.ReadLine();
        while(searchword != "")
        {
            if (phonebook.ContainsKey(searchword))
            {
                Console.WriteLine("{0} -> {1}",searchword ,string.Join(", ", phonebook[searchword]) );
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", searchword);
            }
            searchword = Console.ReadLine();
        }

    }
}
