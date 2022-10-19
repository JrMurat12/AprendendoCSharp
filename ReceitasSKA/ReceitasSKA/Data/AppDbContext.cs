using Microsoft.EntityFrameworkCore;
using ReceitasSKA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReceitasSKA.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Criando os relacionamentos
            builder.Entity<Receita>()
                .HasOne(receita => receita.AssociacaoReceita)
                .WithOne(associacao_receita => associacao_receita.Receita) //Casos 1:1
                //.WithMany(receita => receita.AssociacaoReceita) Casos 1:N
                .HasForeignKey<AssociacaoReceita>(associacao_receita => associacao_receita.ReceitaId);
        }

        public DbSet<Receita> Receitas { get; set; }

        public DbSet<AssociacaoReceita> AssociacaoReceita { get; set; }
    }
}
