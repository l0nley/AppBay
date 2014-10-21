using System;
using System.Data.Services.Client;
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

    [TestMethod]
    public void UpdateJobs()
    {
      var context = GetContext();
      var job = context.Jobs.FirstOrDefault();
      Assert.IsNotNull(job);
      var id = job.Id;
      var newDescription = "Some new dummy description" + Guid.NewGuid();
      job.Description = newDescription;
      context.UpdateObject(job);
      context.SaveChanges();
      context = GetContext();
      // ReSharper disable once ReplaceWithSingleCallToFirstOrDefault
      var modifiedJob = context.Jobs.Where(p => p.Id == id).FirstOrDefault();
      Assert.IsNotNull(modifiedJob);
      Assert.AreEqual(newDescription, modifiedJob.Description);
    }

    [TestMethod, ExpectedException(typeof(DataServiceRequestException))]
    public void UpdateJobIsRunning()
    {
      PostToJobs();
      PostToJobs();
      var context = GetContext();
      var job = context.Jobs.FirstOrDefault();
      Assert.IsNotNull(job);
      job.IsRunning = !job.IsRunning;
      context.SaveChanges();
    }

    [TestMethod, ExpectedException(typeof(DataServiceRequestException))]
    public void PostIntoJobResults()
    {
      var context = GetContext();
      var jobResult = new JobResult();
      context.AddToJobResults(jobResult);
      context.SaveChanges();
    }

    private Entities GetContext()
    {
      return new DataServices.Entities(new Uri("http://localhost:6000/"));
    }
  }
}
