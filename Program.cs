using System;

public class Program
{
    public static string name;
    public static string age;
    public static string eyeColor;
    public static string hairColor;
    public static string shoeSize;
    public static string favoriteColor;
    public static string favoriteTVorMovie;
    public static string favoriteTeacher;
    public static string favoriteClass;
    public static string favoriteHoliday;
    public static string favoriteSeason;
    public static string dreamJob;
    public static string numberOfSiblings;
    public static int ageIn5Years;
    public static void Main(string[] args)
    {
        AskName();
        AskAge();
        AskEyeColor();
        AskHairColor();
        AskShoeSize();
        AskFavoriteColor();
        AskFavoriteTvShow();
        AskFavoriteTeacher();
        AskFavoriteClass();
        AskFavoriteHoliday();
        AskFavoriteSeason();
        AskDreamJob();
        CalculateAgeIn5Years(age);
        AskNumberOfSiblings();
        DisplaySummaryMessage();
    }

    public static void AskName()
    {
        Console.WriteLine("What's your name?");
        name = Console.ReadLine();
    }

    public static void AskAge()
    {
        Console.WriteLine("What is your age?");
        age = Console.ReadLine();
    }

    public static void AskEyeColor()
    {
        Console.WriteLine("What color are your eyes?");
        eyeColor = Console.ReadLine();
    }

    public static void AskHairColor()
    {
        Console.WriteLine("What color is your hair");
        hairColor = Console.ReadLine();
    }

    public static void AskShoeSize()
    {
        Console.WriteLine("What's your shoe size?");
        shoeSize = Console.ReadLine();
    }

    public static void AskFavoriteColor()
    {
        Console.WriteLine("What's your favorite color?");
        favoriteColor = Console.ReadLine();
    }

    public static void AskFavoriteTvShow()
    {
        Console.WriteLine("Favorite TV show or movie?");
        favoriteTVorMovie = Console.ReadLine();
    }

    public static void AskFavoriteTeacher()
    {
        Console.WriteLine("Favorite Teacher?");
        favoriteTeacher = Console.ReadLine();
    }

    public static void AskFavoriteClass()
    {
        Console.WriteLine("Favorite Class?");
        favoriteClass = Console.ReadLine();
    }

    public static void AskFavoriteHoliday()
    {
        Console.WriteLine("Favorite Holiday?");
        favoriteHoliday = Console.ReadLine();
    }

    public static void AskFavoriteSeason()
    {
        Console.WriteLine("Favorite Season?");
        favoriteSeason = Console.ReadLine();
    }

    public static void AskDreamJob()
    {
        Console.WriteLine("Dream Job?");
        dreamJob = Console.ReadLine();
    }

    public static void CalculateAgeIn5Years(string age)
    {
        ageIn5Years = int.Parse(age) + 5;
    }

    public static void AskNumberOfSiblings()
    {
        Console.WriteLine("How many siblings do you have?");
        numberOfSiblings = Console.ReadLine();
    }

    public static void DisplaySummaryMessage()
    {
        Console.WriteLine("My friend's name is " + name + ". " + name + " is " + age + " years old. " + name + "'s eyes are " + eyeColor + " and has " + hairColor + " hair. Their shoe size is " + shoeSize + ". "+ name + "'s favorite color is " + favoriteColor +
        ", their favorite TV show/movie is " + favoriteTVorMovie + ", their favorite teacher is " + favoriteTeacher + ", and their favorite class is " + favoriteClass + ". " + name + "'s favorite holiday is " + favoriteHoliday + " and their favorite season is "
        + favoriteSeason + ". Their dream job is being " + dreamJob + ". They will be " + ageIn5Years + " in 5 years. " + name + " has " + numberOfSiblings + " sibling(s).");
    }
}
