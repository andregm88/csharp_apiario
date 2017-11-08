#region HEADER
/* LPII - 1º Trabalho Pratico - Gestor de Colmeias
 * Aluno: 11198 - André Martins
 * 
 * LAYER : BussinessObjects
 * CLASSE ABSTRACTA : AbsApicultor
 */
#endregion

#region USINGs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

#region Classe Abstracta - Apicultor
namespace LP2_Final_Colmeia_11198.BusinessObjects
{
    [Serializable]
    abstract class AbsApicultor
    {
        #region ESTADO
        protected int numero;
        protected string nome;
        protected DateTime dataIniAtividade;
        #endregion

        #region PROPERTIES
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        /// <summary>
        /// Gets or sets the nome.
        /// </summary>
        /// <value>
        /// The nome.
        /// </value>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Gets or sets the data ini atividade.
        /// </summary>
        /// <value>
        /// The data ini atividade.
        /// </value>
        public DateTime DataIniAtividade
        {
            get { return dataIniAtividade; }
            set { dataIniAtividade = value; }
        }
        #endregion
    }
}
#endregion
