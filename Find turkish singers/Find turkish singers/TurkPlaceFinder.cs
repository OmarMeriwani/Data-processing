﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Find_turkish_singers
{
    class TurkPlaceFinder
    {
        //Before the end of the first string, before the paragraph end (.)
        //Have the word "(il)" in the title.
        //Have the word "İl merkezi" in the description part.
        //Could have the word (şehir) in the first sentence.
        //If a smaller unit were found, then the search should stop.
        //Don't consider the "." that's preceded by a number as an end of the sentence.
        //Search any link word in the first sentence to see if it is a place, if it was a larger place then set it as a parent. Search in the database first and then in the web.

        //Get the words (latitude, longitude), and then the next two charachters until the character "<" for each place.
        string[] Province = { "il", "ildir", "ili", "ilinden" };
        string[] district = { "ilçe", "ilçesidir", "ilçesinden", "ilçedir", "ilçelerinden", "ilçesi" };
        string[] city = { "şehir", "şehridir", "şehri", "merkezidir", "kenttir", "şehirdir" };
        string[] language = { "Kürtçe" };
    }
}