using System;

namespace Exercicio_7___Empilhar_Numeros
{
    class Program
    {
        
         static int nrPosicoesArray = 10;

        static void Main(string[] args)
        {
            var array = new int[nrPosicoesArray];
            var nrInteiros = 0;

            while (nrInteiros < nrPosicoesArray)
            {
                Console.WriteLine("Informe um número inteiro");
                var strNumero = Console.ReadLine();

                var intNumero = 0;

                if (int.TryParse(strNumero, out intNumero))
                {
                    array[nrInteiros] = intNumero;

                    nrInteiros++;
                }
            }

            ImprimirOrdemDecrescente(array);

            Console.ReadKey();
        }

        public static void ImprimirOrdemDecrescente(int[] array)
        {
            var newArray = new int[nrPosicoesArray];
            var nrInteiros = 0;
            var posicaoMaiorNumero = 0;
            var listaPosicaoesJaVistas = new System.Collections.Generic.List<int>();

            while (nrInteiros < nrPosicoesArray)
            {
                var maiorNumero = 0;
                var achouMaiorNumero = false;

                for (int x = 0; x < nrPosicoesArray; x++)
                {
                    if (listaPosicaoesJaVistas.Contains(x))
                    {
                        continue;
                    }

                    var numeroTeste = array[x];

                    for (int i = 0; i < nrPosicoesArray; i++)
                    {
                        if (listaPosicaoesJaVistas.Contains(i))
                        {
                            continue;
                        }

                        var numeroComparar = array[i];

                        if (numeroTeste > numeroComparar || numeroTeste == numeroComparar)
                        {
                            achouMaiorNumero = true;
                            maiorNumero = numeroTeste;
                            posicaoMaiorNumero = x;
                        }
                        else
                        {
                            achouMaiorNumero = false;
                            break;
                        }
                    }

                    if (achouMaiorNumero)
                    {
                        break;
                    }
                }

                if (achouMaiorNumero)
                {
                    array[posicaoMaiorNumero] = 0;
                    newArray[nrInteiros] = maiorNumero;
                    nrInteiros++;
                }
            }

            Console.WriteLine("------- ORDEM DECRESCENTE -------");

            for (int i = 0; i < nrPosicoesArray; i++)
            {
                Console.WriteLine(newArray[i]);
            }
        }
        }
    }


