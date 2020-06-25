using System.Web.Mvc;
using AddressSearcher.helpers;
using AddressSearcher.Models;

namespace AddressSearcher.Controllers
{
    public class AddressController : Controller
    {
        // GET: Address
        public ActionResult Index()
        {
            return View();
        }

        //GET: Address/Search
        public ActionResult Search(string address)
        {
            var addressSearch = new SearchAddress();
            var foundAddresses = addressSearch.Find(address);
            return View(foundAddresses);
        }

        //GET: Address/Closest
        public ActionResult Closest(Address address)
        {
            var closestAddresses = new ClosestAddresses();
            var tenClosest = closestAddresses.Calculate(address);
            return View(tenClosest);
        }
    }
}