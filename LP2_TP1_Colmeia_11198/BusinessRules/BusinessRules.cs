#region HEADER
/* LPII - 1º Trabalho Pratico - Gestor de Colmeias
 * Aluno: 11198 - André Martins
 * 
 * LAYER : BusinessRules
 * CLASSE : Businessrules
 */
#endregion

#region USINGs
using LP2_Final_Colmeia_11198.BusinessObjects;
using LP2_Final_Colmeia_11198.DataLayer;
using System;
using System.Collections.Generic;
#endregion

#region Classe BussinessRules
namespace LP2_Final_Colmeia_11198.BusinessRules
{
    /// <summary>
    /// Classe: BusinessRules
    /// Classe que ira fazer a ponte entre a parte que interage com o utilizador com a camada DataLayer onde esta a informacao
    /// </summary>
    class BusinessRules
    {
        #region Constantes
        const int MAXAPIARIOS = 2;
        const int MAXCOLMEIAS = 5;
        const int MAXAPICULTORES = 3;
        #endregion

        #region METODOS SOBRE APIARIOS/COLMEIAS

        #region Metodo - GuardaApiario
        /// <summary>
        /// Metodo - GuardaApiario
        /// Recebe um Apiario vai ao DataLayer e adciciona na lista de Apiarios
        /// </summary>
        /// <param name="a">Objecto de Apiario</param>
        /// <returns></returns>
        public static bool GuardaApiario(Apiario a)
        {
            int ta = GestorApiario.TotalApiariosDL();
            if (ta >= MAXAPIARIOS)
            {
                throw new Exception("Nao pode adicionar mais apiarios, atingiu o maximo permitido de Apiarios!");
            }
            else
            {
                bool ga = false;
                try
                {
                    ga = GestorApiario.InsereApiarioListaDL(a);
                    return ga;
                }
                catch (ApiarioException e)
                {
                    throw new ApiarioException("Erro: ", e);
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro: ", ex);
                }
            }
        }
        #endregion

        #region Metodo - RegistaColmeiaApiario
        /// <summary>
        /// Recebe um numero de apiario e uma Colmeia, regista essa colmeia no apiario
        /// </summary>
        /// <param name="numApiario">The number apiario.</param>
        /// <param name="c">The c.</param>
        /// <returns></returns>
        public static bool RegistaColmeiaNoApiario(int numApiario, ColmeiaInt c)
        {
            if (GestorApiario.ExisteApiarioDL(numApiario) == false)
            {
                throw new Exception("Nao existe apiario com esse numero");
            }
            else
            {
                bool insColm = false;
                try
                {
                    insColm = GestorApiario.InsereColmeiaNoApiarioDL(numApiario, c);
                    return insColm;
                }
                catch (Exception e)
                {
                    throw new Exception("Erro: ", e);
                }
            }
        }
        #endregion

        #region Metodo - RemoveColmeiaBR

        public static bool RemoveColmeiaBR(int numApiario, int numColmeia)
        {
            try
            {
                return GestorApiario.RemoveColmeiaDL(numApiario, numColmeia);
            }
            catch (Exception e)
            {
                throw new Exception("", e);
            }        
        }

        #endregion

        #region Metodo - ConsultaColmeiaLightBR
        /// <summary>
        /// Metodo - ConsultaColmeiaApiario
        /// Metodo recebe um num de Apiario e um numero de Colmeia e recebe a colmeia correspondente
        /// </summary>
        /// <param name="numApiario">The number apiario.</param>
        /// <param name="numColmeia">The number colmeia.</param>
        /// <returns></returns>
        public static ColmeiaLight ConsultaColmeiaLightBR(int numApiario, int numColmeia)
        {
            if (GestorApiario.ExisteApiarioDL(numApiario) == true)
            {
                try
                {
                    return GestorApiario.ConsultaColmeiaLightDL(numApiario, numColmeia);
                }
                catch (Exception e)
                {
                    throw new Exception("Erro Ao Consultar Colmeia! ", e);
                }
            }
            else
            {
                throw new Exception("Nao existe apiario com este numero!");
            }

        }
        #endregion

        /// <summary>
        /// Consultas the colmeia int apiario.
        /// </summary>
        /// <param name="numApiario">The number apiario.</param>
        /// <param name="numColmeia">The number colmeia.</param>
        /// <returns></returns>
        public static ColmeiaInt ConsultaColmeiaIntApiarioBR(int numApiario, int numColmeia)
        {
            if ((GestorApiario.ExisteApiarioDL(numApiario) == true) && (GestorApiario.ExisteColmeiaDL(numApiario, numColmeia) == true))
            {
                return GestorApiario.ConsultaColmeiaIntDL(numApiario, numColmeia);
            }
            else
            {
                throw new Exception("Nao existe Apiario ou Colmeia!");
            }
        }

