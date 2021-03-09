using System;
using System.Collections.Generic;
using System.Text;

namespace GymApp.Product
{
   // The Product declares the interface, which is common to all objects 
    //that can be produced by the creator and its subclasses.
   public interface IGym
    {
        string GetMembershipFee();
    }
}
