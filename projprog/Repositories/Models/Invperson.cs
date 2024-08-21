using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projprog.Repositories.Models
{
	[Table("invperson")]
	internal class Invperson
	{
		public int? Serial { get; set; }
		public int? Serpers { get; set; }
		public string? FName { get; set; }
		public string? LName { get; set; }
		public string? Father { get; set; }
		public string? Mother { get; set; }
		public string? Nation { get; set; }
		public string? Reg { get; set; }
		public string? PBirth { get; set; }
		public DateTime? DBirth { get; set; }
		public string? Resid { get; set; }
		public string? Adrs { get; set; }
		public string? Attr { get; set; }
		public int? Exst { get; set; }
		public int? Arch { get; set; }
		public string? Nickname { get; set; }
		public string? Occupation { get; set; }
		public string? Idnum { get; set; }
		public string? Mobileno { get; set; }
		public string? Status { get; set; }
		public string? Gender { get; set; }

	}
}
