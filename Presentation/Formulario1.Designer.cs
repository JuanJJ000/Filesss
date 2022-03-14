
namespace Presentation
{
    partial class Formulario1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tvwFiles = new System.Windows.Forms.TreeView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.rchtbxDatos = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tvwFiles
            // 
            this.tvwFiles.Location = new System.Drawing.Point(1, 23);
            this.tvwFiles.Name = "tvwFiles";
            this.tvwFiles.Size = new System.Drawing.Size(121, 303);
            this.tvwFiles.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // rchtbxDatos
            // 
            this.rchtbxDatos.Location = new System.Drawing.Point(404, 83);
            this.rchtbxDatos.Name = "rchtbxDatos";
            this.rchtbxDatos.Size = new System.Drawing.Size(100, 96);
            this.rchtbxDatos.TabIndex = 1;
            this.rchtbxDatos.Text = "";
            // 
            // Formulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rchtbxDatos);
            this.Controls.Add(this.tvwFiles);
            this.Name = "Formulario1";
            this.Text = "Documents";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvwFiles;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox rchtbxDatos;
    }
}

