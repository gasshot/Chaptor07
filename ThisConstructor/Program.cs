using System;

namespace ThisConstructor
{
    class MyClass
    {
        int a, b, c;
        public MyClass()
        {
            this.a = 5425;
            Console.WriteLine("MyClass()");
        }
        public MyClass(int b) : this()
        {
            this.b = b;
            Console.WriteLine($"MyClass({b})");
        }
        public MyClass(int b,int c) : this(b)
        {
            this.c = c;
            Console.WriteLine($"MyClass({b},{c})");
        }
        public void PrintField()
        {
            Console.WriteLine($"a:{a},b:{b},c:{c}");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass();
            a.PrintField();
            Console.WriteLine();

            MyClass b = new MyClass(1);
            b.PrintField();
            Console.WriteLine();

            MyClass c = new MyClass(10,20);
            c.PrintField();
        }
    }
}
