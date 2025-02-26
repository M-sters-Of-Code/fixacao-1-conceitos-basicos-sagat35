using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    internal class MetrosMilimetros
    {
    
    public static void Main(string[] args)
    {
        int metro = 0;
        int milimetro = 0;
        Console.WriteLine("Digite o valor em Metros:");
        metro = Convert.ToInt16(Console.ReadLine());
        milimetro = metro * 1000;
        Console.WriteLine(resultado_mm);
        Console.WriteLine("\nEspero que tenha gostado!");

    }
}
}
