﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shark.EntityFrameworkCore.Extensions.Test.DbContextExtensions;

namespace Shark.EntityFrameworkCore.Extensions.Test.DbSetExtensions;

[TestClass]
public class ClearAsync : DbContextExtensionsBase
{
    [TestMethod]
    public async Task Using_Dbset()
    {
        var dbContext = SetupDbContext(true);
        int oldOrdersCount = dbContext.Orders.Count();
        await dbContext.Orders.ClearAsync();
        int newOrdersCount = dbContext.Orders.Count();

        Assert.IsTrue(oldOrdersCount > 0, "Orders table should have data");
        Assert.IsTrue(newOrdersCount == 0, "Order table should be empty after truncating");
    }
}