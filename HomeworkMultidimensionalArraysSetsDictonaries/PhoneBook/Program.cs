using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> phonebook = new Dictionary<string,string>();
            string[] currentInputFields = new string[2];

            string currentInput = string.Empty;
            currentInput = Console.ReadLine();

            while(currentInput != "search")
            {
                currentInputFields = currentInput.Split('-');
                phonebook.Add(currentInputFields[0], currentInputFields[1]);
                currentInput = Console.ReadLine();

            }
            currentInput = Console.ReadLine();
            while (currentInput != "")
            {
                if (phonebook.ContainsKey(currentInput))
                {
                        Console.WriteLine("{0} -> {1}", currentInput, phonebook[currentInput]);
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist", currentInput);
                }

                currentInput = Console.ReadLine();
            }

            //foreach (var item in phonebook)
            //{
            //    Console.WriteLine("{0} {1}", item.Key, item.Value);
            //}
            
        }
    }
}
