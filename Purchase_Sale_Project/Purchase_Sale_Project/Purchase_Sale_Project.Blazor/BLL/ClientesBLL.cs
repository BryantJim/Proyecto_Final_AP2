using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using Purchase_Sale_Project.Blazor.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Purchase_Sale_Project.Blazor.BLL
{
    
    public class ClientesBLL
    {
        private ApplicationDbContext context;

        public ClientesBLL(ApplicationDbContext _context)
        {
            context = _context;
        }

        public async Task<bool> Guardar(Clientes clientes)
        {
            if (!Existe(clientes.ClienteId))
                return await Insertar(clientes);
            else
                return await Modificar(clientes);
        }

        private bool Existe(int id)
        {
            bool existe = false;

            try
            {
                existe = context.Clientes.Any(c => c.ClienteId == id);
            }
            catch (Exception)
            {
                throw;
            }
            return existe;
        }

        private async Task<bool> Insertar(Clientes clientes)
        {
            bool Insertado = false;

            try
            {
                context.Clientes.Add(clientes);
                Insertado = await context.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return Insertado;
        }

        private async Task<bool> Modificar(Clientes clientes)
        {
            bool Insertado = false;

            try
            {
                context.Entry(clientes).State = EntityState.Modified;
                Insertado = await context.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return Insertado;
        }

        public async Task<Clientes> Buscar(int id)
        {
            Clientes cliente = new Clientes();

            try
            {
                cliente = await context.Clientes.FindAsync(id);
            }
            catch (Exception)
            {
                throw;
            }
            return cliente;
        }

        public async Task<bool> Eliminar(int id)
        {
            bool Eliminado = false;

            try
            {
                var cliente = await context.Clientes.FindAsync(id);

                if (cliente != null)
                {
                    context.Clientes.Remove(cliente);
                    Eliminado = (await context.SaveChangesAsync() > 0);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Eliminado;
        }

        public async Task<List<Clientes>> GetList(Expression<Func<Clientes, bool>> cliente)
        {
            List<Clientes> Lista = new List<Clientes>();
            try
            {
                Lista = await context.Clientes.Where(cliente).ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return Lista;
        }
    }
}
