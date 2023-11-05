namespace Graficador_de_figuras_geométricas
{
    partial class Inicio
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
            this.rdbtn_Circulo = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pctbx_visualizer = new System.Windows.Forms.PictureBox();
            this.rdbtn_Cuadrado = new System.Windows.Forms.RadioButton();
            this.rdbtn_Rectangulo = new System.Windows.Forms.RadioButton();
            this.rdbtn_Triangulo = new System.Windows.Forms.RadioButton();
            this.txtbx_base_radio_ladoX = new System.Windows.Forms.TextBox();
            this.lbl_base_radio_lado = new System.Windows.Forms.Label();
            this.txtbx_alturaY = new System.Windows.Forms.TextBox();
            this.lbl_altura = new System.Windows.Forms.Label();
            this.btn_graficar = new System.Windows.Forms.Button();
            this.rdbtn_empty = new System.Windows.Forms.RadioButton();
            this.grpbx_Data = new System.Windows.Forms.GroupBox();
            this.lbl_none = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_visualizer)).BeginInit();
            this.grpbx_Data.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbtn_Circulo
            // 
            this.rdbtn_Circulo.AutoSize = true;
            this.rdbtn_Circulo.Location = new System.Drawing.Point(12, 73);
            this.rdbtn_Circulo.Name = "rdbtn_Circulo";
            this.rdbtn_Circulo.Size = new System.Drawing.Size(57, 17);
            this.rdbtn_Circulo.TabIndex = 0;
            this.rdbtn_Circulo.TabStop = true;
            this.rdbtn_Circulo.Text = "Circulo";
            this.rdbtn_Circulo.UseVisualStyleBackColor = true;
            this.rdbtn_Circulo.CheckedChanged += new System.EventHandler(this.rdbtn_Circulo_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // pctbx_visualizer
            // 
            this.pctbx_visualizer.Location = new System.Drawing.Point(292, 38);
            this.pctbx_visualizer.Name = "pctbx_visualizer";
            this.pctbx_visualizer.Size = new System.Drawing.Size(250, 200);
            this.pctbx_visualizer.TabIndex = 2;
            this.pctbx_visualizer.TabStop = false;
            // 
            // rdbtn_Cuadrado
            // 
            this.rdbtn_Cuadrado.AutoSize = true;
            this.rdbtn_Cuadrado.Location = new System.Drawing.Point(12, 96);
            this.rdbtn_Cuadrado.Name = "rdbtn_Cuadrado";
            this.rdbtn_Cuadrado.Size = new System.Drawing.Size(71, 17);
            this.rdbtn_Cuadrado.TabIndex = 3;
            this.rdbtn_Cuadrado.TabStop = true;
            this.rdbtn_Cuadrado.Text = "Cuadrado";
            this.rdbtn_Cuadrado.UseVisualStyleBackColor = true;
            this.rdbtn_Cuadrado.CheckedChanged += new System.EventHandler(this.rdbtn_Cuadrado_CheckedChanged);
            // 
            // rdbtn_Rectangulo
            // 
            this.rdbtn_Rectangulo.AutoSize = true;
            this.rdbtn_Rectangulo.Location = new System.Drawing.Point(12, 119);
            this.rdbtn_Rectangulo.Name = "rdbtn_Rectangulo";
            this.rdbtn_Rectangulo.Size = new System.Drawing.Size(80, 17);
            this.rdbtn_Rectangulo.TabIndex = 4;
            this.rdbtn_Rectangulo.TabStop = true;
            this.rdbtn_Rectangulo.Text = "Rectángulo";
            this.rdbtn_Rectangulo.UseVisualStyleBackColor = true;
            this.rdbtn_Rectangulo.CheckedChanged += new System.EventHandler(this.rdbtn_Rectangulo_CheckedChanged);
            // 
            // rdbtn_Triangulo
            // 
            this.rdbtn_Triangulo.AutoSize = true;
            this.rdbtn_Triangulo.Location = new System.Drawing.Point(12, 142);
            this.rdbtn_Triangulo.Name = "rdbtn_Triangulo";
            this.rdbtn_Triangulo.Size = new System.Drawing.Size(69, 17);
            this.rdbtn_Triangulo.TabIndex = 5;
            this.rdbtn_Triangulo.TabStop = true;
            this.rdbtn_Triangulo.Text = "Triángulo";
            this.rdbtn_Triangulo.UseVisualStyleBackColor = true;
            this.rdbtn_Triangulo.CheckedChanged += new System.EventHandler(this.rdbtn_Triangulo_CheckedChanged);
            // 
            // txtbx_base_radio_ladoX
            // 
            this.txtbx_base_radio_ladoX.Location = new System.Drawing.Point(40, 52);
            this.txtbx_base_radio_ladoX.Name = "txtbx_base_radio_ladoX";
            this.txtbx_base_radio_ladoX.Size = new System.Drawing.Size(100, 20);
            this.txtbx_base_radio_ladoX.TabIndex = 6;
            // 
            // lbl_base_radio_lado
            // 
            this.lbl_base_radio_lado.AutoSize = true;
            this.lbl_base_radio_lado.Location = new System.Drawing.Point(17, 36);
            this.lbl_base_radio_lado.Name = "lbl_base_radio_lado";
            this.lbl_base_radio_lado.Size = new System.Drawing.Size(104, 13);
            this.lbl_base_radio_lado.TabIndex = 7;
            this.lbl_base_radio_lado.Text = "Base - Radio - Lado:";
            // 
            // txtbx_alturaY
            // 
            this.txtbx_alturaY.Location = new System.Drawing.Point(40, 101);
            this.txtbx_alturaY.Name = "txtbx_alturaY";
            this.txtbx_alturaY.Size = new System.Drawing.Size(100, 20);
            this.txtbx_alturaY.TabIndex = 8;
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Location = new System.Drawing.Point(17, 85);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(37, 13);
            this.lbl_altura.TabIndex = 9;
            this.lbl_altura.Text = "Altura:";
            // 
            // btn_graficar
            // 
            this.btn_graficar.Location = new System.Drawing.Point(50, 141);
            this.btn_graficar.Name = "btn_graficar";
            this.btn_graficar.Size = new System.Drawing.Size(80, 24);
            this.btn_graficar.TabIndex = 10;
            this.btn_graficar.Text = "Graficar";
            this.btn_graficar.UseVisualStyleBackColor = true;
            // 
            // rdbtn_empty
            // 
            this.rdbtn_empty.AutoSize = true;
            this.rdbtn_empty.Location = new System.Drawing.Point(12, 164);
            this.rdbtn_empty.Name = "rdbtn_empty";
            this.rdbtn_empty.Size = new System.Drawing.Size(51, 17);
            this.rdbtn_empty.TabIndex = 11;
            this.rdbtn_empty.TabStop = true;
            this.rdbtn_empty.Text = "None";
            this.rdbtn_empty.UseVisualStyleBackColor = true;
            this.rdbtn_empty.CheckedChanged += new System.EventHandler(this.rdbtn_empty_CheckedChanged);
            // 
            // grpbx_Data
            // 
            this.grpbx_Data.Controls.Add(this.lbl_none);
            this.grpbx_Data.Controls.Add(this.btn_graficar);
            this.grpbx_Data.Controls.Add(this.lbl_altura);
            this.grpbx_Data.Controls.Add(this.txtbx_alturaY);
            this.grpbx_Data.Controls.Add(this.lbl_base_radio_lado);
            this.grpbx_Data.Controls.Add(this.txtbx_base_radio_ladoX);
            this.grpbx_Data.Location = new System.Drawing.Point(98, 38);
            this.grpbx_Data.Name = "grpbx_Data";
            this.grpbx_Data.Size = new System.Drawing.Size(173, 200);
            this.grpbx_Data.TabIndex = 12;
            this.grpbx_Data.TabStop = false;
            this.grpbx_Data.Text = "Datos";
            // 
            // lbl_none
            // 
            this.lbl_none.Location = new System.Drawing.Point(6, 54);
            this.lbl_none.Name = "lbl_none";
            this.lbl_none.Size = new System.Drawing.Size(161, 71);
            this.lbl_none.TabIndex = 11;
            this.lbl_none.Text = "Elige una de las opciones para comenzar a graficar tu figura geométrica!";
            this.lbl_none.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.grpbx_Data);
            this.Controls.Add(this.rdbtn_empty);
            this.Controls.Add(this.rdbtn_Triangulo);
            this.Controls.Add(this.rdbtn_Rectangulo);
            this.Controls.Add(this.rdbtn_Cuadrado);
            this.Controls.Add(this.pctbx_visualizer);
            this.Controls.Add(this.rdbtn_Circulo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_visualizer)).EndInit();
            this.grpbx_Data.ResumeLayout(false);
            this.grpbx_Data.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbtn_Circulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pctbx_visualizer;
        private System.Windows.Forms.RadioButton rdbtn_Cuadrado;
        private System.Windows.Forms.RadioButton rdbtn_Rectangulo;
        private System.Windows.Forms.RadioButton rdbtn_Triangulo;
        private System.Windows.Forms.TextBox txtbx_base_radio_ladoX;
        private System.Windows.Forms.Label lbl_base_radio_lado;
        private System.Windows.Forms.TextBox txtbx_alturaY;
        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.Button btn_graficar;
        private System.Windows.Forms.RadioButton rdbtn_empty;
        private System.Windows.Forms.GroupBox grpbx_Data;
        private System.Windows.Forms.Label lbl_none;
    }
}

