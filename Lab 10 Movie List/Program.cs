using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lab_10_Movie_List
{
    class Program
    {
      
        static void Main(string[] args)
        {
            GetMovieList();
        }

        static void GetMovieList()
        {
            string[] Titles = {"Frozen 2", "Spiderman: Into the Spiderverse", "Joker", "Birds of Prey", 
                "Bloodshot", "Little Women", "The Invisible Man", "It: Chapter 2", "Blade Runner", "Arrival"};
            string[] Categories = {"Animated", "Animated", "Drama", "Drama", "Drama", "Drama", "Horror",
                "Horror", "Scifi", "Scifi"};

            for (int i = 0; i < Categories.Length; i++)
            {
                Console.WriteLine($"{Categories[i],-15}{Titles[i],-15}");
            }
            Console.WriteLine("Enter a category, and i'll give you a movie suggestion.");
            string searchCategory = Console.ReadLine();

            if (searchCategory == "animated")
            {
                Console.WriteLine($"{Titles}");
            }
        }
           

        //Loop that goes through movie list and check each movie category
        //public static void FillListOfMovies(List<Movie> movies)
        //{
        //    movies.Add(new Movie("Frozen 2", "Animated"));
        //    movies.Add(new Movie("Spiderman:Into the Spiderverse", "Animated"));
        //    movies.Add(new Movie("Joker", "Drama"));
        //    movies.Add(new Movie("Birds of Prey", "Drama"));
        //    movies.Add(new Movie("Blood Shot", "Drama"));
        //    movies.Add(new Movie("Little Women", "Drama"));
        //    movies.Add(new Movie("The Invisible Man", "Horror"));
        //    movies.Add(new Movie("It: Chapter 2", "Horror"));
        //    movies.Add(new Movie("Blade Runner", "Scifi"));
        //    movies.Add(new Movie("Arrival", "Scifi"));
        //}

        //public static void SearchByCategory(string category)
        //{
        //    List<Movie> movies = new List<Movie>();
        //    FillListOfMovies(movies);
        //    category = "";

            

        //    }       
        //}

    //public static bool UserContinue(string message)
    //{
    //    Console.WriteLine(message);
    //    String Response = Console.ReadLine().ToLower();
    //    while (Response != "n" && Response != "y")
    //    {
    //        Console.WriteLine("What was that?  Would you like to learn more? y/n");
    //        Response = Console.ReadLine();
    //    }
    //    if (Response == "n")
    //    {
    //        Console.WriteLine("Okay!  See you next time.");
    //        return false;
    //    }
    //    else
    //    { 
    //        return true;
    //    }
    

    }
}

