using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_3_25._09
{
    class Program
    {
        public struct Carro
        {
            public string[] modelo, cor;
            public int[] ano;
        }
        static void Main(string[] args)
        {
            Carro carro;
            carro.modelo = new string[500];
            carro.cor = new string[500];
            carro.ano = new int[500];
            int i=0, menu, ano, cd;
            string s, modelo, cor;
            do
            {
                Console.Clear();
                Console.WriteLine("SISTEMA DE AUTOMÓVEIS\n");
                Console.WriteLine("MENU PRINCIPAL");
                Console.WriteLine("1-CADASTRAR CARRO");
                Console.WriteLine("2-CONSULTAR CARRO POR ANO DE FABRICAÇÃO");
                Console.WriteLine("3-CONSULTAR CARRO POR MODELO");
                Console.WriteLine("4-CONSULTAR CARRO POR COR");
                Console.WriteLine("5-EXIBIR TODOS OS CARROS CADASTRADOS");
                Console.WriteLine("6-ALTERAR ALGUM DADO DE ALGUM CARRO");
                Console.WriteLine("7-EXCLUIR UM CARRO");
                Console.WriteLine("0-SAIR");
                Console.WriteLine("\nAlternativa: ");
                menu = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (menu)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("-----CADASTAR CARRO------");
                            Console.Write("MODELO: ");
                            carro.modelo[i] = Console.ReadLine();
                            Console.Write("ANO DE FABRICAÇÃO: ");
                            carro.ano[i] = int.Parse(Console.ReadLine());
                            Console.Write("COR: ");
                            carro.cor[i] = Console.ReadLine();
                            Console.Write("");
                            Console.WriteLine("\nOS DADOS ESTÃO CORRETOS? sim/não");
                            s = Console.ReadLine();
                        } while (s.ToUpper() != "SIM");
                        i++;
                        break;
                    case 2:
                        Console.Write("Informe um ano: ");
                        ano = int.Parse(Console.ReadLine());
                        Console.WriteLine("------CARROS DE " + ano + "------");
                        Console.WriteLine("num|  modelo  |   cor    |   ano    ");
                        Console.WriteLine("___|__________|__________|__________");
                        for (i = 0; i < 500; i++)
                        {
                            if (carro.ano[i] == ano)
                            {
                                Console.WriteLine("{0,3}|{1,10}|{2,10}|{3,10}", i, carro.modelo[i], carro.cor[i], carro.ano[i]);
                            }
                        }
                        Console.WriteLine("\nPressione 'Enter' para sair...");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Write("Informe um modelo: ");
                        modelo = Console.ReadLine();
                        Console.WriteLine("------CARROS " + modelo.ToUpper() + "------");
                        Console.WriteLine("num|  modelo  |   cor    |   ano    ");
                        Console.WriteLine("___|__________|__________|__________");
                        for (i = 0; i < 500; i++)
                        {
                            if (carro.modelo[i].ToUpper() == modelo.ToUpper())
                            {
                                Console.WriteLine("{0,3}|{1,10}|{2,10}|{3,10}", i, carro.modelo[i], carro.cor[i], carro.ano[i]);
                            }
                        }
                        Console.WriteLine("\nPressione 'Enter' para sair...");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Write("Informe uma cor: ");
                        cor = Console.ReadLine();
                        Console.WriteLine("------CARROS DE COR " + cor.ToUpper() + "------");
                        Console.WriteLine("num|  modelo  |   cor    |   ano    ");
                        Console.WriteLine("___|__________|__________|__________");
                        for (i = 0; i < 500; i++)
                        {
                            if (carro.cor[i].ToUpper() == cor.ToUpper())
                            {
                                Console.WriteLine("{0,3}|{1,10}|{2,10}|{3,10}", i, carro.modelo[i], carro.cor[i], carro.ano[i]);
                            }
                        }
                        Console.WriteLine("\nPressione 'Enter' para sair...");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("------EXIBINDO TODOS OS CARROS------");
                        Console.WriteLine("num|  modelo  |   cor    |   ano    ");
                        Console.WriteLine("___|__________|__________|__________");
                        for (i = 0; i < 500; i++)
                        {
                            Console.WriteLine("{0,3}|{1,10}|{2,10}|{3,10}", i, carro.modelo[i], carro.cor[i], carro.ano[i]);
                        }
                        Console.WriteLine("\nPressione 'Enter' para sair...");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("------INFORME O NUMERO DO CARRO------");
                        Console.WriteLine("num|  modelo  |   cor    |   ano    ");
                        Console.WriteLine("___|__________|__________|__________");
                        for (i = 0; i < 500; i++)
                        {
                            Console.WriteLine("{0,3}|{1,10}|{2,10}|{3,10}", i, carro.modelo[i], carro.cor[i], carro.ano[i]);
                        }
                        Console.WriteLine("\nNÚMERO:");
                        cd = int.Parse(Console.ReadLine());
                        Console.Clear();
                        for (i = 0; i < 500; i++)
                        {
                            if (cd == i)
                            {
                                Console.WriteLine("---QUER ALTERAR O MODELO, A COR OU O ANO---");
                                Console.WriteLine("{0,3}|{1,10}|{2,10}|{3,10}", i, carro.modelo[i], carro.cor[i], carro.ano[i]);
                                Console.Write("\nOpção: ");
                                s = Console.ReadLine();
                                switch (s.ToUpper())
                                {
                                    case "MODELO":
                                        Console.Write("Informe o modelo: ");
                                        carro.modelo[i] = Console.ReadLine();
                                        break;
                                    case "COR":
                                        Console.Write("Informe a cor: ");
                                        carro.cor[i] = Console.ReadLine();
                                        break;
                                    case "ANO":
                                        Console.Write("Informe o ano: ");
                                        carro.ano[i] = int.Parse(Console.ReadLine());
                                        break;
                                }
                            }
                        }
                        Console.WriteLine("\nPressione 'Enter' para sair...");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("--INFORME O NUMERO DO CARRO PARA EXCLUIR--");
                        Console.WriteLine("num|  modelo  |   cor    |   ano    ");
                        Console.WriteLine("___|__________|__________|__________");
                        for (i = 0; i < 500; i++)
                        {
                            Console.WriteLine("{0,3}|{1,10}|{2,10}|{3,10}", i, carro.modelo[i], carro.cor[i], carro.ano[i]);
                        }
                        Console.WriteLine("\nNÚMERO:");
                        cd = int.Parse(Console.ReadLine());
                        Console.Clear();
                        for (i = 0; i < 500; i++)
                        {
                            if (cd == i)
                            {
                                Console.WriteLine("---QUER MESMO EXCLUIR ESSE VEÍCULO?---");
                                Console.WriteLine("\n{0,3}|{1,10}|{2,10}|{3,10}", i, carro.modelo[i], carro.cor[i], carro.ano[i]);
                                Console.WriteLine("\nSim ou Não:");
                                s = Console.ReadLine();
                                if (s.ToUpper() == "SIM")
                                {
                                    carro.modelo[i] = "";
                                    carro.cor[i] = "";
                                    carro.ano[i] = 0;
                                    Console.Clear();
                                    Console.WriteLine("\n-----CARRO EXCUÍDO COM SUCESSO!-----\n");
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        Console.ReadKey();
                        break;
                }
            } while (menu != 0);
        }
    }
}
