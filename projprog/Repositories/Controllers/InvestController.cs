using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projprog.Repositories.Models;

namespace projprog.Repositories.Controllers
{
	internal static class InvestController
	{
		public static async Task<List<Invest>> GetAllInvests()
		{
			List<Invest>? invests = null;

			try
			{
				using var context = new DatabaseContext();
				invests = await context.Invests.ToListAsync();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error when fetching all invests: " + ex.Message);
				throw new Exception(ex.Message);
			}

			return invests;
		}

		public static async Task<Invest> GetInvestBySerial(int serial)
		{
			Invest? invest = null;

			try
			{
				using var context = new DatabaseContext();
				invest = await context.Invests.SingleOrDefaultAsync(element => element.Serial == serial);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error when fetching invest by serial: " + ex.Message);
				throw new Exception(ex.Message);
			}

			return invest;
		}

		public static async Task<List<Invest>> GetInvestsByWorld(string world) {
			List<Invest>? invests = null;

			try
			{
				using var context = new DatabaseContext();
				invests = await context.Invests.Where(value => value.Crime == world).ToListAsync();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error when fetching all invests by world: " + ex.Message);
				throw new Exception(ex.Message);
			}

			return invests;
		}
		public static async Task UpdateInvest(Invest newInvest)
		{
			try
			{
				Invest? invest = await GetInvestBySerial((int)newInvest.Serial);
				if (invest != null)
				{
					using var context = new DatabaseContext();
					context.Invests.Update(newInvest);
					await context.SaveChangesAsync();
				}
				else
				{
					throw new Exception("Invest does not exist");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error when updating invest: " + ex.Message);
				throw new Exception(ex.Message);
			}
		}

		public static async Task RemoveInvest(Invest removedInvest)
		{
			try
			{
				Invest invest = await GetInvestBySerial((int)removedInvest.Serial);
				if(invest != null)
				{
					using var context = new DatabaseContext();
					context.Invests.Remove(removedInvest);
					await context.SaveChangesAsync();
				}
				else
				{
					throw new Exception("Invest does not exist");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error when deleting invest: " + ex.Message);
				throw new Exception(ex.Message);
			}
		}

		public static async Task CreateInvest(Invest newInvest)
		{
			try
			{
				Invest invest = await GetInvestBySerial((int)newInvest.Serial);
				if(invest == null)
				{
					using var context = new DatabaseContext();
					await context.Invests.AddAsync(newInvest);
					await context.SaveChangesAsync();
				}
				else
				{
					throw new Exception("Invest already exists");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error when creating invest: " + ex.Message);
				throw new Exception(ex.Message);
			}
		}
	}
}
