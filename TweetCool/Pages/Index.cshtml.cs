using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace TweetCool.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public void OnPost(
                        [FromForm(Name = "poster")] string poster,
                        [FromForm(Name = "content")] string content)
        {
            TweetsModel.allTweets.Add(new Tweet(poster, content, TweetsModel.allTweets.Count + 1));

            Response.Redirect("/NewTweets");
        }
    }
}
