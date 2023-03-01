// See https://aka.ms/new-console-template for more information

Thread t = new Thread(dislplayMessage);

t.Start();

Console.WriteLine("Hello, World!");
Thread.Sleep(1000); 
Console.WriteLine("Hello, World!");
Thread.Sleep(1000);
Console.WriteLine("Hello, World!");
Thread.Sleep(1000);
Console.WriteLine("Hello, World!");
Thread.Sleep(1000);
Console.WriteLine("Hello, World!");
Thread.Sleep(1000);
Console.WriteLine("Hello, World!");
Thread.Sleep(1000);
Console.WriteLine("Hello, World!");

void dislplayMessage ()
{
    Console.WriteLine("Hello, World! Thread_2");
    Thread.Sleep(1000);
    Console.WriteLine("Hello, World! Thread_2");
    Thread.Sleep(1000);
    Console.WriteLine("Hello, World! Thread_2");
    Thread.Sleep(1000);
    Console.WriteLine("Hello, World! Thread_2");
    Thread.Sleep(1000);
    Console.WriteLine("Hello, World! Thread_2");
    Thread.Sleep(1000);
    Console.WriteLine("Hello, World! Thread_2");

}