using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projprog.Repositories.Models;

namespace projprog.Repositories.Controllers
{
	internal class ImageFaceController
	{
		public static async Task<ImageFace> GetImageFaceByPrimaries(int serial, int serpers)
		{
			ImageFace? imageFace = null;

			try
			{
				using var context = new DatabaseContext();
				imageFace = await context.ImageFaces.SingleOrDefaultAsync(element => element.Serial == serial && element.Serpers == serpers);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error when fetching imageFace by serials: " + ex.Message);
				throw new Exception(ex.Message);
			}

			return imageFace;
		}

		public static async Task UpsertImageFace(ImageFace newImageFace)
		{
			try
			{
				ImageFace? imageFace = await GetImageFaceByPrimaries((int)newImageFace.Serial, (int)newImageFace.Serpers);
				if (imageFace != null)
				{
					using var context = new DatabaseContext();
					context.ImageFaces.Update(newImageFace);
					await context.SaveChangesAsync();
				}
				else
				{
					using var context = new DatabaseContext();
					await context.ImageFaces.AddAsync(newImageFace);
					await context.SaveChangesAsync();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error when updating imageFace: " + ex.Message);
				throw new Exception(ex.Message);
			}
		}
	}
}
