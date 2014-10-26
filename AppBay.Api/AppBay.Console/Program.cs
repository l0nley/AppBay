using System;
using System.Data.Services;
using AppBay.ApiEnd;

namespace AppBay.Console
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var serviceType = typeof(AppBayService);
      var baseAddress = new Uri("http://localhost:6000/");
      var host = new DataServiceHost(serviceType, new[] { baseAddress });
      
      host.Open();
      
      // Keep the data service host open while the console is open. 
      System.Console.WriteLine(
        "Navigate to the following URI to see the service.");
      System.Console.WriteLine(baseAddress);
      System.Console.WriteLine("Press any key to exit...");
      System.Console.ReadKey();

      // Close the host. 
      host.Close();
    }
  }
}