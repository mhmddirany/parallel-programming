using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projprog.Repositories.Models;

namespace projprog.Repositories.Controllers
{
	internal class VillageController
	{
		public static async Task<List<Village>> GetAllVillages()
		{
			List<Village>? villages = null;

			try
			{
				using var context = new DatabaseContext();
				villages = await context.Villages.ToListAsync();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error when fetching all villages: " + ex.Message);
				throw new Exception(ex.Message);
			}

			return villages;
		}
	}
}
