using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Cadastroclientes.Models
{
    public class CadastroclientesContext : DbContext
    {
        public CadastroclientesContext (DbContextOptions<CadastroclientesContext> options)
            : base(options)
        {
        }

        public DbSet<Cadastroclientes.Models.cadastro> cadastro { get; set; }
    }
}
