using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataBase.Entities
{
	[Table("wusr_mg_CDA_TT_Workplace")]
	public class WorkPlace
	{
		public WorkPlace()
		{
			ProdProcesses = new HashSet<ProdProcess>();
		}

		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Key]
		public int ID { get; set; }

		[StringLength(255)]
		public string Code { get; set; }

		[StringLength(255)]
		public string Name { get; set; }

		[StringLength(500)]
		public string Note { get; set; }

		public int? DepartmentId { get; set; }

		[Column("wusr_mg_CDA_TT_ProdProcess")]
		public  ICollection<ProdProcess> ProdProcesses { get; set; }
	}
}
