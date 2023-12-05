using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Getters_and_setters
{
    internal class Movie
    {
        public string title;
        public string director;
        public string rating;

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            rating = aRating;
        }
        public string Rating
        {
            get 
            { 
                ReturnMessage rating; 
            }
            set
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }   

    }
}
