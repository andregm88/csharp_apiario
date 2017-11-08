#region HEADER
/* LPII - 1º Trabalho Pratico - Gestor de Colmeias
 * Aluno: 11198 - André Martins
 * 
 * LAYER : Business Object
 * CLASSE : Apicultor
 */
#endregion

#region USINGs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

#region CLASSE APICULTOR
namespace LP2_Final_Colmeia_11198.BusinessObjects
{
    /// <summary>
    /// Classe : Apicultor
    /// </summary>
    [Serializable]
    class Apicultor : AbsApicultor
    {
        #region ESTADO
        //private int numero;
        //private string nome;
        //private DateTime dataIniAtividade;
        private string associacao;
        private string contacto;
        private string foto;
        #endregion

        #region Construtores

        /// <summary>
        /// Initializes a new instance of the <see cref="Apicultor"/> class.
        /// </summary>
        /// <param name="numero">The numero.</param>
        /// <param name="nome">The nome.</param>
        /// <param name="dataIniAtividade">The data ini atividade.</param>
        /// <param name="associacao">The associacao.</param>
        /// <param name="contacto">The contacto.</param>
        /// <param name="foto">The foto.</param>
        public Apicultor(int numero, string nome, DateTime dataIniAtividade, string associacao, string contacto, string foto)
        {
            this.numero = numero;
            this.nome = nome;
            this.dataIniAtividade = dataIniAtividade;
            this.associacao = associacao;
            this.contacto = contacto;
            this.foto = foto;
        }

        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the numero.
        /// </summary>
        /// <value>
        /// The numero.
        /// </value>
        //public int Numero
        //{
        //    get { return numero; }
        //    set { numero = value; }
        //}

        ///// <summary>
        ///// Gets or sets the nome.
        ///// </summary>
        ///// <value>
        ///// The nome.
        ///// </value>
        //public string Nome
        //{
        //    get { return nome; }
        //    set { nome = value; }
        //}

        ///// <summary>
        ///// Gets or sets the data ini atividade.
        ///// </summary>
        ///// <value>
        ///// The data ini atividade.
        ///// </value>
        //public DateTime DataIniAtividade
        //{
        //    get { return dataIniAtividade; }
        //    set { dataIniAtividade = value; }
        //}

        /// <summary>
        /// Gets or sets the associacao.
        /// </summary>
        /// <value>
        /// The associacao.
        /// </value>
        public string Associacao
        {
            get { return associacao; }
            set { associacao = value; }
        }

        /// <summary>
        /// Gets or sets the contacto.
        /// </summary>
        /// <value>
        /// The contacto.
        /// </value>
        public string Contacto
        {
            get { return contacto; }
            set { contacto = value; }
        }

        /// <summary>
        /// Gets or sets the foto.
        /// </summary>
        /// <value>
        /// The foto.
        /// </value>
        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        #endregion

        #region Override / Operadores

        /// <summary>
        /// Overide ToString()
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return("Nome: " + nome);
        }

        #endregion

        #region Metodos
        #endregion

    }
}
#endregion