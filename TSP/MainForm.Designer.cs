namespace TSP
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Description = new System.Windows.Forms.Label();
            this.rtbDataDescription = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbSolution = new System.Windows.Forms.RichTextBox();
            this.rtbPheromone = new System.Windows.Forms.RichTextBox();
            this.lbSolution = new System.Windows.Forms.Label();
            this.lbPheromone = new System.Windows.Forms.Label();
            this.numCities = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.theChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ACO = new System.Windows.Forms.TabPage();
            this.Greedy = new System.Windows.Forms.TabPage();
            this.Optimal = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.rtbGreedy = new System.Windows.Forms.RichTextBox();
            this.txtGreedy = new System.Windows.Forms.Label();
            this.ShortestLen = new System.Windows.Forms.Label();
            this.rtbShort = new System.Windows.Forms.RichTextBox();
            this.cbxChecked = new System.Windows.Forms.CheckBox();
            this.SoFarBestSolution = new System.Windows.Forms.Label();
            this.SoFarShortestLen = new System.Windows.Forms.Label();
            this.btnRunEnd = new System.Windows.Forms.Button();
            this.ppg = new System.Windows.Forms.PropertyGrid();
            this.btnRunOneIteration = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.rbtACOSolver = new System.Windows.Forms.RadioButton();
            this.rbtCreateGA = new System.Windows.Forms.RadioButton();
            this.rtbLen = new System.Windows.Forms.RichTextBox();
            this.cbxAnimation = new System.Windows.Forms.CheckBox();
            this.rtbBestSol = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theChart)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightYellow;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.tsbNew});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1432, 39);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbOpen
            // 
            this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(96, 36);
            this.tsbOpen.Text = "Open";
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // tsbNew
            // 
            this.tsbNew.BackColor = System.Drawing.Color.LightYellow;
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(87, 36);
            this.tsbNew.Text = "New";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.splitContainer1.Panel1.Controls.Add(this.Description);
            this.splitContainer1.Panel1.Controls.Add(this.rtbDataDescription);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.numCities);
            this.splitContainer1.Panel1.Controls.Add(this.title);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(997, 940);
            this.splitContainer1.SplitterDistance = 331;
            this.splitContainer1.TabIndex = 15;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Description.Location = new System.Drawing.Point(18, 47);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(146, 22);
            this.Description.TabIndex = 8;
            this.Description.Text = "Data Description:";
            // 
            // rtbDataDescription
            // 
            this.rtbDataDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDataDescription.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtbDataDescription.Location = new System.Drawing.Point(22, 72);
            this.rtbDataDescription.Name = "rtbDataDescription";
            this.rtbDataDescription.Size = new System.Drawing.Size(285, 124);
            this.rtbDataDescription.TabIndex = 0;
            this.rtbDataDescription.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rtbSolution);
            this.groupBox2.Controls.Add(this.rtbPheromone);
            this.groupBox2.Controls.Add(this.lbSolution);
            this.groupBox2.Controls.Add(this.lbPheromone);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(0, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 735);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // rtbSolution
            // 
            this.rtbSolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSolution.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtbSolution.Location = new System.Drawing.Point(22, 308);
            this.rtbSolution.Name = "rtbSolution";
            this.rtbSolution.Size = new System.Drawing.Size(285, 410);
            this.rtbSolution.TabIndex = 31;
            this.rtbSolution.Text = "";
            // 
            // rtbPheromone
            // 
            this.rtbPheromone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbPheromone.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtbPheromone.Location = new System.Drawing.Point(22, 51);
            this.rtbPheromone.Name = "rtbPheromone";
            this.rtbPheromone.Size = new System.Drawing.Size(285, 229);
            this.rtbPheromone.TabIndex = 28;
            this.rtbPheromone.Text = "";
            // 
            // lbSolution
            // 
            this.lbSolution.AutoSize = true;
            this.lbSolution.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbSolution.Location = new System.Drawing.Point(18, 283);
            this.lbSolution.Name = "lbSolution";
            this.lbSolution.Size = new System.Drawing.Size(84, 22);
            this.lbSolution.TabIndex = 29;
            this.lbSolution.Text = "Solutions";
            // 
            // lbPheromone
            // 
            this.lbPheromone.AutoSize = true;
            this.lbPheromone.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbPheromone.Location = new System.Drawing.Point(18, 26);
            this.lbPheromone.Name = "lbPheromone";
            this.lbPheromone.Size = new System.Drawing.Size(104, 22);
            this.lbPheromone.TabIndex = 24;
            this.lbPheromone.Text = "Pheromone";
            // 
            // numCities
            // 
            this.numCities.AutoSize = true;
            this.numCities.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numCities.Location = new System.Drawing.Point(18, 25);
            this.numCities.Name = "numCities";
            this.numCities.Size = new System.Drawing.Size(152, 22);
            this.numCities.TabIndex = 5;
            this.numCities.Text = "Number Of Cities:";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.title.Location = new System.Drawing.Point(18, 3);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(48, 22);
            this.title.TabIndex = 6;
            this.title.Text = "Title:";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer2.Size = new System.Drawing.Size(662, 940);
            this.splitContainer2.SplitterDistance = 709;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.theChart);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer4.Size = new System.Drawing.Size(662, 709);
            this.splitContainer4.SplitterDistance = 315;
            this.splitContainer4.TabIndex = 1;
            // 
            // theChart
            // 
            chartArea2.Name = "ChartArea1";
            this.theChart.ChartAreas.Add(chartArea2);
            this.theChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.theChart.Legends.Add(legend2);
            this.theChart.Location = new System.Drawing.Point(0, 0);
            this.theChart.Name = "theChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "IterationAverage";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "IterationBest";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "SoFarTheBest";
            this.theChart.Series.Add(series4);
            this.theChart.Series.Add(series5);
            this.theChart.Series.Add(series6);
            this.theChart.Size = new System.Drawing.Size(662, 315);
            this.theChart.TabIndex = 0;
            this.theChart.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ACO);
            this.tabControl1.Controls.Add(this.Greedy);
            this.tabControl1.Controls.Add(this.Optimal);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(662, 390);
            this.tabControl1.TabIndex = 0;
            // 
            // ACO
            // 
            this.ACO.Location = new System.Drawing.Point(4, 32);
            this.ACO.Name = "ACO";
            this.ACO.Padding = new System.Windows.Forms.Padding(3);
            this.ACO.Size = new System.Drawing.Size(654, 354);
            this.ACO.TabIndex = 0;
            this.ACO.Text = "Solution";
            this.ACO.UseVisualStyleBackColor = true;
            this.ACO.Paint += new System.Windows.Forms.PaintEventHandler(this.ACOSolution_Paint);
            // 
            // Greedy
            // 
            this.Greedy.Location = new System.Drawing.Point(4, 32);
            this.Greedy.Name = "Greedy";
            this.Greedy.Padding = new System.Windows.Forms.Padding(3);
            this.Greedy.Size = new System.Drawing.Size(654, 354);
            this.Greedy.TabIndex = 1;
            this.Greedy.Text = "Greedy";
            this.Greedy.UseVisualStyleBackColor = true;
            this.Greedy.Paint += new System.Windows.Forms.PaintEventHandler(this.Greedy_Paint);
            // 
            // Optimal
            // 
            this.Optimal.Location = new System.Drawing.Point(4, 32);
            this.Optimal.Name = "Optimal";
            this.Optimal.Size = new System.Drawing.Size(654, 354);
            this.Optimal.TabIndex = 2;
            this.Optimal.Text = "Optimal";
            this.Optimal.UseVisualStyleBackColor = true;
            this.Optimal.Paint += new System.Windows.Forms.PaintEventHandler(this.Optimal_Paint);
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.splitContainer5.Panel1.Controls.Add(this.rtbGreedy);
            this.splitContainer5.Panel1.Controls.Add(this.txtGreedy);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.splitContainer5.Panel2.Controls.Add(this.ShortestLen);
            this.splitContainer5.Panel2.Controls.Add(this.rtbShort);
            this.splitContainer5.Size = new System.Drawing.Size(662, 227);
            this.splitContainer5.SplitterDistance = 322;
            this.splitContainer5.TabIndex = 12;
            // 
            // rtbGreedy
            // 
            this.rtbGreedy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbGreedy.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtbGreedy.Location = new System.Drawing.Point(7, 48);
            this.rtbGreedy.Name = "rtbGreedy";
            this.rtbGreedy.Size = new System.Drawing.Size(312, 164);
            this.rtbGreedy.TabIndex = 10;
            this.rtbGreedy.Text = "";
            // 
            // txtGreedy
            // 
            this.txtGreedy.AutoSize = true;
            this.txtGreedy.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtGreedy.Location = new System.Drawing.Point(3, 23);
            this.txtGreedy.Name = "txtGreedy";
            this.txtGreedy.Size = new System.Drawing.Size(185, 22);
            this.txtGreedy.TabIndex = 9;
            this.txtGreedy.Text = "Greedy Route Length:";
            // 
            // ShortestLen
            // 
            this.ShortestLen.AutoSize = true;
            this.ShortestLen.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ShortestLen.Location = new System.Drawing.Point(3, 23);
            this.ShortestLen.Name = "ShortestLen";
            this.ShortestLen.Size = new System.Drawing.Size(197, 22);
            this.ShortestLen.TabIndex = 7;
            this.ShortestLen.Text = "Global Shortest Length:";
            // 
            // rtbShort
            // 
            this.rtbShort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbShort.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtbShort.Location = new System.Drawing.Point(7, 48);
            this.rtbShort.Name = "rtbShort";
            this.rtbShort.Size = new System.Drawing.Size(317, 167);
            this.rtbShort.TabIndex = 11;
            this.rtbShort.Text = "";
            // 
            // cbxChecked
            // 
            this.cbxChecked.AutoSize = true;
            this.cbxChecked.Checked = true;
            this.cbxChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxChecked.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxChecked.Location = new System.Drawing.Point(25, 408);
            this.cbxChecked.Name = "cbxChecked";
            this.cbxChecked.Size = new System.Drawing.Size(259, 26);
            this.cbxChecked.TabIndex = 4;
            this.cbxChecked.Text = "Show Pheromone/ Solutions";
            this.cbxChecked.UseVisualStyleBackColor = true;
            // 
            // SoFarBestSolution
            // 
            this.SoFarBestSolution.AutoSize = true;
            this.SoFarBestSolution.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SoFarBestSolution.ForeColor = System.Drawing.Color.Indigo;
            this.SoFarBestSolution.Location = new System.Drawing.Point(21, 141);
            this.SoFarBestSolution.Name = "SoFarBestSolution";
            this.SoFarBestSolution.Size = new System.Drawing.Size(203, 22);
            this.SoFarBestSolution.TabIndex = 10;
            this.SoFarBestSolution.Text = "So Far The Best solution:";
            // 
            // SoFarShortestLen
            // 
            this.SoFarShortestLen.AutoSize = true;
            this.SoFarShortestLen.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SoFarShortestLen.ForeColor = System.Drawing.Color.Maroon;
            this.SoFarShortestLen.Location = new System.Drawing.Point(19, 110);
            this.SoFarShortestLen.Name = "SoFarShortestLen";
            this.SoFarShortestLen.Size = new System.Drawing.Size(228, 22);
            this.SoFarShortestLen.TabIndex = 9;
            this.SoFarShortestLen.Text = "So Far The Shortest Length:";
            // 
            // btnRunEnd
            // 
            this.btnRunEnd.BackColor = System.Drawing.Color.LightCyan;
            this.btnRunEnd.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnRunEnd.FlatAppearance.BorderSize = 2;
            this.btnRunEnd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRunEnd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRunEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunEnd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRunEnd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRunEnd.Location = new System.Drawing.Point(23, 364);
            this.btnRunEnd.Name = "btnRunEnd";
            this.btnRunEnd.Size = new System.Drawing.Size(208, 38);
            this.btnRunEnd.TabIndex = 26;
            this.btnRunEnd.Text = "Run To End";
            this.btnRunEnd.UseVisualStyleBackColor = false;
            this.btnRunEnd.Click += new System.EventHandler(this.btnRunEnd_Click);
            // 
            // ppg
            // 
            this.ppg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ppg.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ppg.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ppg.Location = new System.Drawing.Point(0, 472);
            this.ppg.Name = "ppg";
            this.ppg.Size = new System.Drawing.Size(431, 468);
            this.ppg.TabIndex = 3;
            // 
            // btnRunOneIteration
            // 
            this.btnRunOneIteration.BackColor = System.Drawing.Color.LightCyan;
            this.btnRunOneIteration.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnRunOneIteration.FlatAppearance.BorderSize = 2;
            this.btnRunOneIteration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRunOneIteration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRunOneIteration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunOneIteration.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRunOneIteration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRunOneIteration.Location = new System.Drawing.Point(25, 309);
            this.btnRunOneIteration.Name = "btnRunOneIteration";
            this.btnRunOneIteration.Size = new System.Drawing.Size(206, 38);
            this.btnRunOneIteration.TabIndex = 12;
            this.btnRunOneIteration.Text = "Run One iteration";
            this.btnRunOneIteration.UseVisualStyleBackColor = false;
            this.btnRunOneIteration.Click += new System.EventHandler(this.btnRunOneIteration_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightCyan;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReset.Location = new System.Drawing.Point(296, 37);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 38);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 39);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackColor = System.Drawing.Color.MintCream;
            this.splitContainer3.Panel2.Controls.Add(this.rbtACOSolver);
            this.splitContainer3.Panel2.Controls.Add(this.rbtCreateGA);
            this.splitContainer3.Panel2.Controls.Add(this.rtbLen);
            this.splitContainer3.Panel2.Controls.Add(this.cbxAnimation);
            this.splitContainer3.Panel2.Controls.Add(this.rtbBestSol);
            this.splitContainer3.Panel2.Controls.Add(this.SoFarShortestLen);
            this.splitContainer3.Panel2.Controls.Add(this.btnRunEnd);
            this.splitContainer3.Panel2.Controls.Add(this.ppg);
            this.splitContainer3.Panel2.Controls.Add(this.cbxChecked);
            this.splitContainer3.Panel2.Controls.Add(this.SoFarBestSolution);
            this.splitContainer3.Panel2.Controls.Add(this.btnRunOneIteration);
            this.splitContainer3.Panel2.Controls.Add(this.btnReset);
            this.splitContainer3.Size = new System.Drawing.Size(1432, 940);
            this.splitContainer3.SplitterDistance = 997;
            this.splitContainer3.TabIndex = 16;
            // 
            // rbtACOSolver
            // 
            this.rbtACOSolver.AutoSize = true;
            this.rbtACOSolver.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtACOSolver.Location = new System.Drawing.Point(23, 62);
            this.rbtACOSolver.Name = "rbtACOSolver";
            this.rbtACOSolver.Size = new System.Drawing.Size(178, 26);
            this.rbtACOSolver.TabIndex = 32;
            this.rbtACOSolver.Text = "Create ACO Solver";
            this.rbtACOSolver.UseVisualStyleBackColor = true;
            this.rbtACOSolver.CheckedChanged += new System.EventHandler(this.rbtACOSolver_CheckedChanged);
            // 
            // rbtCreateGA
            // 
            this.rbtCreateGA.AutoSize = true;
            this.rbtCreateGA.Checked = true;
            this.rbtCreateGA.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtCreateGA.Location = new System.Drawing.Point(25, 21);
            this.rbtCreateGA.Name = "rbtCreateGA";
            this.rbtCreateGA.Size = new System.Drawing.Size(112, 26);
            this.rbtCreateGA.TabIndex = 31;
            this.rbtCreateGA.TabStop = true;
            this.rbtCreateGA.Text = "Create GA";
            this.rbtCreateGA.UseVisualStyleBackColor = true;
            // 
            // rtbLen
            // 
            this.rtbLen.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtbLen.Location = new System.Drawing.Point(244, 99);
            this.rtbLen.Margin = new System.Windows.Forms.Padding(0);
            this.rtbLen.Name = "rtbLen";
            this.rtbLen.Size = new System.Drawing.Size(146, 33);
            this.rtbLen.TabIndex = 29;
            this.rtbLen.Text = "";
            // 
            // cbxAnimation
            // 
            this.cbxAnimation.AutoSize = true;
            this.cbxAnimation.Checked = true;
            this.cbxAnimation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAnimation.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxAnimation.Location = new System.Drawing.Point(23, 440);
            this.cbxAnimation.Name = "cbxAnimation";
            this.cbxAnimation.Size = new System.Drawing.Size(271, 26);
            this.cbxAnimation.TabIndex = 28;
            this.cbxAnimation.Text = "Show Chart/Route Animations";
            this.cbxAnimation.UseVisualStyleBackColor = true;
            // 
            // rtbBestSol
            // 
            this.rtbBestSol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbBestSol.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtbBestSol.Location = new System.Drawing.Point(23, 166);
            this.rtbBestSol.Name = "rtbBestSol";
            this.rtbBestSol.Size = new System.Drawing.Size(367, 121);
            this.rtbBestSol.TabIndex = 27;
            this.rtbBestSol.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 979);
            this.Controls.Add(this.splitContainer3);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "TSP Solver";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.theChart)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label SoFarBestSolution;
        private System.Windows.Forms.Label SoFarShortestLen;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label numCities;
        private System.Windows.Forms.Button btnRunEnd;
        private System.Windows.Forms.CheckBox cbxChecked;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtbSolution;
        private System.Windows.Forms.RichTextBox rtbPheromone;
        private System.Windows.Forms.Label lbSolution;
        private System.Windows.Forms.Label lbPheromone;
        private System.Windows.Forms.PropertyGrid ppg;
        private System.Windows.Forms.Button btnRunOneIteration;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataVisualization.Charting.Chart theChart;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.RichTextBox rtbDataDescription;
        private System.Windows.Forms.Label ShortestLen;
        private System.Windows.Forms.RichTextBox rtbBestSol;
        private System.Windows.Forms.CheckBox cbxAnimation;
        private System.Windows.Forms.RichTextBox rtbLen;
        private System.Windows.Forms.Label txtGreedy;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ACO;
        private System.Windows.Forms.TabPage Greedy;
        private System.Windows.Forms.TabPage Optimal;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.RichTextBox rtbShort;
        private System.Windows.Forms.RichTextBox rtbGreedy;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.RadioButton rbtACOSolver;
        private System.Windows.Forms.RadioButton rbtCreateGA;
    }
}

