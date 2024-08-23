using System;

namespace Static_Class_Attributes;
public class Song
    {
        // This is a normal attribute
        public string title;
        public string artist;
        public int duration;

        // example for static attribute:
        public static int Songcount = 0;

        public Song(string aTitile, string aArtist, int aDuration)
        {
            title = aTitile;
            artist = aArtist;
            duration = aDuration;
            
            // everytime the song created, the Songcount get incremented 
            Songcount++; 
            

        }

        // create a method that counts on each of the individual object
        public int Getsongcount()
        {
            return Songcount;
        }
        

    }
