using AnimaFest.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimaFest.DAL
{
    public class Context :  DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //string dbPath = Directory.GetCurrentDirectory() + @"\DAL\db\Database.mdf";
                //optionsBuilder.UseSqlServer($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security=True");
                optionsBuilder.UseSqlServer(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AnimaFest;Data Source=LAPTOP-I9LM3CSP");
            }
        }

        public DbSet<Alocacao> Alocacaoes { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Gasolina> Gasolinas { get; set; }
        public DbSet<Gasto> Gastos { get; set; }
        public DbSet<Produto> Produto { get; set; }

    }
}
