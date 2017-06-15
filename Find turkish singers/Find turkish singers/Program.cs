using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace Find_turkish_singers
{
    class Singerr
    {
        public Singerr(string name, string link)
        {
            Name = name;
            Link = link;
        }
        public string Name;
        public string Link;
    }
    class Program
    {
        static void Main(string[] args)
        {
            string erkek = "https://tr.wikipedia.org/wiki/Kategori:T%C3%BCrk_erkek_%C5%9Fark%C4%B1c%C4%B1lar";
            string kadin = "https://tr.wikipedia.org/wiki/Kategori:T%C3%BCrk_kad%C4%B1n_%C5%9Fark%C4%B1c%C4%B1lar";
            string erkekdata = readUrl(erkek);
            //Console.WriteLine(erkekdata);
            getSingers(erkekdata);
            Console.ReadLine();
        }
        static string readUrl(string url)
        {
            System.Net.HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string data = "";
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;

                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }

                data = readStream.ReadToEnd();

                response.Close();
                readStream.Close();
            }
            return data;
        }

        static List<Singerr> getSingers(string page)
        {
            List<Singerr> dic = new List<Singerr>();
            int firstSinger = 1;
            while (true)
            {
                firstSinger = page.IndexOf("/wiki/", firstSinger - 1 );
                if (firstSinger == -1)
                    break;
                
                int endOfFirstSinger = page.IndexOf('"', firstSinger) - 1;
                string link =  page.Substring(firstSinger, endOfFirstSinger - firstSinger);
                if (link.Contains(":") == true)
                {
                    firstSinger = endOfFirstSinger;
                    continue;
                }
                link = "https://tr.wikipedia.org" + link;
                int nameFirstIndex = page.IndexOf("title=", endOfFirstSinger) + 7;
                int endOfNameIndex = page.IndexOf('"', nameFirstIndex);
                firstSinger = endOfNameIndex;
                string name = page.Substring(nameFirstIndex, endOfNameIndex - nameFirstIndex);
                Singerr s = new Singerr(name, link);
                dic.Add(s);
            }
            return dic;
        }
    }
   
}
