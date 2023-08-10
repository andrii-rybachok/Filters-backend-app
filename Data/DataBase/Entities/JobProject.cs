using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataBase.Entities
{
	[Table("wusr_mg_CDA_TT_JobProject")]
	public class JobProject
	{
		[Key]
		public int ID { get; set; }

		[Required]
		[StringLength(255)]
		public string Numer { get; set; }

		[StringLength(255)]
		public string Nazwa { get; set; }

		[StringLength(255)]
		public string Opis { get; set; }
	}
}
