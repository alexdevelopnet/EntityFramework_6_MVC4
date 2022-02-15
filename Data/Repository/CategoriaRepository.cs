using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
  public   class CategoriaRepository
    {
        public void Incluir(Categoria categoria)
        {
            using (var contexto = new DbContextMVC())
            {
                if (categoria != null)
                {
                    contexto.Categorias.Add(categoria);
                    contexto.SaveChanges();
                }
            }
        }

        public List<Categoria> GetAll()
        {
            using (var contexto = new DbContextMVC())
            {
                List<Categoria> Categorias = contexto.Categorias.ToList();
                return Categorias;
            }
        }

        public Categoria Get(int id)
        {
            using (var contexto = new DbContextMVC())
            {
                Categoria Categoria = contexto.Categorias.Where(p => p.Id == id).FirstOrDefault();
                return Categoria;
            }
        }

        public void Delete(int id)
        {
            using (var contexto = new DbContextMVC())
            {
                Categoria Categoria = contexto.Categorias.Where(p => p.Id == id).FirstOrDefault();
                if (Categoria != null)
                {
                    contexto.Categorias.Remove(Categoria);
                    contexto.SaveChanges();

                }
            }
        }

        public void Update(int id)
        {
            using (var contexto = new DbContextMVC())
            {
                Categoria Categoria = contexto.Categorias.Where(p => p.Id == id).FirstOrDefault();
                if (Categoria != null)
                {
                    contexto.Categorias.Attach(Categoria);
                    contexto.SaveChanges();
                }
            }
        }
    }
}
