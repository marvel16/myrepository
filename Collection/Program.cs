using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCollection demo = new MyCollection();

            demo.OnElementAdd += ElementAdded;
            
            demo.Add(3);
            demo.Add(5);
            demo.Add(8);
            demo.Add(7);
            demo.Add(6);
            demo.Add(123);
            demo.Add(78);
            demo.Add(79);
            demo.Add(22);
            demo.Add(65);
            demo.RemoveAt(4);
            demo.RemoveAt(6);
            try
            {
                Console.WriteLine(demo[4]);
                Console.WriteLine(demo[5]);
                Console.WriteLine(demo[4]);
                Console.WriteLine(demo[8]);
                Console.WriteLine(demo[-1]);
               
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Index was out of range {ex}");
            }
            Console.ReadKey();
        }

        static void ElementAdded()
        {
            Console.WriteLine("An element's added to the storage");
        }

    }
}
