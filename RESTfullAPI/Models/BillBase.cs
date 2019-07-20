using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace RESTfullAPI.Models
{
    public class BillBase : IBillBase
    {
        public List<Bill> BillsData = new List<Bill>
        {
            new Bill
            {
                BillId = 11,
                BillBalance = 120,
                BillNumber = "123456781",
                Owner = 1
            },
            new Bill
            {
                BillId = 12,
                BillBalance = 0,
                BillNumber = "123456782",
                Owner = 1
            },
            new Bill
            {
                BillId = 13,
                BillBalance = 1100,
                BillNumber = "123456783",
                Owner = 2
            },
            new Bill
            {
                BillId = 14,
                BillBalance = 1230,
                BillNumber = "123456784",
                Owner = 2
            },
            new Bill
            {
                BillId = 15,
                BillBalance = 57457,
                BillNumber = "123456785",
                Owner = 3
            }
        };
        // Статический обьект класса
        private static BillBase bb = new BillBase();
        public static IBillBase GetStaticClient()
        {
            return bb;
        }
        public IEnumerable<Bill> ShowAllBills()
        {
            return BillsData;
        }
        public Bill GetBill(int id)
        {
            var tmp = from bd in BillsData
                      where bd.BillId == id
                      select bd;
            return tmp.Count() > 0 ? tmp.First() : null;
        }
        public Bill OpenBill(Bill inst)
        {
            inst.BillId = BillsData.Count + 1;
            BillsData.Add(inst);
            return inst;
        }
        public Bill DebitCreditBill(Bill inst, int sum)
        {
            Bill tmp = GetBill(inst.BillId);
            if (tmp != null)
            {
                tmp.BillId = inst.BillId;
                tmp.BillNumber = inst.BillNumber;
                tmp.BillBalance = inst.BillBalance + sum;
                tmp.Owner = inst.Owner;
                return tmp;
            }
            else
                return null;
        }
        public void CloseBill(int id)
        {
            Bill tmp = GetBill(id);
            if (tmp != null)
                BillsData.Remove(tmp);
        }
    }
}