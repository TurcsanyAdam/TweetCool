using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TweetCool
{
    public class TweetsModel : PageModel
    {
        public static List<Tweet> allTweets = new List<Tweet>();
        
        public void OnGet()
        {

        }
    }
}