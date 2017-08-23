namespace NetworkVisualization_Visualization
{
    partial class ServerLevelInformation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ch2_Vis_valMa98 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sec1_dr_01248_dv = new System.Windows.Forms.DataGridView();
            this.sec2_dr_01248_dv = new System.Windows.Forms.DataGridView();
            this.ch1_Vis_valMa = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ch2_Vis_valMa98)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sec1_dr_01248_dv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sec2_dr_01248_dv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch1_Vis_valMa)).BeginInit();
            this.SuspendLayout();
            // 
            // ch2_Vis_valMa98
            // 
            chartArea1.Name = "ChartArea1";
            this.ch2_Vis_valMa98.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ch2_Vis_valMa98.Legends.Add(legend1);
            this.ch2_Vis_valMa98.Location = new System.Drawing.Point(-48, 488);
            this.ch2_Vis_valMa98.Name = "ch2_Vis_valMa98";
            this.ch2_Vis_valMa98.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "ServerLevelStatus Information";
            series1.YValuesPerPoint = 2;
            this.ch2_Vis_valMa98.Series.Add(series1);
            this.ch2_Vis_valMa98.Size = new System.Drawing.Size(324, 213);
            this.ch2_Vis_valMa98.TabIndex = 1;
            this.ch2_Vis_valMa98.Text = "ch2_Vis_valMa98";
            this.ch2_Vis_valMa98.Visible = false;
            this.ch2_Vis_valMa98.Click += new System.EventHandler(this.ch2_Vis_valMa98_Click);
            // 
            // sec1_dr_01248_dv
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.sec1_dr_01248_dv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.sec1_dr_01248_dv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sec1_dr_01248_dv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.sec1_dr_01248_dv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sec1_dr_01248_dv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.sec1_dr_01248_dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sec1_dr_01248_dv.Location = new System.Drawing.Point(181, 503);
            this.sec1_dr_01248_dv.Name = "sec1_dr_01248_dv";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sec1_dr_01248_dv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.sec1_dr_01248_dv.Size = new System.Drawing.Size(262, 88);
            this.sec1_dr_01248_dv.TabIndex = 3;
            this.sec1_dr_01248_dv.Visible = false;
            // 
            // sec2_dr_01248_dv
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.sec2_dr_01248_dv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.sec2_dr_01248_dv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sec2_dr_01248_dv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.sec2_dr_01248_dv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sec2_dr_01248_dv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.sec2_dr_01248_dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sec2_dr_01248_dv.Location = new System.Drawing.Point(86, 364);
            this.sec2_dr_01248_dv.Name = "sec2_dr_01248_dv";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sec2_dr_01248_dv.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.sec2_dr_01248_dv.Size = new System.Drawing.Size(264, 86);
            this.sec2_dr_01248_dv.TabIndex = 4;
            this.sec2_dr_01248_dv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // ch1_Vis_valMa
            // 
            chartArea2.Name = "ChartArea1";
            this.ch1_Vis_valMa.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ch1_Vis_valMa.Legends.Add(legend2);
            this.ch1_Vis_valMa.Location = new System.Drawing.Point(468, 208);
            this.ch1_Vis_valMa.Name = "ch1_Vis_valMa";
            this.ch1_Vis_valMa.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Network Packets Info";
            series2.YValuesPerPoint = 2;
            this.ch1_Vis_valMa.Series.Add(series2);
            this.ch1_Vis_valMa.Size = new System.Drawing.Size(295, 260);
            this.ch1_Vis_valMa.TabIndex = 7;
            this.ch1_Vis_valMa.Text = "ch1_Vis_valMa";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(638, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 40);
            this.button2.TabIndex = 122;
            this.button2.Text = "Recent Execution and Data Details";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Playbill", 18F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(-360, 548);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 24);
            this.label1.TabIndex = 124;
            this.label1.Text = "Server Level Status Informations - Busy / Idle etc..,";
            this.label1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(-51, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 16);
            this.label6.TabIndex = 129;
            this.label6.Text = "Graphical Representataion";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Playbill", 18F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(94, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 24);
            this.label7.TabIndex = 130;
            this.label7.Text = "Number of Packets Received / Send Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(522, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 16);
            this.label3.TabIndex = 131;
            this.label3.Text = "Graphical Representataion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(-272, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 16);
            this.label2.TabIndex = 132;
            this.label2.Text = "List of Server Status Informations";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "cpuBusy",
            "ioBusy",
            "Idle"});
            this.comboBox1.Location = new System.Drawing.Point(-269, 314);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 21);
            this.comboBox1.TabIndex = 133;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ServerLevelInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::NetworkVisualization_Visualization.Properties.Resources.SecondPage2;
            this.ClientSize = new System.Drawing.Size(796, 513);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ch1_Vis_valMa);
            this.Controls.Add(this.sec2_dr_01248_dv);
            this.Controls.Add(this.sec1_dr_01248_dv);
            this.Controls.Add(this.ch2_Vis_valMa98);
            this.Name = "ServerLevelInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Business Management ServerLevelInformation";
            this.Load += new System.EventHandler(this.ServerLevelInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ch2_Vis_valMa98)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sec1_dr_01248_dv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sec2_dr_01248_dv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch1_Vis_valMa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ch2_Vis_valMa98;
        private System.Windows.Forms.DataGridView sec1_dr_01248_dv;
        private System.Windows.Forms.DataGridView sec2_dr_01248_dv;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch1_Vis_valMa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}