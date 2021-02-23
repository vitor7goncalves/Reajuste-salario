using System;

namespace teste_reajuste_salario
{

    class minhaClasse
    {

        static void Main(string[] args)
        {

            double salario, reajuste, novoSalario, percentual;
            string goBack = "";

            //insira os valores corretos de acordo com o enunciado
            while (goBack != "n")
            {
                System.Console.WriteLine("Ente com o salario: ");
                salario = double.Parse(Console.ReadLine());
                if (salario >= 0.00 && salario <= 400.00)
                {
                    reajuste = salario * 0.15;
                    novoSalario = salario + reajuste;
                    percentual = ((novoSalario - salario) * 100) / salario;
                    Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                    Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                    Console.WriteLine("Em percentual: {0} %", percentual);
                }
                else if (salario > 400.00 && salario <= 800.00)
                {
                    reajuste = salario * 0.12;
                    novoSalario = salario + reajuste;
                    percentual = ((novoSalario - salario) * 100) / salario;
                    Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                    Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                    Console.WriteLine("Em percentual: {0} %", percentual);
                }
                else if (salario > 800.00 && salario <= 1200.00)
                {
                    reajuste = salario * 0.10;
                    novoSalario = salario + reajuste;
                    percentual = ((novoSalario - salario) * 100) / salario;
                    Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                    Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                    Console.WriteLine("Em percentual: {0} %", percentual);
                }
                else if (salario > 1200.00 && salario <= 2000.00)
                {
                    reajuste = salario * 0.07;
                    novoSalario = salario + reajuste;
                    percentual = ((novoSalario - salario) * 100) / salario;
                    Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                    Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                    Console.WriteLine("Em percentual: {0} %", percentual);
                }
                else
                {
                    reajuste = salario * 0.04;
                    novoSalario = salario + reajuste;
                    percentual = ((novoSalario - salario) * 100) / salario;
                    Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                    Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                    Console.WriteLine("Em percentual: {0:0} %", percentual);
                }

                System.Console.WriteLine("Gostaria de consultar novamente?: y/n ");
                goBack = Console.ReadLine();
            }
        }

    }
}
