using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataBase.Entities
{
	[Table("wusr_mg_CDA_TT_ProdProcess")]
	public class ProdProcess
	{
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Key]
		public int Id { get; set; }

		public DateTime? ModificationDate { get; set; }

		[StringLength(255)]
		public string ModificationUser { get; set; }

		public int? JobId { get; set; }

		public int? WorkplaceId { get; set; }

		public DateTime? ProcessStart { get; set; }

		public DateTime? ProcessEnd { get; set; }

		public decimal? ProcessDuration { get; set; }

		public string PartName { get; set; }

		public string ProcessStatus { get; set; }

		public bool? IsDone { get; set; }

		public string Name { get; set; }

		public string Note { get; set; }

		public int? TechOrder { get; set; }

		public int? GrossAmount { get; set; }

		public string ProdType { get; set; }

		public decimal? ProcessDurationPoduction { get; set; }

		public decimal? ProcessDurationMakeReady { get; set; }

		public string CalcProcessPath { get; set; }

		public int? CalculationId { get; set; }

		public int? CalcProcessId { get; set; }

		[StringLength(255)]
		public string Maszyna { get; set; }

		[Column("wusr_mg_CDA_TT_Workplace")]
		public virtual WorkPlace WorkPlace { get; set; }
	}
}
