using Hotel_Management_System.Models;
using Hotel_Management_System.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Management_System.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        Hotel_DBEntities2 db;
        public HomeController()
        {
            db=new Hotel_DBEntities2();
        }

        public ActionResult Index()
        {
                CustomerRepository objcustomerRepository = new CustomerRepository();
                ItemRepository objitemRepository = new ItemRepository();
                PayementTypeRepository objpayementTypeRepository = new PayementTypeRepository();
            var objMultipleModel = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>
            (objcustomerRepository.GetAllCustomer(), objitemRepository.GetAllItems(), objpayementTypeRepository.GetAllPaymentType());
            return View(objMultipleModel);
        }
        [HttpGet]
        public JsonResult getItemUnitPrice(int itemId)
        {
            decimal unitprice = db.Items.Single(model => model.itemId == itemId).itemPrice;                                   
            return Json(unitprice,JsonRequestBehavior.AllowGet);
        }

    }


}