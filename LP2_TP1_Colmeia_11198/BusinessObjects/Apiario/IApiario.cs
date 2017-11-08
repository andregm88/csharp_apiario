#region HEADER
/* LPII - 1º Trabalho Pratico - Gestor de Colmeias
 * Aluno: 11198 - André Martins
 * 
 * LAYER : Business Object
 * Interface : IApiario
 */
#endregion

#region USINGs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

#region Interface IApiario
namespace LP2_Final_Colmeia_11198.BusinessObjects
{
    interface IApiario
    {
        #region Properties
        List<ColmeiaInt> ListaColmeias { get; set; }

        int NumApiario { get; set; }

        int NumApicultor { get; set; }

        int TotColmeias { get; set; }

        #endregion

        #region Metodos

        bool InsereColmeiaNoApiario(ColmeiaInt novaColmeia);

        #endregion
    }
}
#endregion