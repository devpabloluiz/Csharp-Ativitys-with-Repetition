
using System;

public class Program
{
    static void Main(string[] args)
    {
        Boolean condicao = true;
        int valor;
        while(condicao == true)
        {
            Console.WriteLine("Digite um valor, 0 para sair");
            valor = int.Parse(Console.ReadLine());            

            if(valor == 0)
            {   
                Console.WriteLine("Você saiu da aplicação");
                condicao = false;
            }
            else
            {
                Console.WriteLine("O valor informado é: " + valor);
            }
        }
    }
}