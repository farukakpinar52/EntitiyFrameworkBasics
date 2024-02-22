using EntitiyDefiningRules.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyDefiningRules.Context
{
    public class ETicaretDbContext : DbContext
    {
        DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Kullanım amaçları :
            //hangi tür veritabanına karşılık davranış sergilenecek : Provider
            //Hangi sunucuda olacak : ConnectionString
            //Lazy & Eager loading hangisi olacak?
            optionsBuilder.UseSqlServer("\"Server=DESKTOP-P7KA77K\\\\SQLEXPRESS;Database=CodefirstDB;User Id=sa;Password=1234; ;TrustServerCertificate=true\"");

        }

    }
}
