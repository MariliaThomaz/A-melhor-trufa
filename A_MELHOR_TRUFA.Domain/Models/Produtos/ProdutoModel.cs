using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_MELHOR_TRUFA.Domain.Models.Produtos
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; }
        public DateTime DataVencimento { get; set; }
        public DateTime  DataFabricacao { get; set; }
        public  decimal Valor { get; set; }
        public int Quantidade { get; set; }


        


    }
}
