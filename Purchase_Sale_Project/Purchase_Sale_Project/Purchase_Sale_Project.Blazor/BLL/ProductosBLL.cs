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
    public class ProductosBLL
    {
        private ApplicationDbContext context;

        public ProductosBLL(ApplicationDbContext _context)
        {
            context = _context;
        }

        public async Task<bool> Guardar(Productos producto)
        {
            if (!Existe(producto.ProductoId))
                return await Insertar(producto);
            else
                return await Modificar(producto);
        }

        private bool Existe(int id)
        {
            bool existe = false;

            try
            {
                existe = context.Productos.Any(c => c.ProductoId == id);
            }
            catch (Exception)
            {
                throw;
            }
            return existe;
        }

        private async Task<bool> Insertar(Productos producto)
        {
            bool Insertado = false;

            try
            {
                context.Productos.Add(producto);
                Insertado = await context.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return Insertado;
        }

        private async Task<bool> Modificar(Productos producto)
        {
            bool Insertado = false;

            try
            {
                context.Productos.Update(producto);
                Insertado = await context.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return Insertado;
        }

        public async Task<Productos> Buscar(int id)
        {
            Productos producto = new Productos();

            try
            {
                producto = await context.Productos.FindAsync(id);
            }
            catch (Exception)
            {
                throw;
            }
            return producto;
        }

        public async Task<bool> Eliminar(int id)
        {
            bool Eliminado = false;

            try
            {
                var producto = await context.Productos.FindAsync(id);

                if (producto != null)
                {
                    context.Productos.Remove(producto);
                    Eliminado = (await context.SaveChangesAsync() > 0);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Eliminado;
        }

        public async Task<List<Productos>> GetList(Expression<Func<Productos, bool>> producto)
        {
            List<Productos> Lista = new List<Productos>();
            try
            {
                Lista = await context.Productos.Where(producto).ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return Lista;
        }
    }
}
