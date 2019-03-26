using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetQuax.Entities
{
  interface IUser
  {
    Address GetAddressByUser(int userId);
    BillingInformation GetBillingInformationByUser(int UserId);
    
  }
}
