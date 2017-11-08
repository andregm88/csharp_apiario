#region HEADER
/* LPII - 1º Trabalho Pratico - Gestor de Colmeias
 * Aluno: 11198 - André Martins
 * 
 * LAYER : Business Object
 * CLASSE : Colmeia
 */
#endregion

#region USINGs
using System;
using LP2_Final_Colmeia_11198.BusinessObjects;
#endregion

#region Classe ColmeiaLight
namespace LP2_Final_Colmeia_11198.BusinessObjects
{
    #region ENUMERADO - TIPO COLMEIA
    /// <summary>
    /// Enumero : Tipo de Colmeia
    /// </summary>
    public enum TipoColmeia
    {
        lusitania = 0,
        reversivel = 1,
        longstroth = 2
    }

    #endregion

    #region CLASSE - COLMEIALIGHT
    /// <summary>
    /// Classe : Colmeia
    /// Pretende-se definir todos os tipos necessarios para definir uma colmeia
    /// </summary>
    [Serializable]
    class ColmeiaLight : IColmeia
    {
        #region ESTADO
        private int numColmeia;
        private int numApiario;
        private int numApicultor;
        private string foto;
        private TipoColmeia tipo;
        private Localizacao local;
        private DateTime dataConstrucao;
        //private List<Intervencao> listaIntervencao;
        //private int totInt;
        #endregion

        #region Construtores

        /// <summary>
        /// Construtor omissao de colmeia<see cref="ColmeiaLight"/> class.
        /// </summary>
        public ColmeiaLight()
        {
            numColmeia = 0;
            numApiario = 0;
            numApicultor = 0;
            foto = "";
            local = new Localizacao();
            tipo = TipoColmeia.lusitania;
            dataConstrucao = DateTime.Now;
            //totInt = 0;
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
        public ColmeiaLight(int numColmeia, int numApiario, int numApicultor, string foto,TipoColmeia tipo, Localizacao local, DateTime dataConstrucao)
        {
            this.numColmeia = numColmeia;
            this.numApiario = numApiario;
            this.numApicultor = numApicultor;
            this.foto = foto;
            this.local = local;
            this.tipo = tipo;
            this.dataConstrucao = dataConstrucao;
            //this.totInt = 0;
        }

        /// <summary>
        /// Construtor parametrizado de colmeia <see cref="ColmeiaLight"/> class.
        /// </summary>
        /// <param name="foto">The foto.</param>
        /// <param name="tipo">The tipo.</param>
        /// <param name="local">The local.</param>
        /// <param name="dataConstrucao">The data construcao.</param>
        public ColmeiaLight(string foto, TipoColmeia tipo, Localizacao local, DateTime dataConstrucao)
        {
            this.numColmeia = 0;
            this.numApiario = 0;
            this.numApicultor = 0;
            this.foto = foto;
            this.local = local;
            this.tipo = tipo;
            this.dataConstrucao = dataConstrucao;
            //this.totInt = 0;
        }
        
        #endregion

        #region Properties
     
        /// <summary>
        /// Gets or sets the number colmeia.
        /// </summary>
        /// <value>
        /// Numero de Colmeia
        /// </value>
        public int NumColmeia
        {
            get { return numColmeia; }
            set { numColmeia = value; }
        }

        /// <summary>
        /// Gets or sets the number apiario.
        /// </summary>
        /// <value>
        /// Numero de Apiario
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
        /// Numero de Apicultor
        /// </value>
        public int NumApicultor
        {
            get { return numApicultor; }
            set { numApicultor = value; }
        }

        /// <summary>
        /// Gets or sets the foto.
        /// </summary>
        /// <value>
        /// String da foto
        /// </value>
        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        /// <summary>
        /// Gets or sets the tipo.
        /// </summary>
        /// <value>
        /// Tipo de Colmeia
        /// </value>
        public TipoColmeia Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        /// <summary>
        /// Gets or sets the local.
        /// </summary>
        /// <value>
        /// Localizacao Colmeia
        /// </value>
        public Localizacao Local
        {
            get { return local; }
            set { local = value; }
        }

        /// <summary>
        /// Gets or sets the data construcao.
        /// </summary>
        /// <value>
        /// Data Construcao
        /// </value>
        public DateTime DataConstrucao
        {
            get { return dataConstrucao; }
            set { dataConstrucao = value; }
        }

        /// <summary>
        /// Gets or sets the lista intervencao.
        /// </summary>
        /// <value>
        /// The lista intervencao.
        /// </value>
        //public List<Intervencao> ListaIntervencao
        //{
        //    get { return listaIntervencao; }
        //    set { listaIntervencao = value; }
        //}

        /// <summary>
        /// Gets or sets the tot int.
        /// </summary>
        /// <value>
        /// The tot int.
        /// </value>
        //public int TotInt
        //{
        //    get { return totInt; }
        //    set { totInt = value; }
        //}
        #endregion
        
        #region Metodos
        

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
            ColmeiaLight c = obj as ColmeiaLight;
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

        public override string ToString()
        {
            return (
                "Numero Colmeia: " + numColmeia + 
                "\nNumero Apiario: " + numApiario +
                "\nNumero Apicultor: " + numApicultor +
                "\nFoto: " + foto +
                "\nTipo: " + tipo.ToString() +
                "\nLocalizacao: " + local.ToString() +
                "\nData Construcao: " + dataConstrucao.ToString()
               );
        }

        #endregion
    }

    #endregion
}
#endregion