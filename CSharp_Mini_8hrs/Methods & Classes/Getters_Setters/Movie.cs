using System;

namespace Getters_Setters;

public class Movie
{
    // 
    public string title;
    public string director; 
    private string rating; // only inside the movie class

    public Movie(string aTitle, string aDirector, string aRating)
    {
        title = aTitle;
        director = aDirector;
        //rating = aRating; // set rating to Raiting to use getter below for secure 
        Rating = aRating;
    }
    // properties
    // is a little method that allow us to define getters and setters
    public string Rating
    {
        get {return rating; } // getter allows to rating attribute
        set                    
        {
            if (value == "G" || value == "PG-13" || value == "R" || value == "NR" )
            {
                rating = value;
            }
            else
            {
                rating = "NR";
            }
        //setter allows me to set a specific rule
         
        }


    }
}
