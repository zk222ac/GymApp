using GymApp.Concrete_Products;
using GymApp.Creator;
using GymApp.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymApp.Concrete_Creator
{
    public class ConcreteMembership : MembershipFactory
    {
        public override IGym GetMembershipType(string type)
        {
            IGym igym = null;
            try
            {
                switch (type)
                {
                    case "montly":
                        return  igym = new Montly();
                    case "yearly":
                        return igym = new Yearly();
                    case "freetrial":
                        return igym = new FreeTrial();
                    default:
                        throw new ApplicationException(String.Format("membership is not avaliable", type));
                }
            }
            catch( Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return igym;
        }
    }
}
