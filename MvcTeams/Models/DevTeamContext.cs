using MvcTeams.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Infrastructure;
using System.Configuration;

namespace MvcTeams.Models
{

public partial class DevTeamContext : DbContext
{
    public DevTeamContext()
        : base("name=DevTeamContext")
       // : base ("name=masterEntities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<Employee> Employee { get; set; }
}
}