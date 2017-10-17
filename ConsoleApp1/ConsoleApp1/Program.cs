using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IGenericList<string> listOfIntegers = new GenericList<string>();
            listOfIntegers.Add("jebo te pas"); // [1]
            Console.WriteLine(listOfIntegers);
            listOfIntegers.Add("2"); // [1 ,2]
            Console.WriteLine(listOfIntegers);
            listOfIntegers.Add("3.88"); // [1 ,2 ,3]
            Console.WriteLine(listOfIntegers);
            listOfIntegers.Add("vrag te jebal"); // [1 ,2 ,3 ,4]
            Console.WriteLine(listOfIntegers);
            listOfIntegers.Add("5"); // [1 ,2 ,3 ,4 ,5]
            Console.WriteLine(listOfIntegers);
            Console.WriteLine(listOfIntegers);
            listOfIntegers.Remove("5"); //[2 ,3 ,4]
            Console.WriteLine(listOfIntegers);
            Console.WriteLine(listOfIntegers.Count ) ; // 3
            Console.WriteLine("JEBOTE LED!");

            foreach (string s in listOfIntegers)
            {
                Console.WriteLine(s);
            }
        }
    }
}
