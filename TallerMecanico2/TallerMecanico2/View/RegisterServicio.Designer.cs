
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
            this.tbCedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnServicioG = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnServicioG);
            this.groupBox1.Controls.Add(this.tbCedula);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbApellido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 349);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servicio";
            // 
            // tbCedula
            // 
            this.tbCedula.Location = new System.Drawing.Point(13, 221);
            this.tbCedula.Name = "tbCedula";
            this.tbCedula.Size = new System.Drawing.Size(247, 20);
            this.tbCedula.TabIndex = 1;
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
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(13, 150);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(247, 20);
            this.tbApellido.TabIndex = 1;
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
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(13, 83);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(247, 20);
            this.tbNombre.TabIndex = 1;
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
            this.btnServicioG.Location = new System.Drawing.Point(68, 258);
            this.btnServicioG.Name = "btnServicioG";
            this.btnServicioG.Size = new System.Drawing.Size(119, 50);
            this.btnServicioG.TabIndex = 4;
            this.btnServicioG.Text = "Guardar";
            this.btnServicioG.UseVisualStyleBackColor = true;
            this.btnServicioG.Click += new System.EventHandler(this.btnClienteG_Click);
            // 
            // RegisterServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 554);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegisterServicio";
            this.Text = "RegisterServicio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnServicioG;
    }
}