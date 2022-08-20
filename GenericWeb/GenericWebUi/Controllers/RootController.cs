using GenericWeb.Data.Abstract;
using GenericWeb.Entity;
using GenericWebUi.Dto;
using GenericWebUi.Functions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GenericWebUi.Controllers
{
    public class RootController : Controller
    {
        private IGenericRepository<SiteConfig> _Setting;
        private IImageSender _ImgSender;
        private IGenericRepository<Logs> _Logs;
        public RootController(
            IGenericRepository<SiteConfig> Setting,
            IImageSender ImgSender,
            IGenericRepository<Logs> Logs
            )
        {
            _Setting = Setting;
            _ImgSender = ImgSender;
            _Logs = Logs;
        }
        public IActionResult Index()
        {
            return View();
        }
        // Site Config
        [HttpGet]
        public IActionResult SiteConfig()
        {
            var s1 = _Setting.GetById(1);
            if(s1 != null)
            {
                var setting = new DtoSiteConfig()
                {
                    Id = s1.Id,
                    MetaDescription = s1.MetaDescription,
                    MetaTags = s1.MetaTags,
                    Author = s1.Author,
                    LogoUrl = s1.LogoUrl,
                    SmtpHost = s1.SmtpHost,
                    SmtpPassword = s1.SmtpPassword,
                    SmtpPort = s1.SmtpPort,
                    SmtpUser = s1.SmtpUser
                };
                return View(setting);
            }
            return View(new DtoSiteConfig { });
        }
        [HttpPost]
        public async Task<IActionResult> SiteConfig(DtoSiteConfig Model,IFormFile FileImage)
        {
            if (!ModelState.IsValid)
            {
                return View(Model);
            }
            if(FileImage != null)
            {
                var random = $"{DateTime.Now.Ticks}.jpg";
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", random);
                //await _ImgSender.ImageSend(path, FileImage);
                var sssetting = new SiteConfig()
                {
                    Id = Model.Id,
                    MetaDescription = Model.MetaDescription,
                    MetaTags = Model.MetaTags,
                    Author = Model.Author,
                    LogoUrl = random,
                    SmtpHost = Model.SmtpHost,
                    SmtpPassword = Model.SmtpPassword,
                    SmtpPort = Model.SmtpPort,
                    SmtpUser = Model.SmtpUser
                };
                _Setting.Update(sssetting);
                TempData["Message"] = "Setting Update";
                return View(Model);
                
            }
            var ssetting = new SiteConfig()
            {
                Id = Model.Id,
                MetaDescription = Model.MetaDescription,
                MetaTags = Model.MetaTags,
                Author = Model.Author,
                LogoUrl = Model.LogoUrl,
                SmtpHost = Model.SmtpHost,
                SmtpPassword = Model.SmtpPassword,
                SmtpPort = Model.SmtpPort,
                SmtpUser = Model.SmtpUser
            };
            _Setting.Update(ssetting);
            TempData["Message"] = "Settings Update";
            return View(Model);
        }
        //logs process
        [HttpGet]
        public IActionResult LogList()
        {
            return View(_Logs.GetAll());
        }
        [HttpGet]
        public IActionResult LogDetails(int id)
        {
            return View(_Logs.GetById(id));
        }

    }
}
