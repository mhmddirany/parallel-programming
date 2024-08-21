using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projprog.Repositories.Models;

namespace projprog.Repositories.Controllers
{
	internal class InvpersonController
	{
		public static async Task<List<Invperson>> GetAllInvpersons(int serial)
		{
			List<Invperson>? invpersons = null;

			try
			{
				using var context = new DatabaseContext();
				invpersons = await context.Invpersons.Where((element) => element.Serial == serial).ToListAsync();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error when fetching all invpersons: " + ex.Message);
				throw new Exception(ex.Message);
			}

			return invpersons;
		}

		public static async Task<Invperson> GetInvpersonByPrimaries(int serial, int serpers)
		{
			Invperson? invperson = null;

			try
			{
				using var context = new DatabaseContext();
				invperson = await context.Invpersons.SingleOrDefaultAsync(element => element.Serial == serial && element.Serpers == serpers);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error when fetching invperson by serials: " + ex.Message);
				throw new Exception(ex.Message);
			}

			return invperson;
		}

		public static async Task UpdateInvperson(Invperson newInvperson)
		{
			try
			{
				Invperson? invperson = await GetInvpersonByPrimaries((int)newInvperson.Serial, (int)newInvperson.Serpers);
				if (invperson != null)
				{
					using var context = new DatabaseContext();
					context.Invpersons.Update(newInvperson);
					await context.SaveChangesAsync();
				}
				else
				{
					throw new Exception("Invperson does not exist");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error when updating invperson: " + ex.Message);
				throw new Exception(ex.Message);
			}
		}

		public static async Task RemoveInvperson(Invperson removedInvperson)
		{
			try
			{
				Invperson invperson = await GetInvpersonByPrimaries((int)removedInvperson.Serial, (int)removedInvperson.Serpers);
				if (invperson != null)
				{
					using var context = new DatabaseContext();
					context.Invpersons.Remove(removedInvperson);
					await context.SaveChangesAsync();
				}
				else
				{
					throw new Exception("Invperson does not exist");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error when deleting invperson: " + ex.Message);
				throw new Exception(ex.Message);
			}
		}

		public static async Task CreateInvperson(Invperson newInvperson)
		{
			try
			{
				Invperson invperson = await GetInvpersonByPrimaries((int)newInvperson.Serial, (int)newInvperson.Serpers);
				if (invperson == null)
				{
					using var context = new DatabaseContext();
					await context.Invpersons.AddAsync(newInvperson);
					await context.SaveChangesAsync();
				}
				else
				{
					throw new Exception("Invperson already exists");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error when creating invperson: " + ex.Message);
				throw new Exception(ex.Message);
			}
		}
	}
}
