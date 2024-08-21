using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projprog.Utilities
{
	internal class BlobConversion
	{
		static public byte[] ConvertImageToBlob(string imageLocation)
		{
			try
			{
				return File.ReadAllBytes(imageLocation);
			}
			catch (Exception ex)
			{
				ErrorViewer.ShowError(ex.Message);
			}

			return null;
		}

		static public Image ConvertBlobToImage(byte[] imageBlob)
		{
			if (imageBlob == null) return null;
			try
			{
				using MemoryStream ms = new(imageBlob);
				return Image.FromStream(ms);
			}
			catch (Exception ex)
			{
				ErrorViewer.ShowError(ex.Message);

			}

			return null;
		}
	}
}
