using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace NicosiaAssingment;

public static class Program
{
	public static void Main(string[] args)
	{
		try
		{
			CreateHostBuilder(args).Build().Run();
		}
		catch (Exception)
		{
			throw;
		}
	}

	public static IHostBuilder CreateHostBuilder(string[] args) =>
		Host.CreateDefaultBuilder(args)
			.ConfigureWebHostDefaults(webBuilder =>
				webBuilder.UseStartup<Startup>()
			);
}
