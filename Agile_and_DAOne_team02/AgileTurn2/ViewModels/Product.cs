using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile_and_DAOne_team02.ViewModels
{
	public class Product
	{
		public Guid idProduct { get; set; }
		public string nameProduct { get; set; }
		public string typeProduct { get; set; }
		public string descriptionProduct { get; set; }	
		public int statusProduct { get; set; }
		public virtual ICollection<ProductDetail> ProductDetails { get; set; }
	}
}
