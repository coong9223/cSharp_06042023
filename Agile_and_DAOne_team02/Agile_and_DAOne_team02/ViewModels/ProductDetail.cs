using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile_and_DAOne_team02.ViewModels
{
	public class ProductDetail
	{
		public Guid idProDetail { get; set; }
		public Guid idProduct { get; set; }
		public Guid idColor { get; set; }
		public Guid idMaterial { get; set; }
		public Guid idProducer { get; set; }	
		public Guid idSize { get; set; }
		public string nameProduct { get; set; }
		public string nameColor { get; set; }	
		public string nameMaterial { get; set; }	
		public string nameProducer { get;set; }
		public string typeSize { get; set; }
		public DateTime DImport { get; set; }
		public DateTime DSell { get; set; }
		public decimal priceImport { get; set; }	
		public decimal price { get; set; }
		public int availableQuantity { get; set; }
		public string description { get; set; }
		public int status { get; set; }
		public virtual Product Products { get; set; }
		public virtual Color Colors { get; set; }
		public virtual Material Materials { get; set; }
		public virtual Producer Producers { get; set; }
		public virtual Size Sizes { get; set; }
		public virtual ICollection<BillDetail> BillDetails { get; set; }
	}
}
