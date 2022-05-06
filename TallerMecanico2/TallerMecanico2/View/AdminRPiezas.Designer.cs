namespace TallerMecanico2.View
{
    partial class AdminRPiezas
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nEstadoN = new System.Windows.Forms.NumericUpDown();
            this.nTCantidad = new System.Windows.Forms.NumericUpDown();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPNombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgPiezas = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.tBuscarId = new System.Windows.Forms.TextBox();
            this.txBuscar = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnMostrar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnInsert = new FontAwesome.Sharp.IconButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nEstadoN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTCantidad)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPiezas)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nEstadoN);
            this.groupBox2.Controls.Add(this.nTCantidad);
            this.groupBox2.Controls.Add(this.tbPrecio);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtPNombre);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(12, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 462);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Piezas";
            // 
            // nEstadoN
            // 
            this.nEstadoN.Location = new System.Drawing.Point(16, 300);
            this.nEstadoN.Name = "nEstadoN";
            this.nEstadoN.Size = new System.Drawing.Size(120, 20);
            this.nEstadoN.TabIndex = 5;
            // 
            // nTCantidad
            // 
            this.nTCantidad.Location = new System.Drawing.Point(14, 140);
            this.nTCantidad.Name = "nTCantidad";
            this.nTCantidad.Size = new System.Drawing.Size(227, 20);
            this.nTCantidad.TabIndex = 4;
            this.nTCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(16, 201);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(225, 20);
            this.tbPrecio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 260);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado_Nuevo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 185);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Precio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 114);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Cantidad";
            // 
            // txtPNombre
            // 
            this.txtPNombre.Location = new System.Drawing.Point(13, 83);
            this.txtPNombre.Name = "txtPNombre";
            this.txtPNombre.Size = new System.Drawing.Size(228, 20);
            this.txtPNombre.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 56);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nombre";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgPiezas);
            this.groupBox3.Location = new System.Drawing.Point(370, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(805, 407);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // dgPiezas
            // 
            this.dgPiezas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPiezas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPiezas.Location = new System.Drawing.Point(3, 16);
            this.dgPiezas.Name = "dgPiezas";
            this.dgPiezas.Size = new System.Drawing.Size(799, 388);
            this.dgPiezas.TabIndex = 0;
            this.dgPiezas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPiezas_CellDoubleClick);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.iconButton6);
            this.groupBox7.Controls.Add(this.btnBuscar);
            this.groupBox7.Controls.Add(this.tBuscarId);
            this.groupBox7.Controls.Add(this.txBuscar);
            this.groupBox7.Location = new System.Drawing.Point(450, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(529, 73);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            // 
            // iconButton6
            // 
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton6.IconColor = System.Drawing.Color.Black;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton6.IconSize = 24;
            this.iconButton6.Location = new System.Drawing.Point(431, 19);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(68, 34);
            this.iconButton6.TabIndex = 5;
            this.iconButton6.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnBuscar.IconSize = 24;
            this.btnBuscar.Location = new System.Drawing.Point(185, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(68, 34);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // tBuscarId
            // 
            this.tBuscarId.Location = new System.Drawing.Point(6, 19);
            this.tBuscarId.Multiline = true;
            this.tBuscarId.Name = "tBuscarId";
            this.tBuscarId.Size = new System.Drawing.Size(182, 34);
            this.tBuscarId.TabIndex = 4;
            // 
            // txBuscar
            // 
            this.txBuscar.Location = new System.Drawing.Point(284, 19);
            this.txBuscar.Multiline = true;
            this.txBuscar.Name = "txBuscar";
            this.txBuscar.Size = new System.Drawing.Size(150, 34);
            this.txBuscar.TabIndex = 4;
            this.txBuscar.TextChanged += new System.EventHandler(this.txBuscar_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnMostrar);
            this.groupBox5.Controls.Add(this.btnLimpiar);
            this.groupBox5.Controls.Add(this.btnUpdate);
            this.groupBox5.Controls.Add(this.btnInsert);
            this.groupBox5.Location = new System.Drawing.Point(12, 513);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(587, 112);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            // 
            // btnMostrar
            // 
            this.btnMostrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMostrar.IconColor = System.Drawing.Color.Black;
            this.btnMostrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMostrar.Location = new System.Drawing.Point(423, 34);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(119, 50);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLimpiar.IconColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.Location = new System.Drawing.Point(298, 34);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(119, 50);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUpdate.IconColor = System.Drawing.Color.Black;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.Location = new System.Drawing.Point(164, 34);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 50);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnInsert.IconColor = System.Drawing.Color.Black;
            this.btnInsert.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInsert.Location = new System.Drawing.Point(39, 34);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(119, 50);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Guardar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // AdminRPiezas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 637);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "AdminRPiezas";
            this.Text = "AdminRPiezas";
            this.Load += new System.EventHandler(this.AdminRPiezas_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nEstadoN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTCantidad)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPiezas)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nTCantidad;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPNombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgPiezas;
        private System.Windows.Forms.GroupBox groupBox7;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox tBuscarId;
        private System.Windows.Forms.TextBox txBuscar;
        private System.Windows.Forms.GroupBox groupBox5;
        private FontAwesome.Sharp.IconButton btnMostrar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnInsert;
        private System.Windows.Forms.NumericUpDown nEstadoN;
    }
}