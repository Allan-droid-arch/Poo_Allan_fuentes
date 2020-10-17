namespace POO_Allan_Fuentes.Formularios
{
    partial class Frmpromedio4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnagregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nota = new System.Windows.Forms.TextBox();
            this.listnota = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(256, 24);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 30);
            this.btnagregar.TabIndex = 0;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nota";
            // 
            // nota
            // 
            this.nota.Location = new System.Drawing.Point(107, 22);
            this.nota.Name = "nota";
            this.nota.Size = new System.Drawing.Size(100, 25);
            this.nota.TabIndex = 2;
            // 
            // listnota
            // 
            this.listnota.FormattingEnabled = true;
            this.listnota.ItemHeight = 20;
            this.listnota.Location = new System.Drawing.Point(107, 79);
            this.listnota.Name = "listnota";
            this.listnota.Size = new System.Drawing.Size(120, 84);
            this.listnota.TabIndex = 3;
            // 
            // Frmpromedio4
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(376, 292);
            this.Controls.Add(this.listnota);
            this.Controls.Add(this.nota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnagregar);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frmpromedio4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promedio 4 calificaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nota;
        private System.Windows.Forms.ListBox listnota;
    }
}