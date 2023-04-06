using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile_and_DAOne_team02.ViewModels
{
	public class Size
	{
		public Guid idSize { get; set; }
		public string typeSize { get; set; }
		public string descriptionSize { get; set; }
		public int statusSize { get; set; }
		public virtual ICollection<ProductDetail> ProductDetails { get; set; }
	}
}
