using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanGiayAgile.ViewModels;

namespace BanGiayAgile.ViewModels
{
    public class Staff
    {
        public Guid idStaff { get; set; }
        public string nameStaff { get; set; }
        public string sexStaff { get; set; }
        public DateTime DoBStaff { get; set; }
        public string phoneNumber { get; set; }
        public string addressStaff { get; set; }
        public EmailAddressAttribute emailStaff { get; set; }
        public PasswordPropertyTextAttribute passwordStaff { get; set; }
        public int statusStaff { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
    }
}
