using GymApp.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymApp.Concrete_Products
{
    class FreeTrial : IGym
    {
        public string GetMembershipFee()
        {
            return "Free membership for one month";
        }
    }
}
