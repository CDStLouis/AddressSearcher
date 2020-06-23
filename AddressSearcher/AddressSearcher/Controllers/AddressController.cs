using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AddressSearcher.helpers;

namespace AddressSearcher.Controllers
{
    public class AddressController : Controller
    {
        // GET: Address
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search(string address)
        {
            //string test = address;

            var addressSearch = new SearchAddress();
            var foundAddresses = addressSearch.find(address);
            // pass address into function, function returns an array of results
            // pass array of addresses into view
            // NEED TO do some sort of print statement here so i can see whether the address is being passed through or not
            return View(foundAddresses); //returns list of address objects to view
        }

        public ActionResult Closest(string address)
        {
            //string test = address;

            var foundAddress = new ClosestAddresses();
            var closestAddresses = foundAddress.calculate(address);
            return View(closestAddresses);
        }
    }
}