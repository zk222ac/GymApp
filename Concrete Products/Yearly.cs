using GymApp.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymApp.Concrete_Products
{
    public class Yearly : IGym
    {
        public string GetMembershipFee()
        {
            return "2000 yearly";
        }
    }
}
