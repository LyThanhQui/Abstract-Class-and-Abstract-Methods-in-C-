using System;

namespace AbstractClassAndAbstractMethod
{
    // abstract class MyClass has one abstract method which has got various implementations in sub-classes.
    class Program
    {
        public abstract class MyClass
        {
            public abstract void calculate(double x);
        }
        class Sub1 : MyClass
        {
            public override void calculate(double x)
            {
                Console.WriteLine("SQUARE ROOT IS " + Math.Sqrt(x));
            }
        }
        public class Sub2 : MyClass
        {
            public override void calculate(double x)
            {
                Console.WriteLine("SQUARE is :" + (x * x));
            }
        }
        public class Sub3 : MyClass
        {
            public override void calculate(double x)
            {
                Console.WriteLine("CUBE is :" + (x * x * x));
            }
        }
        class Test
        {
            static void Main(string[] args)
            {
                Sub1 obj1 = new Sub1();
                Sub2 obj2 = new Sub2();
                Sub3 obj3 = new Sub3();
                obj1.calculate(9);
                obj2.calculate(9);
                obj3.calculate(9);
                Console.ReadKey();
            }
        }

    }
}
