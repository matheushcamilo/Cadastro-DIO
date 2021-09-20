using Cadastros.Interfaces;
using System;
using System.Collections.Generic;

namespace Cadastros.Classes
{
    public class RepositorioSeries : IRepositorios<Series>
    {
        private List<Series> listaSerie = new List<Series>();

        public void Atualizar(int i, Series objeto)
        {
            listaSerie[i - 1] = objeto;
        }

        public void Excluir(int i)
        {
            listaSerie.RemoveAt(i - 1);
        }

        public void Inserir(Series objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Series> Lista()
        {
            return listaSerie;
        }

        public int Tamanho()
        {
            return listaSerie.Count;
        }

        public Series RetornaPorId(int id)
        {
            return listaSerie[id - 1];
        }

        public bool isEmpty()
        {
            return Tamanho() == 0;
        }

        public string ToString()
        {
            if(isEmpty())
            {
                Console.WriteLine("Lista vazia");
                return "Catálogo de séries vazio!";
            }
            int count = 1;
            string str = "";
            while(count <= Tamanho())
            {
                str += "Série " + count + ":\n";
                str += RetornaPorId(count).toString();
                count++;
            }
            return str;
        }
    }
}