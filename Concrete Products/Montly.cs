using GymApp.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymApp.Concrete_Products
{
    public class Montly : IGym
    {
        public string GetMembershipFee()
        {
            return "200 kr/month";
        }
    }
}
