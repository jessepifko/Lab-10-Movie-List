using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_10_Movie_List
{
   public class Movie
    {
        //private fields - title, category
        //these start with a lower-case letter - camel case

        private string title;
        private string category;

        //public properties - getters & setters
        //because these are public, these are what we use to access the properties of an object
        //these start with an upper-case letter - pascal case

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value; 
            }
        }

        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }

        //constructor(s)

        //all classes come with a default constructor. BUT PLEASE NOTE that the minute a default
        //constructor is overloaded, it no longer exists.
        //this overloaded constructor will allow me to give an object's properties value
        //when I create the object.

        public Movie(string _title, string _category)
        {
            title = _title;
            category = _category;
        }

       

        //methods

        public void PrintMovieInfo()
        {
            Console.WriteLine($"{title} is the title. {category} is the category.");
        }
      


    }
}
