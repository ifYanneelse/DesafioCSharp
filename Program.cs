using System;
using System.Data;
using System.Linq;
using System.Drawing;

namespace Carros
{
    class Program
    {

        static void Main(string[] args)
        {
   

            Carro c1 = new Carro("abcdefgutd0123456789", Marcas.Volkswagen, "gol", 2012, Motores.umpontozero, Color.Aqua, 4);
            Console.WriteLine(c1.ToString());
            c1.Idade(2012);

            Carro c2 = new Carro("s1234567890123456789", Marcas.Fiat, "doblo", 2015, Motores.umpontooito, Color.Blue, 2);
            Console.WriteLine(c2.ToString());
            c2.Idade(2013);

            Carro c3= new Carro("8ab34567890123456789", Marcas.Chevrolet, "onix", 2017, Motores.doispontozero, Color.DarkGray, 2);
            Console.WriteLine(c3.ToString());
            c3.Idade(2017);

            Carro c4 = new Carro("01234abcdefgutd56789", Marcas.Ford, "ecosport", 2022, Motores.umpontozero, Color.Indigo, 4);
            Console.WriteLine(c4.ToString());
            c4.Idade(2022);

            /*
            //teste pra erro
            Carro e1 = new Carro("01234abcdefgutd56789", Marcas.Ford, "ecosport", 2024, Motores.doispontozero, Color.Orange, 2);
            Console.WriteLine(e1.ToString());
            e1.Idade(2024);
            */
        }

    }
}