using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terceira_lista_de_exercicios.Models;

namespace Terceira_lista_de_exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //preço e cor
            try
            {
                Computador asus = new Computador(2500, "amarelo");

            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
                
            }

            //nome e idade
            try
            {
                Estudante vinicius = new Estudante("",11);
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }

            //idade e telefone
            try
            {
                Estudante joao = new Estudante(11, "0000000000-0000000000");
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }

            //ano do veículo
            try
            {
                Veiculo corsa = new Veiculo(1999);
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);                
            }

            // tipo e ano
            try
            {
                Veiculo palio = new Veiculo("barquinho", 2000);
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }

            //cor e modelo
            try
            {
                Veiculo peugeot = new Veiculo("", "abc");
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }

        }
    }
}
