using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Trabalho_programação
{
    class Inclusao
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public double Quantidade { get; set; }

        public void Produtos(double soma)
        {
            Quantidade = soma;
        }

        public void alteraNome(string novoproduto)
        {
            Produto = novoproduto;
        }

        public override string ToString()
        {
            return "Id:" + Id
                + ", Produto: "
                + Produto
                + ", Quantidade de produto: "
                + Quantidade.ToString("F2", CultureInfo.InvariantCulture);
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Inclusao objAsPart = obj as Inclusao;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }

        public bool Equals(Inclusao other)
        {
            if (other == null) return false;
            return (this.Id.Equals(other.Id));
        }
    }
}
