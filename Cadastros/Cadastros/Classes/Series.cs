using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastros.Enum;

namespace Cadastros.Classes
{
    public class Series : EntidadeBase
    {
        private Genero genero {get; set;}
        private string titulo { get; set;}
        private string descricao { get; set;}
        private int ano { get; set;}
        private bool excluido {get; set;}

        public Series(Genero genero, string titulo, string descricao, int ano)
        {
            this.genero = genero;
            this.titulo = titulo;
            this.descricao = descricao;
            this.ano = ano;
            this.excluido = false;
        }

        public void Excluir(){
            this.excluido = true;
        }

        public string toString(){
            string ans = "";
            ans += "Gênero: " + this.genero + Environment.NewLine;
            ans += "Título: " + this.titulo + Environment.NewLine;
            ans += "Descrição: " + this.descricao + Environment.NewLine;
            ans += "Ano: " + this.ano + Environment.NewLine;
            return ans;
        }


    }
}
