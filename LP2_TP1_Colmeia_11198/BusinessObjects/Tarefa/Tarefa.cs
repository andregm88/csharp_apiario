#region HEADER
/* LPII - 1º Trabalho Pratico - Gestor de Colmeias
 * Aluno: 11198 - André Martins
 * 
 * LAYER : Business Object
 * CLASSE : Tarefa
 */
#endregion

#region USINGs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace LP2_Final_Colmeia_11198.BusinessObjects
{

    #region Enumerado TipoTarefa
    [Serializable]
    public enum TipoTarefa
    {
        desinfeccaoColmeias = 0,
        gestaoAlcas = 1,
        cresta = 2
    }

    #endregion

    #region Classe Tarefa
    [Serializable]
    class Tarefa
    {
        #region ESTADO

        private TipoTarefa tipo;
        private DateTime dataInicio;
        
        #endregion

        #region CONSTRUTORES

        public Tarefa(TipoTarefa tipo, DateTime data)
        {
            this.tipo = tipo;
            this.dataInicio = data;
        }
        #endregion

        #region PROPERTIES

        public TipoTarefa Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public DateTime DataInicio
        {
            get { return dataInicio; }
            set { dataInicio = value; }
        }

        #endregion


        #region Overrides

        public override string ToString()
        {
            string dt = "";
            if (this.tipo == TipoTarefa.cresta) dt = "Cresta Apanha do Mel";
            if (this.tipo == TipoTarefa.desinfeccaoColmeias) dt = "Desinfeccao de Colmeias";
            if (this.tipo == TipoTarefa.gestaoAlcas) dt = "Gestao Alcas";

            return ("Data Tarefa: " + this.dataInicio.ToString() + " Tipo Tarefa: " + dt);
        }
        #endregion

    }
}
    #endregion
