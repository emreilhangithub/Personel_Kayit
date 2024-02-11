
namespace Personel_Kayit
{
    partial class FrmGrafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrafikler));
            this.chartSehirler = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMeslekMaas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartSehirler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMeslekMaas)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSehirler
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSehirler.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSehirler.Legends.Add(legend1);
            this.chartSehirler.Location = new System.Drawing.Point(-4, -5);
            this.chartSehirler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartSehirler.Name = "chartSehirler";
            this.chartSehirler.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Sehirler";
            this.chartSehirler.Series.Add(series1);
            this.chartSehirler.Size = new System.Drawing.Size(535, 620);
            this.chartSehirler.TabIndex = 0;
            this.chartSehirler.Text = "chart1";
            // 
            // chartMeslekMaas
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMeslekMaas.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMeslekMaas.Legends.Add(legend2);
            this.chartMeslekMaas.Location = new System.Drawing.Point(527, -5);
            this.chartMeslekMaas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartMeslekMaas.Name = "chartMeslekMaas";
            this.chartMeslekMaas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Meslek-Maas";
            this.chartMeslekMaas.Series.Add(series2);
            this.chartMeslekMaas.Size = new System.Drawing.Size(519, 603);
            this.chartMeslekMaas.TabIndex = 1;
            this.chartMeslekMaas.Text = "chart2";
            // 
            // FrmGrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1038, 588);
            this.Controls.Add(this.chartMeslekMaas);
            this.Controls.Add(this.chartSehirler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmGrafikler";
            this.Text = "Grafik Paneli";
            this.Load += new System.EventHandler(this.FrmGrafikler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSehirler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMeslekMaas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSehirler;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMeslekMaas;
    }
}