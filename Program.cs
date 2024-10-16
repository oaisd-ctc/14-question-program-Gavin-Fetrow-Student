using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What's your name?");
        string name = Console.ReadLine();
        Console.WriteLine("What is your age?");
        string age = Console.ReadLine();
        int age5 = int.Parse(age) + 5;
        Console.WriteLine("What color are your eyes?");
        string eyecolor = Console.ReadLine();
        Console.WriteLine("What color is your hair");
        string haircolor = Console.ReadLine();
        Console.WriteLine("What's your shoe size?");
        string shoesize = Console.ReadLine();
        Console.WriteLine("What's your favorite color?");
        string favcolor = Console.ReadLine();
        Console.WriteLine("Favorite TV show or movie?");
        string favtv = Console.ReadLine();
        Console.WriteLine("Favorite Teacher?");
        string favteacher = Console.ReadLine();
        Console.WriteLine("Favorite Class?");
        string favclass = Console.ReadLine();
        Console.WriteLine("Favorite Holiday?");
        string favholiday = Console.ReadLine();
        Console.WriteLine("Favorite Season?");
        string favseason = Console.ReadLine();
        Console.WriteLine("Dream Job?");
        string dreamjob = Console.ReadLine();
        Console.WriteLine("How many siblings do you have?");
        string siblings = Console.ReadLine();
        Console.WriteLine("My friend's name is " + name + ". " + name + " is " + age + " years old. " + name + "'s eyes are " + eyecolor + " and has " + haircolor + " hair. " + name + "'s favorite color is " + favcolor +
        ", their favorite TV show/movie is " + favtv + ", their favorite teacher is " + favteacher + ", and their favorite class is " + favclass + ". " + name + "'s favorite holiday is " + favholiday + " and their favorite season is "
        + favseason + ". Their dream job is being " + dreamjob + ". They will be " + age5 + " in 5 years. " + name + " has " + siblings + " sibling(s).");
    }
}
