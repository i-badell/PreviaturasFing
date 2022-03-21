using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreviaturasFing.Infrastructure.Context.Factories
{
    public class SubjectDbContextFactory : DesignTimeDbContextFactory<SubjectDbContext>
    {
        protected override SubjectDbContext CreateNewInstance(DbContextOptions<SubjectDbContext> options)
        {
            return new SubjectDbContext(options);
        }
    }
}
