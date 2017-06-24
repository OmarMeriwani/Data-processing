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
            //Even with constructor you cannot call the class
            dataSample d ;

        }
        void MonthsFinder(string text)
        {

        }
    }
    abstract class dataSample
    {
        string name;
        int val;
        //Creating constructor for an abstract class is a meaningless thing to do
        public dataSample(int v, string namee)
        {
            name = namee;
            val = v;
        }
        //But it's ok to create a methods, and these methods will be abstract as well
        public int ValueSquare()
        {
            return val * val;
        }
    }


}
