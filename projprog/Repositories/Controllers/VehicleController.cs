using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projprog.Repositories.Models;

namespace projprog.Repositories.Controllers
{
	internal class VehicleController
	{
		public static async Task<List<Vehicle>> GetAllVehicles(int serial)
		{
			List<Vehicle>? vehicles = null;

			try
			{
				using var context = new DatabaseContext();
				vehicles = await context.Vehicles.Where((element) => element.Serial == serial).ToListAsync();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error when fetching all vehicles: " + ex.Message);
				throw new Exception(ex.Message);
			}

			return vehicles;
		}

		public static async Task<Vehicle> GetVehicleByVid(int vid)
		{
			Vehicle? vehicle = null;

			try
			{
				using var context = new DatabaseContext();
				vehicle = await context.Vehicles.SingleOrDefaultAsync(element => element.Vid == vid);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error when fetching vehicle by vid: " + ex.Message);
				throw new Exception(ex.Message);
			}

			return vehicle;
		}

		public static async Task UpdateVehicle(Vehicle newVehicle)
		{
			try
			{
				Vehicle? vehicle = await GetVehicleByVid((int)newVehicle.Vid);
				if (vehicle != null)
				{
					using var context = new DatabaseContext();
					context.Vehicles.Update(newVehicle);
					await context.SaveChangesAsync();
				}
				else
				{
					throw new Exception("Vehicle does not exist");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error when updating vehicle: " + ex.Message);
				throw new Exception(ex.Message);
			}
		}

		public static async Task RemoveVehicle(Vehicle removedVehicle)
		{
			try
			{
				Vehicle vehicle = await GetVehicleByVid((int)removedVehicle.Vid);
				if (vehicle != null)
				{
					using var context = new DatabaseContext();
					context.Vehicles.Remove(removedVehicle);
					await context.SaveChangesAsync();
				}
				else
				{
					throw new Exception("Vehicle does not exist");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error when deleting vehicle: " + ex.Message);
				throw new Exception(ex.Message);
			}
		}

		public static async Task CreateVehicle(Vehicle newVehicle)
		{
			try
			{
				Vehicle vehicle = await GetVehicleByVid((int)newVehicle.Vid);
				if (vehicle == null)
				{
					using var context = new DatabaseContext();
					await context.Vehicles.AddAsync(newVehicle);
					await context.SaveChangesAsync();
				}
				else
				{
					throw new Exception("Vehicle already exists");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error when creating vehicle: " + ex.Message);
				throw new Exception(ex.Message);
			}
		}
	}
}
