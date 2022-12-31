namespace Proyecto_Final.Forms
{
    partial class Crear_Prof
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
            this.Btn_Nombre = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Turno = new System.Windows.Forms.ComboBox();
            this.Txt_Semestre = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Gb_Acciones = new System.Windows.Forms.GroupBox();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Mod = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Txt_1Apellido = new System.Windows.Forms.TextBox();
            this.Txt_2Apellido = new System.Windows.Forms.TextBox();
            this.Dgv_Profes = new System.Windows.Forms.DataGridView();
            this.Gb_Datos = new System.Windows.Forms.GroupBox();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Gb_Acciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Profes)).BeginInit();
            this.Gb_Datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Nombre
            // 
            this.Btn_Nombre.AutoSize = true;
            this.Btn_Nombre.Location = new System.Drawing.Point(9, 36);
            this.Btn_Nombre.Name = "Btn_Nombre";
            this.Btn_Nombre.Size = new System.Drawing.Size(65, 20);
            this.Btn_Nombre.TabIndex = 0;
            this.Btn_Nombre.Text = "Nombre";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(13, 59);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(165, 26);
            this.Txt_Nombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Primer Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Segundo Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Turno";
            // 
            // Txt_Turno
            // 
            this.Txt_Turno.FormattingEnabled = true;
            this.Txt_Turno.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino"});
            this.Txt_Turno.Location = new System.Drawing.Point(279, 128);
            this.Txt_Turno.Name = "Txt_Turno";
            this.Txt_Turno.Size = new System.Drawing.Size(121, 28);
            this.Txt_Turno.TabIndex = 7;
            // 
            // Txt_Semestre
            // 
            this.Txt_Semestre.FormattingEnabled = true;
            this.Txt_Semestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.Txt_Semestre.Location = new System.Drawing.Point(152, 128);
            this.Txt_Semestre.Name = "Txt_Semestre";
            this.Txt_Semestre.Size = new System.Drawing.Size(121, 28);
            this.Txt_Semestre.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Semestre";
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Location = new System.Drawing.Point(125, 34);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(113, 41);
            this.Btn_Agregar.TabIndex = 12;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Gb_Acciones
            // 
            this.Gb_Acciones.Controls.Add(this.Btn_Cancelar);
            this.Gb_Acciones.Controls.Add(this.Btn_Nuevo);
            this.Gb_Acciones.Controls.Add(this.Btn_Eliminar);
            this.Gb_Acciones.Controls.Add(this.Btn_Mod);
            this.Gb_Acciones.Controls.Add(this.Btn_Modificar);
            this.Gb_Acciones.Controls.Add(this.Btn_Agregar);
            this.Gb_Acciones.Location = new System.Drawing.Point(629, 339);
            this.Gb_Acciones.Name = "Gb_Acciones";
            this.Gb_Acciones.Size = new System.Drawing.Size(248, 192);
            this.Gb_Acciones.TabIndex = 14;
            this.Gb_Acciones.TabStop = false;
            this.Gb_Acciones.Text = "Acciones";
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Location = new System.Drawing.Point(6, 128);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(113, 41);
            this.Btn_Eliminar.TabIndex = 15;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Mod
            // 
            this.Btn_Mod.Location = new System.Drawing.Point(125, 81);
            this.Btn_Mod.Name = "Btn_Mod";
            this.Btn_Mod.Size = new System.Drawing.Size(113, 41);
            this.Btn_Mod.TabIndex = 14;
            this.Btn_Mod.Text = "Modificar";
            this.Btn_Mod.UseVisualStyleBackColor = true;
            this.Btn_Mod.Click += new System.EventHandler(this.Btn_Mod_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Location = new System.Drawing.Point(6, 81);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(113, 41);
            this.Btn_Modificar.TabIndex = 13;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Txt_1Apellido
            // 
            this.Txt_1Apellido.Location = new System.Drawing.Point(184, 59);
            this.Txt_1Apellido.Name = "Txt_1Apellido";
            this.Txt_1Apellido.Size = new System.Drawing.Size(165, 26);
            this.Txt_1Apellido.TabIndex = 15;
            // 
            // Txt_2Apellido
            // 
            this.Txt_2Apellido.Location = new System.Drawing.Point(355, 59);
            this.Txt_2Apellido.Name = "Txt_2Apellido";
            this.Txt_2Apellido.Size = new System.Drawing.Size(165, 26);
            this.Txt_2Apellido.TabIndex = 16;
            // 
            // Dgv_Profes
            // 
            this.Dgv_Profes.AllowUserToAddRows = false;
            this.Dgv_Profes.AllowUserToDeleteRows = false;
            this.Dgv_Profes.AllowUserToOrderColumns = true;
            this.Dgv_Profes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dgv_Profes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Profes.Location = new System.Drawing.Point(12, 12);
            this.Dgv_Profes.Name = "Dgv_Profes";
            this.Dgv_Profes.ReadOnly = true;
            this.Dgv_Profes.RowHeadersWidth = 62;
            this.Dgv_Profes.RowTemplate.Height = 28;
            this.Dgv_Profes.Size = new System.Drawing.Size(944, 303);
            this.Dgv_Profes.TabIndex = 17;
            // 
            // Gb_Datos
            // 
            this.Gb_Datos.Controls.Add(this.Txt_Turno);
            this.Gb_Datos.Controls.Add(this.Btn_Nombre);
            this.Gb_Datos.Controls.Add(this.Txt_2Apellido);
            this.Gb_Datos.Controls.Add(this.Txt_Nombre);
            this.Gb_Datos.Controls.Add(this.Txt_1Apellido);
            this.Gb_Datos.Controls.Add(this.label2);
            this.Gb_Datos.Controls.Add(this.label3);
            this.Gb_Datos.Controls.Add(this.label5);
            this.Gb_Datos.Controls.Add(this.label4);
            this.Gb_Datos.Controls.Add(this.Txt_Semestre);
            this.Gb_Datos.Location = new System.Drawing.Point(80, 359);
            this.Gb_Datos.Name = "Gb_Datos";
            this.Gb_Datos.Size = new System.Drawing.Size(528, 162);
            this.Gb_Datos.TabIndex = 18;
            this.Gb_Datos.TabStop = false;
            this.Gb_Datos.Text = "Datos del profesor";
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
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(125, 128);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(113, 41);
            this.Btn_Cancelar.TabIndex = 17;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Crear_Prof
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 561);
            this.Controls.Add(this.Gb_Datos);
            this.Controls.Add(this.Dgv_Profes);
            this.Controls.Add(this.Gb_Acciones);
            this.Name = "Crear_Prof";
            this.Text = "Crear_Prof";
            this.Load += new System.EventHandler(this.Crear_Prof_Load);
            this.Gb_Acciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Profes)).EndInit();
            this.Gb_Datos.ResumeLayout(false);
            this.Gb_Datos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Btn_Nombre;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Txt_Turno;
        private System.Windows.Forms.ComboBox Txt_Semestre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.GroupBox Gb_Acciones;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Mod;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.TextBox Txt_1Apellido;
        private System.Windows.Forms.TextBox Txt_2Apellido;
        private System.Windows.Forms.DataGridView Dgv_Profes;
        private System.Windows.Forms.GroupBox Gb_Datos;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Cancelar;
    }
}