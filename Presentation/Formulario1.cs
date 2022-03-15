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
            openFileDialog1.Title = "Abrir archivo... ";

            string text = string.Empty;

            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                text = openFileDialog1.FileName;


                var fileStream = openFileDialog1.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    rchtbxDatos.Text = reader.ReadToEnd();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Abrir carpeta... ";

            string text = string.Empty;

            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

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


            }
        }

        private void treevwFiles_DoubleClick(object sender, EventArgs e)
        {
            rchtbxDatos.Text = string.Empty;
            string textos = string.Empty;

            textos = treevwFiles.SelectedImageKey;
            rchtbxDatos.Text = texto.Read((Path.GetDirectoryName(openFileDialog1.FileName)));




        }
    }


    #endregion




}

