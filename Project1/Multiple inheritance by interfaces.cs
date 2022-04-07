using System;

namespace Project1
{
    interface IA
    {
        void AMethod();
    }

    interface IB
    {
        void BMethod();
    }

    class A : IA
    {
        public void AMethod()
        {
            Console.WriteLine("Class A");
        }
    }
    class B : IB {
        public void BMethod() { 
            Console.WriteLine("Class B");
        }
    }

    class C : IA, IB
    {
        A a = new A();
        B b = new B();

        public void AMethod()
        {
            a.AMethod();
        }
        public void BMethod()
        {
            b.BMethod();
        }

        static void Main(string[] args) { 
            C c = new C();
            c.AMethod();
            c.BMethod();
        }
    }
    
}
