using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho2.Control;

namespace Trabalho2.Model
{
    public static class Funcao
    {
        /// <summary>
        /// Lista de letras da Tabela
        /// </summary>
        public static List<string> Tabela = new List<string>();

        /// <summary>
        /// Lista de palavras do combo box
        /// </summary>
        public static List<string> HistoricoDePalavras = new List<string>();

        /// <summary>
        /// Guarda todos os pontos
        /// </summary>
        public static double PontosGeral = new double();

        static Random ram = new Random();

        /// <summary>
        /// Converte os numeros selecionados pelos randoms em letras na tabela
        /// </summary>
        /// <returns></returns>
        public static List<string> ConverteNumerosParaLetras()
        {
            List<string> letras = new List<string>();
            letras.Add(AdicionaDois("A", "D"));
            letras.Add(AdicionaDois("E", "F"));
            letras.Add(AdicionaDois("B", "C"));
            letras.Add(AdicionaTres("G", "I", "U"));
            letras.Add(AdicionaTres("H", "J", "V"));
            letras.Add(AdicionaDois("K", "L"));
            letras.Add(AdicionaTres("M", "O", "Q"));
            letras.Add(AdicionaTres("N", "T", "P"));
            letras.Add(AdicionaTres("R", "S", "Z"));
            Tabela = letras;
            return letras;
        }

        /// <summary>
        /// Faz um random de 1 ou 2 para escolher a letra que tem apenas duas opções
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns></returns>
        public static string AdicionaDois(string numero1, string numero2)
        {
            var numeros = ram.Next(1, 3);

            if (numeros == 1)
            {
                return numero1;
            }
            else
            {
                return numero2;
            }
        }

        /// <summary>
        /// Faz um random de 1 ou 2 ou 3 para escolher as letras que tem apenas três opções
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="numero3"></param>
        /// <returns></returns>
        public static string AdicionaTres(string numero1, string numero2, string numero3)
        {
            var numeros = ram.Next(1, 4);

            if (numeros == 1)
            {
                return numero1;
            }
            else if (numeros == 2)
            {
                return numero2;
            }
            else
            {
                return numero3;
            }
        }

        /// <summary>
        /// Adiciona a palavra na lista
        /// </summary>
        /// <param name="a"></param>
        public static void AddLista(string a)
        {
            HistoricoDePalavras.Add(a);
        }

        /// <summary>
        /// Retorna os pontos da rodada atual e verifica as letras
        /// </summary>
        /// <param name="palavraChave"></param>
        /// <returns></returns>
        public static double RetornaPontosP(string palavraChave)
        {
            string letrasSemRepetir = "";
            double pontos = 0;
            if (LetraEstaNoCacaPalavraERepete(palavraChave, 0, letrasSemRepetir))
            {
                letrasSemRepetir += palavraChave[0];
                pontos++;
            }
            else
            {
                return 0;
            }
            for (int i = 1; i < palavraChave.Length; i++)
            {
                if (LetraEstaNoCacaPalavraERepete(palavraChave, i, letrasSemRepetir))
                {
                    letrasSemRepetir += palavraChave[i];
                    if (palavraChave[i] == 'A' || palavraChave[i] == 'D')
                    {
                        if (ConfereLetraAoRedor(palavraChave[i - 1], 1))
                        {
                            pontos++;
                        }
                        else
                        {
                            return Math.Floor(pontos / 2);
                        }
                    }
                    else if (palavraChave[i] == 'E' || palavraChave[i] == 'F')
                    {
                        if (ConfereLetraAoRedor(palavraChave[i - 1], 2))
                        {
                            pontos++;
                        }
                        else
                        {
                            return Math.Floor(pontos / 2);
                        }
                    }
                    else if (palavraChave[i] == 'B' || palavraChave[i] == 'C')
                    {
                        if (ConfereLetraAoRedor(palavraChave[i - 1], 3))
                        {
                            pontos++;
                        }
                        else
                        {
                            return Math.Floor(pontos / 2);
                        }
                    }
                    else if (palavraChave[i] == 'G' || palavraChave[i] == 'I' || palavraChave[i] == 'U')
                    {
                        if (ConfereLetraAoRedor(palavraChave[i - 1], 4))
                        {
                            pontos++;
                        }
                        else
                        {
                            return Math.Floor(pontos / 2);
                        }
                    }
                    else if (palavraChave[i] == 'H' || palavraChave[i] == 'J' || palavraChave[i] == 'V')
                    {
                        if (ConfereLetraAoRedor(palavraChave[i - 1], 5))
                        {
                            pontos++;
                        }
                        else
                        {
                            return Math.Floor(pontos / 2);
                        }
                    }
                    else if (palavraChave[i] == 'K' || palavraChave[i] == 'L')
                    {
                        if (ConfereLetraAoRedor(palavraChave[i - 1], 6))
                        {
                            pontos++;
                        }
                        else
                        {
                            return Math.Floor(pontos / 2);
                        }
                    }
                    else if (palavraChave[i] == 'M' || palavraChave[i] == 'O' || palavraChave[i] == 'Q')
                    {
                        if (ConfereLetraAoRedor(palavraChave[i - 1], 7))
                        {
                            pontos++;
                        }
                        else
                        {
                            return Math.Floor(pontos / 2);
                        }
                    }
                    else if (palavraChave[i] == 'N' || palavraChave[i] == 'T' || palavraChave[i] == 'P')
                    {
                        if (ConfereLetraAoRedor(palavraChave[i - 1], 8))
                        {
                            pontos++;
                        }
                        else
                        {
                            return Math.Floor(pontos / 2);
                        }
                    }
                    else if (palavraChave[i] == 'R' || palavraChave[i] == 'S' || palavraChave[i] == 'Z')
                    {
                        if (ConfereLetraAoRedor(palavraChave[i - 1], 9))
                        {
                            pontos++;
                        }
                        else
                        {
                            return Math.Floor(pontos / 2);
                        }
                    }
                }
                else
                {
                    return Math.Floor(pontos / 2);
                }
            }
            return Math.Floor(pontos / 2);
        }

