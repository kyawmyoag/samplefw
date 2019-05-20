using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SampleFw.Data.Common
{
    public class SampleFwDbContext : IdentityDbContext
    {
        public SampleFwDbContext(DbContextOptions<SampleFwDbContext> options)
            : base(options)
        {
        }
    }
}
