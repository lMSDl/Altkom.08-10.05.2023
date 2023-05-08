using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;

namespace WPC.DesignPrinciples
{
    public class Customer
    {
        public Customer(int id)
        {
            Id = id;
        }

        public int Id { get; }
        public string CustomerName { get; set; }
        public bool IsActive { get; set; }

        public PaymentAccount Account { get; } = new PaymentAccount();
    }
}
