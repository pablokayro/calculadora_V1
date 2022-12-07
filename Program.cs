using System;

// Usando o Switch Case

class Aula13
{
    static void Main(string[]args){
        //CALCULADORA SIMPLES 

        double n1, n2, resultado;
        int opcao;
        Console.Write("CALCULADORA\nDigite um valor: ");
        n1 = double.Parse(Console.ReadLine());
        Console.Write("Digite outro valor: ");
        n2 = double.Parse(Console.ReadLine());
        Console.WriteLine("ESCOLHA UMA OPÇÃO");
        Console.WriteLine("1 - SOMA");
        Console.WriteLine("2 - SUBTRAÇÃO");
        Console.WriteLine("3 - MULTIPLICAÇÃO");
        Console.WriteLine("4 - DIVISÃO");
        opcao = int.Parse(Console.ReadLine());
        switch(opcao){
            case 1:
                resultado=n1+n2;
                break;
            case 2:
                resultado=n1-n2;
                break;
            case 3:
                resultado=n1*n2;
                break;
            case 4:
                resultado=n1/n2;
                break;
            default:
                resultado = -1;
                break;
        }
        if (resultado<0){
            Console.Write("Opção Inválida!");
        }else{
            Console.WriteLine($"O resultado da operação é: {resultado}");
        }


    

    }
}
