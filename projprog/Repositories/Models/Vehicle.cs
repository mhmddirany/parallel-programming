using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projprog.Repositories.Models
{
	[Table("vehicle")]
	internal class Vehicle
	{
		[Key]
		public int? Vid { get; set; }
		public int? Serial {  get; set; }
		public string? VNumber { get; set; }
		public string? Code {  get; set; }
		public DateTime? Prod {  get; set; }
		public string? Chassis {  get; set; }
		public string? Motor { get; set; }
		public DateTime? Aquisition { get; set; }
		public int? PreMiseCirc { get; set; }
		public string? Color { get; set; }
		public string? Brand { get; set; }
		public string? Model { get; set; }
		public string? Utilis { get; set; }
		public string? FName { get; set; }
		public string? LName { get; set; }
		public string? Address { get; set; }
		public string ? City { get; set; }
		public string? Iqama { get; set; }
		public bool? InCirculation { get; set; }
		public string? Mother { get; set; }
		public string? Mobileno {  get; set; }
		public int? Age { get; set; }
		public string? PBirth { get; set; }
		public string? Reg { get; set; }

	}
}
