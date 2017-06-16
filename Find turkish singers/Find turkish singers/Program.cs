using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Data.SqlClient;

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
        static string connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Omar\Documents\GitHub\Data-processing\Find turkish singers\Find turkish singers\SingersDB.mdf;Integrated Security=True;User Instance=True";
        static void Main(string[] args)
        {
            string erkek = "https://tr.wikipedia.org/wiki/Kategori:T%C3%BCrk_erkek_%C5%9Fark%C4%B1c%C4%B1lar";
            string erkek2 = "https://tr.wikipedia.org/w/index.php?title=Kategori:T%C3%BCrk_erkek_%C5%9Fark%C4%B1c%C4%B1lar&pagefrom=Mahmut+Tuncer#mw-pages";
            string kadin = "https://tr.wikipedia.org/wiki/Kategori:T%C3%BCrk_kad%C4%B1n_%C5%9Fark%C4%B1c%C4%B1lar";
            string kadin2 = "https://tr.wikipedia.org/w/index.php?title=Kategori:T%C3%BCrk_kad%C4%B1n_%C5%9Fark%C4%B1c%C4%B1lar&pagefrom=P%C4%B1nar+Aylin#mw-pages";
            Console.WriteLine("Reading..");
            string erkekdata = readUrl(kadin2);
            Console.WriteLine("Parsing..");
            //Console.WriteLine(erkekdata);
            SaveToDB(getSingers(erkekdata));
            Console.WriteLine("List is finished..");
            FindUnexistPagesInDB();
            Console.WriteLine("Unavailable list finished..");
            Console.ReadLine();
        }

        static void FindUnexistPagesInDB()
        {
            string notFound = "Vikipedi'de bu isimde bir madde bulunmamaktadır";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlConnection conn2 = new SqlConnection(connectionString);
            conn.Open();
            conn2.Open();
            SqlDataReader r = new SqlCommand("select Singer, link from Singers where availablePage is null",conn).ExecuteReader();
            while (r.Read())
            {
                string page = readUrl(r[1].ToString());
                string Exist = "";
                if (page.Contains(notFound) == true || page.Contains("##Error") == true )
                {
                    Exist = "'FALSE'";
                }
                else
                {
                    Exist = "'TRUE'";
                }
                new SqlCommand("Update singers set AvailablePage = "+ Exist +" where Singer = N'" + r[0].ToString() + "'", conn2).ExecuteNonQuery();
            }
            r.Close();
            conn.Close();
            conn2.Close();
        }
        static void SaveToDB(List<Singerr> list)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            foreach (Singerr s in list)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into singers (Singer,Link) values (N'" + s.Name + "', N'" + s.Link + "')");
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    SqlCommand cmd = new SqlCommand("insert into Errors (Singer,Error) values (N'" + s.Name + "', N'" + ex.Message + "')");
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                }
            }
            conn.Dispose();
            conn.Close();
        }
        static string readUrl(string url)
        {
            string data = "";
            try
            {
                System.Net.HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
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
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("404"))
                    return "##Error: 404";
                else
                    return "##Error: " + ex.Message;
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
                string link =  page.Substring(firstSinger, endOfFirstSinger - firstSinger + 1);
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
