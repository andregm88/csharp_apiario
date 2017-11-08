#region HEADER
/* LPII - 1º Trabalho Pratico - Gestor de Colmeias
 * Aluno: 11198 - André Martins
 * 
 * LAYER : Data Layer
 * CLASSE : Apiario
 */
#endregion

#region USINGs
using System.Collections.Generic;
using System;
#endregion

#region Classe Apiario
namespace LP2_Final_Colmeia_11198.BusinessObjects
{
    /// <summary>
    /// Classe Apiario
    /// </summary>
    [Serializable]
    class Apiario : IApiario
    {
        #region ESTADO
        private List<ColmeiaInt> listaColmeias = new List<ColmeiaInt>();
        private int numApiario;
        private int numApicultor;
        private int totColmeias;
        private Dictionary<DateTime, List<Tarefa>> agendaTarefas = new Dictionary<DateTime, List<Tarefa>>();
        #endregion

        #region Construtores

        /// <summary>
        /// Construtor por omissao de um Apiario
        /// </summary>
        public Apiario()
        {
            numApiario = 0;
            numApicultor = 0;
            totColmeias = 0;
        }

        /// <summary>
        /// Construtor parametrizado de Apiario
        /// </summary>
        /// <param name="numApiario">Numero do Apiario</param>
        /// <param name="numApicultor">Numero do Apicultor</param>
        public Apiario(int numApiario, int numApicultor)
        {
            this.numApiario = numApiario;
            this.numApicultor = numApicultor;
            totColmeias = 0;
        }

        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the lista colmeias1.
        /// </summary>
        /// <value>
        /// The lista colmeias1.
        /// </value>
        public List<ColmeiaInt> ListaColmeias
        {
            get { return listaColmeias; }
            set { listaColmeias = value; }
        }

        /// <summary>
        /// Gets or sets the number apiario.
        /// </summary>
        /// <value>
        /// The number apiario.
        /// </value>
        public int NumApiario
        {
            get { return numApiario; }
            set { numApiario = value; }
        }

        /// <summary>
        /// Gets or sets the number apicultor.
        /// </summary>
        /// <value>
        /// The number apicultor.
        /// </value>
        public int NumApicultor
        {
            get { return numApicultor; }
            set { numApicultor = value; }
        }

        /// <summary>
        /// Gets or sets the tot colmeias.
        /// </summary>
        /// <value>
        /// The tot colmeias.
        /// </value>
        public int TotColmeias
        {
            get { return totColmeias; }
            set { totColmeias = value; }
        }
        #endregion

        #region Metodos

        #region Metodo - InsereColmeiaApiario
        /// <summary>
        /// Metodo - InsereColmeiaApiario
        /// Metodo que recebe uma colmeia e insere num apiario
        /// </summary>
        /// <param name="c">Objectio Colmeia</param>
        /// <returns></returns>
        public bool InsereColmeiaNoApiario(ColmeiaInt novaColmeia)
        {
            int flag = 0;

            foreach (ColmeiaLight c in listaColmeias)
            {
                if (c.Equals(novaColmeia))
                {
                    flag = 1;
                    throw new Exception("Ja existe uma colmeia igual no Apiario!");
                }
            }

            if (flag != 1)
            {
                novaColmeia.NumApiario = this.numApiario;
                novaColmeia.NumApicultor = this.numApicultor;
                listaColmeias.Add(novaColmeia);
                totColmeias++;
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Metodo - RemoveColmeia

        public bool RemoveColmeiaApiario(int numColmeia)
        {
            if (VerificaExisteNumColmeia(numColmeia) == true)
            {
                foreach(ColmeiaInt c in listaColmeias)
                {
                    if (c.NumColmeia == numColmeia)
                    {
                        listaColmeias.Remove(c);
                        return true;
                    }
                }
                return false;
            }
            else
            {
                throw new Exception("Nao existe colmeia");
            }
        }


        #endregion

        #region Metodo - VerificaExisteNumColmeia
        /// <summary>
        /// Metododo - VerificaExistaNumColmeia
        /// Metodo que recebe um numero de uma colmeia e verifica se ja existe alguma colmeia com esse numero na lista;
        /// </summary>
        /// <param name="numColmeia">The number colmeia.</param>
        /// <returns></returns>
        public bool VerificaExisteNumColmeia(int numColmeia)
        {
            foreach (ColmeiaLight c in listaColmeias)
            {
                if (c.NumColmeia == numColmeia) return true;
                else return false;
            }
            return false;
        }
        #endregion

        #region Metodo - ConsultaLocalizacoesColmeias

        /// <summary>
        /// Metodo - ConsultaLocalizacoesColmeias
        /// Metodo que devolve um array do tipo Localizacoes que devolve todas as localizacoes das colmeias do Apiario
        /// </summary>
        /// <returns></returns>
        Localizacao[] ConsultaLocalizacoesColmeias()
        {

            int totalLoc = listaColmeias.Count;
            int pos = 0;

            Localizacao[] loca = new Localizacao[totalLoc];

            foreach (ColmeiaInt c in listaColmeias)
            {
                loca[pos] = c.Local;
                pos++;
            }
        
            return loca;

        }

        public Dictionary<DateTime, List<Tarefa>> AgendaTarefas
        {
            get { return agendaTarefas; }
            set { agendaTarefas = value; }
        }


        #endregion

        #region Metodo - AgendaTarefa     
        /// <summary>
        /// Agendas the tarefa.
        /// </summary>
        /// <param name="t">The t.</param>
        /// <returns></returns>
        public bool AgendaTarefa(Tarefa t)
        { 
            DateTime key = t.DataInicio.Date;
            if (agendaTarefas.ContainsKey(key))
            {
                this.agendaTarefas[key].Add(t);
                return true;
            }
            else
            {
                List<Tarefa> nagendaTarefas = new List<Tarefa>();
                nagendaTarefas.Add(t);
                this.agendaTarefas.Add(key, nagendaTarefas);
                return true;
            }
        }
        #endregion

        #region Metodo - Consulta Agenda Tarefas

        public List<Tarefa> ConsultaAgenda(DateTime data)
        {
            List<Tarefa> listaTarefas = null;

            DateTime key = data.Date;
            if(agendaTarefas.ContainsKey(key))
            {
                listaTarefas = agendaTarefas[key];
            }

            return listaTarefas;
        }

        #endregion

        #endregion
    }
}
#endregion
