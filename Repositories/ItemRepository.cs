using Hotel_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Management_System.Repositories
{
    public class ItemRepository
    {
        private Hotel_DBEntities2 db;
        public ItemRepository()
        {
            db = new Hotel_DBEntities2();

        }

        public IEnumerable<SelectListItem>GetAllItems()
        {
            var ObjectList = new List<SelectListItem>();
            ObjectList = (from obj in db.Items
                          select new SelectListItem
                          {
                              Text = obj.itemName,
                              Value = obj.itemId.ToString(),
                              Selected = false,

                          }).ToList();
            return ObjectList;

        }


    }
}
