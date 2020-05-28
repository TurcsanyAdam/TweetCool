using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TweetCool
{
    public class Tweet
    {
        public string poster { get; set; }
        public string content { get; set; }
        public DateTime timeStamp { get; set; }
        public int id { get; set; }

        public Tweet(string poster, string content, int id)
        {
            this.poster = poster;
            this.content = content;
            timeStamp = DateTime.Now;
            this.id = id;
        }
        public override string ToString()
        {
            return content;
        }
    }
}
