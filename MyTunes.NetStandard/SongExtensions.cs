using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace MyTunes
{
    public static class SongExtensions
    {
        static HttpClient httpClient=new HttpClient();
        public static string RuinSongName(this string songName)
        {
            return songName.Replace("Crocodile", "Alligator");
        }
    }
}
