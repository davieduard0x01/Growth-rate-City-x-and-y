using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program2
    {
        static void Main(string[] args)
        {
            int cidadex = 80000000;
            double perc = 0.05;
            int cidadey = 300000000;
            double percy = 0.015;
            int anos = 0;
            while(cidadex<cidadey)
            {
                cidadex += (int)(cidadex * perc);
                cidadey += (int)(cidadey * percy);
                anos++; 
            }
            Console.WriteLine("Numero de anos necessarios " + anos);
        }
    }
}
           
    /*Supondo que a população da República Democrática de X seja da ordem de 80.000.000
            (oitenta milhões) de habitantes com uma taxa anual de crescimento de 5 % e que a população de um
            país União Federalista do Y seja de aproximadamente 300.000.000(trezentos milhões) de
            habitantes com uma taxa anual de crescimento de 1,5 %.Faça um programa que calcule e escreva o
            número de anos necessários para que a população dos Xs alcance ou ultrapasse a
            população dos Ys. Suponha que serão mantidas essas taxas de crescimento.*/
