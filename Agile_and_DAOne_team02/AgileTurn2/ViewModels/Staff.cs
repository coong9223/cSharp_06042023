using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile_and_DAOne_team02.ViewModels
{
	public class Staff
	{
		public Guid idStaff { get; set; }
		public Guid idRole { get; set; }
		public string hoTenStaff { get; set; }	
		public string nameRole { get; set; }	
		public string sexStaff { get; set; }	
		public DateTime DoBStaff { get; set; }	
		public string phoneNumber { get; set; }	
		public string addressStaff { get; set; }	
		public EmailAddressAttribute emailStaff { get; set; }
		public PasswordPropertyTextAttribute passwordStaff { get; set; }
		public int statusStaff { get; set; }
		public virtual ICollection<Bill> Bills { get; set; }
		public virtual Role Roles { get; set; }
	}
}
