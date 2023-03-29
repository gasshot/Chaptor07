using System;

namespace This
{
    class Employee
    {
        private string Name;
        private string Position;
        public int Number = 10;

        public void Setname(string Name)
        {
            this.Name = Name;
        }

        public string GetName()
        {
            return Name;
        }
        public void SetPosition(string Position)
        {
            this.Position = Position;
        }
        public string GetPosition()
        {
            //char[] arr = new char[6];
            //arr = this.Position.ToCharArray();
            var arr = this.Position.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (char)(arr[i] + 10);
            }
            return new string(arr);
            //return this.Position;
        }
    }
      
    class MainApp
    {
        static void Main(string[] args)
        {
            Employee pooh = new Employee();
            pooh.Setname("Pooh");
            pooh.SetPosition("Waiter");
            Console.WriteLine($"{pooh.GetName()} {pooh.GetPosition()}");

            Employee tigger= new Employee();
            tigger.Setname("Tigger");
            tigger.SetPosition("Cleaner");
            Console.WriteLine($"{tigger.GetName()} {tigger.GetPosition()}");

            Employee c = new Employee();
            Console.WriteLine(c.Number);
            c.Number = 1;
            //c.name = "a"; 보안수준(private)때문에 접근이 불가함
            Console.WriteLine(c.Number);
        }
    }
}
