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
            this.nroEdicionSimposio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.congreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_generarReporte = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_resultado = new System.Windows.Forms.DataGridView();
            this.dgv_edicion = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_simposio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_edicion)).BeginInit();
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
            this.select,
            this.nroEdicionSimposio,
            this.congreso});
            this.dgv_simposio.Location = new System.Drawing.Point(12, 176);
            this.dgv_simposio.Name = "dgv_simposio";
            this.dgv_simposio.Size = new System.Drawing.Size(760, 153);
            this.dgv_simposio.TabIndex = 2;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombreSimposio";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // areaInvestigacion
            // 
            this.areaInvestigacion.DataPropertyName = "areaInvestigacion";
            this.areaInvestigacion.HeaderText = "Area de investigacion";
            this.areaInvestigacion.Name = "areaInvestigacion";
            // 
            // fechaInicio
            // 
            this.fechaInicio.DataPropertyName = "fechaInicio";
            this.fechaInicio.HeaderText = "Fecha Inicio";
            this.fechaInicio.Name = "fechaInicio";
            // 
            // fechaFin
            // 
            this.fechaFin.DataPropertyName = "fechaFin";
            this.fechaFin.HeaderText = "Fecha Fin";
            this.fechaFin.Name = "fechaFin";
            // 
            // select
            // 
            this.select.HeaderText = "";
            this.select.Name = "select";
            // 
            // nroEdicionSimposio
            // 
            this.nroEdicionSimposio.DataPropertyName = "nroEdicionSimposio";
            this.nroEdicionSimposio.HeaderText = "Numero Simposio";
            this.nroEdicionSimposio.Name = "nroEdicionSimposio";
            // 
            // congreso
            // 
            this.congreso.DataPropertyName = "nroEdicionCongreso";
            this.congreso.HeaderText = "Edicion Congreso";
            this.congreso.Name = "congreso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccionar simposios: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_generarReporte
            // 
            this.btn_generarReporte.Location = new System.Drawing.Point(560, 344);
            this.btn_generarReporte.Name = "btn_generarReporte";
            this.btn_generarReporte.Size = new System.Drawing.Size(212, 65);
            this.btn_generarReporte.TabIndex = 9;
            this.btn_generarReporte.Text = "Generar Reporte";
            this.btn_generarReporte.UseVisualStyleBackColor = true;
            this.btn_generarReporte.Click += new System.EventHandler(this.btn_generarReporte_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Resultado";
            // 
            // dgv_resultado
            // 
            this.dgv_resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resultado.Location = new System.Drawing.Point(12, 425);
            this.dgv_resultado.Name = "dgv_resultado";
            this.dgv_resultado.Size = new System.Drawing.Size(760, 181);
            this.dgv_resultado.TabIndex = 14;
            // 
            // dgv_edicion
            // 
            this.dgv_edicion.AllowUserToAddRows = false;
            this.dgv_edicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_edicion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1});
            this.dgv_edicion.Location = new System.Drawing.Point(149, 13);
            this.dgv_edicion.Name = "dgv_edicion";
            this.dgv_edicion.Size = new System.Drawing.Size(249, 128);
            this.dgv_edicion.TabIndex = 16;
            this.dgv_edicion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_edicion_CellClick);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "numeroEdicion";
            this.Column2.HeaderText = "Numero Edicion";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // Formulario_datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 634);
            this.Controls.Add(this.dgv_edicion);
            this.Controls.Add(this.dgv_resultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_generarReporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_simposio);
            this.Controls.Add(this.label1);
            this.Name = "Formulario_datos";
            this.Text = "Formulario_datos";
            this.Load += new System.EventHandler(this.Formulario_datos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_simposio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_edicion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_simposio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_generarReporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_resultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaInvestigacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroEdicionSimposio;
        private System.Windows.Forms.DataGridViewTextBoxColumn congreso;
        private System.Windows.Forms.DataGridView dgv_edicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    }
}