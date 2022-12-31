namespace Proyecto_Final.Forms
{
    partial class Crear_Clase
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
            this.Gb_Datos = new System.Windows.Forms.GroupBox();
            this.Cb_Prof = new System.Windows.Forms.ComboBox();
            this.Cb_Materia = new System.Windows.Forms.ComboBox();
            this.Cb_Turno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_2Apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cb_Semestre = new System.Windows.Forms.ComboBox();
            this.Gb_Acciones = new System.Windows.Forms.GroupBox();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Mod = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Dgv_Clases = new System.Windows.Forms.DataGridView();
            this.Lbl_Id = new System.Windows.Forms.Label();
            this.Gb_Datos.SuspendLayout();
            this.Gb_Acciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Clases)).BeginInit();
            this.SuspendLayout();
            // 
            // Gb_Datos
            // 
            this.Gb_Datos.Controls.Add(this.Lbl_Id);
            this.Gb_Datos.Controls.Add(this.Cb_Prof);
            this.Gb_Datos.Controls.Add(this.Cb_Materia);
            this.Gb_Datos.Controls.Add(this.Cb_Turno);
            this.Gb_Datos.Controls.Add(this.label1);
            this.Gb_Datos.Controls.Add(this.Txt_2Apellido);
            this.Gb_Datos.Controls.Add(this.label2);
            this.Gb_Datos.Controls.Add(this.label3);
            this.Gb_Datos.Controls.Add(this.label5);
            this.Gb_Datos.Controls.Add(this.label4);
            this.Gb_Datos.Controls.Add(this.Cb_Semestre);
            this.Gb_Datos.Location = new System.Drawing.Point(26, 498);
            this.Gb_Datos.Name = "Gb_Datos";
            this.Gb_Datos.Size = new System.Drawing.Size(1107, 162);
            this.Gb_Datos.TabIndex = 21;
            this.Gb_Datos.TabStop = false;
            this.Gb_Datos.Text = "Datos de la Clase";
            // 
            // Cb_Prof
            // 
            this.Cb_Prof.FormattingEnabled = true;
            this.Cb_Prof.Location = new System.Drawing.Point(216, 120);
            this.Cb_Prof.Name = "Cb_Prof";
            this.Cb_Prof.Size = new System.Drawing.Size(165, 28);
            this.Cb_Prof.TabIndex = 18;
            this.Cb_Prof.SelectedIndexChanged += new System.EventHandler(this.Cb_Prof_SelectedIndexChanged);
            // 
            // Cb_Materia
            // 
            this.Cb_Materia.FormattingEnabled = true;
            this.Cb_Materia.Location = new System.Drawing.Point(216, 59);
            this.Cb_Materia.Name = "Cb_Materia";
            this.Cb_Materia.Size = new System.Drawing.Size(165, 28);
            this.Cb_Materia.TabIndex = 17;
            // 
            // Cb_Turno
            // 
            this.Cb_Turno.FormattingEnabled = true;
            this.Cb_Turno.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino"});
            this.Cb_Turno.Location = new System.Drawing.Point(22, 120);
            this.Cb_Turno.Name = "Cb_Turno";
            this.Cb_Turno.Size = new System.Drawing.Size(121, 28);
            this.Cb_Turno.TabIndex = 7;
            this.Cb_Turno.SelectedIndexChanged += new System.EventHandler(this.Txt_Turno_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Materia";
            // 
            // Txt_2Apellido
            // 
            this.Txt_2Apellido.Location = new System.Drawing.Point(815, 85);
            this.Txt_2Apellido.Name = "Txt_2Apellido";
            this.Txt_2Apellido.Size = new System.Drawing.Size(165, 26);
            this.Txt_2Apellido.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Profesor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(811, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Segundo Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Semestre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Turno";
            // 
            // Cb_Semestre
            // 
            this.Cb_Semestre.FormattingEnabled = true;
            this.Cb_Semestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.Cb_Semestre.Location = new System.Drawing.Point(22, 61);
            this.Cb_Semestre.Name = "Cb_Semestre";
            this.Cb_Semestre.Size = new System.Drawing.Size(121, 28);
            this.Cb_Semestre.TabIndex = 8;
            this.Cb_Semestre.SelectedIndexChanged += new System.EventHandler(this.Txt_Semestre_SelectedIndexChanged);
            // 
            // Gb_Acciones
            // 
            this.Gb_Acciones.Controls.Add(this.Btn_Cancelar);
            this.Gb_Acciones.Controls.Add(this.Btn_Nuevo);
            this.Gb_Acciones.Controls.Add(this.Btn_Eliminar);
            this.Gb_Acciones.Controls.Add(this.Btn_Mod);
            this.Gb_Acciones.Controls.Add(this.Btn_Modificar);
            this.Gb_Acciones.Controls.Add(this.Btn_Agregar);
            this.Gb_Acciones.Location = new System.Drawing.Point(1213, 491);
            this.Gb_Acciones.Name = "Gb_Acciones";
            this.Gb_Acciones.Size = new System.Drawing.Size(248, 192);
            this.Gb_Acciones.TabIndex = 19;
            this.Gb_Acciones.TabStop = false;
            this.Gb_Acciones.Text = "Acciones";
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(125, 128);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(113, 41);
            this.Btn_Cancelar.TabIndex = 17;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.Location = new System.Drawing.Point(6, 35);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(113, 41);
            this.Btn_Nuevo.TabIndex = 16;
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.UseVisualStyleBackColor = true;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Location = new System.Drawing.Point(6, 128);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(113, 41);
            this.Btn_Eliminar.TabIndex = 15;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_Mod
            // 
            this.Btn_Mod.Location = new System.Drawing.Point(125, 81);
            this.Btn_Mod.Name = "Btn_Mod";
            this.Btn_Mod.Size = new System.Drawing.Size(113, 41);
            this.Btn_Mod.TabIndex = 14;
            this.Btn_Mod.Text = "Modificar";
            this.Btn_Mod.UseVisualStyleBackColor = true;
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Location = new System.Drawing.Point(6, 81);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(113, 41);
            this.Btn_Modificar.TabIndex = 13;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Location = new System.Drawing.Point(125, 34);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(113, 41);
            this.Btn_Agregar.TabIndex = 12;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // Dgv_Clases
            // 
            this.Dgv_Clases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dgv_Clases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Clases.Location = new System.Drawing.Point(12, 12);
            this.Dgv_Clases.Name = "Dgv_Clases";
            this.Dgv_Clases.RowHeadersWidth = 62;
            this.Dgv_Clases.RowTemplate.Height = 28;
            this.Dgv_Clases.Size = new System.Drawing.Size(1336, 453);
            this.Dgv_Clases.TabIndex = 22;
            // 
            // Lbl_Id
            // 
            this.Lbl_Id.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Id.Location = new System.Drawing.Point(311, 95);
            this.Lbl_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Id.Name = "Lbl_Id";
            this.Lbl_Id.Size = new System.Drawing.Size(56, 23);
            this.Lbl_Id.TabIndex = 19;
            this.Lbl_Id.Text = "label7";
            // 
            // Crear_Clase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 702);
            this.Controls.Add(this.Dgv_Clases);
            this.Controls.Add(this.Gb_Datos);
            this.Controls.Add(this.Gb_Acciones);
            this.Name = "Crear_Clase";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear_Clase";
            this.Load += new System.EventHandler(this.Crear_Clase_Load);
            this.Gb_Datos.ResumeLayout(false);
            this.Gb_Datos.PerformLayout();
            this.Gb_Acciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Clases)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gb_Datos;
        private System.Windows.Forms.ComboBox Cb_Turno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cb_Semestre;
        private System.Windows.Forms.GroupBox Gb_Acciones;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Mod;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.DataGridView Dgv_Clases;
        private System.Windows.Forms.ComboBox Cb_Prof;
        private System.Windows.Forms.ComboBox Cb_Materia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_2Apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_Id;
    }
}