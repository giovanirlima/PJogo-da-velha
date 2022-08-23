using System;
using System.Threading;

namespace PJogoVelha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração das váriaveis
            char[,] matriz = CriarMatiz();
            char[] XouO = CriarJogador();
            string[] nomeJogador;
            int jogarOuSair;
            bool finalDoJogo = false;
            int cont = 0;
            int contJogador;

            //Tela inicial de boas vindas ao jogador
            BoasVindas();

            //Verificação do usuário se qr jogar ou não
            jogarOuSair = ModoDeJogo();

            if (jogarOuSair == 1)
            {
                //chamada das funcoes para interação com usuario
                OpcaoEscolhida(jogarOuSair);

                //Solicitação do nome dos jogadores.
                nomeJogador = CriarNomeJogadores();

                //Instruções do jogo
                Instrucoes(nomeJogador);

                //Criar cerquilha com o jogo
                RenderizarCerquilha(matriz);
                do
                {
                    //Condição para troca de jogadores 1 e 2
                    if (cont % 2 == 0)
                    {
                        contJogador = 0;
                        LerJogada(matriz, XouO[0], nomeJogador[0]);
                    }
                    else
                    {
                        contJogador = 1;
                        LerJogada(matriz, XouO[1], nomeJogador[1]);
                    }

                    Console.Clear();
                    RenderizarCerquilha(matriz);

                    cont++;

                    //Verificação para terminar o jogo ou informar empate
                    if (cont > 3)
                    {
                        finalDoJogo = FinalDePartida(finalDoJogo, matriz, cont, nomeJogador, contJogador);

                    }

                } while (!finalDoJogo);
            }

            //Sair do jogo
            else
            {
                Console.WriteLine("Você escolheu sair.");
                Console.WriteLine("Até mais.");
                int sair = 0;

                do
                {
                    Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░█████████");
                    Console.WriteLine("░░███████░░░░░░░░░░███▒▒▒▒▒▒▒▒███");
                    Console.WriteLine("░░█▒▒▒▒▒▒█░░░░░░░███▒▒▒▒▒▒▒▒▒▒▒▒▒███");
                    Console.WriteLine("░░░█▒▒▒▒▒▒█░░░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██");
                    Console.WriteLine("░░░░█▒▒▒▒▒█░░░██▒▒▒▒▒██▒▒▒▒▒▒██▒▒▒▒▒███");
                    Console.WriteLine("░░░░░█▒▒▒█░░░█▒▒▒▒▒▒████▒▒▒▒████▒▒▒▒▒▒██");
                    Console.WriteLine("░░░█████████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██");
                    Console.WriteLine("░░░█▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒██");
                    Console.WriteLine("░██▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒██▒▒▒▒▒▒▒▒▒▒██▒▒▒▒██");
                    Console.WriteLine("██▒▒▒███████████▒▒▒▒▒██▒▒▒▒▒▒▒▒██▒▒▒▒▒██");
                    Console.WriteLine("█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒████████▒▒▒▒▒▒▒██");
                    Console.WriteLine("██▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██");
                    Console.WriteLine("░█▒▒▒███████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██");
                    Console.WriteLine("░██▒▒▒▒▒▒▒▒▒▒████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█");
                    Console.WriteLine("░░████████████░░░█████████████████");
                    Console.WriteLine("Até mais...");

                    Thread.Sleep(500);
                    Console.Clear();

                    Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░█████████");
                    Console.WriteLine("░░░░░░░░░░░░░░░░░░░███▒▒▒▒▒▒▒▒███");
                    Console.WriteLine("░░░░░░░░░░░░░░░░░███▒▒▒▒▒▒▒▒▒▒▒▒▒███");
                    Console.WriteLine("░░░░░░░░░░░░░░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██");
                    Console.WriteLine("░░░░░░░░░░░░░░██▒▒▒▒▒██▒▒▒▒▒▒██▒▒▒▒▒███");
                    Console.WriteLine("░░░░░░░░░░░░░█▒▒▒▒▒▒████▒▒▒▒████▒▒▒▒▒▒██");
                    Console.WriteLine("░░░█████████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██");
                    Console.WriteLine("░░░█▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒██");
                    Console.WriteLine("░██▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒██▒▒▒▒▒▒▒▒▒▒██▒▒▒▒██");
                    Console.WriteLine("██▒▒▒███████████▒▒▒▒▒██▒▒▒▒▒▒▒▒██▒▒▒▒▒██");
                    Console.WriteLine("█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒████████▒▒▒▒▒▒▒██");
                    Console.WriteLine("██▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██");
                    Console.WriteLine("░█▒▒▒███████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██");
                    Console.WriteLine("░██▒▒▒▒▒▒▒▒▒▒████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█");
                    Console.WriteLine("░░████████████░░░█████████████████");
                    Console.WriteLine("Até mais...");

                    Thread.Sleep(500);
                    Console.Clear();
                    sair++;

                } while (sair < 50);
            }
        }


        static char[,] CriarMatiz()
        {
            //Criar matriz com posicoes fixas
            char[,] matriz = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
            return matriz;
        }
        static char[] CriarJogador()
        {
            //Criar jogador com nomes atribuidos
            char[] jogadores = new char[2];
            jogadores[0] = 'X';
            jogadores[1] = 'O';

            return jogadores;

        }
        static string[] CriarNomeJogadores()

        {
            //Função para obter nome dos jogadores.
            string[] nomeJogadores = new string[2];

            Console.WriteLine("\nOla, caro Jogador 1!");
            Console.Write("Informe seu nome: ");
            nomeJogadores[0] = Console.ReadLine();

            Console.WriteLine("\nOla, caro Jogador 2!");
            Console.Write("Informe seu nome: ");
            nomeJogadores[1] = Console.ReadLine();

            return nomeJogadores;
        }
        static void BoasVindas()
        {
            //Tela de interação com usuário. Não faz nada.
            Console.WriteLine("\t\t--------------------------");
            Console.WriteLine("\t\t| BEM-VINDO CARO JOGADOR |");
            Console.WriteLine("\t\t--------------------------");

            Console.WriteLine();
            Console.WriteLine();
        }
        static int ModoDeJogo()
        {
            //Verificação se o usuario deseja jogar ou nao
            int opcao = 10;
            Console.WriteLine("Escolha o modo de jogo!\n");
            Console.WriteLine("1 - Multiplayer ");
            Console.WriteLine("0 - Sair \n");
            do
            {
                //Tratativa de possivel error de digitação
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                    if (opcao < 0 || opcao > 1)
                    {
                        Console.WriteLine("Informe uma opção válida!");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Informe uma opção válida!");
                }
            } while (opcao < 0 || opcao > 1);

            return opcao;
        }
        static void OpcaoEscolhida(int n)
        {
            ////Tela de interação com usuário. Não faz nada.
            Console.Clear();
            Console.WriteLine("\t\t--------------------------");
            Console.WriteLine("\t\t|   O JOGO VAI COMEÇAR!  |");
            Console.WriteLine("\t\t--------------------------");

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Você escolheu a opção: ");

            if (n == 1)
            {
                Console.WriteLine("Multiplayer");
            }

            Thread.Sleep(500);

        }
        static void Instrucoes(string[] nomeJogadores)
        {
            ////Tela de interação com usuário. Não faz nada.
            
            Console.Clear();
            Console.WriteLine("\t\t--------------------------");
            Console.WriteLine("\t\t|   O JOGO VAI COMEÇAR!  |");
            Console.WriteLine("\t\t--------------------------");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"Caro jogador {nomeJogadores[0]} e {nomeJogadores[1]}");
            Console.WriteLine("Se atentem as seguintes regras:");
            Thread.Sleep(2000);

            Console.WriteLine($"\n1 - O jogador {nomeJogadores[0]} será o X e o jogador {nomeJogadores[1]} será o O.");
            Console.WriteLine("2 - Quem fizer uma sequência de 3 caracteres iguais ganha a partida. ");
            Console.WriteLine("3 - Caso nenhum jogador consiga, é considerado empate!");
            Thread.Sleep(5000);
            Console.Clear();

        }
        static void RenderizarCerquilha(char[,] matriz)
        {
            //Criação do # na tela para o usuario
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine("\t\t");
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Console.Write($"\t\t  {matriz[i, j]}");
                    }
                    else
                    {
                        Console.Write($"  |  {matriz[i, j]}");
                    }

                }
                //Condição para colocada da linha
                Console.WriteLine();
                if (i < 2)
                {
                    Console.Write("\t\t-----------------");
                }
            }

        }
        static bool VerificarVertical(char[,] matriz)
        {
            //Verificar se existe ganhador em todas as colunas, caso encontre retorne verdadeiro.
            bool vitoriaLinha1 = matriz[0, 0] == matriz[1, 0] && matriz[0, 0] == matriz[2, 0];
            bool vitoriaLinha2 = matriz[0, 1] == matriz[1, 1] && matriz[0, 1] == matriz[2, 1];
            bool vitoriaLinha3 = matriz[0, 2] == matriz[1, 2] && matriz[0, 2] == matriz[2, 2];

            return vitoriaLinha1 || vitoriaLinha2 || vitoriaLinha3;
        }
        static bool VerificarHorizontal(char[,] matriz)
        {
            //Verificar se existe ganhador em todas as linhas, caso encontre retorne verdadeiro.
            bool vitoriaLinha1 = matriz[0, 0] == matriz[0, 1] && matriz[0, 0] == matriz[0, 2];
            bool vitoriaLinha2 = matriz[1, 0] == matriz[1, 1] && matriz[1, 0] == matriz[1, 2];
            bool vitoriaLinha3 = matriz[2, 0] == matriz[2, 1] && matriz[2, 0] == matriz[2, 2];

            return vitoriaLinha1 || vitoriaLinha2 || vitoriaLinha3;
        }
        static bool VerificarDiagonal(char[,] matriz)
        {
            //Verificar se existe ganhador em todas as diagonais, caso encontre retorne verdadeiro.
            bool vitoriaLinha1 = matriz[0, 0] == matriz[1, 1] && matriz[0, 0] == matriz[2, 2];
            bool vitoriaLinha2 = matriz[0, 2] == matriz[1, 1] && matriz[0, 2] == matriz[2, 0];

            return vitoriaLinha1 || vitoriaLinha2;
        }
        static bool FinalDePartida(bool finalDoJogo, char[,] matriz, int cont, string[] nomeJogador, int contJogador)
        {
            //Verifica se existe ganhador em qualquer uma das condições, finaliza a partida.
            if (VerificarDiagonal(matriz) || VerificarHorizontal(matriz) || VerificarVertical(matriz))
            {

                Console.WriteLine("Fim de jogo!!!");
                Console.WriteLine($"\t\tVITÓRIA DO JOGADOR {nomeJogador[contJogador]}");
                return finalDoJogo = true;
            }
            //Caso nao ocorra vitória em 9 lances, acaba o jogo como empate.
            if (cont == 9)
            {
                Console.WriteLine("Fim de jogo!!!");
                Console.WriteLine("\t\tEMPATE ENTRE OS JOGADORES!");
                return finalDoJogo = true;
            }

            return false;
        }
        static bool Posicao(int i, int j, char[,] matriz)
        {
            //Testa se a posições do jogador atual esta livre para ser escolhida. 
            //Trata possiveis erros de digitação.
            try
            {
                if (matriz[i, j] != 'X' && matriz[i, j] != 'O')
                {
                    return false;
                }

                else
                {
                    Console.WriteLine("Posição inválida ou ocupada !");
                    Console.WriteLine();
                    return true;
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Digite um número entre 1 e 3 !");
                return true;
            }



        }
        static void LerJogada(char[,] matriz, char XouO, string nomeJogador)
        {
            bool verificarPosicao;
            do
            {
                int i = 0;
                int j = 0;

                Console.WriteLine();
                Console.WriteLine($"Vez do(a) {nomeJogador}");
                //Pede a posição para o usuário, caso o mesmo entre com valor inválido,
                //o mesmo ira tratar o error, e solicitar nova númeração ao usuário.
                do
                {
                    Console.Write("Digite a linha: ");
                    try
                    {
                        i = int.Parse(Console.ReadLine());
                        verificarPosicao = false;

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Digite um número inteiro !");
                        verificarPosicao = true;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Você digitou um número bem grande, digite um número entre 1 e 3 !");
                        verificarPosicao = true;
                    }

                } while (verificarPosicao);

                //Pede a posição para o usuário, caso o mesmo entre com valor inválido,
                //o mesmo ira tratar o error, e solicitar nova númeração ao usuário.
                do
                {
                    Console.Write("Digite a Coluna: ");
                    try
                    {
                        j = int.Parse(Console.ReadLine());
                        verificarPosicao = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Digite um número inteiro !");
                        verificarPosicao = true;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Você digitou um número bem grande, digite um número entre 1 e 3 !");
                        verificarPosicao = true;
                    }
                } while (verificarPosicao);

                //Verifica se a posição está livre para marcar 
                verificarPosicao = Posicao(i - 1, j - 1, matriz);

                //Testa condição para marcar X ou O
                if (!verificarPosicao)
                {
                    matriz[i - 1, j - 1] = XouO;
                }

                
            } while (verificarPosicao);

            return;
        }
    }
}



