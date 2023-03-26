using Hotel_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Management_System.Repositories
{
    public class CustomerRepository
    {
        private Hotel_DBEntities2 db;


        public CustomerRepository()
        {
            db = new Hotel_DBEntities2();

        }

        public IEnumerable<SelectListItem> GetAllCustomer()
        {
            var ObjectList = new List<SelectListItem>();
            ObjectList = (from obj in db.Customers
                          select new SelectListItem
                          {
                              Text = obj.CustomerName,
                              Value = obj.CustomerId.ToString(),
                              Selected = true,

                          }).ToList();
            return ObjectList;

        }


    }
}
