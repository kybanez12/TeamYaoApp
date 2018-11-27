using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamYaoApp.Models
{
    public class FixtureDetailsViewModel
    {
        public Fixture game { get; set; }
        public List<Payment> Pay { get; set; }
    }
}