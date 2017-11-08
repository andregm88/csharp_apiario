#region USINGs
using LP2_Final_Colmeia_11198.BusinessObjects;
using LP2_Final_Colmeia_11198.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
#endregion

namespace LP2_Final_Colmeia_11198
{
    class Aplicacao
    {
        [STAThread]
        static void Main(string[] args)
        {
            GestorApiario.LoadApiario("ListaApiarios.my");
            GestorApiario.LoadApicultor("ListaApicultores.my");

           
            #region CRIA / GUARDA APICULTOR

            //Cria apicultor
            Apicultor andre = new Apicultor(14, "Andre", DateTime.Now, "Associacao XPTO", "914425158", "Caminho da foto perfil ANDRE");
            Apicultor luis = new Apicultor(2, "Luis", DateTime.Now, "Associacao XPTO", "914425158", "Caminho da foto perfil LUIS");

            //Guarda apicultuor

            bool ga = false;
            try
            {
                ga = BusinessRules.BusinessRules.GuardaApicultorBR(andre);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("\nGuarda Apicultor: {0}", ga.ToString());
            }

            ga = false;

            try
            {
                ga = BusinessRules.BusinessRules.GuardaApicultorBR(luis);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("\nGuarda Apicultor: {0}", ga.ToString());
            }



            #endregion

            #region CRIA / GUARDA APIARIO

            //Cria apiario
            Apiario ap1 = new Apiario(1, andre.Numero);

            Apiario ap2 = new Apiario(2, luis.Numero);

            //Guarda Apiario
            bool ia = false;
            try
            {
                ia = BusinessRules.BusinessRules.GuardaApiario(ap1);
            }
            catch (ApiarioException a)
            {
                Console.WriteLine(a.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("\nGuarda Apiario: {0}\n", ia.ToString());
            }

            ia = false;

            try
            {
                ia = BusinessRules.BusinessRules.GuardaApiario(ap2);
            }
            catch (ApiarioException a)
            {
                Console.WriteLine(a.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("\nGuarda Apiario: {0}\n", ia.ToString());
            }



            #endregion

            #region Cria Localização
            //Cria Localizações
            Localizacao local = new Localizacao("10.000", "20,000");
            #endregion

            #region Cria / Guarda Colmeia
            ////Cria colmeia
            ColmeiaInt c1 = new ColmeiaInt(1, "BAHSHDHASD", TipoColmeia.longstroth, local, DateTime.Now);
            ColmeiaInt c2 = new ColmeiaInt(2, "Foto colmeia c2", TipoColmeia.reversivel, local, DateTime.Now);

            //regista colmeia no apiario 1
            bool vRegistaColmeia = false;

            try
            {
                vRegistaColmeia = BusinessRules.BusinessRules.RegistaColmeiaNoApiario(1, c1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("Regista Colmeia no Apiario: {0}", vRegistaColmeia.ToString());
            }

            vRegistaColmeia = false;

            try
            {
                vRegistaColmeia = BusinessRules.BusinessRules.RegistaColmeiaNoApiario(2, c2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("Regista Colmeia no Apiario: {0}", vRegistaColmeia.ToString());
            }


            #endregion

            #region Consulta Colmeia

            //Consulta colmeia basico
            ColmeiaLight cln = null;
            try
            {

                cln = BusinessRules.BusinessRules.ConsultaColmeiaLightBR(1, 1);
            }
            catch (Exception a)
            {
                Console.WriteLine(a.ToString());
            }


            Console.WriteLine("\nConsulta informacao basica colmeia:\n");

            if (cln != null)
            {
                Console.WriteLine(cln.ToString());
            }

            #endregion

            #region Metodo RemoveColmeia

            //bool rc = false;

            //try
            //{
            //    rc = BusinessRules.BusinessRules.RemoveColmeiaBR(2, 4);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.ToString());
            //}
            //finally
            //{
            //    Console.WriteLine("\nRemove colmeia: {0}\n", rc.ToString());
            //}


            #endregion

            #region Cria / Insere Intervencao na colmeia

            //Cria intervencao
            Intervencao int1 = new Intervencao("Nao faz nada", DateTime.Now);

            //Insere intervencao na colmeia
            bool validaInsereInt = false;

            try
            {
                validaInsereInt = BusinessRules.BusinessRules.RegistaIntervencaoColmeiaBR(1, 1, int1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("\nRegistaIntervencaoColmeia: {0}\n", validaInsereInt.ToString());
            }

            #endregion

            #region Consulta Intervencoes Colmeia

            //Consulta colmeia Intervencoes
            ColmeiaInt cin = null;

            try
            {
                cin = BusinessRules.BusinessRules.ConsultaColmeiaIntApiarioBR(1, 1);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            if (cin != null)
            {
                foreach (Intervencao i in cin.ListaIntervencao)
                {
                    Console.WriteLine("\n" + i.ToString() + "\n");
                }
            }

            #endregion

            #region Consulta Localizacao Colmeias

            //Consulta LocalizacaoColmeia
            Localizacao[] localizacoes = null;

            try
            {
                localizacoes = BusinessRules.BusinessRules.ConsultaLocalizacoesColmeiasBR(1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            if (localizacoes != null)
            {

                Console.WriteLine("\nLocalizacoes: {0}\n", localizacoes.Length.ToString());
                foreach (Localizacao l in localizacoes)
                {
                    Console.WriteLine(l.ToString());
                }
            }
            
            #endregion

            #region Agenda Tarefa Apiario

            //Cria tarefa
            Tarefa tf = new Tarefa(TipoTarefa.cresta, DateTime.Now);

            bool at = false;

            try
            {
                at = BusinessRules.BusinessRules.AgendaTarefaBR(1, tf);
                at = BusinessRules.BusinessRules.AgendaTarefaBR(1, tf);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n" + e.ToString());
            }
            finally
            {
                Console.WriteLine("\nAgenda Tarefa: {0}\n", at.ToString());
            }

            #endregion

            #region Consulta Agenda Apiario

            List<Tarefa> agendaT = null;

            try
            {
                agendaT = BusinessRules.BusinessRules.ConsultaAgendaApiarioBR(1, DateTime.Parse("20-06-2015"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                if (agendaT != null)
                {
                    Console.WriteLine("\nConsulta Agenda: {0} tarefas\n", agendaT.Count);

                    foreach (Tarefa t in agendaT)
                    {
                        Console.WriteLine(t.ToString()+"\n");
                    }
                }
                else Console.WriteLine("\nLista Tarefas Vazia");
            }


            
            #endregion

            Application.EnableVisualStyles();
            FormHome novo = new FormHome();
            Application.Run(novo);


            GestorApiario.SaveApiario("ListaApiarios.my");
            GestorApiario.SaveApicultores("ListaApicultores.my");

            GestorApiario.Clear();



        }
    }
}
