namespace TallerMecanico2.View
{
    partial class RDetalleReparacion
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fechaDet = new System.Windows.Forms.DateTimePicker();
            this.tManoO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCosto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPiezas = new System.Windows.Forms.ComboBox();
            this.tDVehiculo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgDetalleRep = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Clean = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Read = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.tBuscarId = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.comboMec = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleRep)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.fechaDet);
            this.groupBox1.Controls.Add(this.tManoO);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbCosto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbPiezas);
            this.groupBox1.Controls.Add(this.tDVehiculo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 480);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "acerca del vehiculo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Costo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha de registro";
            // 
            // fechaDet
            // 
            this.fechaDet.CustomFormat = "yyyy-MM-dd";
            this.fechaDet.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaDet.Location = new System.Drawing.Point(15, 357);
            this.fechaDet.Name = "fechaDet";
            this.fechaDet.Size = new System.Drawing.Size(200, 20);
            this.fechaDet.TabIndex = 11;
            // 
            // tManoO
            // 
            this.tManoO.Location = new System.Drawing.Point(15, 303);
            this.tManoO.Name = "tManoO";
            this.tManoO.Size = new System.Drawing.Size(200, 20);
            this.tManoO.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Costo mano de obra";
            // 
            // tbCosto
            // 
            this.tbCosto.Location = new System.Drawing.Point(148, 239);
            this.tbCosto.Name = "tbCosto";
            this.tbCosto.Size = new System.Drawing.Size(125, 20);
            this.tbCosto.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Piezas";
            // 
            // cbPiezas
            // 
            this.cbPiezas.FormattingEnabled = true;
            this.cbPiezas.Location = new System.Drawing.Point(12, 239);
            this.cbPiezas.Name = "cbPiezas";
            this.cbPiezas.Size = new System.Drawing.Size(121, 21);
            this.cbPiezas.TabIndex = 6;
            // 
            // tDVehiculo
            // 
            this.tDVehiculo.Location = new System.Drawing.Point(12, 119);
            this.tDVehiculo.MaxLength = 255;
            this.tDVehiculo.Multiline = true;
            this.tDVehiculo.Name = "tDVehiculo";
            this.tDVehiculo.Size = new System.Drawing.Size(364, 81);
            this.tDVehiculo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado_Vehiculo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(462, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mecanico asignado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgDetalleRep);
            this.groupBox2.Location = new System.Drawing.Point(465, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 322);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dgDetalleRep
            // 
            this.dgDetalleRep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalleRep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDetalleRep.Location = new System.Drawing.Point(3, 16);
            this.dgDetalleRep.Name = "dgDetalleRep";
            this.dgDetalleRep.Size = new System.Drawing.Size(555, 303);
            this.dgDetalleRep.TabIndex = 0;
            this.dgDetalleRep.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetalleRep_CellClick);
            this.dgDetalleRep.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetalleRep_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Clean);
            this.groupBox3.Controls.Add(this.Delete);
            this.groupBox3.Controls.Add(this.Read);
            this.groupBox3.Controls.Add(this.Update);
            this.groupBox3.Controls.Add(this.Insert);
            this.groupBox3.Location = new System.Drawing.Point(465, 391);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(561, 122);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // Clean
            // 
            this.Clean.Location = new System.Drawing.Point(442, 45);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(103, 36);
            this.Clean.TabIndex = 0;
            this.Clean.Text = "Clean";
            this.Clean.UseVisualStyleBackColor = true;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(333, 45);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(103, 36);
            this.Delete.TabIndex = 0;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Read
            // 
            this.Read.Location = new System.Drawing.Point(224, 45);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(103, 36);
            this.Read.TabIndex = 0;
            this.Read.Text = "Read";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(115, 45);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(103, 36);
            this.Update.TabIndex = 0;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(6, 45);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(103, 36);
            this.Insert.TabIndex = 0;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // tBuscarId
            // 
            this.tBuscarId.Location = new System.Drawing.Point(655, 40);
            this.tBuscarId.Name = "tBuscarId";
            this.tBuscarId.Size = new System.Drawing.Size(220, 20);
            this.tBuscarId.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 20;
            this.btnBuscar.Location = new System.Drawing.Point(867, 35);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(34, 28);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // comboMec
            // 
            this.comboMec.FormattingEnabled = true;
            this.comboMec.Location = new System.Drawing.Point(471, 41);
            this.comboMec.Name = "comboMec";
            this.comboMec.Size = new System.Drawing.Size(139, 21);
            this.comboMec.TabIndex = 7;
            // 
            // RDetalleReparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1038, 544);
            this.Controls.Add(this.comboMec);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tBuscarId);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Name = "RDetalleReparacion";
            this.Text = "RDetalleReparacion";
            this.Load += new System.EventHandler(this.RDetalleReparacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleRep)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCosto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPiezas;
        private System.Windows.Forms.TextBox tDVehiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tManoO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker fechaDet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Clean;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.TextBox tBuscarId;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.DataGridView dgDetalleRep;
        private System.Windows.Forms.ComboBox comboMec;
    }
}