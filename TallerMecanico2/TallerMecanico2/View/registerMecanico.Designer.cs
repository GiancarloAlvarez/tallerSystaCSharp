
namespace TallerMecanico2.View
{
    partial class registerMecanico
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMecanicoC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMecanicoA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMecanicoN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMecaG = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgMecanico = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMecaS = new FontAwesome.Sharp.IconButton();
            this.btnMecaD = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnMecaE = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMecanico)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMecanicoC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMecanicoA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMecanicoN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 459);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mecanico";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(13, 285);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(318, 20);
            this.txtFecha.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha_nac";
            // 
            // txtMecanicoC
            // 
            this.txtMecanicoC.Location = new System.Drawing.Point(13, 221);
            this.txtMecanicoC.Name = "txtMecanicoC";
            this.txtMecanicoC.Size = new System.Drawing.Size(318, 20);
            this.txtMecanicoC.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cedula";
            // 
            // txtMecanicoA
            // 
            this.txtMecanicoA.Location = new System.Drawing.Point(13, 150);
            this.txtMecanicoA.Name = "txtMecanicoA";
            this.txtMecanicoA.Size = new System.Drawing.Size(318, 20);
            this.txtMecanicoA.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellido";
            // 
            // txtMecanicoN
            // 
            this.txtMecanicoN.Location = new System.Drawing.Point(13, 83);
            this.txtMecanicoN.Name = "txtMecanicoN";
            this.txtMecanicoN.Size = new System.Drawing.Size(318, 20);
            this.txtMecanicoN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // btnMecaG
            // 
            this.btnMecaG.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMecaG.IconColor = System.Drawing.Color.Black;
            this.btnMecaG.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMecaG.Location = new System.Drawing.Point(48, 45);
            this.btnMecaG.Name = "btnMecaG";
            this.btnMecaG.Size = new System.Drawing.Size(71, 50);
            this.btnMecaG.TabIndex = 3;
            this.btnMecaG.Text = "Insertar";
            this.btnMecaG.UseVisualStyleBackColor = true;
            this.btnMecaG.Click += new System.EventHandler(this.btnMecaG_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.dgMecanico);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(371, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 333);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // dgMecanico
            // 
            this.dgMecanico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMecanico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMecanico.Location = new System.Drawing.Point(3, 16);
            this.dgMecanico.Name = "dgMecanico";
            this.dgMecanico.Size = new System.Drawing.Size(473, 314);
            this.dgMecanico.TabIndex = 0;
            this.dgMecanico.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMecanico_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMecaS);
            this.groupBox3.Controls.Add(this.btnMecaD);
            this.groupBox3.Controls.Add(this.iconButton2);
            this.groupBox3.Controls.Add(this.btnMecaE);
            this.groupBox3.Controls.Add(this.btnMecaG);
            this.groupBox3.Location = new System.Drawing.Point(382, 372);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(468, 132);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // btnMecaS
            // 
            this.btnMecaS.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMecaS.IconColor = System.Drawing.Color.Black;
            this.btnMecaS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMecaS.Location = new System.Drawing.Point(356, 45);
            this.btnMecaS.Name = "btnMecaS";
            this.btnMecaS.Size = new System.Drawing.Size(71, 50);
            this.btnMecaS.TabIndex = 3;
            this.btnMecaS.Text = "Mostrar";
            this.btnMecaS.UseVisualStyleBackColor = true;
            this.btnMecaS.Click += new System.EventHandler(this.btnMecaS_Click);
            // 
            // btnMecaD
            // 
            this.btnMecaD.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMecaD.IconColor = System.Drawing.Color.Black;
            this.btnMecaD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMecaD.Location = new System.Drawing.Point(279, 45);
            this.btnMecaD.Name = "btnMecaD";
            this.btnMecaD.Size = new System.Drawing.Size(71, 50);
            this.btnMecaD.TabIndex = 3;
            this.btnMecaD.Text = "Borrar";
            this.btnMecaD.UseVisualStyleBackColor = true;
            this.btnMecaD.Click += new System.EventHandler(this.btnMecaD_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(202, 45);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(71, 50);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.Text = "Limpiar";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnMecaE
            // 
            this.btnMecaE.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMecaE.IconColor = System.Drawing.Color.Black;
            this.btnMecaE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMecaE.Location = new System.Drawing.Point(125, 45);
            this.btnMecaE.Name = "btnMecaE";
            this.btnMecaE.Size = new System.Drawing.Size(71, 50);
            this.btnMecaE.TabIndex = 3;
            this.btnMecaE.Text = "Editar";
            this.btnMecaE.UseVisualStyleBackColor = true;
            this.btnMecaE.Click += new System.EventHandler(this.btnMecaE_Click);
            // 
            // registerMecanico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(862, 542);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "registerMecanico";
            this.Text = "registerMecanico";
            this.Load += new System.EventHandler(this.registerMecanico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMecanico)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnMecaG;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMecanicoC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMecanicoA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMecanicoN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgMecanico;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton btnMecaD;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnMecaE;
        private FontAwesome.Sharp.IconButton btnMecaS;
    }
}