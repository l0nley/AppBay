using System;
using System.Linq;
using AppBay.Tests.DataServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppBay.Tests
{
  [TestClass]
  public class DataServiceTests
  {
    [TestMethod]
    public void QueryJobs()
    {
      var some = GetContext().Jobs.Take(100).ToList();
      Assert.IsTrue(true);
    }

    [TestMethod]
    public void QueryPackages()
    {
      var some = GetContext().Packages.Take(100).ToList();
      Assert.IsTrue(true);
    }

    [TestMethod]
    public void QueryResults()
    {
      var some = GetContext().JobResults.Take(100).ToList();
      Assert.IsTrue(true);
    }

    [TestMethod]
    public void PostToJobs()
    {
      var job = new JobDescription
      {
        Added = DateTime.Now,
        Description = "Some job",
        IsRunning = false,
        PackageId = 200,
        Started = null
      };
      var context = GetContext();
      context.AddToJobs(job);
      context.SaveChanges();
      Assert.IsTrue(true);
    }

    [TestMethod]
    public void PostToPackages()
    {
      var package = new Package
      {
        Description = "Some package",
        TargetClassName = "SomeClass"
      };
      var context = GetContext();
      context.AddToPackages(package);
      context.SaveChanges();
      Assert.IsTrue(true);
    }

    private Entities GetContext()
    {
      return new DataServices.Entities(new Uri("http://localhost:6000/"));
    }
  }
}
