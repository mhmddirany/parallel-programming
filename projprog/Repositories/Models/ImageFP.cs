using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projprog.Repositories.Models
{
	[Table("imageFP")]
	internal class ImageFP
	{
		public int? Serial { get; set; }
		public int? Serpers { get; set; }
		public byte[]? fpRight { get; set; }
		public byte[]? fpLeft { get; set; }
	}
}
