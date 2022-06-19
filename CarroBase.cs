using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Carros {

    public enum Marcas
    {
        Ford, Chevrolet, Volkswagen, Fiat
    }

    public enum Motores //botar de forma tradutiva umpontozero, umpontooito e não a, b, c
    {
        a,  // 1.0, 
        b,  //1.8,
        c   //2.0
    }

    public abstract class CarroBase
    {
        public string chassi;
        private string Chassi
        {
            get { return chassi; } //vai ler o chassi
            set // e quando receber número vai passar pela validação
            {
                if ((value.Length == 20))
                {
                    chassi = value;
                }
                else
                {
                    throw new Exception("O Chassi deve possuir apenas 20 dígitos.");
                }
                    //tem que fazer validação sem espaços em brancos, sem caracteres especiais
            }
        }

        public Marcas Marca { get; set; }

        public string modelo;
        private string Modelo
        {
            get { return modelo.ToUpper(); }
            set { modelo = value; }
        }
 

        
        public int ano;
        public int Ano
        {
            get { return ano; }

            set
            { //quando alguem escrever:
                if ((value >= 2010 & value <= DateTime.Now.Year + 1))
                {
                    ano = value;
                }
                else
                {
                    throw new ArgumentException("Apenas entre 2010 e 2023");
                }
                    
            }
        }
        

        public Motores Motor { get; set; }     
        
        public string TipoMotores(Motores motor) 
        {
            switch (motor)
            {
                case Motores.a :
                    return "1.0";
                case Motores.b :
                    return "1.8";
                case Motores.c :
                    return "2.0";           
            }
            return "0.0";
        }



        //construtor
        public CarroBase()
        {
            
        }

        public CarroBase(string chassi, Marcas marca, string modelo, int ano, Motores motor)
        {
            this.Chassi = chassi;    
            this.Modelo = modelo;
            this.Marca = marca;
            this.Ano = ano;
            this.Motor = motor;
            Console.WriteLine ($"Chassi: {this.Chassi}\nMarca: {this.Marca}\nModelo: {this.Modelo}\nAno: {this.Ano}\nMotor: {this.TipoMotores(Motor)}");
            
        }    


    }


}
