using System;
using System.Collections.Generic;
using System.Text;

namespace Serialization
{
    public class Game
    {

        //name,platform,release_date,summary,meta_score,user_review

        public string name { get; set; }
        public string platform { get; set; }
        public string release_date { get; set; }
        public string summary { get; set; }
        public double meta_score { get; set; }
        public string user_review { get; set; }

        public Game()
        {
            name = string.Empty;
            platform = string.Empty;
            release_date = string.Empty;
            summary = string.Empty;
            meta_score = 0.0;
            user_review = string.Empty;
        }

        public Game(string Name, string Platform, string Release_Date, string Summary, double Meta_Score, string User_Review)
        {
            name = Name;
            platform = Platform;
            release_date = Release_Date;
            summary = Summary;
            meta_score = Meta_Score;
            user_review = User_Review;
        }

    }
}
