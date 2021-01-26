using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasssInheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            StuffedToy toy = new Bear();
            toy.Hug();
            toy.Squeeze();
            toy.Wash();
            Console.Read();
        }
    }
}
