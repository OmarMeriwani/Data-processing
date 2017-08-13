using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Find_turkish_singers
{
    class DateFinder
    {
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
                monthIndex = wholeText.IndexOfAny(TrMonths,monthIndex);
            }
            return t;
        }
    }
}
