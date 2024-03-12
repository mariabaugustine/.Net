using System.Diagnostics;
using System;

namespace Sample
{
    internal class Program
    {
      
           public class AnonymousMethods
        {
            public delegate string GreetingsDelegate(string name);
            public static string Greetings(string name)
            {
                return "Hello @" + name + " Welcome to Dotnet Tutorials";
            }
            static void Main(string[] args)
            {
                GreetingsDelegate gd = new GreetingsDelegate(AnonymousMethods.Greetings);
                string GreetingsMessage = gd.Invoke("Pranaya");
                Console.WriteLine(GreetingsMessage);
                Console.ReadKey();
            }
        }
    }
    
}