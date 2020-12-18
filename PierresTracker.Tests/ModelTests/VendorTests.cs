using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresTracker.Models;
using System.Collections.Generic;
using System;

namespace PierresTracker.Tests
{
    [TestClass]
    public class VendorTest : IDisposable
    {

      public void Dispose()
      {
        Vendor.ClearAll();
      }

      [TestMethod]
      public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
      {
        Vendor newVendor = new Vendor("Test Vendor");
        Assert.AreEqual(typeof(Vendor), newVendor.GetType());
      }

      [TestMethod]
      public void GetName_ReturnsName_String()
      {
        string name = "Test Vendor";
        Vendor newVendor = new Vendor(name);
        string result = newVendor.Name;
        Assert.AreEqual(name, result);
      }

      [TestMethod]
      public void GetId_ReturnVendorId_int()
      {
        string name = "Test Vendor";
        Vendor newVendor = new Vendor(name);
        int result = newVendor.Id;
        Assert.AreEqual(1, result);
      }
    }
}