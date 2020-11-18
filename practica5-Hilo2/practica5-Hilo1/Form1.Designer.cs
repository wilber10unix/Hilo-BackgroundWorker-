namespace practica5_Hilo1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsdtipoletra = new System.Windows.Forms.ToolStripDropDownButton();
            this.wideeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tstamañoletra = new System.Windows.Forms.ToolStripComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ncaracteres = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nfilas = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.RichTextBox();
            this.hiloTrabajador = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 267);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(771, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsdtipoletra,
            this.tstamañoletra});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(771, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsdtipoletra
            // 
            this.tsdtipoletra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsdtipoletra.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wideeToolStripMenuItem,
            this.arialToolStripMenuItem});
            this.tsdtipoletra.Image = ((System.Drawing.Image)(resources.GetObject("tsdtipoletra.Image")));
            this.tsdtipoletra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdtipoletra.Name = "tsdtipoletra";
            this.tsdtipoletra.Size = new System.Drawing.Size(164, 22);
            this.tsdtipoletra.Text = "toolStripDropDownButton1";
            this.tsdtipoletra.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // wideeToolStripMenuItem
            // 
            this.wideeToolStripMenuItem.Name = "wideeToolStripMenuItem";
            this.wideeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.wideeToolStripMenuItem.Text = "Wide Latin";
            this.wideeToolStripMenuItem.Click += new System.EventHandler(this.wideeToolStripMenuItem_Click);
            // 
            // arialToolStripMenuItem
            // 
            this.arialToolStripMenuItem.Name = "arialToolStripMenuItem";
            this.arialToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.arialToolStripMenuItem.Text = "Arial";
            this.arialToolStripMenuItem.Click += new System.EventHandler(this.arialToolStripMenuItem_Click);
            // 
            // tstamañoletra
            // 
            this.tstamañoletra.Items.AddRange(new object[] {
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30"});
            this.tstamañoletra.Name = "tstamañoletra";
            this.tstamañoletra.Size = new System.Drawing.Size(75, 25);
            this.tstamañoletra.SelectedIndexChanged += new System.EventHandler(this.tstamañoletra_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Caracteres:";
            // 
            // ncaracteres
            // 
            this.ncaracteres.AutoSize = true;
            this.ncaracteres.Location = new System.Drawing.Point(80, 268);
            this.ncaracteres.Name = "ncaracteres";
            this.ncaracteres.Size = new System.Drawing.Size(35, 13);
            this.ncaracteres.TabIndex = 4;
            this.ncaracteres.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filas:";
            // 
            // nfilas
            // 
            this.nfilas.AutoSize = true;
            this.nfilas.Location = new System.Drawing.Point(169, 268);
            this.nfilas.Name = "nfilas";
            this.nfilas.Size = new System.Drawing.Size(35, 13);
            this.nfilas.TabIndex = 6;
            this.nfilas.Text = "label4";
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(0, 28);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(764, 237);
            this.text.TabIndex = 7;
            this.text.Text = "";
            this.text.TextChanged += new System.EventHandler(this.text_TextChanged);
            // 
            // hiloTrabajador
            // 
            this.hiloTrabajador.WorkerReportsProgress = true;
            this.hiloTrabajador.DoWork += new System.ComponentModel.DoWorkEventHandler(this.hiloTrabajador_DoWork);
            this.hiloTrabajador.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.hiloTrabajador_ProgressChanged);
            this.hiloTrabajador.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.hiloTrabajador_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 289);
            this.Controls.Add(this.text);
            this.Controls.Add(this.nfilas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ncaracteres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Editor de texto con hilos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsdtipoletra;
        private System.Windows.Forms.ToolStripMenuItem wideeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arialToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox tstamañoletra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ncaracteres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nfilas;
        private System.Windows.Forms.RichTextBox text;
        private System.ComponentModel.BackgroundWorker hiloTrabajador;
    }
}

