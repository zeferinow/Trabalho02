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

        public static bool Verifica(string sequencia)
        {

            foreach (var item in Funcao.HistoricoDePalavras)
            {
                if (item == sequencia)
                {
                    return false;
                }
            }
            Funcao.AddLista(sequencia);
            return true;
        }

        public static double RetornaPontosP(string sequencia)
        {
            Funcao.PontosGeral += Funcao.RetornaPontosP(sequencia);
            return Funcao.RetornaPontosP(sequencia);
        }

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
