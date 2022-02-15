using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ProdutoRepository
    {
        public void Incluir(Produto produto)
        {
            using (var contexto = new DbContextMVC())
            {
                if (produto != null)
                {
                    contexto.Produtos.Add(produto);
                    contexto.SaveChanges();
                }
            }

        }
       
        public List<Produto> GetAll()
        {
            using (var contexto = new DbContextMVC())
            {
                List<Produto> produtos = contexto.Produtos.ToList();
                return produtos;
            }
        }
        
        public Produto Get(int id)
        {
            using (var contexto = new DbContextMVC())
            {
                Produto produto = contexto.Produtos.Where(p => p.Id == id).FirstOrDefault();
                return produto;
            }
        }

        public void Delete(int id)
        {
            using (var contexto = new DbContextMVC())
            {
                Produto produto = contexto.Produtos.Where(p => p.Id == id).FirstOrDefault();
                if (produto != null)
                {
                    contexto.Produtos.Remove(produto);
                    contexto.SaveChanges();

                }
            }
        }

        public void Update(int id)
        {
            using (var contexto = new DbContextMVC())
            {
                Produto produto = contexto.Produtos.Where(p => p.Id == id).FirstOrDefault();
                if (produto != null)
                {
                    contexto.Produtos.Attach(produto);
                    contexto.SaveChanges();
                }
            }
        }
    }

}
