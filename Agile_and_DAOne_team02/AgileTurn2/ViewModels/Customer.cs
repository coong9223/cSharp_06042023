using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile_and_DAOne_team02.ViewModels
{
	public class Customer
	{
		public Guid idCustomer { get; set; }	
		public string codeCustomer { get; set; }
		public string nameCustomer { get; set; }	
		public DateTime DoBCustomer { get; set; }
		public string addressCustomer { get; set; }
		public string phoneNumberCustomer { get; set; }
		public EmailAddressAttribute emailCustomer { get; set; }	
		public int statusCustomer { get; set; }
		public virtual ICollection<Bill> Bills { get; set; }
	}
}
