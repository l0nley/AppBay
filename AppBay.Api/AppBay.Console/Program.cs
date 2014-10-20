using System;
using System.Data.Services;

namespace AppBay.Console
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var serviceType = typeof(AppBayService);
      var baseAddress = new Uri("http://localhost:6000/");
      var baseAddresses = new[] { baseAddress };

      // Create a new hosting instance for the Northwind 
      // data service at the specified address. 
      var host = new DataServiceHost(
         serviceType,
         baseAddresses);
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