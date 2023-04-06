using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile_and_DAOne_team02.ViewModels
{
	public class Producer
	{
		public Guid idProducer { get; set; } 
		public string nameProducer { get; set; }
		public string descriptionProducer { get; set; }
		public int statusProducer { get; set; }
		public virtual ICollection<ProductDetail> ProductDetails { get; set; }
	}
}
