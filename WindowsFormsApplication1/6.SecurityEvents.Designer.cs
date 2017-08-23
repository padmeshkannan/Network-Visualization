namespace NetworkVisualization_Visualization
{
    partial class UserContextValue
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
            this.ch1_Vis_valMa = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sec2_dr_01248_dv = new System.Windows.Forms.DataGridView();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ch1_Vis_valMa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sec2_dr_01248_dv)).BeginInit();
            this.SuspendLayout();
            // 
            // ch1_Vis_valMa
            // 
            chartArea1.Name = "ChartArea1";
            this.ch1_Vis_valMa.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ch1_Vis_valMa.Legends.Add(legend1);
            this.ch1_Vis_valMa.Location = new System.Drawing.Point(-1, -21);
            this.ch1_Vis_valMa.Name = "ch1_Vis_valMa";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ch1_Vis_valMa.Series.Add(series1);
            this.ch1_Vis_valMa.Size = new System.Drawing.Size(601, 656);
            this.ch1_Vis_valMa.TabIndex = 19;
            this.ch1_Vis_valMa.Text = "ch1_Vis_valMa";
            // 
            // sec2_dr_01248_dv
            // 
            this.sec2_dr_01248_dv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.sec2_dr_01248_dv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.sec2_dr_01248_dv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sec2_dr_01248_dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sec2_dr_01248_dv.Location = new System.Drawing.Point(468, 167);
            this.sec2_dr_01248_dv.Name = "sec2_dr_01248_dv";
            this.sec2_dr_01248_dv.Size = new System.Drawing.Size(370, 278);
            this.sec2_dr_01248_dv.TabIndex = 20;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(779, 25);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(24, 13);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Exit";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AUTHENTICATE",
            "CONTROL",
            "CONNECT",
            "VIEW DETAILS"});
            this.comboBox1.Location = new System.Drawing.Point(597, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 24);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Database Actions";
            this.label1.Visible = false;
            // 
            // UserContextValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(847, 543);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.sec2_dr_01248_dv);
            this.Controls.Add(this.ch1_Vis_valMa);
            this.Name = "UserContextValue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecurityEvents";
            this.Load += new System.EventHandler(this.UserContextValue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ch1_Vis_valMa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sec2_dr_01248_dv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ch1_Vis_valMa;
        private System.Windows.Forms.DataGridView sec2_dr_01248_dv;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}