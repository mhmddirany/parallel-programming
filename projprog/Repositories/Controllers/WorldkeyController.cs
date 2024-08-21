using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projprog.Repositories.Models;

namespace projprog.Repositories.Controllers
{
	internal class WorldkeyController
	{
		public static async Task<List<Worldkey>> GetAllWorldkeys()
		{
			List<Worldkey>? worldkeys = null;

			try
			{
				using var context = new DatabaseContext();
				worldkeys = await context.Worldkeys.ToListAsync();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error when fetching all worldkeys: " + ex.Message);
				throw new Exception(ex.Message);
			}

			return worldkeys;
		}
	}
}
