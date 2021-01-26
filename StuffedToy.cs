using System;

namespace ClasssInheritanceExample
{
    class StuffedToy
    {
        public virtual void Hug()
        {
            Console.WriteLine("I'm getting hugged.");
        }
        public virtual void Squeeze()
        {
            Console.WriteLine("I'm getting squeeezed.");
        }
        public virtual void Wash()
        {
            Console.WriteLine("I'm getting washed.");
        }
    }
}
