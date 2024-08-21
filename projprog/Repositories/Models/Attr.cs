﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projprog.Repositories.Models
{
	[Table("attr")]
	internal class Attr
	{
		[Key]
		public int? Code { get; set; }
		public string? Label { get; set; }
	}
}
