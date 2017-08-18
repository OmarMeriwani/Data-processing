using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Find_turkish_singers
{
    class DateFinder
    {
        /*
         * To find birthdate and death date you have to follow the following rules:
         * - Word d. followed by space and then a 4 digits number.
         * - word ö. followed by space and then a 4 digits number.
         * 
         * The year is: 4 digits number (between 1500 - current year) .
         * Full date is: day + month name +  year
         * Year date: YEAR + 'da OR yılında
         * Year date: YEAR + text 
         * Year and season: yılı + [Season name: sonbahar, İlkbahar, Kış, yaz]
         * Year and month: yılı + month name + ayında
         * Year and period: yılı + başlarında, Sonunda, Ortasında
         * Year and month: YEAR + 'ün + MONTH + ayında
         * Year and month: YEAR + 'nin + MONTH + ayında
         * Period of years: Year + 'lerde
         * 
         * 
         * To catch a date-year event:
         * - year + yılında + cut the text until "," or "." (but not the dot sign of numbers) or until another year.
         * - Full date + cut the text until "," or "." or until another year.
         * - in the description panel find a month name or year, then the word before them. ex: Doğum	27 Kasım 1955
         * - cut the text until the character "-" followed by a year. ex: İkinci Bahar - 1998
         * - TEXT (YEAR) ex: Adam Gibi (2004)
         * - in the first paragraph (Full date, city name, country name -  Full date, city name, country name)
         * - (d. FULL DATE, PLACE)
         * - Add sub-titles with the event.
         */
        string[] year = { /*4 digits*/"'de", "'te", "yılında", "yılından itibaren", /*GET THE LAST YEAR*/ "Aynı yıl içerisinde" };
        string[] TrMonths = {"ocak", "şubat", "mart", "nisan", "mayıs", "haziran", "temmuz","temmuz","ağustos","eylül","ekim","kasım","aralık" };
        
        class Eventt
        {
            public string eventt;
            public DateTime date;
        }
        List<Eventt> GetDates(string wholeText)
        {
            List<Eventt> t = new List<Eventt>();
            int monthIndex = 0;
            while (monthIndex != -1)
            {
                //monthIndex = wholeText.IndexOfAny(TrMonths,monthIndex);
            }
            return t;
        }
    }
}
