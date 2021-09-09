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
        public static List<string> Tabela = new List<string>();

        public static List<string> HistoricoDePalavras = new List<string>();

        public static double PontosGeral = new double();

        public static List<int> PreencheTabelaComNumeros()
        {
            List<int> letras = new List<int>();
            Random ram = new Random();

            for (int i = 0; i < 4; i++)
            {
                var a = ram.Next(1, 3);
                letras.Add(a);
            }

            for (int i = 0; i < 5; i++)
            {
                var a = ram.Next(1, 4);
                letras.Add(a);
            }
            return letras;
        }

        public static List<string> ConverteNumerosParaLetras()
        {
            var numeros = PreencheTabelaComNumeros();
            List<string> letras = new List<string>();
            letras.Add(Adiciona("A", "D"));
            letras.Add(Adiciona("E", "F"));
            letras.Add(Adiciona("B", "C"));
            letras.Add(Adiciona("G", "I", "U"));
            letras.Add(Adiciona("H", "J", "V"));
            letras.Add(Adiciona("K", "L"));
            letras.Add(Adiciona("M", "O", "Q"));
            letras.Add(Adiciona("N", "T", "P"));
            letras.Add(Adiciona("R", "S", "Z"));
            Tabela = letras;
            return letras;
        }

        public static string Adiciona(string numero1, string numero2)
        {
            var numeros = PreencheTabelaComNumeros();

            if (numeros[0] == 1)
            {
                return numero1;
            }
            else
            {
                return numero2;
            }
        }

        public static string Adiciona(string numero1, string numero2, string numero3)
        {
            var numeros = PreencheTabelaComNumeros();

            if (numeros[0] == 1)
            {
                return numero1;
            }
            else if (numeros[0] == 2)
            {
                return numero2;
            }
            else
            {
                return numero3;
            }
        }

        public static void AddLista(string a)
        {
            HistoricoDePalavras.Add(a);
        }

        public static double RetornaPontosP(string sequencia)
        {
            string letrasSemRepetir = "";
            double pontos = 0;
            if (LetraEstaNoCacaPalavraERepete(sequencia, 0, letrasSemRepetir))
            {
                letrasSemRepetir += sequencia[0];
                pontos++;
            }
            else
            {
                return 0;
            }
            for (int i = 1; i < sequencia.Length; i++)
            {
                if (LetraEstaNoCacaPalavraERepete(sequencia, i, letrasSemRepetir))
                {
                    letrasSemRepetir += sequencia[i];
                    if (sequencia[i] == 'A' || sequencia[i] == 'D')
                    {
                        if (VerificaSequencia(sequencia[i - 1], 1))
                        {
                            pontos++;
                        }
                        else
                        {
                            return Math.Floor(pontos / 2);
                        }
                    }
                    else if (sequencia[i] == 'E' || sequencia[i] == 'F')
                    {
                        if (VerificaSequencia(sequencia[i - 1], 2))
                        {
                            pontos++;
                        }
                        else
                        {
                            return Math.Floor(pontos / 2);
                        }
                    }
                    else if (sequencia[i] == 'B' || sequencia[i] == 'C')
                    {
                        if (VerificaSequencia(sequencia[i - 1], 3))
                        {
                            pontos++;
                        }
                        else
                        {
                            return Math.Floor(pontos / 2);
                        }
                    }
                    else if (sequencia[i] == 'G' || sequencia[i] == 'I' || sequencia[i] == 'U')
                    {
                        if (VerificaSequencia(sequencia[i - 1], 4))
                        {
                            pontos++;
                        }
                        else
                        {
                            return Math.Floor(pontos / 2);
                        }
                    }
                    else if (sequencia[i] == 'H' || sequencia[i] == 'J' || sequencia[i] == 'V')
                    {
                        if (VerificaSequencia(sequencia[i - 1], 5))
                        {
                            pontos++;
                        }
                        else
                        {
                            return Math.Floor(pontos / 2);
                        }
                    }
                    else if (sequencia[i] == 'K' || sequencia[i] == 'L')
                    {
                        if (VerificaSequencia(sequencia[i - 1], 6))
                        {
                            pontos++;
                        }
                        else
                        {
                            return Math.Floor(pontos / 2);
                        }
                    }
                    else if (sequencia[i] == 'M' || sequencia[i] == 'O' || sequencia[i] == 'Q')
                    {
                        if (VerificaSequencia(sequencia[i - 1], 7))
                        {
                            pontos++;
                        }
                        else
                        {
                            return Math.Floor(pontos / 2);
                        }
                    }
                    else if (sequencia[i] == 'N' || sequencia[i] == 'T' || sequencia[i] == 'P')
                    {
                        if (VerificaSequencia(sequencia[i - 1], 8))
                        {
                            pontos++;
                        }
                        else
                        {
                            return Math.Floor(pontos / 2);
                        }
                    }
                    else if (sequencia[i] == 'R' || sequencia[i] == 'S' || sequencia[i] == 'Z')
                    {
                        if (VerificaSequencia(sequencia[i - 1], 9))
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

        public static bool LetraEstaNoCacaPalavraERepete(string sequencia, int indice, string letraSemRepetir)
        {
            foreach (var item in Tabela)
            {
                if (sequencia[indice] == Convert.ToChar(item))
                {
                    foreach (var item2 in letraSemRepetir)
                    {
                        if(sequencia[indice] == item2)
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            return false;
        }

        public static double RetornaPontosG()
        {
            var pontos = PontosGeral;
            return pontos;
        }

        public static bool VerificaSequencia(char letra, int posicao)
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

        public static void LimpaHistorico()
        {
            HistoricoDePalavras.Clear();
        }
    }
}
