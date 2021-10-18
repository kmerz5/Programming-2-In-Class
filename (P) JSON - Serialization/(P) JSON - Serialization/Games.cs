using System;
using System.Collections.Generic;
using System.Text;

namespace _P__JSON___Serialization
{
    public class Games
    {
        //name,platform,release_date,summary,meta_score,user_review
        public string name { get; set; }
        public string platform { get; set; }
        public string release_date { get; set; }
        public string summary { get; set; }
        public int meta_score { get; set; }
        public double user_review { get; set; }

        public Games()
        {
            name = string.Empty;
            platform = string.Empty;
            release_date = string.Empty;
            summary = string.Empty;
            meta_score = 0;
            user_review = 0.0;
        }

        public Games(string gamename, string gameplatform, string gamerelease_date, string gamesummary, int gamemeta_score, double gameuser_review)
        {
            name = gamename;
            platform = gameplatform;
            release_date = gamerelease_date;
            summary = gamesummary;
            meta_score = gamemeta_score;
            user_review = gameuser_review;

        }

        public override string ToString()
        {
            return $"{name}";
        }
    }
}
