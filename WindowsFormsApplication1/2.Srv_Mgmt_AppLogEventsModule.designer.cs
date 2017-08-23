namespace NetworkVisualization_Visualization
{
    partial class AppLogEventsModule
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
            this.view_disp3_dg = new System.Windows.Forms.DataGridView();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.view_disp4_dg = new System.Windows.Forms.DataGridView();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.view_disp3_dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_disp4_dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.SuspendLayout();
            // 
            // view_disp3_dg
            // 
            this.view_disp3_dg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.view_disp3_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_disp3_dg.Location = new System.Drawing.Point(93, 346);
            this.view_disp3_dg.Name = "view_disp3_dg";
            this.view_disp3_dg.Size = new System.Drawing.Size(303, 67);
            this.view_disp3_dg.TabIndex = 15;
            // 
            // chart3
            // 
            chartArea1.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart3.Legends.Add(legend1);
            this.chart3.Location = new System.Drawing.Point(57, 400);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Authentication Mode";
            this.chart3.Series.Add(series1);
            this.chart3.Size = new System.Drawing.Size(463, 300);
            this.chart3.TabIndex = 14;
            this.chart3.Text = "chart3";
            // 
            // view_disp4_dg
            // 
            this.view_disp4_dg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.view_disp4_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_disp4_dg.Location = new System.Drawing.Point(604, 346);
            this.view_disp4_dg.Name = "view_disp4_dg";
            this.view_disp4_dg.Size = new System.Drawing.Size(303, 67);
            this.view_disp4_dg.TabIndex = 17;
            // 
            // chart4
            // 
            chartArea2.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart4.Legends.Add(legend2);
            this.chart4.Location = new System.Drawing.Point(558, 400);
            this.chart4.Name = "chart4";
            this.chart4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Protocols Availability";
            this.chart4.Series.Add(series2);
            this.chart4.Size = new System.Drawing.Size(418, 300);
            this.chart4.TabIndex = 16;
            this.chart4.Text = "chart4";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(379, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Extract server level info";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AppLogEventsModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::NetworkVisualization_Visualization.Properties.Resources.Fourth1;
            this.ClientSize = new System.Drawing.Size(1144, 741);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.view_disp4_dg);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.view_disp3_dg);
            this.Controls.Add(this.chart3);
            this.Name = "AppLogEventsModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Management Application Log Events Module";
            this.Load += new System.EventHandler(this.AppLogEventsModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view_disp3_dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_disp4_dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView view_disp3_dg;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataGridView view_disp4_dg;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.Button button2;
    }
}