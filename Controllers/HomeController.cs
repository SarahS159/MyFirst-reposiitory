using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MtNews.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MtNews.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MtNewsContext _context;

        public HomeController(ILogger<HomeController> logger, MtNewsContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            //   var remoteIPAddress = Request.HttpContext.Connection.RemoteIpAddress; how to get the Ip Address
              var IpAddress = "105.20.55.3";// News
            //var IpAddress = "23.66.10.2"; //MT_News
            //var IpAddress = "10.12.3.4"; // MT

            var IPAddressInDb = _context.IpAddresses.Single(c=> c.Address == IpAddress);
            if (IPAddressInDb.Address == null)
                return NotFound("The IP Address not found");

            var Ip_agency = _context.Agencies_IpAddresses.Single(c => c.IpAddressId == IPAddressInDb.Id);
            var agency = _context.Agencies.Single(c => c.Id == Ip_agency.AgencyId);

            if (agency.Type == "News")
                return View("NewsIndex");

            if (agency.Type == "MT")
                return View("MtIndex");

            return View();
        }

        public ActionResult NewsIndex()
        {
            return View();
        }

        public ActionResult MtIndex()
        {
            return View();
        }

        public ActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
