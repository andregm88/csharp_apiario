#region HEADER
/* LPII - 1º Trabalho Pratico - Gestor de Colmeias
 * Aluno: 11198 - André Martins
 * 
 * LAYER : Other
 * CLASSE : Intervencao
 */
#endregion

#region USINGs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

#region Classe Intervencao
namespace LP2_Final_Colmeia_11198.BusinessObjects
{
    /// <summary>
    /// Classe Intervencao
    /// Pretende-se atraves desta classe definir os tipos de dados necessarios para guardar a informacao relativa a uma intervencao numa colmeia
    /// </summary>
    [Serializable]
    class Intervencao
    {
        #region ESTADO

        private string descricao;
        private DateTime data;

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor omissao
        /// </summary>
        public Intervencao()
        {
            descricao = "";
            data = DateTime.Now;
        }

        /// <summary>
        /// Construtor parametrizado
        /// </summary>
        /// <param name="descricao">The descricao.</param>
        /// <param name="data">The data.</param>
        public Intervencao(string descricao, DateTime data)
        {
            this.descricao = descricao;
            this.data = data;
        }
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the descricao.
        /// </summary>
        /// <value>
        /// Valor da Descricao
        /// </value>
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// Valor da Data
        /// </value>
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        #endregion

        #region Overrides
        /// <summary>
        /// OverRide do metodo ToString
        /// </summary>
        /// <returns>
        /// String com Intervencao
        /// </returns>
        public override string ToString()
        {
            return ("Data Intervencao: " + data.ToString() + "| Descricao: " + descricao);
        }
        #endregion
    }
}
#endregion