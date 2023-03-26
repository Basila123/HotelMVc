using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using Hotel_Management_System.Models;
namespace Hotel_Management_System.Repositories
{

    public class PayementTypeRepository
    {

        
        private Hotel_DBEntities2 db;
      public PayementTypeRepository() {
            db= new Hotel_DBEntities2();
                  
        }

        public IEnumerable<SelectListItem> GetAllPaymentType()
        {
            var  ObjectList = new List<SelectListItem>();
            ObjectList = (from obj in db.PayementTypes
                          select new SelectListItem
                          {
                              Text = obj.PayementTypeName,
                              Value = obj.PayementTypeId.ToString(),
                              Selected = true,

                          }).ToList();
            return ObjectList;

        }


    }
}