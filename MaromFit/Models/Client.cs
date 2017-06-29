using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaromFit.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime SubscribeDate { get; set; }

        public Plan Plan { get; set; }
        public int PlanId { get; set; }
    }
}