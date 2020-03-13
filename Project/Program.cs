using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using ProjectName.Models;

namespace ProjectName
{
  class Program
  {
  public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();

      host.Run();
    }
  }
}
