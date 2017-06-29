using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaromFit.Models.ViewModel
{
    public class PlanoUsuarioViewModel
    {
        public Client Usuario { get; set; }
        public List<Plan> Planos { get; set; }
    }
}