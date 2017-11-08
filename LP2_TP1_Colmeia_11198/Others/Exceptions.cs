#region HEADER
/* LPII - 1º Trabalho Pratico - Gestor de Colmeias
 * Aluno: 11198 - André Martins
 * 
 * LAYER : 
 * CLASSE : Exceptions
 */
#endregion

#region USINGs
using System;
#endregion

namespace LP2_Final_Colmeia_11198
{
    [Serializable]
    public class IntervencoesException : ApplicationException
    {
        string extraMessage;

        public IntervencoesException(string s, Exception e)
        {
            extraMessage = s;
            throw new Exception(e.Message + extraMessage);
        }

        public IntervencoesException(Exception e)
        {
            throw new Exception("CAO");
        }

        public string ExtraMessage
        {
            get { return extraMessage; }
            set { extraMessage = value; }
        }
    }


    public class ColmeiaException : ApplicationException
    {

        string extraMessage;

        public ColmeiaException(string s, Exception e)
        {
            extraMessage = s;
            throw new Exception(e.Message + extraMessage);
        }

    }

    public class ApiarioException : ApplicationException
    {
        public ApiarioException()
        {
        }

        public ApiarioException(string message)
            : base(message)
        {
        }

        public ApiarioException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
