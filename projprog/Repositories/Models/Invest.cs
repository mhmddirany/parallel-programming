using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projprog.Repositories.Models
{
	[Table("invest")]
	internal class Invest
	{
		[Key]
		public int? Serial { get; set; }
		public DateTime? DFile { get; set; }
		public DateTime? DMahdar { get; set; }
		public string? Crime { get; set; }
		public string? Madbout { get; set; }
		public string? Resume { get; set; }
		public string? Rem { get; set; }

	}
}
