using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terceira_lista_de_exercicios.Models
{
    class Computador
    {
        public Computador() { }

        public Computador(string _modelo)
        {
            Modelo = _modelo;
        }

        public Computador(double _preco, string _cor)
        {
            Preco = _preco;
            Cor = _cor;   
        }

        public Computador(string modelo, string _cor)
        {

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
                if (value == "branco" || value == "preto")
                {
                    cor = value;
                }
                else
                {
                    throw new Exception("Insira os caracteres branco ou preto");
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

            }
        }

        private double preco;
        public double Preco
        {
            get
            {
                return preco;
            }
            set
            {
                if (value > 2300 && value <= 8000)
                {
                    preco = value;
                }
                else
                {
                    throw new Exception("Insira um valor entre 2300 até 8000");
                }
            }
        }

    }
}
