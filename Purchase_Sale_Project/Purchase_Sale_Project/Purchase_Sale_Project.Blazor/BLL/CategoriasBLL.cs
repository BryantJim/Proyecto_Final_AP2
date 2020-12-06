using Microsoft.AspNetCore.Mvc;
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
    public class CategoriasBLL : ControllerBase
    {
        private ApplicationDbContext context;

        public CategoriasBLL(ApplicationDbContext _context)
        {
            context = _context;
        }

        public async Task<bool> Guardar(Categorias categoria)
        {
            if (!Existe(categoria.CategoriaId))
                return await Insertar(categoria);
            else
                return await Modificar(categoria);
        }

        private bool Existe(int id)
        {
            bool existe = false;

            try
            {
                existe = context.Categorias.Any(c => c.CategoriaId == id);
            }
            catch (Exception)
            {
                throw;
            }
            return existe;
        }

        private async Task<bool> Insertar(Categorias categoria)
        {
            bool Insertado = false;

            try
            {
                context.Categorias.Add(categoria);
                Insertado = await context.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return Insertado;
        }

        private async Task<bool> Modificar(Categorias categoria)
        {
            bool Modificado = false;

            try
            {
                context.Entry(categoria).State = EntityState.Modified;
                Modificado = await context.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return Modificado;
        }

        public async Task<Categorias> Buscar(int id)
        {
            Categorias categoria = new Categorias();
            string Id = User.getUserId();

            try
            {
                categoria = await context.Categorias.FindAsync(id);
            }
            catch (Exception)
            {
                throw;
            }
            return categoria;
        }

        public async Task<bool> Eliminar(int id)
        {
            bool Eliminado = false;

            try
            {
                var categoria = await context.Categorias.FindAsync(id);

                if (categoria != null)
                {
                    context.Categorias.Remove(categoria);
                    Eliminado = (await context.SaveChangesAsync() > 0);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Eliminado;
        }

        public async Task<List<Categorias>> GetList(Expression<Func<Categorias, bool>> categoria)
        {
            List<Categorias> Lista = new List<Categorias>();
            try
            {
                Lista = await context.Categorias.Where(categoria).ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return Lista;
        }
    }
}
