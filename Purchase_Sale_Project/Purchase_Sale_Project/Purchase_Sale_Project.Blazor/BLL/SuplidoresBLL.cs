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
    public class SuplidoresBLL
    {
        private ApplicationDbContext context;

        public SuplidoresBLL(ApplicationDbContext _context)
        {
            context = _context;
        }

        public async Task<bool> Guardar(Suplidores suplidor)
        {
            if (!Existe(suplidor.SuplidorId))
                return await Insertar(suplidor);
            else
                return await Modificar(suplidor);
        }

        private bool Existe(int id)
        {
            bool existe = false;

            try
            {
                existe = context.Suplidores.Any(c => c.SuplidorId == id);
            }
            catch (Exception)
            {
                throw;
            }
            return existe;
        }

        private async Task<bool> Insertar(Suplidores suplidor)
        {
            bool Insertado = false;

            try
            {
                context.Suplidores.Add(suplidor);
                Insertado = await context.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return Insertado;
        }

        private async Task<bool> Modificar(Suplidores suplidor)
        {
            bool Modificado = false;

            try
            {
                context.Entry(suplidor).State = EntityState.Modified;
                Modificado = await context.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return Modificado;
        }

        public async Task<Suplidores> Buscar(int id)
        {
            Suplidores suplidor = new Suplidores();

            try
            {
                suplidor = await context.Suplidores.FindAsync(id);
            }
            catch (Exception)
            {
                throw;
            }
            return suplidor;
        }

        public async Task<bool> Eliminar(int id)
        {
            bool Eliminado = false;

            try
            {
                var suplidor = await context.Suplidores.FindAsync(id);

                if (suplidor != null)
                {
                    context.Suplidores.Remove(suplidor);
                    Eliminado = (await context.SaveChangesAsync() > 0);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Eliminado;
        }

        public async Task<List<Suplidores>> GetList(Expression<Func<Suplidores, bool>> suplidor)
        {
            List<Suplidores> Lista = new List<Suplidores>();
            try
            {
                Lista = await context.Suplidores.Where(suplidor).ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return Lista;
        }
    }
}
