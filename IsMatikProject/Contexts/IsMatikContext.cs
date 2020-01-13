using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsMatikProject.Gateways
{
    class IsMatikContext : DbContext
    {
        public IsMatikContext() : base("data source=localhost;initial catalog=IsMatikProject;persist security info=True;integrated security=SSPI;MultipleActiveResultSets=True;App=EntityFramework")
        {

        }
        public DbSet<ProductDetails> productDetails { get; set; }
    }
}
