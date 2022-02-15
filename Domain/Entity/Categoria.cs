using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public  class Categoria
    {
        
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual List<Produto> Produto { get; set; }
    }
}