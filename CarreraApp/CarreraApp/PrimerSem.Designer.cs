namespace CarreraApp
{
    partial class PrimerSem
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
            this.universidadDataSet = new CarreraApp.universidadDataSet();
            this.universidadDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_REPORTE_PRIMER_SEMESTREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPREPORTEPRIMERSEMESTREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_REPORTE_PRIMER_SEMESTRETableAdapter = new CarreraApp.universidadDataSetTableAdapters.SP_REPORTE_PRIMER_SEMESTRETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_REPORTE_PRIMER_SEMESTREBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPREPORTEPRIMERSEMESTREBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetPrimSem";
            reportDataSource1.Value = this.SP_REPORTE_PRIMER_SEMESTREBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CarreraApp.rptPrimSem.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 359);
            this.reportViewer1.TabIndex = 0;
            // 
            // universidadDataSet
            // 
            this.universidadDataSet.DataSetName = "universidadDataSet";
            this.universidadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // universidadDataSetBindingSource
            // 
            this.universidadDataSetBindingSource.DataSource = this.universidadDataSet;
            this.universidadDataSetBindingSource.Position = 0;
            // 
            // SP_REPORTE_PRIMER_SEMESTREBindingSource
            // 
            this.SP_REPORTE_PRIMER_SEMESTREBindingSource.DataMember = "SP_REPORTE_PRIMER_SEMESTRE";
            this.SP_REPORTE_PRIMER_SEMESTREBindingSource.DataSource = this.universidadDataSet;
            // 
            // sPREPORTEPRIMERSEMESTREBindingSource
            // 
            this.sPREPORTEPRIMERSEMESTREBindingSource.DataMember = "SP_REPORTE_PRIMER_SEMESTRE";
            this.sPREPORTEPRIMERSEMESTREBindingSource.DataSource = this.universidadDataSetBindingSource;
            // 
            // sP_REPORTE_PRIMER_SEMESTRETableAdapter
            // 
            this.sP_REPORTE_PRIMER_SEMESTRETableAdapter.ClearBeforeFill = true;
            // 
            // PrimerSem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PrimerSem";
            this.Text = "PrimerSem";
            this.Load += new System.EventHandler(this.PrimerSem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_REPORTE_PRIMER_SEMESTREBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPREPORTEPRIMERSEMESTREBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource universidadDataSetBindingSource;
        private universidadDataSet universidadDataSet;
        private System.Windows.Forms.BindingSource SP_REPORTE_PRIMER_SEMESTREBindingSource;
        private System.Windows.Forms.BindingSource sPREPORTEPRIMERSEMESTREBindingSource;
        private universidadDataSetTableAdapters.SP_REPORTE_PRIMER_SEMESTRETableAdapter sP_REPORTE_PRIMER_SEMESTRETableAdapter;
    }
}