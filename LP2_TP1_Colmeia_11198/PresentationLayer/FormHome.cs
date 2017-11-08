using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LP2_Final_Colmeia_11198.BusinessObjects;

namespace LP2_Final_Colmeia_11198
{
    public partial class FormHome : Form
    {

        string caminhoFoto = string.Empty;
        public FormHome()
        {
            InitializeComponent();

            #region Status

            int tApi, tApiarios, tColmeias;

            tApi = BusinessRules.BusinessRules.ConsultaTotaisBR(out tApiarios, out tColmeias);

            #endregion

            labelNApicultores.Text = "Numero Apicultores: " + tApi.ToString();

            labelNApiarios.Text = "Numero Apiarios: " + tApiarios.ToString();

            labelNColmeias.Text = "Numero Colmeias: " + tColmeias.ToString();

           
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Status_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelTApicultores_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btCriarApicultor_Click(object sender, EventArgs e)
        {
            Form2 nova = new Form2();

            nova.Show();

        }

        private void tabCriaApicultor_Click(object sender, EventArgs e)
        {

        }

        private void FotoPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Ficheiros de imagem|*.jpg;*.jpeg;*.bmp;*.png";
            openFileDialog.Title = "Selecione ficheiro de imagem";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                caminhoFoto = openFileDialog.FileName;
                FotoApitultor.ImageLocation = openFileDialog.FileName;
            }
        }

        private void LimpaFormApiario()
        {
            textCodApicultor.Clear();
            textNomeApicultor.Clear();
            dateDataInicioAtividade.Value = DateTime.Now;
            textContactoApicultor.Clear();
            textAssociacao.Clear();
            FotoApitultor.Refresh();
        }

        private void buttonGravaApicultor_Click(object sender, EventArgs e)
        {

            int codigo = int.Parse(textCodApicultor.Text);

            Apicultor novo = new Apicultor(codigo, textNomeApicultor.Text, dateDataInicioAtividade.Value,textAssociacao.Text, textContactoApicultor.Text, caminhoFoto);

            bool ia = false;
            try
            {
                ia = BusinessRules.BusinessRules.GuardaApicultorBR(novo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                MessageBox.Show("Gravou Apicultor: " + ia.ToString());
            }

            LimpaFormApiario();

        }



    }
}
