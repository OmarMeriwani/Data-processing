using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace Find_turkish_singers
{
    class Program
    {
        static void Main(string[] args)
        {
            string urlAddress = "https://tr.wikipedia.org/wiki/Serkan_Kaya";

            System.Net.HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
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

                string data = readStream.ReadToEnd();

                response.Close();
                readStream.Close();
            }
            //-----------------------------------------------------------------
            //using (WebClient client = new WebClient())
            //{
            //    string htmlCode = client.DownloadString(urlAddress);
            //}


        }
    }
}
