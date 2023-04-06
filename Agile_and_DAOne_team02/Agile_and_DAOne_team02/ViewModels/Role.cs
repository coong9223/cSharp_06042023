using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile_and_DAOne_team02.ViewModels
{
	public class Role
	{
		public Guid idRole { get; set; }	
		public string nameRole { get; set; }	
		public virtual ICollection<Staff> Staffs { get; set; }	
	}
}
