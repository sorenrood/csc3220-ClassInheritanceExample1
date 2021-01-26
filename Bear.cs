using System;

namespace ClasssInheritanceExample
{
    class Bear : StuffedToy // Inheriting StuffedToy using the colon syntax
    {
        override public void Hug()
        {
            Console.WriteLine("Hug Bear");
        }
        public override void Squeeze()
        {
            Console.WriteLine("Squeeze Bear.");
        }
        public override void Wash()
        {
            Console.WriteLine("Wash Bear.");
        }
    }
}