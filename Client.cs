using GymApp.Concrete_Creator;
using GymApp.Concrete_Products;
using GymApp.Creator;
using GymApp.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymApp
{
   public  class Client
    {
       public static void CallClient()
        {
            // Traditional way of using client class
            // IGym igym = null;

            // Console.WriteLine("type your membership here");
            // string type = Console.ReadLine();
            // if(type == "montly")
            // {
            //     igym = new Montly();
            // }
            // else if(type == "yearly")
            // {
            //     igym = new Yearly();
            // }

            //Console.WriteLine(igym.GetMembershipFee());

            //Here we use factory method way of style 

            try
            {
                // Factory or creator method 
                MembershipFactory factory = new ConcreteMembership();
                Console.WriteLine("type your membership here");
                string type = Console.ReadLine();
                IGym igym = factory.GetMembershipType(type);
                Console.WriteLine(igym.GetMembershipFee());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
         
        }

    }
}
