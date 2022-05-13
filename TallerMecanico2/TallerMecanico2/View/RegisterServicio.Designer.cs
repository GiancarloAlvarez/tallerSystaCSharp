
namespace TallerMecanico2.View
{
    partial class RegisterServicio
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
            this.tbCostoS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombreS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnServicioG = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgServicio = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMostrar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnSD = new FontAwesome.Sharp.IconButton();
            this.btnServicioE = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgServicio)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCostoS);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbTipo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbNombreS);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 349);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servicio";
            // 
            // tbCostoS
            // 
            this.tbCostoS.Location = new System.Drawing.Point(13, 221);
            this.tbCostoS.Name = "tbCostoS";
            this.tbCostoS.Size = new System.Drawing.Size(247, 20);
            this.tbCostoS.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Costo";
            // 
            // tbTipo
            // 
            this.tbTipo.Location = new System.Drawing.Point(13, 150);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.Size = new System.Drawing.Size(247, 20);
            this.tbTipo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo_Servicio";
            // 
            // tbNombreS
            // 
            this.tbNombreS.Location = new System.Drawing.Point(13, 83);
            this.tbNombreS.Name = "tbNombreS";
            this.tbNombreS.Size = new System.Drawing.Size(247, 20);
            this.tbNombreS.TabIndex = 1;
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
            // btnServicioG
            // 
            this.btnServicioG.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnServicioG.IconColor = System.Drawing.Color.Black;
            this.btnServicioG.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnServicioG.Location = new System.Drawing.Point(24, 29);
            this.btnServicioG.Name = "btnServicioG";
            this.btnServicioG.Size = new System.Drawing.Size(92, 40);
            this.btnServicioG.TabIndex = 4;
            this.btnServicioG.Text = "Guardar";
            this.btnServicioG.UseVisualStyleBackColor = true;
            this.btnServicioG.Click += new System.EventHandler(this.btnServicioG_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgServicio);
            this.groupBox2.Location = new System.Drawing.Point(377, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 339);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // dgServicio
            // 
            this.dgServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgServicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgServicio.Location = new System.Drawing.Point(3, 16);
            this.dgServicio.Name = "dgServicio";
            this.dgServicio.Size = new System.Drawing.Size(513, 320);
            this.dgServicio.TabIndex = 0;
            this.dgServicio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgServicio_CellContentClick);
            this.dgServicio.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgServicio_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMostrar);
            this.groupBox3.Controls.Add(this.btnLimpiar);
            this.groupBox3.Controls.Add(this.btnSD);
            this.groupBox3.Controls.Add(this.btnServicioE);
            this.groupBox3.Controls.Add(this.btnServicioG);
            this.groupBox3.Location = new System.Drawing.Point(138, 378);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(557, 88);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // btnMostrar
            // 
            this.btnMostrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMostrar.IconColor = System.Drawing.Color.Black;
            this.btnMostrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMostrar.Location = new System.Drawing.Point(316, 29);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(92, 40);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLimpiar.IconColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.Location = new System.Drawing.Point(414, 29);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(92, 40);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSD
            // 
            this.btnSD.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSD.IconColor = System.Drawing.Color.Black;
            this.btnSD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSD.Location = new System.Drawing.Point(218, 29);
            this.btnSD.Name = "btnSD";
            this.btnSD.Size = new System.Drawing.Size(92, 40);
            this.btnSD.TabIndex = 4;
            this.btnSD.Text = "Delete";
            this.btnSD.UseVisualStyleBackColor = true;
            this.btnSD.Click += new System.EventHandler(this.btnSD_Click);
            // 
            // btnServicioE
            // 
            this.btnServicioE.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnServicioE.IconColor = System.Drawing.Color.Black;
            this.btnServicioE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnServicioE.Location = new System.Drawing.Point(122, 29);
            this.btnServicioE.Name = "btnServicioE";
            this.btnServicioE.Size = new System.Drawing.Size(92, 40);
            this.btnServicioE.TabIndex = 4;
            this.btnServicioE.Text = "Edit";
            this.btnServicioE.UseVisualStyleBackColor = true;
            this.btnServicioE.Click += new System.EventHandler(this.btnServicioE_Click);
            // 
            // RegisterServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(908, 478);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegisterServicio";
            this.Text = "RegisterServicio";
            this.Load += new System.EventHandler(this.RegisterServicio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgServicio)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCostoS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombreS;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnServicioG;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgServicio;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton btnMostrar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnSD;
        private FontAwesome.Sharp.IconButton btnServicioE;
    }
}