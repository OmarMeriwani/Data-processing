using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Date_finder
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        void MonthsFinder(string text)
        {
            string[] monthsE = { "january" , "february" , "march" , "april" , "may" , "june" , "july" , "august" , "september" , "october" , "november" , "december" };
            string[] monthsESmall = { "jan" , "feb" , "mar" , "apr" , "may" , "jun" , "jul" , "aug" , "sep" , "sept" , "oct" , "nov" , "dec" };
            string[] monthNum = { "1","2","3","4","5","6","7","8","9","10", "11","12" };
            string[] monthNumWithZero = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
            string[] monthsTr = {"ocak","gücük","yelin","açaray","gülay","bozaran","biçim","derim","verim","ekim","kasım","aralık"};
            string[] monthsTr2 = { "ocak", "şubat", "mart", "nisan", "mayıs", "haziran", "temmuz", "ağustos", "eylül", "ekim", "kasım", "aralık" };
            string[] monthsAr = { "كانون الثاني","شباط","آذار","نيسان","أيار","حزيران","تموز","آب","أيلول","تشرين الأول","تشرين الثاني","كانون الأول"};
            string[] monthsAr2 = { "يناير","فبراير","مارس","أبريل","مايس","يونيو","يوليو","أغسطس","سبتمبر","أكتوبر","نوفمبر","ديسمبر"};
            string[] monthsAr3 = { "يناير", "فبراير", "مارس", "أبريل", "ماي", "يونيو", "يوليوز", "غشت", "شتنبر", "أكتوبر", "نونبر", "دجنبر" };
            string[] monthsAr4 = { "جانفي", "فيفري", "مارس", "أفريل", "ماي", "جوان", "جويليه", "أوت", "شتنبر", "أكتوبر", "نونبر", "دجنبر" };
            string[] monthsHijri = { "محرم", "صفر", "ربيع الأول", "ربيع الثاني", "جمادى الأولى", "جمادى الآخر", "رجب", "شعبان", "رمضان", "ذو القعدة", "ذو الحجة"};
        }
    }


}
