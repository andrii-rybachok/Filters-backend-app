using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataBase.Entities
{
	[Table("wusr_mg_CDA_TT_WorkplaceCapacity")]
	public class WorkPlaceCapacity
	{
		[Key]
		public int id { get; set; }

		public int? workplaceid { get; set; }

		public int? dailycapacity { get; set; }

		[Column(TypeName = "smalldatetime")]
		public DateTime? date { get; set; }

		[StringLength(255)]
		public string Maszyna { get; set; }
	}
}
