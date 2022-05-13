
namespace TallerMecanico2.View
{
    partial class RegisterFactura
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbCostoServicio = new System.Windows.Forms.ComboBox();
            this.sYSTASSERVICIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systa_taller2DataSet = new TallerMecanico2.Systa_taller2DataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPieza = new System.Windows.Forms.ComboBox();
            this.cbPrecioPiezas = new System.Windows.Forms.ComboBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.cManoO = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSubtotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbServicio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fechaDet = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgFactura = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Report = new System.Windows.Forms.Button();
            this.Clean = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Read = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnSearID = new FontAwesome.Sharp.IconButton();
            this.txtBuscarID = new System.Windows.Forms.TextBox();
            this.sYSTAS_SERVICIOTableAdapter = new TallerMecanico2.Systa_taller2DataSetTableAdapters.SYSTAS_SERVICIOTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sYSTASSERVICIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systa_taller2DataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFactura)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbCostoServicio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbPieza);
            this.groupBox1.Controls.Add(this.cbPrecioPiezas);
            this.groupBox1.Controls.Add(this.tbTotal);
            this.groupBox1.Controls.Add(this.cManoO);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbSubtotal);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbCantidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbServicio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fechaDet);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 499);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Factura";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CbCostoServicio
            // 
            this.CbCostoServicio.FormattingEnabled = true;
            this.CbCostoServicio.Location = new System.Drawing.Point(26, 151);
            this.CbCostoServicio.Name = "CbCostoServicio";
            this.CbCostoServicio.Size = new System.Drawing.Size(121, 21);
            this.CbCostoServicio.TabIndex = 27;
            // 
            // sYSTASSERVICIOBindingSource
            // 
            this.sYSTASSERVICIOBindingSource.DataMember = "SYSTAS_SERVICIO";
            this.sYSTASSERVICIOBindingSource.DataSource = this.systa_taller2DataSet;
            // 
            // systa_taller2DataSet
            // 
            this.systa_taller2DataSet.DataSetName = "Systa_taller2DataSet";
            this.systa_taller2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Piezas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "PrecioPiezas";
            // 
            // cbPieza
            // 
            this.cbPieza.FormattingEnabled = true;
            this.cbPieza.Location = new System.Drawing.Point(32, 290);
            this.cbPieza.Name = "cbPieza";
            this.cbPieza.Size = new System.Drawing.Size(121, 21);
            this.cbPieza.TabIndex = 25;
            // 
            // cbPrecioPiezas
            // 
            this.cbPrecioPiezas.FormattingEnabled = true;
            this.cbPrecioPiezas.Location = new System.Drawing.Point(183, 290);
            this.cbPrecioPiezas.Name = "cbPrecioPiezas";
            this.cbPrecioPiezas.Size = new System.Drawing.Size(121, 21);
            this.cbPrecioPiezas.TabIndex = 25;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(183, 224);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(140, 20);
            this.tbTotal.TabIndex = 23;
            // 
            // cManoO
            // 
            this.cManoO.Location = new System.Drawing.Point(183, 153);
            this.cManoO.Name = "cManoO";
            this.cManoO.Size = new System.Drawing.Size(140, 20);
            this.cManoO.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(183, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(183, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Costo_ManoObra";
            // 
            // tbSubtotal
            // 
            this.tbSubtotal.Location = new System.Drawing.Point(29, 224);
            this.tbSubtotal.Name = "tbSubtotal";
            this.tbSubtotal.Size = new System.Drawing.Size(140, 20);
            this.tbSubtotal.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Subtotal_Piezas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Costo_Servicio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Cantidad usada";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(180, 73);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(121, 20);
            this.tbCantidad.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Servicio";
            // 
            // cbServicio
            // 
            this.cbServicio.FormattingEnabled = true;
            this.cbServicio.Location = new System.Drawing.Point(26, 73);
            this.cbServicio.Name = "cbServicio";
            this.cbServicio.Size = new System.Drawing.Size(121, 21);
            this.cbServicio.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fecha de facturacion";
            // 
            // fechaDet
            // 
            this.fechaDet.CustomFormat = "yyyy-MM-dd";
            this.fechaDet.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaDet.Location = new System.Drawing.Point(120, 13);
            this.fechaDet.Name = "fechaDet";
            this.fechaDet.Size = new System.Drawing.Size(200, 20);
            this.fechaDet.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgFactura);
            this.groupBox2.Location = new System.Drawing.Point(386, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(607, 278);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dgFactura
            // 
            this.dgFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgFactura.Location = new System.Drawing.Point(3, 16);
            this.dgFactura.Name = "dgFactura";
            this.dgFactura.Size = new System.Drawing.Size(601, 259);
            this.dgFactura.TabIndex = 0;
            this.dgFactura.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFactura_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Report);
            this.groupBox3.Controls.Add(this.Clean);
            this.groupBox3.Controls.Add(this.Delete);
            this.groupBox3.Controls.Add(this.Read);
            this.groupBox3.Controls.Add(this.Update);
            this.groupBox3.Controls.Add(this.Insert);
            this.groupBox3.Location = new System.Drawing.Point(386, 389);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(617, 122);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // Report
            // 
            this.Report.Location = new System.Drawing.Point(486, 45);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(90, 36);
            this.Report.TabIndex = 0;
            this.Report.Text = "Report";
            this.Report.UseVisualStyleBackColor = true;
            // 
            // Clean
            // 
            this.Clean.Location = new System.Drawing.Point(390, 45);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(90, 36);
            this.Clean.TabIndex = 0;
            this.Clean.Text = "Clean";
            this.Clean.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(294, 45);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(90, 36);
            this.Delete.TabIndex = 0;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Read
            // 
            this.Read.Location = new System.Drawing.Point(198, 45);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(90, 36);
            this.Read.TabIndex = 0;
            this.Read.Text = "Read";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(102, 45);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(90, 36);
            this.Update.TabIndex = 0;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(6, 45);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(90, 36);
            this.Insert.TabIndex = 0;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnSearID);
            this.groupBox7.Controls.Add(this.txtBuscarID);
            this.groupBox7.Location = new System.Drawing.Point(389, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(427, 70);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            // 
            // btnSearID
            // 
            this.btnSearID.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearID.IconColor = System.Drawing.Color.Black;
            this.btnSearID.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSearID.IconSize = 24;
            this.btnSearID.Location = new System.Drawing.Point(338, 30);
            this.btnSearID.Name = "btnSearID";
            this.btnSearID.Size = new System.Drawing.Size(68, 34);
            this.btnSearID.TabIndex = 5;
            this.btnSearID.UseVisualStyleBackColor = true;
            // 
            // txtBuscarID
            // 
            this.txtBuscarID.Location = new System.Drawing.Point(6, 38);
            this.txtBuscarID.Name = "txtBuscarID";
            this.txtBuscarID.Size = new System.Drawing.Size(326, 20);
            this.txtBuscarID.TabIndex = 4;
            // 
            // sYSTAS_SERVICIOTableAdapter
            // 
            this.sYSTAS_SERVICIOTableAdapter.ClearBeforeFill = true;
            // 
            // RegisterFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1019, 512);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegisterFactura";
            this.Text = "RegisterFactura";
            this.Load += new System.EventHandler(this.RegisterFactura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sYSTASSERVICIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systa_taller2DataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFactura)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbServicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechaDet;
        private System.Windows.Forms.TextBox cManoO;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbSubtotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgFactura;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Report;
        private System.Windows.Forms.Button Clean;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.GroupBox groupBox7;
        private FontAwesome.Sharp.IconButton btnSearID;
        private System.Windows.Forms.TextBox txtBuscarID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPieza;
        private System.Windows.Forms.ComboBox cbPrecioPiezas;
        private System.Windows.Forms.ComboBox CbCostoServicio;
        private Systa_taller2DataSet systa_taller2DataSet;
        private System.Windows.Forms.BindingSource sYSTASSERVICIOBindingSource;
        private Systa_taller2DataSetTableAdapters.SYSTAS_SERVICIOTableAdapter sYSTAS_SERVICIOTableAdapter;
    }
}