using System;

public class Program
{
	public class Admin
	{
		public string name { get; set; }
		public string adminName { get; set; }
		public string password { get; set; }
		public string email { get; set; }
		public bool isSuperAdmin { get; set; }
		public Admin()
		{
			this.name = "admin";
			this.adminName = "admin";
			this.password = "password";
			this.email = "admin@localhost";
			this.isSuperAdmin = true;
		}
	}

	public static void Main()
	{
		var admin = new Admin();
		admin.name = "martin";
		WriteObjectToConsole(admin);
		Console.WriteLine("Lort");
	}

	public static string WriteObjectToConsole(object obj)
	{
		try
		{
			var properties = obj.GetType().GetProperties();
			foreach (var property in properties)
			{			
				Console.WriteLine("{0,-20}: {1,-20}", property.Name, property.GetValue(obj));
			}

			return "";
		}
		catch (Exception e)
		{
			Console.WriteLine("EXCEPTION");
			Console.WriteLine(e.Message);
			
			return "";
		}
	}
}