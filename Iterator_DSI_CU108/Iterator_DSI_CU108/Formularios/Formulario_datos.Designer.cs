namespace Iterator_DSI_CU108
{
    partial class Formulario_datos
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_simposio = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaInvestigacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_generarReporte = new System.Windows.Forms.Button();
            this.dgv_EdicionCongreso = new System.Windows.Forms.DataGridView();
            this.numeroEdicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_simposio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EdicionCongreso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccionar ediciones: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgv_simposio
            // 
            this.dgv_simposio.AllowUserToAddRows = false;
            this.dgv_simposio.AllowUserToDeleteRows = false;
            this.dgv_simposio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_simposio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.areaInvestigacion,
            this.fechaInicio,
            this.fechaFin,
            this.select});
            this.dgv_simposio.Location = new System.Drawing.Point(35, 201);
            this.dgv_simposio.Name = "dgv_simposio";
            this.dgv_simposio.ReadOnly = true;
            this.dgv_simposio.Size = new System.Drawing.Size(573, 182);
            this.dgv_simposio.TabIndex = 2;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // areaInvestigacion
            // 
            this.areaInvestigacion.HeaderText = "Area de investigacion";
            this.areaInvestigacion.Name = "areaInvestigacion";
            this.areaInvestigacion.ReadOnly = true;
            // 
            // fechaInicio
            // 
            this.fechaInicio.HeaderText = "Fecha Inicio";
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.ReadOnly = true;
            // 
            // fechaFin
            // 
            this.fechaFin.HeaderText = "Fecha Fin";
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.ReadOnly = true;
            // 
            // select
            // 
            this.select.HeaderText = "";
            this.select.Name = "select";
            this.select.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccionar simposios: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_generarReporte
            // 
            this.btn_generarReporte.Location = new System.Drawing.Point(450, 401);
            this.btn_generarReporte.Name = "btn_generarReporte";
            this.btn_generarReporte.Size = new System.Drawing.Size(158, 46);
            this.btn_generarReporte.TabIndex = 9;
            this.btn_generarReporte.Text = "Generar Reporte";
            this.btn_generarReporte.UseVisualStyleBackColor = true;
            // 
            // dgv_EdicionCongreso
            // 
            this.dgv_EdicionCongreso.AllowUserToAddRows = false;
            this.dgv_EdicionCongreso.AllowUserToDeleteRows = false;
            this.dgv_EdicionCongreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_EdicionCongreso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroEdicion,
            this.seleccionar});
            this.dgv_EdicionCongreso.Location = new System.Drawing.Point(35, 34);
            this.dgv_EdicionCongreso.Name = "dgv_EdicionCongreso";
            this.dgv_EdicionCongreso.ReadOnly = true;
            this.dgv_EdicionCongreso.Size = new System.Drawing.Size(573, 123);
            this.dgv_EdicionCongreso.TabIndex = 10;
            // 
            // numeroEdicion
            // 
            this.numeroEdicion.DataPropertyName = "numeroEdicion";
            this.numeroEdicion.HeaderText = "Numero Edicion Congreso";
            this.numeroEdicion.Name = "numeroEdicion";
            this.numeroEdicion.ReadOnly = true;
            // 
            // seleccionar
            // 
            this.seleccionar.DataPropertyName = "seleccionar";
            this.seleccionar.HeaderText = "Seleccionar";
            this.seleccionar.Name = "seleccionar";
            this.seleccionar.ReadOnly = true;
            // 
            // Formulario_datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 459);
            this.Controls.Add(this.dgv_EdicionCongreso);
            this.Controls.Add(this.btn_generarReporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_simposio);
            this.Controls.Add(this.label1);
            this.Name = "Formulario_datos";
            this.Text = "Formulario_datos";
            this.Load += new System.EventHandler(this.Formulario_datos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_simposio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EdicionCongreso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_simposio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaInvestigacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_generarReporte;
        private System.Windows.Forms.DataGridView dgv_EdicionCongreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroEdicion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seleccionar;
    }
}