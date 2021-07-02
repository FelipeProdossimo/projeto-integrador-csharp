using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchCompany
{
    public partial class frmItem : Form
    {
        public frmItem()
        {
            InitializeComponent();
        }

        private void btnArquivo_Click(object sender, EventArgs e)
        {
            Janela.InitialDirectory = "C://Desktop";
            Janela.Title = "Selecione uma imagem.";
            Janela.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            Janela.FilterIndex = 1;
            try
            {
                if (Janela.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (Janela.CheckFileExists)
                    {
                        string caminhoDaImagem = System.IO.Path.GetFullPath(Janela.FileName);
                        lblCaminhoDaImagem.Text = caminhoDaImagem;
                        picImagem.Image = new Bitmap(picImagem.FileName);
                        picImagem.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    MessageBox.Show("Realize o upload da imagem.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
