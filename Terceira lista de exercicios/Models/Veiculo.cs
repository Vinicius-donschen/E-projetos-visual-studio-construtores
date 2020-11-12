using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terceira_lista_de_exercicios.Models
{
    class Veiculo
    {
        public Veiculo() { }

        public Veiculo(string _tipo)
        {
            Tipo = _tipo;
        }

        public Veiculo(string _tipo, int _ano)
        {
            Tipo = _tipo;
            Ano = _ano;
        }

        public Veiculo(int _ano)
        {
            Ano = _ano;
        }

        public Veiculo(string _cor, string _modelo)
        {
            Modelo = _modelo;
        }

        public Veiculo(string _cor, string _modelo, int _ano, string _tipo)
        {
            Cor = _cor;
            Modelo = _modelo;
            Ano = _ano;
            Tipo = _tipo;
        }

        private int ano;
        public int Ano
        {
            get
            {
                return ano;
            }
            set
            {
                if (value > 1999 && value <= 2020)
                {
                    ano = value;
                }
                else
                {
                    throw new Exception("O ano deve ser entre 2000 e 2020");
                }
            }
        }

        private string tipo;
        public string Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                if (value == "carro" || value == "moto" || value == "caminhao" || value == "barco" || value == "aviao")
                {
                    tipo = value;
                }
                else
                {
                    throw new Exception("insira um dos tipos: carro, moto, caminhao, barco ou aviao");
                }
            }
        }

        private string modelo;
        public string Modelo
        {
            get
            {
                return modelo;
            }
            set
            {
                if (value.Length >= 5)
                {
                    modelo = value;
                }
                else
                {
                    throw new Exception("o modelo deve ter no mínimo 5 caracteres");
                }
            }
        }

        private string cor;
        public string Cor
        {
            get
            {
                return cor;
            }
            set
            {
                if (value == "azul" || value == "verde")
                {
                    cor = value;
                }
                else
                {
                    throw new Exception("Insira o cadastro de cor azul ou verde");
                }
            }
        }
    }
}
