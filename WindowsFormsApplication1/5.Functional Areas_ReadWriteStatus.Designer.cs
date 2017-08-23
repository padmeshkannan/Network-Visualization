namespace NetworkVisualization_Visualization
{
    partial class ReadWriteStatus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ch1_Vis_valMa = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.datagrid_ReadLatency = new System.Windows.Forms.DataGridView();
            this.ch2_Vis_valMa98 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.sec1_dr_01248_dv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.ch3_Vis_valMa98 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ch1_Vis_valMa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_ReadLatency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch2_Vis_valMa98)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sec1_dr_01248_dv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch3_Vis_valMa98)).BeginInit();
            this.SuspendLayout();
            // 
            // ch1_Vis_valMa
            // 
            this.ch1_Vis_valMa.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.ch1_Vis_valMa.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ch1_Vis_valMa.Legends.Add(legend1);
            this.ch1_Vis_valMa.Location = new System.Drawing.Point(1, 266);
            this.ch1_Vis_valMa.Name = "ch1_Vis_valMa";
            this.ch1_Vis_valMa.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Latency period";
            this.ch1_Vis_valMa.Series.Add(series1);
            this.ch1_Vis_valMa.Size = new System.Drawing.Size(349, 283);
            this.ch1_Vis_valMa.TabIndex = 0;
            this.ch1_Vis_valMa.Text = "ch1_Vis_valMa";
            // 
            // datagrid_ReadLatency
            // 
            this.datagrid_ReadLatency.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_ReadLatency.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_ReadLatency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_ReadLatency.Location = new System.Drawing.Point(348, 42);
            this.datagrid_ReadLatency.Name = "datagrid_ReadLatency";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.datagrid_ReadLatency.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_ReadLatency.Size = new System.Drawing.Size(331, 123);
            this.datagrid_ReadLatency.TabIndex = 136;
            // 
            // ch2_Vis_valMa98
            // 
            this.ch2_Vis_valMa98.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.ch2_Vis_valMa98.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ch2_Vis_valMa98.Legends.Add(legend2);
            this.ch2_Vis_valMa98.Location = new System.Drawing.Point(244, 235);
            this.ch2_Vis_valMa98.Name = "ch2_Vis_valMa98";
            this.ch2_Vis_valMa98.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series2.Legend = "Legend1";
            series2.Name = "Average Bytes Transfer in Data File";
            this.ch2_Vis_valMa98.Series.Add(series2);
            this.ch2_Vis_valMa98.Size = new System.Drawing.Size(355, 309);
            this.ch2_Vis_valMa98.TabIndex = 137;
            this.ch2_Vis_valMa98.Text = "ch2_Vis_valMa98";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 24);
            this.label1.TabIndex = 138;
            this.label1.Text = "Latency and Bytes Tranfer info with Server";
            // 
            // sec1_dr_01248_dv
            // 
            this.sec1_dr_01248_dv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sec1_dr_01248_dv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.sec1_dr_01248_dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sec1_dr_01248_dv.Location = new System.Drawing.Point(695, 44);
            this.sec1_dr_01248_dv.Name = "sec1_dr_01248_dv";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.sec1_dr_01248_dv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.sec1_dr_01248_dv.Size = new System.Drawing.Size(264, 121);
            this.sec1_dr_01248_dv.TabIndex = 139;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(364, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(386, 23);
            this.button1.TabIndex = 140;
            this.button1.Text = "Start Refreshing the Data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ch3_Vis_valMa98
            // 
            this.ch3_Vis_valMa98.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.ch3_Vis_valMa98.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ch3_Vis_valMa98.Legends.Add(legend3);
            this.ch3_Vis_valMa98.Location = new System.Drawing.Point(605, 235);
            this.ch3_Vis_valMa98.Name = "ch3_Vis_valMa98";
            this.ch3_Vis_valMa98.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Latency period";
            this.ch3_Vis_valMa98.Series.Add(series3);
            this.ch3_Vis_valMa98.Size = new System.Drawing.Size(334, 263);
            this.ch3_Vis_valMa98.TabIndex = 141;
            this.ch3_Vis_valMa98.Text = "ch3_Vis_valMa98";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(709, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 37);
            this.button2.TabIndex = 142;
            this.button2.Text = "Security Events Tracing =>";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReadWriteStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NetworkVisualization_Visualization.Properties.Resources.ThirdPage;
            this.ClientSize = new System.Drawing.Size(961, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ch3_Vis_valMa98);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sec1_dr_01248_dv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ch2_Vis_valMa98);
            this.Controls.Add(this.datagrid_ReadLatency);
            this.Controls.Add(this.ch1_Vis_valMa);
            this.Name = "ReadWriteStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Functional Areas Read Write Status";
            this.Load += new System.EventHandler(this.ReadWriteStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ch1_Vis_valMa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_ReadLatency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch2_Vis_valMa98)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sec1_dr_01248_dv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch3_Vis_valMa98)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ch1_Vis_valMa;
        private System.Windows.Forms.DataGridView datagrid_ReadLatency;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch2_Vis_valMa98;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView sec1_dr_01248_dv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch3_Vis_valMa98;
        private System.Windows.Forms.Button button2;
    }
}