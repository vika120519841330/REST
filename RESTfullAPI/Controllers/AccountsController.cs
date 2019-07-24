using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RESTfullAPI.Models;

namespace RESTfullAPI.Controllers
{
    public class AccountsController : ApiController
    {
        public IBillBase bl;

        public AccountsController()
        {
            bl = BillBase.GetStaticClient();
        }
        
        [HttpGet]
        public IEnumerable<Bill> ShowAllBills()
        {
            return bl.ShowAllBills();
        }

        ////[HttpGet]
        ////public Bill GetBill(int id)
        ////{
        ////    return bl.GetBill(id);
        ////}

        //[HttpPost]
        //public void OpenBill(Bill inst)
        //{
            
        //}

        ////[HttpPut]
        ////[Route("{inst:int}/{sum:int}")]
        ////public Bill DebitCreditBill(Bill inst, int sum)
        ////{
        ////    return bl.DebitCreditBill(inst, sum);
        ////}
        //[HttpDelete]
        //public void CloseBill(int id)
        //{
        //    bl.CloseBill(id);
        //}
    }
}
