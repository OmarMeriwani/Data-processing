using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Find_turkish_singers
{
    class TurkPlaceFinder
    {
        /*
          1- Before the end of the first string, before the paragraph end (.)
          2- Have the word "(il)" in the title.
          
          City
          1- Have the word "İl merkezi" in the description part.
          2- Could have the word (şehir) in the first sentence.
         
          - If a smaller unit were found, then the search should stop.
          - Don't consider the "." that's preceded by a number as an end of the sentence.
          - Search any link word in the first sentence to see if it is a place, if it was a larger place then set it as a parent. Search in the database first and then in the web.
        */
        //Get the words (latitude, longitude), and then the next two charachters until the character "<" for each place.
        string[] Province = { "il", "ildir", "ili", "ilinden" };
        string[] district = { "ilçe", "ilçesidir", "ilçesinden", "ilçedir", "ilçelerinden", "ilçesi" };
        string[] city = { "şehir", "şehridir", "şehri", "merkezidir", "kenttir", "şehirdir" };
        string[] language = { "Kürtçe" };
        /*
        - Word +  kökenli. in the first paragraph
        - 
        */
        string[] origin = { "kökenli" };
        /*
         1- Have one of the words.
         2- Is link
        */
        string[] musicType = { "Müzik", "Müziği", "Musikisi" };
    }
}
