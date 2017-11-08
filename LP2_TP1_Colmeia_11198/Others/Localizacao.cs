#region HEADER
/* LPII - 1º Trabalho Pratico - Gestor de Colmeias
 * Aluno: 11198 - André Martins
 * 
 * LAYER : Other
 * CLASSE : Localizacao
 */
#endregion

#region USINGs
using System;
#endregion

#region Classe Localizacao
namespace LP2_Final_Colmeia_11198.BusinessObjects
{
    /// <summary>
    /// Classe : Localizacao
    /// Pretende-se com esta classe criar um tipo de dados para guardar a informação relativa a localizacao, guardando uma latitude e longitude;
    /// </summary>
    [Serializable]
    class Localizacao
    {
        
        #region ESTADO

        private string latitude;
        private string longitude;

        #endregion

        #region CONSTRUTORES

        /// <summary>
        /// Construtor por omissão de Localizacao
        /// </summary>
        public Localizacao()
        {
            this.latitude = "";
            this.Longitude = "";
        }

        /// <summary>
        /// Construtor parametrizado de Localização
        /// </summary>
        /// <param name="latitude">String latitude.</param>
        /// <param name="longitude">String longitude.</param>
        public Localizacao(string latitude, string longitude)
        {
            this.latitude = latitude;
            this.longitude = longitude;
        }

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        /// <value>
        /// Valor da Latitude
        /// </value>
        public string Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        /// <value>
        /// Valor da Longitude
        /// </value>
        public string Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }
        #endregion

        #region METODOS

        #endregion

        #region Overides / Operadores
        /// <summary>
        /// override do metodo ToString para apresentar uma localização
        /// </summary>
        /// <returns>
        /// String com localizacao
        /// </returns>
        public override string ToString()
        {
            return("Latitude: " + latitude.ToString() + "   Longitude: " + longitude.ToString());
        }
        #endregion

    }
}
#endregion