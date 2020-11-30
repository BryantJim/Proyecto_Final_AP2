using Microsoft.EntityFrameworkCore;
using Models;
using Purchase_Sale_Project.Blazor.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Purchase_Sale_Project.Blazor.BLL
{
    public class UsuariosBLL
    {
        private ApplicationDbContext context;

        public UsuariosBLL(ApplicationDbContext _context)
        {
            context = _context;
        }

        public async Task<List<Usuarios>> GetList(Expression<Func<Usuarios, bool>> usuario)
        {
            List<Usuarios> Lista = new List<Usuarios>();
            try
            {
                Lista = await context.Usuarios.Where(usuario).ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return Lista;
        }
    }
}
