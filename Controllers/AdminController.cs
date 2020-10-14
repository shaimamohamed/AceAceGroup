using AceAceGroupTestApplication.Models;
using AceAceGroupTestApplication.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace AceAceGroupTestApplication.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly OneSignalAPIService _oneSignalAPIService;
        public AdminController()
        {
            _oneSignalAPIService = new OneSignalAPIService();
        }

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        // GET: Admin Index
        public ActionResult AdminIndex()
        {
            return View();
        }
        //Get : Get All Apps
        [Authorize]
        public ActionResult GettAllApps(OneSignalApplication getappsrequest)
        {
            return View(_oneSignalAPIService.OneSignalGetApps(getappsrequest));
        }
        //Get : Get an App
       
        public ActionResult GettanApp(string id)
        {
            return View(_oneSignalAPIService.OneSignalGetannApp(id));
        }

        //Get : Create  an App
        [Authorize(Roles = "Admin")]
        public ActionResult CreateanApp()
        {
            return View();
        }
        //Post : Create an App
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult CreateanApp(OneSignalApplication oneSignalCreateAppRequest)
        {
            bool Issuccess = _oneSignalAPIService.OneSignalCreateApp(oneSignalCreateAppRequest);
            if (Issuccess)
                return RedirectToAction("AdminIndex");
            else
                return View(oneSignalCreateAppRequest);
        }

        //Get : Update  an App
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult UpdateanApp(string id)
        {
            return View();
        }
        //Post : Update an App
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateanApp(OneSignalApplication oneSignalUpdateAppRequest)
        {
            bool Issuccess = _oneSignalAPIService.OneSignalUpdateApp(oneSignalUpdateAppRequest);
            if (Issuccess)
                return RedirectToAction("AdminIndex");
            else
                return View(oneSignalUpdateAppRequest);
        }
 

    }
}