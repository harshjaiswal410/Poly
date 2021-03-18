using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunTimeDynamicPoly
    //This type of polynorphism is allow us to call child class mrthod using perent class reference variable.
{
    public class Perent
    {
        public virtual void Method1()
        {
            Console.WriteLine("Perent Method First");
        }
        public virtual void Method2()
        {
            Console.WriteLine("Perent Method Second");
        }
    }
    public class Child: Perent
    {
        public override void Method1()
        {
            Console.WriteLine("Child Method First");
        }
        public override void Method2()
        {
            Console.WriteLine("Child Method Second");
        }
        static void Main(string[] args)
        {
            Child c1 = new Child();
            c1.Method1();
            c1.Method2();
            Perent p1 = new Child(); //This works after defining perent method with virtual keyword 
            p1.Method1(); //and child method with override keyword.P1 is referencs variable of parent class.
            p1.Method2();
            Console.ReadLine();
        }
    }
}
