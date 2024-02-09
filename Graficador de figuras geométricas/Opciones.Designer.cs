namespace Graficador_de_figuras_geométricas
{
    partial class Opciones
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpbx_Data = new System.Windows.Forms.GroupBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.lbl_Color = new System.Windows.Forms.Label();
            this.cmbx_Colores = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.grpbx_Data.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // grpbx_Data
            // 
            this.grpbx_Data.BackColor = System.Drawing.SystemColors.Control;
            this.grpbx_Data.Controls.Add(this.cmbx_Colores);
            this.grpbx_Data.Controls.Add(this.btn_Guardar);
            this.grpbx_Data.Controls.Add(this.lbl_Color);
            this.grpbx_Data.Location = new System.Drawing.Point(92, 40);
            this.grpbx_Data.Name = "grpbx_Data";
            this.grpbx_Data.Size = new System.Drawing.Size(173, 200);
            this.grpbx_Data.TabIndex = 13;
            this.grpbx_Data.TabStop = false;
            this.grpbx_Data.Text = "Modificar vista";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(49, 133);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(80, 24);
            this.btn_Guardar.TabIndex = 10;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // lbl_Color
            // 
            this.lbl_Color.AutoSize = true;
            this.lbl_Color.Location = new System.Drawing.Point(16, 57);
            this.lbl_Color.Name = "lbl_Color";
            this.lbl_Color.Size = new System.Drawing.Size(86, 13);
            this.lbl_Color.TabIndex = 7;
            this.lbl_Color.Text = "Color del gráfico:";
            // 
            // cmbx_Colores
            // 
            this.cmbx_Colores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_Colores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbx_Colores.FormattingEnabled = true;
            this.cmbx_Colores.Location = new System.Drawing.Point(29, 84);
            this.cmbx_Colores.Name = "cmbx_Colores";
            this.cmbx_Colores.Size = new System.Drawing.Size(121, 21);
            this.cmbx_Colores.TabIndex = 11;
            // 
            // Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 291);
            this.ControlBox = false;
            this.Controls.Add(this.grpbx_Data);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Opciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graficador de figuras geométricas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpbx_Data.ResumeLayout(false);
            this.grpbx_Data.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpbx_Data;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label lbl_Color;
        private System.Windows.Forms.ComboBox cmbx_Colores;
    }
}