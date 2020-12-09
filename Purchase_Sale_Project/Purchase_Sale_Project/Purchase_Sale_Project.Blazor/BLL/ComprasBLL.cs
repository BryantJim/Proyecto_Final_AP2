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
    public class ComprasBLL
    {
        private ApplicationDbContext context;

        public ComprasBLL(ApplicationDbContext _context)
        {
            context = _context;
        }

        public async Task<bool> Guardar(Compras compra)
        {
            if (!Existe(compra.CompraId))
                return await Insertar(compra);
            else
                return await Modificar(compra);
        }

        private bool Existe(int id)
        {
            bool existe = false;

            try
            {
                existe = context.Compras.Any(c => c.CompraId == id);
            }
            catch (Exception)
            {
                throw;
            }
            return existe;
        }

        private async Task<bool> Insertar(Compras compra)
        {
            bool Insertado = false;

            try
            {
                context.Compras.Add(compra);
                Insertado = await context.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return Insertado;
        }

        private async Task<bool> Modificar(Compras compra)
        {
            bool Insertado = false;

            try
            {
                context.Database.ExecuteSqlRaw($"Delete FROM ComprasDetalle Where CompraId = {compra.CompraId}");
                foreach (var item in compra.Detalle)
                {
                    context.Entry(item).State = EntityState.Added;
                }

                context.Entry(compra).State = EntityState.Modified;
                Insertado = await context.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return Insertado;
        }

        public async Task<Compras> Buscar(int id)
        {
            Compras compra = new Compras();

            try
            {
                compra = await context.Compras
                    .Where(c => c.CompraId == id)
                    .Include(e => e.Detalle)
                    .FirstOrDefaultAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return compra;
        }

        public async Task<bool> Eliminar(int id)
        {
            bool Eliminado = false;

            try
            {
                var compra = await Buscar(id);

                if (compra != null)
                {
                    context.Compras.Remove(compra);
                    Eliminado = (await context.SaveChangesAsync() > 0);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Eliminado;
        }

        public async Task<List<Compras>> GetList(Expression<Func<Compras, bool>> compra)
        {
            List<Compras> Lista = new List<Compras>();
            try
            {
                Lista = await context.Compras.Where(compra).ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return Lista;
        }
    }
}
