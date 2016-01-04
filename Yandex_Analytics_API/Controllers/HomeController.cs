using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using Yandex_Analytics_API.Models;

namespace Yandex_Analytics_API.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
     
        public ActionResult Index()
        {

            string url = "https://api-metrika.yandex.com.tr/stat/traffic/summary?id=d636c1f9abc04439ab36cde51a1cfd84&oauth_token=d636c1f9abc04439ab36cde51a1cfd84&date1=20151201&date2=20151231";
            XmlDocument visits = new XmlDocument();
            XmlNodeList nodelist = visits.GetElementsByTagName("row");
            List<DailyStats> stats = new List<DailyStats>();
            foreach (XmlNode item in nodelist)
            {
                DailyStats stt = new DailyStats();
                stt.Day = DateTime.ParseExact(item["date"].InnerText, "yyyyMMdd", null);
                stt.Visits = Convert.ToInt32(item["visits"].InnerText);
                stt.Visitors = Convert.ToInt32(item["visitors"].InnerText);
                stt.PageViews = Convert.ToInt32(item["page_views"].InnerText);
                stt.NewVisitors = Convert.ToInt32(item["new_visitors"].InnerText);
                stats.Add(stt);
            }

            return View();

        }
    }
}