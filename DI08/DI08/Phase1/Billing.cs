using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI08.Phase1
{
    public class Billing
    {
        public void ProcessPayment(OrderInfo orderInfo)
        {
            Console.WriteLine("進行付款");
        }
    }
}
