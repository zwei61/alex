using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //VanLian_OMSEntities db = new VanLian_OMSEntities();
            //var data = db.oms_open_td_PurchaseOrderStatus.OrderBy(x => x.openPurchaseOrderStatusCode);//.Select(x=>new { status = x.openPurchaseOrderStatusCode ,name=x.openPurchaseOrderStatusName});
            //if (data.Count() > 0)
            //{
            //    foreach(oms_open_td_PurchaseOrderStatus s in data)
            //    {
            //        Console.WriteLine("code:"+s.openPurchaseOrderStatusCode);
            //        Console.WriteLine("name:"+s.openPurchaseOrderStatusName);
            //    }
            //}

            VanLian_OMSEntities db = new VanLian_OMSEntities();
            var joinData = from a in db.oms_open_tt_PurchaseOrder
                           join b in db.oms_open_td_PurchaseOrderStatus on a.openPurchaseOrderStatusCode equals b.openPurchaseOrderStatusCode
                           select new
                           {
                               openPurchaseOrderID = a.openPurchaseOrderID,
                               openPurchaseOrderStatusCode = b.openPurchaseOrderStatusCode,
                               openPurchaseOrderStatusName = b.openPurchaseOrderStatusName
                           };
            foreach (var s in joinData)
            {
                Console.WriteLine("openPurchaseOrderID:" + s.openPurchaseOrderID);
                Console.WriteLine("openPurchaseOrderStatusCode:" + s.openPurchaseOrderStatusCode);
                Console.WriteLine("openPurchaseOrderStatusName:" + s.openPurchaseOrderStatusName);
            }

            Console.ReadLine();
        }
    }
}
