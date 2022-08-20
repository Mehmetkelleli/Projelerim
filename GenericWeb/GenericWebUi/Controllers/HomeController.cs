using GenericWeb.Data.Abstract;
using GenericWeb.Entity;
using GenericWebUi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GenericWebUi.Controllers
{
    public class HomeController : Controller
    {
        private IGenericRepository<Logs> _Logs;
        private IGenericRepository<SiteConfig> _setting;
        public HomeController(IGenericRepository<Logs> Logs, IGenericRepository<SiteConfig> setting)
        {
            //inject process
            _Logs = Logs;
            _setting = setting;
            // click day
            if(_setting.GetById(1).Date == DateTime.Now.ToString())
            {
                var click = _setting.GetById(1);
                click.ClickDay += 1;
                _setting.Update(click);
            }
            else
            {
                var click = _setting.GetById(1);
                click.Date = DateTime.Now.ToString();
                click.ClickDay = 0;
                click.ClickDay += 1;
                _setting.Update(click);
            }
            //ip process
            var webClient = new WebClient();

            string dnsString = webClient.DownloadString("http://checkip.dyndns.org");
            dnsString = (new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b")).Match(dnsString).Value;

            webClient.Dispose();
            var myIP = dnsString;
            var logs = _Logs.GetAll();
            foreach (var i in logs)
            {
                if(i.IpAdress != myIP)
                {
                    string strQuery;

                    HttpWebRequest HttpWReq;
                    HttpWebResponse HttpWResp;

                    strQuery = "http://ip-api.com/json/" + myIP;

                    JavaScriptSerializer serializer = new JavaScriptSerializer();

                    HttpWReq = (HttpWebRequest)WebRequest.Create(strQuery);
                    HttpWReq.Method = "GET";
                    HttpWResp = (HttpWebResponse)HttpWReq.GetResponse();

                    System.IO.StreamReader reader = new System.IO.StreamReader(HttpWResp.GetResponseStream());
                    string content = reader.ReadToEnd();

                    dynamic item = serializer.Deserialize<object>(content);
                    string city = item["city"] + " - " + item["regionName"];
                    string country = item["country"];

                    var log = new Logs
                    {
                        IpAdress = myIP,
                        City = city,
                        Country = country,

                     
                    };
                    _Logs.Create(log);
                }
            }

        }
        public IActionResult index()
        {
            return View();
        }
    }
}
