using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DatabaseFirstConsole.Model
{
    [Table("Clients")]
    public class Client
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Mail { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime? SubscribeDate { get; set; }

        public bool IsSubscribedToNews { get; set; }

        public int PlanId { get; set; }

    }
}
