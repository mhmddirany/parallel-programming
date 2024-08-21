using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projprog.Repositories.Models;

namespace projprog.Repositories.Controllers
{
	internal class NationController
	{
		public static async Task<List<Nation>> GetAllNations()
		{
			List<Nation>? nations = null;

			try
			{
				using var context = new DatabaseContext();
				nations = await context.Nations.ToListAsync();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error when fetching all nations: " + ex.Message);
				throw new Exception(ex.Message);
			}

			return nations;
		}
	}
}
