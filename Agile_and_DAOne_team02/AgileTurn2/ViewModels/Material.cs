using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile_and_DAOne_team02.ViewModels
{
	public class Material
	{
		public Guid idMaterial { get; set; }
		public string nameMaterial { get; set; }	
		public string descriptionMaterial { get; set; }	
		public int statusMaterial { get; set; }
		public virtual ICollection<ProductDetail> ProductDetails { get; set; }
	}
}
