namespace CarreraApp
{
    partial class ReporteAsignatura
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.asignaturaDataSet = new CarreraApp.AsignaturaDataSet();
            this.asignaturaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AsignaturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asignaturaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.asignaturaTableAdapter = new CarreraApp.AsignaturaDataSetTableAdapters.AsignaturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsignaturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.asignaturaBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CarreraApp.Reporte.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // asignaturaDataSet
            // 
            this.asignaturaDataSet.DataSetName = "AsignaturaDataSet";
            this.asignaturaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asignaturaDataSetBindingSource
            // 
            this.asignaturaDataSetBindingSource.DataSource = this.asignaturaDataSet;
            this.asignaturaDataSetBindingSource.Position = 0;
            // 
            // AsignaturaBindingSource
            // 
            this.AsignaturaBindingSource.DataMember = "Asignatura";
            this.AsignaturaBindingSource.DataSource = this.asignaturaDataSet;
            // 
            // asignaturaBindingSource1
            // 
            this.asignaturaBindingSource1.DataMember = "Asignatura";
            this.asignaturaBindingSource1.DataSource = this.asignaturaDataSetBindingSource;
            // 
            // asignaturaTableAdapter
            // 
            this.asignaturaTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteAsignatura";
            this.Text = "ReporteAsignatura";
            this.Load += new System.EventHandler(this.ReporteAsignatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.asignaturaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsignaturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource asignaturaDataSetBindingSource;
        private AsignaturaDataSet asignaturaDataSet;
        private System.Windows.Forms.BindingSource AsignaturaBindingSource;
        private System.Windows.Forms.BindingSource asignaturaBindingSource1;
        private AsignaturaDataSetTableAdapters.AsignaturaTableAdapter asignaturaTableAdapter;
    }
}