using _03._04GenericListVersion._03_Generic_List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._04GenericListVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new GenericList<int>();

            list.addElement(60);
            list.addElement(6);
            list.addElement(12);
            list.addElement(9756);
            list.addElement(3);
            list.addElement(74);
            list.addElement(687);
            list.addElement(123);
            list.Version();
            Console.WriteLine();
            Console.WriteLine("Start list --> {0}\n", list);
            Console.WriteLine("Max: ---> {0}\n", list.Max());
            Console.WriteLine("Min: ---> {0}\n", list.Min());

            list.Insert(7, 2);
            list.Insert(300, 1);
            Console.WriteLine("Insert: 300 and 7 ---> {0}\n", list);

            Console.WriteLine("Accessed by index 3 --> {0}\n", list.Access(3));

            Console.WriteLine(list.Contains(74));
            Console.WriteLine(list.Contains(4));
            Console.WriteLine();

            list.removeElement(4);
            list.removeElement(6);
            Console.WriteLine("After removal ---> {0}\n", list);

            Console.WriteLine("Found indexes:");
            Console.WriteLine("Index of 1 --> {0}", list.FindIndex(1));
            Console.WriteLine("Index of 60 --> {0}\n", list.FindIndex(60));
            Console.WriteLine("Final list --> {0}\n", list);
            // list = new GenericList<int>();
            list.Clear();
            Console.WriteLine("Cleared --> {0}\n", list);

            list.addElement(60);
            list.addElement(6);
            list.addElement(12);
            list.addElement(9756);
            list.addElement(3);
            list.addElement(74);
            list.addElement(687);
            list.addElement(123);
            list.addElement(60);
            list.addElement(6);
            list.addElement(12);
            list.addElement(9756);
            list.addElement(3);
            list.addElement(74);
            list.addElement(687);
            list.addElement(123);
            list.addElement(60);
            list.addElement(6);
            list.addElement(12);
            list.addElement(9756);
            list.addElement(3);
            list.addElement(74);
            list.addElement(687);
            list.addElement(123);
            Console.WriteLine("List with more than 16 symbols --> {0}", list);
        }
    }
}
