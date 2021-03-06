using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reminder.Classes
{
       public class SearchResults
        {
            public List<SearchResult> Search { get; set; }
            public string totalResults { get; set; }
            public bool Response { get; set; }
        }

        public class SearchResult
        {
            public string Title { get; set; }
            public string Year { get; set; }
            public string imdbID { get; set; }
            public string Type { get; set; }
            public string Poster { get; set; }
        }
}
