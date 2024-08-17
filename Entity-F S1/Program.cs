using Entity_F_S1.Context;
using Microsoft.EntityFrameworkCore;

namespace Entity_F_S1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompanyDbContext dbContext = new CompanyDbContext(); 
            //dbContext.Database.Migrate();
        }
    }
}
