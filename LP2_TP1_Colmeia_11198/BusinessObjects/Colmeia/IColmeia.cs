#region HEADER
/* LPII - 1º Trabalho Pratico - Gestor de Colmeias
 * Aluno: 11198 - André Martins
 * 
 * LAYER : Business Object
 * Interface : IColmeia
 */
#endregion

#region USINGs
using System;
#endregion

#region Interface Colmeia
namespace LP2_Final_Colmeia_11198.BusinessObjects
{
    /// <summary>
    /// Interface - Colmeia
    /// Interface que define atributos e metodos da colmeia
    /// </summary>
    interface IColmeia
    {
        int NumColmeia { get; set; }
        int NumApiario { get; set; }
        int NumApicultor { get; set; }
        string Foto { get; set; }
        TipoColmeia Tipo { get; set; }
        Localizacao Local { get; set; }
        DateTime DataConstrucao { get; set; }
    }
}
#endregion