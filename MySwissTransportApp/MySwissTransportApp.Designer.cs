﻿namespace MySwissTransportApp {
  partial class OeVApp {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.tabControlTabs = new System.Windows.Forms.TabControl();
      this.tabPgConnections = new System.Windows.Forms.TabPage();
      this.btnPinConnections = new System.Windows.Forms.Button();
      this.groupBoxPinned = new System.Windows.Forms.GroupBox();
      this.listBoxPinned = new System.Windows.Forms.ListBox();
      this.dataGridViewConnections = new System.Windows.Forms.DataGridView();
      this.colStartLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnConnectionsSearch = new System.Windows.Forms.Button();
      this.pictureBoxSearchStart = new System.Windows.Forms.PictureBox();
      this.pictureBoxSearchGoal = new System.Windows.Forms.PictureBox();
      this.lblTitleConnections = new System.Windows.Forms.Label();
      this.cmbxDestination = new System.Windows.Forms.ComboBox();
      this.cmbxStartLocation = new System.Windows.Forms.ComboBox();
      this.lblDestination = new System.Windows.Forms.Label();
      this.lblStartLocation = new System.Windows.Forms.Label();
      this.tabPgDepartures = new System.Windows.Forms.TabPage();
      this.btnDeparturesSearch = new System.Windows.Forms.Button();
      this.cmbxDepartureStation = new System.Windows.Forms.ComboBox();
      this.lblDepartureStation = new System.Windows.Forms.Label();
      this.dataGridViewDepartures = new System.Windows.Forms.DataGridView();
      this.colFromStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colDirection = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colDepartureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lblTitleDepartures = new System.Windows.Forms.Label();
      this.tabPgMap = new System.Windows.Forms.TabPage();
      this.webViewMap = new Microsoft.Web.WebView2.WinForms.WebView2();
      this.lblTitleMap = new System.Windows.Forms.Label();
      this.pnlControl = new System.Windows.Forms.Panel();
      this.lblTitle = new System.Windows.Forms.Label();
      this.tabControlTabs.SuspendLayout();
      this.tabPgConnections.SuspendLayout();
      this.groupBoxPinned.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConnections)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchStart)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchGoal)).BeginInit();
      this.tabPgDepartures.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartures)).BeginInit();
      this.tabPgMap.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.webViewMap)).BeginInit();
      this.pnlControl.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControlTabs
      // 
      this.tabControlTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControlTabs.Controls.Add(this.tabPgConnections);
      this.tabControlTabs.Controls.Add(this.tabPgDepartures);
      this.tabControlTabs.Controls.Add(this.tabPgMap);
      this.tabControlTabs.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.tabControlTabs.Location = new System.Drawing.Point(-4, 86);
      this.tabControlTabs.Name = "tabControlTabs";
      this.tabControlTabs.SelectedIndex = 0;
      this.tabControlTabs.Size = new System.Drawing.Size(1218, 559);
      this.tabControlTabs.TabIndex = 1;
      // 
      // tabPgConnections
      // 
      this.tabPgConnections.Controls.Add(this.btnPinConnections);
      this.tabPgConnections.Controls.Add(this.groupBoxPinned);
      this.tabPgConnections.Controls.Add(this.dataGridViewConnections);
      this.tabPgConnections.Controls.Add(this.btnConnectionsSearch);
      this.tabPgConnections.Controls.Add(this.pictureBoxSearchStart);
      this.tabPgConnections.Controls.Add(this.pictureBoxSearchGoal);
      this.tabPgConnections.Controls.Add(this.lblTitleConnections);
      this.tabPgConnections.Controls.Add(this.cmbxDestination);
      this.tabPgConnections.Controls.Add(this.cmbxStartLocation);
      this.tabPgConnections.Controls.Add(this.lblDestination);
      this.tabPgConnections.Controls.Add(this.lblStartLocation);
      this.tabPgConnections.Location = new System.Drawing.Point(4, 41);
      this.tabPgConnections.Name = "tabPgConnections";
      this.tabPgConnections.Padding = new System.Windows.Forms.Padding(3);
      this.tabPgConnections.Size = new System.Drawing.Size(1210, 514);
      this.tabPgConnections.TabIndex = 0;
      this.tabPgConnections.Text = "Verbindungen";
      this.tabPgConnections.UseVisualStyleBackColor = true;
      // 
      // btnPinConnections
      // 
      this.btnPinConnections.Enabled = false;
      this.btnPinConnections.Image = global::MySwissTransportApp.Properties.Resources.icons8_pin_24px_1;
      this.btnPinConnections.Location = new System.Drawing.Point(384, 124);
      this.btnPinConnections.Name = "btnPinConnections";
      this.btnPinConnections.Size = new System.Drawing.Size(47, 39);
      this.btnPinConnections.TabIndex = 14;
      this.btnPinConnections.UseVisualStyleBackColor = true;
      this.btnPinConnections.Click += new System.EventHandler(this.btnPinConnections_Click);
      this.btnPinConnections.MouseHover += new System.EventHandler(this.btnPinConnections_MouseHover);
      // 
      // groupBoxPinned
      // 
      this.groupBoxPinned.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxPinned.Controls.Add(this.listBoxPinned);
      this.groupBoxPinned.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.groupBoxPinned.Location = new System.Drawing.Point(743, 23);
      this.groupBoxPinned.Name = "groupBoxPinned";
      this.groupBoxPinned.Size = new System.Drawing.Size(439, 209);
      this.groupBoxPinned.TabIndex = 13;
      this.groupBoxPinned.TabStop = false;
      this.groupBoxPinned.Text = "Favoriten";
      // 
      // listBoxPinned
      // 
      this.listBoxPinned.FormattingEnabled = true;
      this.listBoxPinned.ItemHeight = 25;
      this.listBoxPinned.Location = new System.Drawing.Point(6, 28);
      this.listBoxPinned.Name = "listBoxPinned";
      this.listBoxPinned.Size = new System.Drawing.Size(427, 179);
      this.listBoxPinned.TabIndex = 0;
      this.listBoxPinned.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxPinned_MouseDoubleClick);
      // 
      // dataGridViewConnections
      // 
      this.dataGridViewConnections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridViewConnections.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.dataGridViewConnections.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.dataGridViewConnections.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridViewConnections.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dataGridViewConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewConnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStartLocation,
            this.colDestination,
            this.colDeparture,
            this.colArrivalTime});
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridViewConnections.DefaultCellStyle = dataGridViewCellStyle2;
      this.dataGridViewConnections.Location = new System.Drawing.Point(30, 238);
      this.dataGridViewConnections.Name = "dataGridViewConnections";
      this.dataGridViewConnections.RowHeadersVisible = false;
      this.dataGridViewConnections.RowTemplate.Height = 40;
      this.dataGridViewConnections.Size = new System.Drawing.Size(1152, 269);
      this.dataGridViewConnections.TabIndex = 12;
      // 
      // colStartLocation
      // 
      this.colStartLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colStartLocation.FillWeight = 18.27411F;
      this.colStartLocation.HeaderText = "Von";
      this.colStartLocation.Name = "colStartLocation";
      this.colStartLocation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      // 
      // colDestination
      // 
      this.colDestination.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colDestination.FillWeight = 18.27411F;
      this.colDestination.HeaderText = "Nach";
      this.colDestination.Name = "colDestination";
      // 
      // colDeparture
      // 
      this.colDeparture.FillWeight = 345.1777F;
      this.colDeparture.HeaderText = "Abfahrtszeit";
      this.colDeparture.Name = "colDeparture";
      this.colDeparture.Width = 170;
      // 
      // colArrivalTime
      // 
      this.colArrivalTime.FillWeight = 18.27411F;
      this.colArrivalTime.HeaderText = "Ankunft";
      this.colArrivalTime.Name = "colArrivalTime";
      this.colArrivalTime.Width = 170;
      // 
      // btnConnectionsSearch
      // 
      this.btnConnectionsSearch.Location = new System.Drawing.Point(150, 124);
      this.btnConnectionsSearch.Name = "btnConnectionsSearch";
      this.btnConnectionsSearch.Size = new System.Drawing.Size(216, 39);
      this.btnConnectionsSearch.TabIndex = 11;
      this.btnConnectionsSearch.Text = "Suchen";
      this.btnConnectionsSearch.UseVisualStyleBackColor = true;
      this.btnConnectionsSearch.Click += new System.EventHandler(this.btnConnectionsSearch_Click);
      this.btnConnectionsSearch.MouseHover += new System.EventHandler(this.btnConnectionsSearch_MouseHover);
      // 
      // pictureBoxSearchStart
      // 
      this.pictureBoxSearchStart.Image = global::MySwissTransportApp.Properties.Resources.search_32px;
      this.pictureBoxSearchStart.Location = new System.Drawing.Point(103, 23);
      this.pictureBoxSearchStart.Name = "pictureBoxSearchStart";
      this.pictureBoxSearchStart.Size = new System.Drawing.Size(41, 40);
      this.pictureBoxSearchStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBoxSearchStart.TabIndex = 6;
      this.pictureBoxSearchStart.TabStop = false;
      // 
      // pictureBoxSearchGoal
      // 
      this.pictureBoxSearchGoal.Image = global::MySwissTransportApp.Properties.Resources.search_32px;
      this.pictureBoxSearchGoal.Location = new System.Drawing.Point(103, 69);
      this.pictureBoxSearchGoal.Name = "pictureBoxSearchGoal";
      this.pictureBoxSearchGoal.Size = new System.Drawing.Size(41, 40);
      this.pictureBoxSearchGoal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBoxSearchGoal.TabIndex = 6;
      this.pictureBoxSearchGoal.TabStop = false;
      // 
      // lblTitleConnections
      // 
      this.lblTitleConnections.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
      this.lblTitleConnections.AutoSize = true;
      this.lblTitleConnections.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblTitleConnections.Location = new System.Drawing.Point(482, 13);
      this.lblTitleConnections.Name = "lblTitleConnections";
      this.lblTitleConnections.Size = new System.Drawing.Size(243, 47);
      this.lblTitleConnections.TabIndex = 4;
      this.lblTitleConnections.Text = "Verbindungen";
      // 
      // cmbxDestination
      // 
      this.cmbxDestination.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.cmbxDestination.FormattingEnabled = true;
      this.cmbxDestination.Location = new System.Drawing.Point(150, 69);
      this.cmbxDestination.Name = "cmbxDestination";
      this.cmbxDestination.Size = new System.Drawing.Size(281, 40);
      this.cmbxDestination.TabIndex = 2;
      this.cmbxDestination.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbxDestination_KeyUp);
      // 
      // cmbxStartLocation
      // 
      this.cmbxStartLocation.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.cmbxStartLocation.FormattingEnabled = true;
      this.cmbxStartLocation.Location = new System.Drawing.Point(150, 23);
      this.cmbxStartLocation.Name = "cmbxStartLocation";
      this.cmbxStartLocation.Size = new System.Drawing.Size(281, 40);
      this.cmbxStartLocation.TabIndex = 1;
      this.cmbxStartLocation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbxStartLocation_KeyUp);
      // 
      // lblDestination
      // 
      this.lblDestination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lblDestination.AutoSize = true;
      this.lblDestination.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblDestination.Location = new System.Drawing.Point(39, 72);
      this.lblDestination.Name = "lblDestination";
      this.lblDestination.Size = new System.Drawing.Size(53, 32);
      this.lblDestination.TabIndex = 1;
      this.lblDestination.Text = "Ziel";
      // 
      // lblStartLocation
      // 
      this.lblStartLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lblStartLocation.AutoSize = true;
      this.lblStartLocation.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblStartLocation.Location = new System.Drawing.Point(30, 26);
      this.lblStartLocation.Name = "lblStartLocation";
      this.lblStartLocation.Size = new System.Drawing.Size(62, 32);
      this.lblStartLocation.TabIndex = 0;
      this.lblStartLocation.Text = "Start";
      // 
      // tabPgDepartures
      // 
      this.tabPgDepartures.Controls.Add(this.btnDeparturesSearch);
      this.tabPgDepartures.Controls.Add(this.cmbxDepartureStation);
      this.tabPgDepartures.Controls.Add(this.lblDepartureStation);
      this.tabPgDepartures.Controls.Add(this.dataGridViewDepartures);
      this.tabPgDepartures.Controls.Add(this.lblTitleDepartures);
      this.tabPgDepartures.Location = new System.Drawing.Point(4, 41);
      this.tabPgDepartures.Name = "tabPgDepartures";
      this.tabPgDepartures.Size = new System.Drawing.Size(1210, 514);
      this.tabPgDepartures.TabIndex = 2;
      this.tabPgDepartures.Text = "Abfahrtstafel";
      this.tabPgDepartures.UseVisualStyleBackColor = true;
      // 
      // btnDeparturesSearch
      // 
      this.btnDeparturesSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnDeparturesSearch.Location = new System.Drawing.Point(766, 77);
      this.btnDeparturesSearch.Name = "btnDeparturesSearch";
      this.btnDeparturesSearch.Size = new System.Drawing.Size(114, 40);
      this.btnDeparturesSearch.TabIndex = 15;
      this.btnDeparturesSearch.Text = "Suchen";
      this.btnDeparturesSearch.UseVisualStyleBackColor = true;
      this.btnDeparturesSearch.Click += new System.EventHandler(this.btnDeparturesSearch_Click);
      // 
      // cmbxDepartureStation
      // 
      this.cmbxDepartureStation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cmbxDepartureStation.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.cmbxDepartureStation.FormattingEnabled = true;
      this.cmbxDepartureStation.Location = new System.Drawing.Point(465, 77);
      this.cmbxDepartureStation.Name = "cmbxDepartureStation";
      this.cmbxDepartureStation.Size = new System.Drawing.Size(281, 40);
      this.cmbxDepartureStation.TabIndex = 13;
      this.cmbxDepartureStation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbxDepartureStation_KeyUp);
      // 
      // lblDepartureStation
      // 
      this.lblDepartureStation.AutoSize = true;
      this.lblDepartureStation.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblDepartureStation.Location = new System.Drawing.Point(355, 80);
      this.lblDepartureStation.Name = "lblDepartureStation";
      this.lblDepartureStation.Size = new System.Drawing.Size(88, 32);
      this.lblDepartureStation.TabIndex = 12;
      this.lblDepartureStation.Text = "Station";
      // 
      // dataGridViewDepartures
      // 
      this.dataGridViewDepartures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridViewDepartures.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridViewDepartures.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.dataGridViewDepartures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewDepartures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFromStation,
            this.colDirection,
            this.colDepartureTime});
      this.dataGridViewDepartures.Location = new System.Drawing.Point(29, 138);
      this.dataGridViewDepartures.Name = "dataGridViewDepartures";
      this.dataGridViewDepartures.RowHeadersVisible = false;
      this.dataGridViewDepartures.RowTemplate.Height = 40;
      this.dataGridViewDepartures.Size = new System.Drawing.Size(1153, 369);
      this.dataGridViewDepartures.TabIndex = 7;
      // 
      // colFromStation
      // 
      this.colFromStation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colFromStation.HeaderText = "Von";
      this.colFromStation.Name = "colFromStation";
      // 
      // colDirection
      // 
      this.colDirection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colDirection.HeaderText = "Nach";
      this.colDirection.Name = "colDirection";
      // 
      // colDepartureTime
      // 
      this.colDepartureTime.HeaderText = "Abfahrtszeit";
      this.colDepartureTime.Name = "colDepartureTime";
      this.colDepartureTime.Width = 170;
      // 
      // lblTitleDepartures
      // 
      this.lblTitleDepartures.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.lblTitleDepartures.AutoSize = true;
      this.lblTitleDepartures.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblTitleDepartures.Location = new System.Drawing.Point(491, 13);
      this.lblTitleDepartures.Name = "lblTitleDepartures";
      this.lblTitleDepartures.Size = new System.Drawing.Size(228, 47);
      this.lblTitleDepartures.TabIndex = 6;
      this.lblTitleDepartures.Text = "Abfahrtstafel";
      // 
      // tabPgMap
      // 
      this.tabPgMap.Controls.Add(this.webViewMap);
      this.tabPgMap.Controls.Add(this.lblTitleMap);
      this.tabPgMap.Location = new System.Drawing.Point(4, 41);
      this.tabPgMap.Name = "tabPgMap";
      this.tabPgMap.Padding = new System.Windows.Forms.Padding(3);
      this.tabPgMap.Size = new System.Drawing.Size(1210, 514);
      this.tabPgMap.TabIndex = 3;
      this.tabPgMap.Text = "Karte";
      this.tabPgMap.UseVisualStyleBackColor = true;
      // 
      // webViewMap
      // 
      this.webViewMap.AllowExternalDrop = true;
      this.webViewMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.webViewMap.CreationProperties = null;
      this.webViewMap.DefaultBackgroundColor = System.Drawing.Color.White;
      this.webViewMap.Location = new System.Drawing.Point(164, 87);
      this.webViewMap.Name = "webViewMap";
      this.webViewMap.Size = new System.Drawing.Size(870, 409);
      this.webViewMap.Source = new System.Uri("https://www.google.ch/maps/@46.8358449,7.658535,9z?hl=de", System.UriKind.Absolute);
      this.webViewMap.TabIndex = 8;
      this.webViewMap.ZoomFactor = 1D;
      // 
      // lblTitleMap
      // 
      this.lblTitleMap.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.lblTitleMap.AutoSize = true;
      this.lblTitleMap.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblTitleMap.Location = new System.Drawing.Point(547, 17);
      this.lblTitleMap.Name = "lblTitleMap";
      this.lblTitleMap.Size = new System.Drawing.Size(105, 47);
      this.lblTitleMap.TabIndex = 7;
      this.lblTitleMap.Text = "Karte";
      // 
      // pnlControl
      // 
      this.pnlControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pnlControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.pnlControl.Controls.Add(this.lblTitle);
      this.pnlControl.Location = new System.Drawing.Point(0, 0);
      this.pnlControl.Name = "pnlControl";
      this.pnlControl.Size = new System.Drawing.Size(1214, 80);
      this.pnlControl.TabIndex = 2;
      // 
      // lblTitle
      // 
      this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
      this.lblTitle.Location = new System.Drawing.Point(1043, 16);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(139, 47);
      this.lblTitle.TabIndex = 1;
      this.lblTitle.Text = "öV App";
      // 
      // OeVApp
      // 
      this.AcceptButton = this.btnConnectionsSearch;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1216, 646);
      this.Controls.Add(this.pnlControl);
      this.Controls.Add(this.tabControlTabs);
      this.Name = "OeVApp";
      this.Text = "öV App";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.oeVApp_FormClosing);
      this.Load += new System.EventHandler(this.oeVApp_Load);
      this.tabControlTabs.ResumeLayout(false);
      this.tabPgConnections.ResumeLayout(false);
      this.tabPgConnections.PerformLayout();
      this.groupBoxPinned.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConnections)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchStart)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchGoal)).EndInit();
      this.tabPgDepartures.ResumeLayout(false);
      this.tabPgDepartures.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartures)).EndInit();
      this.tabPgMap.ResumeLayout(false);
      this.tabPgMap.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.webViewMap)).EndInit();
      this.pnlControl.ResumeLayout(false);
      this.pnlControl.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private TabControl tabControlTabs;
    private TabPage tabPgConnections;
    private Button btnConnectionsSearch;
    private PictureBox pictureBoxSearchStart;
    private PictureBox pictureBoxSearchGoal;
    private Label lblTitleConnections;
    private ComboBox cmbxDestination;
    private ComboBox cmbxStartLocation;
    private Label lblDestination;
    private Label lblStartLocation;
    private TabPage tabPgDepartures;
    private DataGridView dataGridViewDepartures;
    private Label lblTitleDepartures;
    private Panel pnlControl;
    private Label lblTitle;
    private Button btnDeparturesSearch;
    private ComboBox cmbxDepartureStation;
    private Label lblDepartureStation;
    private DataGridView dataGridViewConnections;
    private GroupBox groupBoxPinned;
    private Button btnPinConnections;
    private DataGridViewTextBoxColumn colFromStation;
    private DataGridViewTextBoxColumn colDirection;
    private DataGridViewTextBoxColumn colDepartureTime;
    private DataGridViewTextBoxColumn colStartLocation;
    private DataGridViewTextBoxColumn colDestination;
    private DataGridViewTextBoxColumn colDeparture;
    private DataGridViewTextBoxColumn colArrivalTime;
    private ListBox listBoxPinned;
    private TabPage tabPgMap;
    private Microsoft.Web.WebView2.WinForms.WebView2 webViewMap;
    private Label lblTitleMap;
  }
}