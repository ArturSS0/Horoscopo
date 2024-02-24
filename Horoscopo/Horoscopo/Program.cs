using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horoscopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos ver seu Horóscopo. Digite seu Mes de Nascimento: ");
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Dia que voce Nasceu: ");
            int dia = int.Parse(Console.ReadLine());
            int final = 0;
            if (mes == 12 && dia >= 22)
            {
                final = 0;
            }

            if (mes == 1 && dia <= 20)
            {
                final = 0;
            }

            if (mes == 1 && dia >= 21)
            {
                final = 1;
            }

            if (mes == 2 && dia <= 19)
            {
                final = 1;
            }

            if (mes == 2 && dia >= 20)
            {
                final = 2;
            }

            if (mes == 3 && dia <= 20)
            {
                final = 2;
            }

            if (mes == 3 && dia >= 21)
            {
                final = 3;
            }

            if (mes == 4 && dia <= 20)
            {
                final = 3;
            }

            if (mes == 4 && dia >= 21)
            {
                final = 4;
            }

            if (mes == 5 && dia <= 20)
            {
                final = 4;
            }

            if (mes == 5 && dia >= 21)
            {
                final = 5;
            }

            if (mes == 6 && dia <= 20)
            {
                final = 5;
            }

            if (mes == 6 && dia >= 21)
            {
                final = 6;
            }

            if (mes == 7 && dia <= 20)
            {
                final = 6;
            }

            if (mes == 7 && dia >= 22)
            {
                final = 7;
            }

            if (mes == 8 && dia <= 22)
            {
                final = 7;
            }

            if (mes == 8 && dia >= 23)
            {
                final = 8;
            }

            if (mes == 9 && dia <= 22)
            {
                final = 8;
            }

            if (mes == 9 && dia >= 23)
            {
                final = 9;
            }

            if (mes == 10 && dia <= 22)
            {
                final = 9;
            }

            if (mes == 10 && dia >= 23)
            {
                final = 10;
            }

            if (mes == 11 && dia <= 21)
            {
                final = 10;
            }

            if (mes == 12 && dia >= 22)
            {
                final = 11;
            }

            if (mes == 1 && dia >= 21)
            {
                final = 2;
            }

            int[] array = { }
        }
    }
}
