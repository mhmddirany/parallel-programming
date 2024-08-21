using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projprog.Repositories.Models;

namespace projprog.Repositories.Controllers
{
	internal class AttrController
	{
		public static async Task<List<Attr>> GetAllAttrs()
		{
			List<Attr>? attrs = null;

			try
			{
				using var context = new DatabaseContext();
				attrs = await context.Attrs.ToListAsync();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error when fetching all attrs: " + ex.Message);
				throw new Exception(ex.Message);
			}

			return attrs;
		}
	}
}
