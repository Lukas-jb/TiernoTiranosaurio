﻿namespace TiernoTiranosaurioI
{
    partial class PorCodigo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PorCodigo));
            this.cbCodigo = new System.Windows.Forms.ComboBox();
            this.mASCOTASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tIERNOTIRANOSAURIODataSet1 = new TiernoTiranosaurioI.TIERNOTIRANOSAURIODataSet1();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txEspecie = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btSalir = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.mASCOTASTableAdapter = new TiernoTiranosaurioI.TIERNOTIRANOSAURIODataSet1TableAdapters.MASCOTASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mASCOTASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIERNOTIRANOSAURIODataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCodigo
            // 
            this.cbCodigo.DataSource = this.mASCOTASBindingSource;
            this.cbCodigo.DisplayMember = "CODIGO";
            this.cbCodigo.FormattingEnabled = true;
            this.cbCodigo.Location = new System.Drawing.Point(568, 32);
            this.cbCodigo.Name = "cbCodigo";
            this.cbCodigo.Size = new System.Drawing.Size(171, 21);
            this.cbCodigo.TabIndex = 49;
            this.cbCodigo.ValueMember = "CODIGO";
            // 
            // mASCOTASBindingSource
            // 
            this.mASCOTASBindingSource.DataMember = "MASCOTAS";
            this.mASCOTASBindingSource.DataSource = this.tIERNOTIRANOSAURIODataSet1;
            // 
            // tIERNOTIRANOSAURIODataSet1
            // 
            this.tIERNOTIRANOSAURIODataSet1.DataSetName = "TIERNOTIRANOSAURIODataSet1";
            this.tIERNOTIRANOSAURIODataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Quicksand", 14F);
            this.label6.Location = new System.Drawing.Point(462, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 28);
            this.label6.TabIndex = 48;
            this.label6.Text = "Código:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(568, -26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 21);
            this.comboBox1.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(8, -69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 589);
            this.panel1.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 16F);
            this.label1.Location = new System.Drawing.Point(14, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consulta de animales por código";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TiernoTiranosaurioI.Properties.Resources.Diseño_sin_título__4__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(102, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 159);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txCantidad
            // 
            this.txCantidad.Enabled = false;
            this.txCantidad.Location = new System.Drawing.Point(568, 357);
            this.txCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txCantidad.Name = "txCantidad";
            this.txCantidad.Size = new System.Drawing.Size(171, 20);
            this.txCantidad.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Quicksand", 14F);
            this.label5.Location = new System.Drawing.Point(453, 349);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 28);
            this.label5.TabIndex = 42;
            this.label5.Text = "Cantidad:";
            // 
            // txPrecio
            // 
            this.txPrecio.Enabled = false;
            this.txPrecio.Location = new System.Drawing.Point(568, 319);
            this.txPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txPrecio.Name = "txPrecio";
            this.txPrecio.Size = new System.Drawing.Size(171, 20);
            this.txPrecio.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quicksand", 14F);
            this.label4.Location = new System.Drawing.Point(480, 311);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 28);
            this.label4.TabIndex = 40;
            this.label4.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand", 14F);
            this.label3.Location = new System.Drawing.Point(462, -33);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 28);
            this.label3.TabIndex = 39;
            this.label3.Text = "Especie:";
            // 
            // txNombre
            // 
            this.txNombre.Enabled = false;
            this.txNombre.Location = new System.Drawing.Point(568, 278);
            this.txNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(171, 20);
            this.txNombre.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 14F);
            this.label2.Location = new System.Drawing.Point(462, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 28);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nombre:";
            // 
            // txEspecie
            // 
            this.txEspecie.Enabled = false;
            this.txEspecie.Location = new System.Drawing.Point(568, 399);
            this.txEspecie.Margin = new System.Windows.Forms.Padding(4);
            this.txEspecie.Name = "txEspecie";
            this.txEspecie.Size = new System.Drawing.Size(171, 20);
            this.txEspecie.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Quicksand", 14F);
            this.label7.Location = new System.Drawing.Point(462, 391);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 28);
            this.label7.TabIndex = 51;
            this.label7.Text = "Especie:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(448, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(323, 177);
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // btSalir
            // 
            this.btSalir.Image = ((System.Drawing.Image)(resources.GetObject("btSalir.Image")));
            this.btSalir.Location = new System.Drawing.Point(679, 436);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(114, 39);
            this.btSalir.TabIndex = 46;
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btBorrar.Image")));
            this.btBorrar.Location = new System.Drawing.Point(547, 436);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(114, 39);
            this.btBorrar.TabIndex = 45;
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btBuscar.Image")));
            this.btBuscar.Location = new System.Drawing.Point(416, 436);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(116, 39);
            this.btBuscar.TabIndex = 44;
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // mASCOTASTableAdapter
            // 
            this.mASCOTASTableAdapter.ClearBeforeFill = true;
            // 
            // PorCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(831, 504);
            this.Controls.Add(this.txEspecie);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cbCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txNombre);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PorCodigo";
            this.Text = "PorCodigo";
            this.Load += new System.EventHandler(this.PorCodigo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mASCOTASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIERNOTIRANOSAURIODataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cbCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox txCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txEspecie;
        private System.Windows.Forms.Label label7;
        private TIERNOTIRANOSAURIODataSet1 tIERNOTIRANOSAURIODataSet1;
        private System.Windows.Forms.BindingSource mASCOTASBindingSource;
        private TIERNOTIRANOSAURIODataSet1TableAdapters.MASCOTASTableAdapter mASCOTASTableAdapter;
    }
}