using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projprog.Repositories.Models;

namespace projprog.Repositories.Controllers
{
	internal class ImageFPController
	{
		public static async Task<ImageFP> GetImageFPByPrimaries(int serial, int serpers)
		{
			ImageFP? imageFP = null;

			try
			{
				using var context = new DatabaseContext();
				imageFP = await context.ImageFPs.SingleOrDefaultAsync(element => element.Serial == serial && element.Serpers == serpers);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error when fetching imageFP by serials: " + ex.Message);
				throw new Exception(ex.Message);
			}

			return imageFP;
		}

		public static async Task UpsertImageFP(ImageFP newImageFP)
		{
			try
			{
				ImageFP? imageFP = await GetImageFPByPrimaries((int)newImageFP.Serial, (int)newImageFP.Serpers);
				if (imageFP != null)
				{
					using var context = new DatabaseContext();
					context.ImageFPs.Update(newImageFP);
					await context.SaveChangesAsync();
				}
				else
				{
					using var context = new DatabaseContext();
					await context.ImageFPs.AddAsync(newImageFP);
					await context.SaveChangesAsync();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error when updating imageFP: " + ex.Message);
				throw new Exception(ex.Message);
			}
		}
	}
}
