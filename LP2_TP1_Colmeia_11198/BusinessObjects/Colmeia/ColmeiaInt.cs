#region HEADER
/* LPII - 1º Trabalho Pratico - Gestor de Colmeias
 * Aluno: 11198 - André Martins
 * 
 * LAYER : Business Object
 * CLASSE : ColmeiaInt
 */
#endregion

#region USINGs
using System.Collections.Generic;
using LP2_Final_Colmeia_11198.BusinessObjects;
using System;
#endregion

#region CLASSE - COLMEIAINT
namespace LP2_Final_Colmeia_11198.BusinessObjects
{
    /// <summary>
    /// Classe : ColmeiaInt
    /// Classe que via herda da classe ColmeiaLight mas adiciona-lhe uma lista de intervençoes como atributo
    /// </summary>
    [Serializable]
    class ColmeiaInt : ColmeiaLight
    {
        #region ESTADO
        private List<Intervencao> listaIntervencao = new List<Intervencao>();
        private int totInt;
        #endregion

        #region Construtores
        /// <summary>
        /// Construtor omissao de colmeia<see cref="ColmeiaLight"/> class.
        /// </summary>
        public ColmeiaInt()
        {
            NumColmeia = 0;
            NumApiario = 0;
            NumApicultor = 0;
            Foto = "";
            Local = new Localizacao();
            Tipo = TipoColmeia.lusitania;
            DataConstrucao = DateTime.Now;
            totInt = 0;
        }

        /// <summary>
        /// Construtor parametrizado de colmeia <see cref="ColmeiaLight"/> class.
        /// </summary>
        /// <param name="numColmeia">The number colmeia.</param>
        /// <param name="numApiario">The number apiario.</param>
        /// <param name="numApicultor">The number apicultor.</param>
        /// <param name="foto">The foto.</param>
        /// <param name="local">The local.</param>
        /// <param name="dataConstrucao">The data construcao.</param>
        public ColmeiaInt(int numColmeia, int numApiario, int numApicultor, string foto, TipoColmeia tipo, Localizacao local, DateTime dataConstrucao)
        {
            this.NumColmeia = numColmeia;
            this.NumApiario = numApiario;
            this.NumApicultor = numApicultor;
            this.Foto = foto;
            this.Local = local;
            this.Tipo = tipo;
            this.DataConstrucao = dataConstrucao;
            this.totInt = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColmeiaInt"/> class.
        /// </summary>
        /// <param name="numColmeia">The number colmeia.</param>
        /// <param name="numApiario">The number apiario.</param>
        /// <param name="numApicultor">The number apicultor.</param>
        /// <param name="foto">The foto.</param>
        /// <param name="tipo"></param>
        /// <param name="local">The local.</param>
        /// <param name="dataConstrucao">The data construcao.</param>
        public ColmeiaInt(int numColmeia, string foto, TipoColmeia tipo, Localizacao local, DateTime dataConstrucao)
        {
            this.NumColmeia = numColmeia;
            this.Foto = foto;
            this.Local = local;
            this.Tipo = tipo;
            this.DataConstrucao = dataConstrucao;
            this.totInt = 0;
        }
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the lista intervencao.
        /// </summary>
        /// <value>
        /// The lista intervencao.
        /// </value>
        public List<Intervencao> ListaIntervencao
        {
            get { return listaIntervencao; }
            set { listaIntervencao = value; }
        }


        /// <summary>
        /// Gets or sets the tot int.
        /// </summary>
        /// <value>
        /// The tot int.
        /// </value>
        public int TotInt
        {
            get { return totInt; }
            set { totInt = value; }
        }

        #endregion

        #region Metodos

        #region Metodo - RegistaIntervencaoLista
        /// <summary>
        /// Metodo - RegistaIntervencaoLista
        /// Recebe uma intervenção e adiciona na lista de Intervencoes dessa colmeia
        /// </summary>
        /// <param name="i">The intervencao</param>
        /// <returns></returns>
        public bool RegistaIntervencaoLista(Intervencao i)
        {
            listaIntervencao.Add(i);
            TotInt++;
            return true;
        }
        #endregion

        #region Metodo - TotalIntervencoes
        /// <summary>
        /// Metodo - TotalIntervencoes
        /// Metodo que devolve o numero total de intervencoes de uma colmeia
        /// </summary>
        /// <returns></returns>
        public int TotalIntervencoes()
        {
            return this.listaIntervencao.Count;
        }
        #endregion

        #endregion

        #region Operadores / Overrides

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            ColmeiaInt c = obj as ColmeiaInt;
            return this.NumColmeia == c.NumColmeia;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion
    }
}
#endregion