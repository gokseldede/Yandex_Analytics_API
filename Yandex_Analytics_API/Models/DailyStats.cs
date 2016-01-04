using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Yandex_Analytics_API.Models
{
    public class DailyStats
    {
        public DateTime Day { get; set; }
        public int Visits { get; set; }
        public int Visitors { get; set; }
        public int PageViews { get; set; }
        public int NewVisitors { get; set; }
    }
}