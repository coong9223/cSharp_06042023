using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile_and_DAOne_team02.ViewModels
{
	public class Color
	{
		public Guid idColor { get; set; }
		public string nameColor { get; set; }
		public virtual ICollection<ProductDetail> ProductDetails { get; set; }
	}
}
