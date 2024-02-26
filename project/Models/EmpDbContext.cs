using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace kendoGridRev.Models;

public partial class EmpDbContext : DbContext
{

    public EmpDbContext(DbContextOptions options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }
    public virtual DbSet<Branch> Branches { get; set; }

    
}
