using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projprog.Repositories.Models
{
	[Table("imageFace")]
	internal class ImageFace
	{
		public int? Serial { get; set; }
		public int? Serpers { get; set; }
		public byte[]? faceLeft { get; set; }
		public byte[]? faceRight { get; set; }
		public byte[]? faceFront { get; set; }
	}
}