        /// <summary>
        /// recebe um numero de apiario e devolve as colmeias desse apiario
        /// </summary>
        /// <param name="numApiario">The number apiario.</param>
        /// <returns></returns>
        //public static Colmeia[] ListaColmeiasApiario(int numApiario)
        //{
        //    Colmeia[] lista = GestorApiario.ListaColmeiasApiario(numApiario);
        //    return lista;
        //}

        #region Metodo - RegistaIntervencaoColmeia
        /// <summary>
        /// Metodo  - RegistaIntervencaColmeia
        /// Recebe uma intervencao, um numero de Apiario e um numero de Colmeia e adiciona na lista de intervencoes
        /// recebe um numero de apiario, um numero de colmeia e regista intervencao nessa colmeia
        /// </summary>
        /// <param name="numApiario">The number apiario.</param>
        /// <param name="numColmeia">The number colmeia.</param>
        /// <param name="i">The i.</param>
        /// <returns></returns>
        public static bool RegistaIntervencaoColmeiaBR(int numApiario, int numColmeia, Intervencao i)
        {
            if ((GestorApiario.ExisteApiarioDL(numApiario) == true) && (GestorApiario.ExisteColmeiaDL(numApiario, numColmeia) == true))
            {
                return (GestorApiario.RegistaIntervencaoNaColmeiaDL(numApiario, numColmeia, i));
            }
            else
            {
                throw new Exception("Nao existe Apiario ou Colmeia!");
            }
        }
        #endregion

        /// <summary>
        /// Recebe um numero de apiario e numero de colmeia, devolve um array com as intervencoes desssa colmeia
        /// </summary>
        /// <param name="numApiario">The number apiario.</param>
        /// <param name="numColmeia">The number colmeia.</param>
        /// <returns></returns>
        //public static Intervencao[] ListaIntervencoes(int numApiario, int numColmeia)
        //{
        //    Intervencao[] listaIntervencoes = GestorApiario.ListaIntervencoesColmeia(numApiario, numColmeia);
        //    return listaIntervencoes;
        //}

        #region Metodo - ConsultaLocalizacoesColmeiasBR
        /// <summary>
        /// recebe um numero de apiario, um numero de colmeia e devolve a localização
        /// </summary>
        /// <param name="numApiario">The number apiario.</param>
        /// <param name="numColmeia">The number colmeia.</param>
        /// <param name="loc">The loc.</param>
        /// <returns></returns>
        public static Localizacao[] ConsultaLocalizacoesColmeiasBR(int numApiario)
        {
            if (GestorApiario.ExisteApiarioDL(numApiario))
            {
                return (GestorApiario.ConsultaLocalizacaoColmeiaDL(numApiario));
            }
            else
            {
                throw new Exception("Nao existe este Apiario!");
            }
            
        }
        #endregion

        #region Metodo - AgendaTarefaBR

        public static bool AgendaTarefaBR(int numApiario, Tarefa t)
        {
            if (GestorApiario.ExisteApiarioDL(numApiario))
            {
                return GestorApiario.AgendaTarefaDL(numApiario, t);
            }
            else
            {
                throw new Exception("Nao existe Apiario com este numero");
            }
        }
        
        #endregion

        #region Metodo - ConsultaAgendaApiario

        public static List<Tarefa> ConsultaAgendaApiarioBR(int numApiario, DateTime data)
        {
            List<Tarefa> listaT = null;
            if (GestorApiario.ExisteApiarioDL(numApiario))
            {
                listaT = GestorApiario.ConsultaAgendaApiarioDL(numApiario, data);
                return listaT;
            }
            else
            {
                throw new Exception("Apiario Nao existe");
            }
        }

        #endregion

        public static int ConsultaTotaisBR(out int totalApiarios, out int ttColmeias)
        {
            int totalApicultores = GestorApiario.ConsultaTotaisDL(out totalApiarios, out ttColmeias);
            return totalApicultores;
        }

        #endregion

        #region METODOS SOBRE APICULTORES

        /// <summary>
        /// Guardas the apicultor br.
        /// </summary>
        /// <param name="a">a.</param>
        /// <returns></returns>
        public static bool GuardaApicultorBR(Apicultor a)
        {
            int tap = GestorApiario.TotalApicultoresDL();

            if (tap >= MAXAPICULTORES)
            {
                throw new Exception("Atingiu maximo de apicultores");
            }
            else
            {
                return GestorApiario.GuardaApicultorListaDL(a);
            }
        }


        #endregion

    }
}
#endregion