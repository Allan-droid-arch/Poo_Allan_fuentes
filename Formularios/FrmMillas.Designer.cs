namespace POO_Allan_Fuentes.Formularios
{
    partial class FrmMillas
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
            this.label1 = new System.Windows.Forms.Label();
            this.milla = new System.Windows.Forms.TextBox();
            this.btnKilometros = new System.Windows.Forms.Button();
            this.btnmetros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese las millas";
            // 
            // milla
            // 
            this.milla.Location = new System.Drawing.Point(134, 35);
            this.milla.Name = "milla";
            this.milla.Size = new System.Drawing.Size(100, 25);
            this.milla.TabIndex = 1;
            // 
            // btnKilometros
            // 
            this.btnKilometros.Location = new System.Drawing.Point(12, 108);
            this.btnKilometros.Name = "btnKilometros";
            this.btnKilometros.Size = new System.Drawing.Size(88, 30);
            this.btnKilometros.TabIndex = 2;
            this.btnKilometros.Text = "Kilometros";
            this.btnKilometros.UseVisualStyleBackColor = true;
            this.btnKilometros.Click += new System.EventHandler(this.btnKilometros_Click);
            // 
            // btnmetros
            // 
            this.btnmetros.Location = new System.Drawing.Point(166, 108);
            this.btnmetros.Name = "btnmetros";
            this.btnmetros.Size = new System.Drawing.Size(88, 30);
            this.btnmetros.TabIndex = 3;
            this.btnmetros.Text = "Metros";
            this.btnmetros.UseVisualStyleBackColor = true;
            this.btnmetros.Click += new System.EventHandler(this.btnmetros_Click);
            // 
            // FrmMillas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(381, 276);
            this.Controls.Add(this.btnmetros);
            this.Controls.Add(this.btnKilometros);
            this.Controls.Add(this.milla);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMillas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Millas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox milla;
        private System.Windows.Forms.Button btnKilometros;
        private System.Windows.Forms.Button btnmetros;
    }
}