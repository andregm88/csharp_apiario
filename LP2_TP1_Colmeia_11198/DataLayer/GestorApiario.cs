#region HEADER
/* LPII - 1º Trabalho Pratico - Gestor de Colmeias
 * Aluno: 11198 - André Martins
 * 
 * LAYER : DataLayer
 * CLASSE : GestorApiario
 */
#endregion

#region USINGs
using System.Collections.Generic;
using System;
using LP2_Final_Colmeia_11198.BusinessObjects;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
#endregion

#region Classe GestorApiario

namespace LP2_Final_Colmeia_11198.DataLayer
{
    /// <summary>
    /// Classe: GestorApiario
    /// Aqui pretende-se criar os dados necessarios para a nossa aplicaçao gerir um apiario, definimos o apicultor e quantos apiarios ira ter esse apicultor para gerir.
    /// </summary>
    class GestorApiario
    {
        #region ESTADO

        static List<Apiario> listaApiarios = new List<Apiario>();
        static List<Apicultor> listaApicultores = new List<Apicultor>();

        #endregion

        #region METODOS

        #region Metodos Sobre Apiario

        #region Metodo - ExisteApiario
        /// <summary>
        /// Metodo - ExisteApiario
        /// Metodo que recebe um numero de Apiario e verifica se ja existe na lista
        /// </summary>
        /// <param name="numApiario">numero a ser verificado</param>
        /// <returns>True / False</returns>
        public static bool ExisteApiarioDL(int numApiario)
        {

            foreach (Apiario a in listaApiarios)
            {
                if (a.NumApiario == numApiario)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region Metodo - ExisteColmeiaDL
        public static bool ExisteColmeiaDL(int numApiario, int numColmeia)
        { 
            if(ExisteApiarioDL(numApiario))
            {
                foreach (Apiario a in listaApiarios)
                {
                    if (a.NumApiario == numApiario)
                    {
                        return a.VerificaExisteNumColmeia(numColmeia);
                    }
                }
            }
            return false;
        }
        #endregion

        #region Metodo - TotalApiariosDL
        /// <summary>
        /// Totals the apiarios dl.
        /// </summary>
        /// <returns></returns>
        public static int TotalApiariosDL()
        {
            return listaApiarios.Count;
        }
        #endregion

        #region Metodo - InsereApiarioListaDL
        /// <summary>
        /// Metodo - InsereApicultorListaDl
        /// Metodo que recebe um apiario e insere esse Apiario numa lista de Apiarios
        /// </summary>
        /// <param name="a">Objecto Apiario</param>
        /// <returns></returns>
        public static bool InsereApiarioListaDL(Apiario a)
        {
            bool eanum = false;
            foreach (Apicultor ap in listaApicultores)
            {
                if (ap.Numero == a.NumApicultor)
                {
                    eanum = true;
                }
            }

            int flag = 0;

            if (eanum == true)
            {
                foreach (Apiario ap in listaApiarios)
                {
                    if (ap.NumApiario == a.NumApiario)
                    {
                        flag = 1;
                    }
                }

                if (flag == 0)
                {
                    listaApiarios.Add(a);
                    return true;
                }
                else
                {
                    throw new ApiarioException("Ja Existe Apiario com esse numero");
                }
            }
            else
            {
                throw new ApiarioException("Não Existe apicultor correspondente");
            }
        }
        #endregion

        #region Metodo - InsereApicultorListaDL
        /// <summary>
        /// Metodo - InsereApicultorLista
        /// Metodo que recebe um apicultor e insere esse apicultor em uma lista de Apicultores
        /// </summary>
        /// <param name="ap">Objecto Apicultor</param>
        /// <returns></returns>
        public static bool InsereApicultorListaDL(Apicultor ap)
        {
            bool flag = false;

            if (listaApicultores.Count == 0)
            {
                listaApicultores.Add(ap);
                return true;
            }
            else
            {
                foreach (Apicultor a in listaApicultores)
                {
                    if (a.Numero == ap.Numero)
                    {
                        flag = true;
                        throw new Exception("Ja Existe Apicultor com este numero!");
                    }
                }

                if (flag == false)
                {
                    listaApicultores.Add(ap);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        #endregion

        #region Metodo - InsereColmeiaNoApiario
        /// <summary>
        /// Metodo - InsereColmeiaNoApiario
        /// Recebe um numero de apiario e uma colmeia e insere essa colmeia no respectivo apiario
        /// </summary>
        /// <param name="numApiario">numero do apiario</param>
        /// <param name="c">Colmeia</param>
        /// <returns>True / False</returns>
        public static bool InsereColmeiaNoApiarioDL(int numApiario, ColmeiaInt c)
        {
            if (ExisteApiarioDL(numApiario) == true)
            {
                foreach (Apiario a in listaApiarios)
                {
                    if (a.NumApiario == numApiario)
                    {
                        return (a.InsereColmeiaNoApiario(c));
                    }
                }
            }
            return false;
        }
        #endregion

        #region Metodo - ConsultaColmeiaLightDL
        /// <summary>
        /// Consultas the colmeia.
        /// </summary>
        /// <param name="numApiario">The number apiario.</param>
        /// <param name="numColmeia">The number colmeia.</param>
        /// <returns></returns>
        public static ColmeiaLight ConsultaColmeiaLightDL(int numApiario, int numColmeia)
        {
            ColmeiaLight cn = new ColmeiaLight();
            foreach (Apiario a in listaApiarios)
            {
                if (a.NumApiario == numApiario)
                {
                    if (a.VerificaExisteNumColmeia(numColmeia))
                    {
                        foreach (ColmeiaLight cl in a.ListaColmeias)
                        {
                            if (cl.NumColmeia == numColmeia)
                            {
                                return cl;
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("Nao existe colmeia com esse numero!");
                    }
                }
            }
            return cn;
        }
        #endregion

        #region Metodo - ConsultaColmeiaIntDL
        /// <summary>
        /// Consultas the colmeia int.
        /// </summary>
        /// <param name="numApiario">The number apiario.</param>
        /// <param name="numColmeia">The number colmeia.</param>
        /// <returns></returns>
        public static ColmeiaInt ConsultaColmeiaIntDL(int numApiario, int numColmeia)
        {
            ColmeiaInt cn = new ColmeiaInt();
            if (ExisteApiarioDL(numApiario) == true)
            {
                foreach (Apiario a in listaApiarios)
                {
                    if (a.NumApiario == numApiario)
                    {
                        foreach (ColmeiaInt cl in a.ListaColmeias)
                        {
                            if (cl.NumColmeia == numColmeia)
                            {
                                return cl;
                            }
                        }
                    }
                }
            }

            return cn;
        }
        #endregion;

        #region Metodo - RemoveColmeiaDL

        public static bool RemoveColmeiaDL(int numApiario, int numColmeia)
        {
            if (ExisteApiarioDL(numApiario) == true)
            {
                foreach (Apiario a in listaApiarios)
                {
                    if (a.NumApiario == numApiario)
                    { 
                        try
                        {
                            a.RemoveColmeiaApiario(numColmeia);
                            return true;
                        }
                        catch(Exception e)
                        {
                            throw new Exception("", e);
                        }
                    }
                }
                return false;
            }
            else
            {
                throw new Exception("Nao existe Apiario");
            }
        }

        #endregion
        /// <summary>
        /// Metodo que recebe um numero de apiario, um numero de colmeia e uma intervencao, insere intervencao nessa colmeia
        /// </summary>
        /// <param name="numApiario">The number apiario.</param>
        /// <param name="numColmeia">The number colmeia.</param>
        /// <param name="i">The i.</param>
        /// <returns></returns>
        public static bool RegistaIntervencaoNaColmeiaDL(int numApiario, int numColmeia, Intervencao i)
        {
            if (ExisteApiarioDL(numApiario) == true)
            {
                foreach (Apiario a in listaApiarios)
                {
                    if (a.NumApiario == numApiario)
                    {
                        foreach (ColmeiaInt ci in a.ListaColmeias)
                        {
                            if (ci.NumColmeia == numColmeia)
                            {
                                return ci.RegistaIntervencaoLista(i);
                            }
                        }
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Dado um numero de apiario devolve um array com as colmeias desse apiario
        /// </summary>
        /// <value>
        /// The total apicultores.
        /// </value>
        /// <param name="numApicultor">The number apicultor.</param>
        //public static Intervencao[] ListaIntervencoesColmeia(int numApiario, int numColmeia)
        //{
        //    if (ExisteApiario(numApiario) == true)
        //    {
        //        if (gestorApiarios[numApiario - 1].VerificaExisteNumColmeia(numColmeia) == true)
        //        {
        //            Intervencao[] listaInt = gestorApiarios[numApiario - 1].ListaIntervencoesColmeia(numColmeia);
        //            return listaInt;
        //        }
        //        else 
        //        {
        //            Intervencao[] listaInt = new Intervencao[0];
        //            return listaInt;

        //        }
        //    }
        //    else
        //    {
        //        Intervencao[] listaInt = new Intervencao[0];
        //        return listaInt;

        //    }
        //}


        #region Metodo - AgendaTarefaDL

        public static bool AgendaTarefaDL(int numApiario, Tarefa t)
        {
            if (ExisteApiarioDL(numApiario))
            {
                foreach (Apiario a in listaApiarios)
                {
                    if (a.NumApiario == numApiario)
                    {
                        a.AgendaTarefa(t);
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }
        
        #endregion

        #region Metodo - ConsultaAgendaApiario

        public static List<Tarefa> ConsultaAgendaApiarioDL(int numApiario, DateTime data)
        {
            List<Tarefa> lt = null;

            if (ExisteApiarioDL(numApiario))
            {
                foreach (Apiario a in listaApiarios)
                {
                    if (a.NumApiario == numApiario)
                    {
                        lt = a.ConsultaAgenda(data);
                        return lt;
                    }
                }
                return lt;
            }
            return lt;
        
        }
        #endregion

        #endregion

        #region Metodos Sobre ListaApicultores

        #region Metodos TotalApicultores

        public static int TotalApicultoresDL()
        {
            return listaApicultores.Count;   
        }

        #endregion

        #region Metodo ExisteNumApicultorDL

        public static bool ExisteNumApicultorDL(int numApicultor)
        {
            foreach (Apicultor a in listaApicultores)
            {
                if (a.Numero == numApicultor)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Metodo - GuardaApicultorListaDL

        /// <summary>
        /// Guardas the apicultor lista dl.
        /// </summary>
        /// <param name="a">a.</param>
        /// <returns></returns>
        public static bool GuardaApicultorListaDL(Apicultor a)
        {
            if (ExisteNumApicultorDL(a.Numero))
            {
                return false;
            }
            else
            {
                listaApicultores.Add(a);
                return true;
            }
        }
        #endregion

        #endregion

        #region Metodo - ConsultaLocalizacaoColmeiaDL
        /// <summary>
        /// Metodo - ConsultaLocalizacaoColmeiaDL
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static Localizacao[] ConsultaLocalizacaoColmeiaDL(int numApiario)
        {
            Localizacao[] loca = new Localizacao[0];
            foreach (Apiario a in listaApiarios)
            {
                if (a.NumApiario == numApiario)
                {
                    int totalLoc = a.ListaColmeias.Count;
                    int pos = 0;
                    loca = new Localizacao[totalLoc];
                    foreach (ColmeiaLight c in a.ListaColmeias)
                    {
                        loca[pos] = c.Local;
                        pos++;
                    }
                    return loca;
                }
            }

            return loca;
        }
        #endregion

        #region Metodo Consulta Numero

        public static int ConsultaTotaisDL(out int totalApiarios, out int ttColmeias)
        {
            int totalApicultores = listaApicultores.Count;
            totalApiarios = listaApiarios.Count;
            ttColmeias = 0;

            foreach (Apiario a in listaApiarios)
            {
                ttColmeias += a.ListaColmeias.Count;
            }
            return totalApicultores;
        }

        #endregion

        #region GUARDAR / CARREGAR FICHEIRO
        /// <summary>
        /// Preservar
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool SaveApiario(string fileName)
        {
            try
            {
                Stream stream = File.Open(fileName, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, listaApiarios);
                stream.Close();
                return true;
            }
            catch (IOException e)
            {
                Console.Write("ERRO:" + e.Message);
                return false;
            }
        }

        public static bool SaveApicultores(string fileName)
        {
            try
            {
                Stream stream = File.Open(fileName, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, listaApicultores);
                stream.Close();
                return true;
            }
            catch (IOException e)
            {
                Console.Write("ERRO:" + e.Message);
                return false;
            }
        }

        public static void Clear()
        {
            listaApiarios.Clear();
            listaApicultores.Clear();

        }

        /// <summary>
        /// Load Data
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool LoadApiario(string fileName)
        {
            if (File.Exists(fileName))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Open);
                    BinaryFormatter bin = new BinaryFormatter();
                    listaApiarios = (List<Apiario>)bin.Deserialize(stream);
                    stream.Close();
                    return true;
                }
                catch (IOException e)
                {
                    Console.Write("ERRO:" + e.Message);
                    return false;
                }
            }
            return false;
        }

        public static bool LoadApicultor(string fileName)
        {
            if (File.Exists(fileName))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Open);
                    BinaryFormatter bin = new BinaryFormatter();
                    listaApicultores = (List<Apicultor>)bin.Deserialize(stream);
                    stream.Close();
                    return true;
                }
                catch (IOException e)
                {
                    Console.Write("ERRO:" + e.Message);
                    return false;
                }
            }
            return false;
        }
    }
        #endregion

        #endregion
}
#endregion