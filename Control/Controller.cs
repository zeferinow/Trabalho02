using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho2.Model;
using Trabalho2.View;

namespace Trabalho2.Control
{
    public static class Controller
    {
        public static List<string> PreencheTabela()
        {
            return Funcao.ConverteNumerosParaLetras();
        }

        /// <summary>
        /// Verifica se a palavra não foi repetida
        /// </summary>
        /// <param name="palavraChave"></param>
        /// <returns></returns>
        public static bool Verifica(string palavraChave)
        {

            foreach (var item in Funcao.HistoricoDePalavras)
            {
                if (item == palavraChave)
                {
                    return false;
                }
            }
            Funcao.AddLista(palavraChave);
            return true;
        }

        /// <summary>
        /// Retorna pontos conseguido na rodada
        /// </summary>
        /// <param name="palavraChave"></param>
        /// <returns></returns>
        public static double RetornaPontosP(string palavraChave)
        {
            Funcao.PontosGeral += Funcao.RetornaPontosP(palavraChave);
            return Funcao.RetornaPontosP(palavraChave);
        }

        /// <summary>
        /// Retorna todos os pontos
        /// </summary>
        /// <returns></returns>
        public static double RetornaPontosG()
        {
            return Funcao.RetornaPontosG();
        }

        public static List<string> RetornaLista()
        {
            return Funcao.HistoricoDePalavras;
        }

        public static void LimpaHistorico()
        {
            Funcao.LimpaHistorico();
        }
    }
}
