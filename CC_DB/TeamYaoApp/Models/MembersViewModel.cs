using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamYaoApp.Models
{
    public class MembersViewModel
    {
        public List<Member> members{ get; set; }
        public List<Payment> payments { get; set; }
    }
}