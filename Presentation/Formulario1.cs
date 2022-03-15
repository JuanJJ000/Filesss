using Appcore.IService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Formulario1 : Form
    {
        string rutapath= string.Empty;
        ITexto texto;
        public Formulario1(ITexto Texto)
        {
            this.texto = Texto;
            InitializeComponent();
        }
        private void Formulario1_Load(object sender, EventArgs e)
        {


        }

        private void LoadFolder(TreeNodeCollection nodes, DirectoryInfo folder)
        {
            var newNode = nodes.Add(folder.Name);
            foreach (var childFolder in folder.EnumerateDirectories())
            {
                LoadFolder(newNode.Nodes, childFolder);
            }
            foreach (FileInfo file in folder.EnumerateFiles())
            {
                newNode.Nodes.Add(file.Name);
            }
        }

        #region menustrip
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            rchtbxDatos.Text = string.Empty;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treevwFiles.Nodes.Clear();
            openFileDialog1.Title = "Abrir carpeta... ";

            string text = string.Empty;

            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rutapath = Path.GetDirectoryName(openFileDialog1.FileName);
                LoadFolder(treevwFiles.Nodes, new DirectoryInfo(Path.GetDirectoryName(openFileDialog1.FileName)));

            }


        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            saveFileDialog1.Title = "Guardar archivo como... ";

            string text = string.Empty;

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = false;
             if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(saveFileDialog1.FileName))
                {
                    MessageBox.Show(rchtbxDatos.Text);
                    string txt = saveFileDialog1.FileName;
                    texto.Add(rchtbxDatos.Text, txt);
                   
                   
                }
                else                
                {
                    MessageBox.Show(rchtbxDatos.Text);
                    string txt = saveFileDialog1.FileName;
                    texto.Add(rchtbxDatos.Text, txt);
                  
                }


            }
            rchtbxDatos.Text = string.Empty;
        }

        private void treevwFiles_DoubleClick(object sender, EventArgs e)
        {
           rchtbxDatos.Text = string.Empty;
            string textos = string.Empty;

            textos = rutapath + "\\" + treevwFiles.SelectedNode.Text;
           
            rchtbxDatos.Text = texto.Read((textos));


        }
    }


    #endregion
}