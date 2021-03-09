using GymApp.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymApp.Creator
{
    // factory class is abstract class
   public abstract class MembershipFactory
    {
        public abstract IGym GetMembershipType(string type);
    }
}
