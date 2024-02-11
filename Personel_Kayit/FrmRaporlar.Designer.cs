
namespace Personel_Kayit
{
    partial class FrmRaporlar
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRaporlar));
            this.Tbl_PersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PersonelVeriTabaniDataSet = new Personel_Kayit.PersonelVeriTabaniDataSet();
            this.Tbl_PersonelTableAdapter = new Personel_Kayit.PersonelVeriTabaniDataSetTableAdapters.Tbl_PersonelTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_PersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelVeriTabaniDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Tbl_PersonelBindingSource
            // 
            this.Tbl_PersonelBindingSource.DataMember = "Tbl_Personel";
            this.Tbl_PersonelBindingSource.DataSource = this.PersonelVeriTabaniDataSet;
            // 
            // PersonelVeriTabaniDataSet
            // 
            this.PersonelVeriTabaniDataSet.DataSetName = "PersonelVeriTabaniDataSet";
            this.PersonelVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Tbl_PersonelTableAdapter
            // 
            this.Tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Tbl_PersonelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Personel_Kayit.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(768, 534);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Tbl_PersonelBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.Location = new System.Drawing.Point(106, 159);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(284, 184);
            this.reportViewer2.TabIndex = 1;
            this.reportViewer2.Visible = false;
            // 
            // FrmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 534);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRaporlar";
            this.Text = "Rapor Paneli";
            this.Load += new System.EventHandler(this.FrmRaporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_PersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelVeriTabaniDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource Tbl_PersonelBindingSource;
        private PersonelVeriTabaniDataSet PersonelVeriTabaniDataSet;
        private PersonelVeriTabaniDataSetTableAdapters.Tbl_PersonelTableAdapter Tbl_PersonelTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}