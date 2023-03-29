using System;

//namespace StaticField
//{
class Global
{
    public static int Count = 0;
}
class ClassA
{
    public ClassA()
    {
        Global.Count++;
    }
}

class ClassB
{
    public ClassB()
    {
        Global.Count++;
    }
}


class MainApp
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Global.Count : {Global.Count}");

        ClassA a = new ClassA();
        new ClassA(); // 힙에만 존재 스택공간엔 존재 X 재소환 불가
        new ClassA();
        new ClassB();
        new ClassB();
        ClassB b = new ClassB();
        Console.WriteLine($"Global.Count : {Global.Count}");

    }
}
//}
