using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaromFit.Models.ViewModel
{
    public class UserPlanViewModel
    {
        public Client Client { get; set; }
        public List<Plan> Plans { get; set; }
    }
}