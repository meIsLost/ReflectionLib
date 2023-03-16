// See https://aka.ms/new-console-template for more information
using ReflectionLib;

Console.WriteLine("Hello, World!");
Clerk clerk = new Clerk("Raju", 1999, new List<string> { "hera", "feri" });
Clerk clerk2 = new Clerk("Shamm", 1997, new List<string> { "hera", "feri" });
Manager manager = new Manager("Baburao", 1995, new List<Person> { clerk , clerk2});


TryReflection(clerk2);
TryReflection(clerk);
 void TryReflection(Object obj)
{

    Type t = obj.GetType();

    Console.WriteLine("Name: " + t.FullName);
    Console.WriteLine("interface: " + t.IsInterface);
    Console.WriteLine("Class: " + t.IsClass);
    Console.WriteLine("Abstract: " + t.IsAbstract);
    Console.WriteLine("Base: " + t.BaseType);

    Console.WriteLine(" === Properties ====");
    foreach (var info in t.GetProperties())
    {
        Console.WriteLine(info);
    }

    Console.WriteLine(" === Methods ====");
    foreach (var info in t.GetMethods())
    {
        Console.WriteLine(info);
    }



}