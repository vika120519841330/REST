using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RESTfullAPI.Models;

namespace RESTfullAPI.Controllers
{
    [RoutePrefix("Bill")]
    public class BillController : ApiController
    {
        private IBillBase bl;

        public BillController()
        {
            bl = BillBase.GetStaticClient();
        }

        [HttpGet]
        IEnumerable<Bill> ShowAllBills()
        {
            return bl.ShowAllBills();
        }

        [HttpGet]
        [Route("{id:int}")]
        Bill GetBill(int id)
        {
            return bl.GetBill(id);
        }

        [HttpPost]
        [Route("{inst:Bill}")]
        Bill OpenBill(Bill inst)
        {
            return bl.OpenBill(inst);
        }
        [HttpPut]
        [Route("{inst:Bill}/{sum:int}")]
        Bill DebitCreditBill(Bill inst, int sum)
        {
            return bl.DebitCreditBill(inst, sum);
        }
        [HttpDelete]
        [Route("{id:int}")]
        void CloseBill(int id)
        {
            bl.CloseBill(id);
        }
    }
}
