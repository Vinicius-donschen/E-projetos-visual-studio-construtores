using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Terceira_lista_de_exercicios.Models
{
    class Estudante
    {
        public Estudante() { }

        public Estudante(string _nome)
        {
            Nome = _nome;
        }

        public Estudante(string _nome, int _idade)
        {
            Nome = _nome;
            Idade = _idade;
        }

        public Estudante(int _idade, string _telefone)
        {
            Idade = _idade;
            Telefone = _telefone;
        }

        public Estudante(string _email, string _telefone)
        {

        }

        private int idade;
        public int Idade
        {
            get
            {
                return idade;
            }
            set
            {
                if (value > 12 && value <= 18)
                {
                    idade = value;
                }
                else
                {
                    throw new Exception("informe uma idade entre 13 e 18!!");
                }
            }
        }

        private string telefone;
        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                if (value.Length >= 11 && value.Length <= 15)
                {
                    telefone = value;
                }
                else
                {
                    throw new Exception("informe um número que contenha entre 11 até 15 cacacteres");
                }
            }
        }

        private string nome;
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (value.Length >= 1)
                {
                    nome = value;
                }
                else
                {
                    throw new Exception("O nome não pode ser nulo!!");                }
            }
        }
    }
}
