using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Carros{


    public class Carro : CarroBase
    {
        public Color Cor { get; set; }

        public int portas;
        public int Portas
        {
            get { return portas; } // ler
            set // gravar o atributo
            {
                if ((value == 2) || (value == 4))
                {
                    portas = value;
                }
                else
                {
                    throw new Exception("Apenas 2 ou 4 portas.");
                }
            }
        }


        public Carro(string chassi, Marcas marca, string modelo, int ano, Motores motor, Color cor, int portas) :
            base (chassi, marca, modelo, ano, motor)
        {
            Cor = cor;
            Portas = portas;
       
        }


        public int idade;
        public void Idade(int ano)
        {
            this.idade = (DateTime.Now.Year+1) - this.ano;
            
                if (idade <= 1)
                {
                    Console.WriteLine($"Esse carro tem {idade} ano || Carro 0km.");
                }
                else
                {
                    Console.WriteLine($"Esse carro tem {idade} anos.");
                }
                Console.WriteLine("---------------------------------\n");
        }

        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Cor}\n");
            sb.Append($"Quantidade de portas: {this.Portas}\n");
      
            return sb.ToString();
        }


    }
}