        /// <summary>
        /// Verifica se letra esta no caça-palavra e se esta repetida
        /// </summary>
        /// <param name="palavraChave"></param>
        /// <param name="indice"></param>
        /// <param name="letraSemRepetir"></param>
        /// <returns></returns>
        public static bool LetraEstaNoCacaPalavraERepete(string palavraChave, int indice, string letraSemRepetir)
        {
            //verifica se a letra esta na tabala
            foreach (var item in Tabela)
            {
                if (palavraChave[indice] == Convert.ToChar(item))
                {
                    //verifica se a letra esta repetida
                    foreach (var item2 in letraSemRepetir)
                    {
                        if(palavraChave[indice] == item2)
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Retornas todos os pontos que o jogador possui
        /// </summary>
        /// <returns></returns>
        public static double RetornaPontosG()
        {
            var pontos = PontosGeral;
            return pontos;
        }

        /// <summary>
        /// verifica se a letra anterior está ao redor da letra atual
        /// </summary>
        /// <param name="letra"></param>
        /// <param name="posicao"></param>
        /// <returns></returns>
        public static bool ConfereLetraAoRedor(char letra, int posicao)
        {
            string slot = LetrasAoRedor(posicao);

            foreach (var item in slot)
            {
                if (letra == item)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Letras ao redor da palavra atual a ser verificada
        /// </summary>
        /// <param name="posicao"></param>
        /// <returns></returns>
        public static string LetrasAoRedor(int posicao)
        {
            string slot = "ERRO";

            switch (posicao)
            {
                case 1:
                    slot = "EFHJVGIU";
                    break;
                case 2:
                    slot = "ADBCGIUHJVKL";
                    break;
                case 3:
                    slot = "EFHJVKL";
                    break;
                case 4:
                    slot = "ADEFHJVMOQNTP";
                    break;
                case 5:
                    slot = "ADEFBCGIUKLMOQNTPRSZ";
                    break;
                case 6:
                    slot = "EFBCHJVNTPRSZ";
                    break;
                case 7:
                    slot = "GIUHJVNTP";
                    break;
                case 8:
                    slot = "GIUHJVKLMOQRSZ";
                    break;
                case 9:
                    slot = "HJVKLNTP";
                    break;
            }
            return slot;
        }

        /// <summary>
        /// Limpa todas as palavras do combo box cbHistorico
        /// </summary>
        public static void LimpaHistorico()
        {
            HistoricoDePalavras.Clear();
        }
    }
}
