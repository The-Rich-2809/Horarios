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
            this.Lbl_Id = new System.Windows.Forms.Label();
            this.Cb_Prof = new System.Windows.Forms.ComboBox();
            this.Cb_Materia = new System.Windows.Forms.ComboBox();
            this.Cb_Turno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.Gb_Horario = new System.Windows.Forms.GroupBox();
            this.ChB_Lunes = new System.Windows.Forms.CheckBox();
            this.ChB_Martes = new System.Windows.Forms.CheckBox();
            this.ChB_Jueves = new System.Windows.Forms.CheckBox();
            this.ChB_Miercoles = new System.Windows.Forms.CheckBox();
            this.ChB_Viernes = new System.Windows.Forms.CheckBox();
            this.CB_LunesI = new System.Windows.Forms.ComboBox();
            this.CB_MartesI = new System.Windows.Forms.ComboBox();
            this.CB_MiercolesI = new System.Windows.Forms.ComboBox();
            this.CB_JuevesI = new System.Windows.Forms.ComboBox();
            this.CB_ViernesI = new System.Windows.Forms.ComboBox();
            this.CB_ViernesF = new System.Windows.Forms.ComboBox();
            this.CB_JuevesF = new System.Windows.Forms.ComboBox();
            this.CB_MiercolesF = new System.Windows.Forms.ComboBox();
            this.CB_MartesF = new System.Windows.Forms.ComboBox();
            this.CB_LunesF = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Gb_Datos.SuspendLayout();
            this.Gb_Acciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Clases)).BeginInit();
            this.Gb_Horario.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gb_Datos
            // 
            this.Gb_Datos.Controls.Add(this.Gb_Horario);
            this.Gb_Datos.Controls.Add(this.Lbl_Id);
            this.Gb_Datos.Controls.Add(this.Cb_Prof);
            this.Gb_Datos.Controls.Add(this.Cb_Materia);
            this.Gb_Datos.Controls.Add(this.Cb_Turno);
            this.Gb_Datos.Controls.Add(this.label1);
            this.Gb_Datos.Controls.Add(this.label2);
            this.Gb_Datos.Controls.Add(this.label5);
            this.Gb_Datos.Controls.Add(this.label4);
            this.Gb_Datos.Controls.Add(this.Cb_Semestre);
            this.Gb_Datos.Location = new System.Drawing.Point(26, 498);
            this.Gb_Datos.Name = "Gb_Datos";
            this.Gb_Datos.Size = new System.Drawing.Size(879, 294);
            this.Gb_Datos.TabIndex = 21;
            this.Gb_Datos.TabStop = false;
            this.Gb_Datos.Text = "Datos de la Clase";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Profesor";
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
            this.Gb_Acciones.Location = new System.Drawing.Point(1070, 498);
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
            // Gb_Horario
            // 
            this.Gb_Horario.Controls.Add(this.label6);
            this.Gb_Horario.Controls.Add(this.label3);
            this.Gb_Horario.Controls.Add(this.CB_ViernesF);
            this.Gb_Horario.Controls.Add(this.CB_JuevesF);
            this.Gb_Horario.Controls.Add(this.CB_MiercolesF);
            this.Gb_Horario.Controls.Add(this.CB_MartesF);
            this.Gb_Horario.Controls.Add(this.CB_LunesF);
            this.Gb_Horario.Controls.Add(this.CB_ViernesI);
            this.Gb_Horario.Controls.Add(this.ChB_Jueves);
            this.Gb_Horario.Controls.Add(this.CB_JuevesI);
            this.Gb_Horario.Controls.Add(this.ChB_Lunes);
            this.Gb_Horario.Controls.Add(this.CB_MiercolesI);
            this.Gb_Horario.Controls.Add(this.ChB_Martes);
            this.Gb_Horario.Controls.Add(this.CB_MartesI);
            this.Gb_Horario.Controls.Add(this.ChB_Miercoles);
            this.Gb_Horario.Controls.Add(this.CB_LunesI);
            this.Gb_Horario.Controls.Add(this.ChB_Viernes);
            this.Gb_Horario.Location = new System.Drawing.Point(410, 38);
            this.Gb_Horario.Name = "Gb_Horario";
            this.Gb_Horario.Size = new System.Drawing.Size(434, 275);
            this.Gb_Horario.TabIndex = 20;
            this.Gb_Horario.TabStop = false;
            this.Gb_Horario.Text = "Horario";
            // 
            // ChB_Lunes
            // 
            this.ChB_Lunes.AutoSize = true;
            this.ChB_Lunes.Location = new System.Drawing.Point(22, 45);
            this.ChB_Lunes.Name = "ChB_Lunes";
            this.ChB_Lunes.Size = new System.Drawing.Size(79, 24);
            this.ChB_Lunes.TabIndex = 23;
            this.ChB_Lunes.Text = "Lunes";
            this.ChB_Lunes.UseVisualStyleBackColor = true;
            this.ChB_Lunes.CheckedChanged += new System.EventHandler(this.ChB_Lunes_CheckedChanged);
            // 
            // ChB_Martes
            // 
            this.ChB_Martes.AutoSize = true;
            this.ChB_Martes.Location = new System.Drawing.Point(21, 79);
            this.ChB_Martes.Name = "ChB_Martes";
            this.ChB_Martes.Size = new System.Drawing.Size(84, 24);
            this.ChB_Martes.TabIndex = 24;
            this.ChB_Martes.Text = "Martes";
            this.ChB_Martes.UseVisualStyleBackColor = true;
            this.ChB_Martes.CheckedChanged += new System.EventHandler(this.ChB_Martes_CheckedChanged);
            // 
            // ChB_Jueves
            // 
            this.ChB_Jueves.AutoSize = true;
            this.ChB_Jueves.Location = new System.Drawing.Point(22, 147);
            this.ChB_Jueves.Name = "ChB_Jueves";
            this.ChB_Jueves.Size = new System.Drawing.Size(85, 24);
            this.ChB_Jueves.TabIndex = 26;
            this.ChB_Jueves.Text = "Jueves";
            this.ChB_Jueves.UseVisualStyleBackColor = true;
            this.ChB_Jueves.CheckedChanged += new System.EventHandler(this.ChB_Jueves_CheckedChanged);
            // 
            // ChB_Miercoles
            // 
            this.ChB_Miercoles.AutoSize = true;
            this.ChB_Miercoles.Location = new System.Drawing.Point(22, 113);
            this.ChB_Miercoles.Name = "ChB_Miercoles";
            this.ChB_Miercoles.Size = new System.Drawing.Size(102, 24);
            this.ChB_Miercoles.TabIndex = 25;
            this.ChB_Miercoles.Text = "Miercoles";
            this.ChB_Miercoles.UseVisualStyleBackColor = true;
            this.ChB_Miercoles.CheckedChanged += new System.EventHandler(this.ChB_Miercoles_CheckedChanged);
            // 
            // ChB_Viernes
            // 
            this.ChB_Viernes.AutoSize = true;
            this.ChB_Viernes.Location = new System.Drawing.Point(22, 181);
            this.ChB_Viernes.Name = "ChB_Viernes";
            this.ChB_Viernes.Size = new System.Drawing.Size(89, 24);
            this.ChB_Viernes.TabIndex = 27;
            this.ChB_Viernes.Text = "Viernes";
            this.ChB_Viernes.UseVisualStyleBackColor = true;
            this.ChB_Viernes.CheckedChanged += new System.EventHandler(this.ChB_Viernes_CheckedChanged);
            // 
            // CB_LunesI
            // 
            this.CB_LunesI.FormattingEnabled = true;
            this.CB_LunesI.Location = new System.Drawing.Point(141, 43);
            this.CB_LunesI.Name = "CB_LunesI";
            this.CB_LunesI.Size = new System.Drawing.Size(121, 28);
            this.CB_LunesI.TabIndex = 28;
            // 
            // CB_MartesI
            // 
            this.CB_MartesI.FormattingEnabled = true;
            this.CB_MartesI.Location = new System.Drawing.Point(141, 77);
            this.CB_MartesI.Name = "CB_MartesI";
            this.CB_MartesI.Size = new System.Drawing.Size(121, 28);
            this.CB_MartesI.TabIndex = 29;
            // 
            // CB_MiercolesI
            // 
            this.CB_MiercolesI.FormattingEnabled = true;
            this.CB_MiercolesI.Location = new System.Drawing.Point(141, 111);
            this.CB_MiercolesI.Name = "CB_MiercolesI";
            this.CB_MiercolesI.Size = new System.Drawing.Size(121, 28);
            this.CB_MiercolesI.TabIndex = 30;
            // 
            // CB_JuevesI
            // 
            this.CB_JuevesI.FormattingEnabled = true;
            this.CB_JuevesI.Location = new System.Drawing.Point(141, 145);
            this.CB_JuevesI.Name = "CB_JuevesI";
            this.CB_JuevesI.Size = new System.Drawing.Size(121, 28);
            this.CB_JuevesI.TabIndex = 31;
            // 
            // CB_ViernesI
            // 
            this.CB_ViernesI.FormattingEnabled = true;
            this.CB_ViernesI.Location = new System.Drawing.Point(141, 179);
            this.CB_ViernesI.Name = "CB_ViernesI";
            this.CB_ViernesI.Size = new System.Drawing.Size(121, 28);
            this.CB_ViernesI.TabIndex = 32;
            // 
            // CB_ViernesF
            // 
            this.CB_ViernesF.FormattingEnabled = true;
            this.CB_ViernesF.Location = new System.Drawing.Point(268, 179);
            this.CB_ViernesF.Name = "CB_ViernesF";
            this.CB_ViernesF.Size = new System.Drawing.Size(121, 28);
            this.CB_ViernesF.TabIndex = 37;
            // 
            // CB_JuevesF
            // 
            this.CB_JuevesF.FormattingEnabled = true;
            this.CB_JuevesF.Location = new System.Drawing.Point(268, 145);
            this.CB_JuevesF.Name = "CB_JuevesF";
            this.CB_JuevesF.Size = new System.Drawing.Size(121, 28);
            this.CB_JuevesF.TabIndex = 36;
            // 
            // CB_MiercolesF
            // 
            this.CB_MiercolesF.FormattingEnabled = true;
            this.CB_MiercolesF.Location = new System.Drawing.Point(268, 111);
            this.CB_MiercolesF.Name = "CB_MiercolesF";
            this.CB_MiercolesF.Size = new System.Drawing.Size(121, 28);
            this.CB_MiercolesF.TabIndex = 35;
            // 
            // CB_MartesF
            // 
            this.CB_MartesF.FormattingEnabled = true;
            this.CB_MartesF.Location = new System.Drawing.Point(268, 77);
            this.CB_MartesF.Name = "CB_MartesF";
            this.CB_MartesF.Size = new System.Drawing.Size(121, 28);
            this.CB_MartesF.TabIndex = 34;
            // 
            // CB_LunesF
            // 
            this.CB_LunesF.FormattingEnabled = true;
            this.CB_LunesF.Location = new System.Drawing.Point(268, 43);
            this.CB_LunesF.Name = "CB_LunesF";
            this.CB_LunesF.Size = new System.Drawing.Size(121, 28);
            this.CB_LunesF.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Inicio de la clase";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Fin de la clase";
            // 
            // Crear_Clase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 935);
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
            this.Gb_Horario.ResumeLayout(false);
            this.Gb_Horario.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_Id;
        private System.Windows.Forms.GroupBox Gb_Horario;
        private System.Windows.Forms.ComboBox CB_ViernesI;
        private System.Windows.Forms.CheckBox ChB_Jueves;
        private System.Windows.Forms.ComboBox CB_JuevesI;
        private System.Windows.Forms.CheckBox ChB_Lunes;
        private System.Windows.Forms.ComboBox CB_MiercolesI;
        private System.Windows.Forms.CheckBox ChB_Martes;
        private System.Windows.Forms.ComboBox CB_MartesI;
        private System.Windows.Forms.CheckBox ChB_Miercoles;
        private System.Windows.Forms.ComboBox CB_LunesI;
        private System.Windows.Forms.CheckBox ChB_Viernes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_ViernesF;
        private System.Windows.Forms.ComboBox CB_JuevesF;
        private System.Windows.Forms.ComboBox CB_MiercolesF;
        private System.Windows.Forms.ComboBox CB_MartesF;
        private System.Windows.Forms.ComboBox CB_LunesF;
    }
}