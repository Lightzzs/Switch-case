using System;

namespace Calculadora_Simples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Perguntar a operação
            Console.WriteLine("Qual a operação deseja realizar? \nSoma, Subtracao, Multiplicacao, Divisao");  
            string operacao = Console.ReadLine().ToLower();

            // Pedir o 1º Numero
            Console.WriteLine("Digite o 1º número :");
            float num1 = float.Parse( Console.ReadLine() );

            // Pedir o 2º Numero
            Console.WriteLine("Digite o º número :");
            float num2 = float.Parse( Console.ReadLine() );

            // Fazer o cálculo
            float resultado = 0f;

            // if(operacao == "Soma")
            // {
            //     resultado = num1 + num2;
            // }else if(operacao == "Subtracao")
            // {
            //     resultado = num1 - num2;
            // }
            // else if(operacao == "Multiplicacao")
            // {
            //     resultado = num1 * num2;
            // }
            // else if(operacao == "Divisao")
            // {
            //     resultado = num1 / num2;
            // }
            // else
            // {
            //     Console.WriteLine("Operação Inválida");

            // }
            switch(operacao){
                
                case "soma":
                    resultado = num1 + num2;
                    break;

                case "subtracao":
                    resultado = num1 - num2;
                    break;
                
                case "divisao":
                    resultado = num1 / num2;
                    break;

                default:
                    Console.WriteLine("Operação inválida! :(");
                    break;

            }

            // Mostrar o resultado

            // Concatenação
            Console.WriteLine("Calculo : "+ num1+" com "+ num2+" = " + resultado);
            


            // Mostrar o resultados
        }
    }
}
