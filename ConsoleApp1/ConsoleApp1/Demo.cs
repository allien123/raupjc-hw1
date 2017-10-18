using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Demo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("List example: ");
            ListExample(new IntegerList());
            Console.WriteLine("\nIteration example: ");
            IterationExample();
        }

        private static void IterationExample()
        {
            IGenericList<string> stringList = new GenericList<string>();
            stringList.Add(" Hello ");
            stringList.Add(" World ");
            stringList.Add("!");
            foreach (string value in stringList)
            {
                Console.WriteLine(value);
            }
            
        }

        public static void ListExample(IIntegerList listOfIntegers)
        {
            listOfIntegers.Add(1);
            listOfIntegers.Add(2);
            listOfIntegers.Add(3);
            listOfIntegers.Add(4);
            listOfIntegers.Add(5);
            listOfIntegers.RemoveAt(0);
            listOfIntegers.Remove(5);
            Console.WriteLine(listOfIntegers.Count );
            Console.WriteLine(listOfIntegers.Remove (100) );
            Console.WriteLine(listOfIntegers.RemoveAt (1) );
            listOfIntegers.Clear();
            Console.WriteLine(listOfIntegers.Count );
        }
}
}
