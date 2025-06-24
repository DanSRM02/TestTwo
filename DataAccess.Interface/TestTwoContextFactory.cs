using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Configuration;

namespace DataAccess
{
    internal class TestTwoContextFactory : IDesignTimeDbContextFactory<TestTwoContext>
    {
        public TestTwoContext CreateDbContext(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            var optionsBuilder = new DbContextOptionsBuilder<TestTwoContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new TestTwoContext(optionsBuilder.Options);
        }
    }
    
    
}
