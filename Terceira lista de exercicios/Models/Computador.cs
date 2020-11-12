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

        public Computador(string _modelo, string _cor)
        {
            Modelo = _modelo;
            Cor = _cor;
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
                    throw new Exception("Insira os cadastros branco ou preto");
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
                if (value == "gamer" || value == "desktop")
                {
                    modelo = value;
                }
                else
                {
                    throw new Exception("Insira os cadastros gamer ou desktop");
                }
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
