namespace MySwissTransportApp {
  partial class oeVApp {
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
      this.tabCtrl = new System.Windows.Forms.TabControl();
      this.tabPgConnections = new System.Windows.Forms.TabPage();
      this.btnConnectionsSearch = new System.Windows.Forms.Button();
      this.groupBoxFavorites = new System.Windows.Forms.GroupBox();
      this.listBoxFavorites = new System.Windows.Forms.ListBox();
      this.pictureBoxCalendar = new System.Windows.Forms.PictureBox();
      this.listBoxConnections = new System.Windows.Forms.ListBox();
      this.dateTimePickerDepartureTime = new System.Windows.Forms.DateTimePicker();
      this.pictureBoxSearchStart = new System.Windows.Forms.PictureBox();
      this.pictureBoxSearchGoal = new System.Windows.Forms.PictureBox();
      this.lblTitleConnections = new System.Windows.Forms.Label();
      this.cmbxDestination = new System.Windows.Forms.ComboBox();
      this.cmbxStartLocation = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.lblDestination = new System.Windows.Forms.Label();
      this.lblStartLocation = new System.Windows.Forms.Label();
      this.tabPgStations = new System.Windows.Forms.TabPage();
      this.webViewStationLocation = new Microsoft.Web.WebView2.WinForms.WebView2();
      this.lblTitleStation = new System.Windows.Forms.Label();
      this.tabPgDepartures = new System.Windows.Forms.TabPage();
      this.btnDeparturesSearch = new System.Windows.Forms.Button();
      this.comboBox2 = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.dataGridViewDepartures = new System.Windows.Forms.DataGridView();
      this.colFromStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colDirection = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colDepartureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lblTitleDepartures = new System.Windows.Forms.Label();
      this.pnlControl = new System.Windows.Forms.Panel();
      this.lblTitle = new System.Windows.Forms.Label();
      this.tabCtrl.SuspendLayout();
      this.tabPgConnections.SuspendLayout();
      this.groupBoxFavorites.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalendar)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchStart)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchGoal)).BeginInit();
      this.tabPgStations.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.webViewStationLocation)).BeginInit();
      this.tabPgDepartures.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartures)).BeginInit();
      this.pnlControl.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabCtrl
      // 
      this.tabCtrl.Controls.Add(this.tabPgConnections);
      this.tabCtrl.Controls.Add(this.tabPgStations);
      this.tabCtrl.Controls.Add(this.tabPgDepartures);
      this.tabCtrl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.tabCtrl.Location = new System.Drawing.Point(-4, 86);
      this.tabCtrl.Name = "tabCtrl";
      this.tabCtrl.SelectedIndex = 0;
      this.tabCtrl.Size = new System.Drawing.Size(1218, 559);
      this.tabCtrl.TabIndex = 1;
      // 
      // tabPgConnections
      // 
      this.tabPgConnections.Controls.Add(this.btnConnectionsSearch);
      this.tabPgConnections.Controls.Add(this.groupBoxFavorites);
      this.tabPgConnections.Controls.Add(this.pictureBoxCalendar);
      this.tabPgConnections.Controls.Add(this.listBoxConnections);
      this.tabPgConnections.Controls.Add(this.dateTimePickerDepartureTime);
      this.tabPgConnections.Controls.Add(this.pictureBoxSearchStart);
      this.tabPgConnections.Controls.Add(this.pictureBoxSearchGoal);
      this.tabPgConnections.Controls.Add(this.lblTitleConnections);
      this.tabPgConnections.Controls.Add(this.cmbxDestination);
      this.tabPgConnections.Controls.Add(this.cmbxStartLocation);
      this.tabPgConnections.Controls.Add(this.label1);
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
      // btnConnectionsSearch
      // 
      this.btnConnectionsSearch.Location = new System.Drawing.Point(450, 37);
      this.btnConnectionsSearch.Name = "btnConnectionsSearch";
      this.btnConnectionsSearch.Size = new System.Drawing.Size(114, 40);
      this.btnConnectionsSearch.TabIndex = 11;
      this.btnConnectionsSearch.Text = "Suchen";
      this.btnConnectionsSearch.UseVisualStyleBackColor = true;
      this.btnConnectionsSearch.Click += new System.EventHandler(this.btnConnectionsSearch_Click);
      // 
      // groupBoxFavorites
      // 
      this.groupBoxFavorites.Controls.Add(this.listBoxFavorites);
      this.groupBoxFavorites.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.groupBoxFavorites.Location = new System.Drawing.Point(35, 223);
      this.groupBoxFavorites.Name = "groupBoxFavorites";
      this.groupBoxFavorites.Size = new System.Drawing.Size(465, 273);
      this.groupBoxFavorites.TabIndex = 10;
      this.groupBoxFavorites.TabStop = false;
      this.groupBoxFavorites.Text = "Favoriten";
      // 
      // listBoxFavorites
      // 
      this.listBoxFavorites.FormattingEnabled = true;
      this.listBoxFavorites.ItemHeight = 25;
      this.listBoxFavorites.Location = new System.Drawing.Point(7, 27);
      this.listBoxFavorites.Name = "listBoxFavorites";
      this.listBoxFavorites.Size = new System.Drawing.Size(453, 229);
      this.listBoxFavorites.TabIndex = 0;
      // 
      // pictureBoxCalendar
      // 
      this.pictureBoxCalendar.Image = global::MySwissTransportApp.Properties.Resources.icons8_calendar_50px;
      this.pictureBoxCalendar.InitialImage = global::MySwissTransportApp.Properties.Resources.icons8_calendar_50px;
      this.pictureBoxCalendar.Location = new System.Drawing.Point(111, 163);
      this.pictureBoxCalendar.Name = "pictureBoxCalendar";
      this.pictureBoxCalendar.Size = new System.Drawing.Size(33, 33);
      this.pictureBoxCalendar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBoxCalendar.TabIndex = 9;
      this.pictureBoxCalendar.TabStop = false;
      // 
      // listBoxConnections
      // 
      this.listBoxConnections.FormattingEnabled = true;
      this.listBoxConnections.ItemHeight = 32;
      this.listBoxConnections.Location = new System.Drawing.Point(595, 108);
      this.listBoxConnections.Name = "listBoxConnections";
      this.listBoxConnections.Size = new System.Drawing.Size(529, 388);
      this.listBoxConnections.TabIndex = 8;
      // 
      // dateTimePickerDepartureTime
      // 
      this.dateTimePickerDepartureTime.CustomFormat = "MM/dd/yyyy, hh:mm";
      this.dateTimePickerDepartureTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.dateTimePickerDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dateTimePickerDepartureTime.Location = new System.Drawing.Point(154, 163);
      this.dateTimePickerDepartureTime.Name = "dateTimePickerDepartureTime";
      this.dateTimePickerDepartureTime.Size = new System.Drawing.Size(281, 33);
      this.dateTimePickerDepartureTime.TabIndex = 3;
      // 
      // pictureBoxSearchStart
      // 
      this.pictureBoxSearchStart.Image = global::MySwissTransportApp.Properties.Resources.search_32px;
      this.pictureBoxSearchStart.Location = new System.Drawing.Point(107, 37);
      this.pictureBoxSearchStart.Name = "pictureBoxSearchStart";
      this.pictureBoxSearchStart.Size = new System.Drawing.Size(41, 40);
      this.pictureBoxSearchStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBoxSearchStart.TabIndex = 6;
      this.pictureBoxSearchStart.TabStop = false;
      // 
      // pictureBoxSearchGoal
      // 
      this.pictureBoxSearchGoal.Image = global::MySwissTransportApp.Properties.Resources.search_32px;
      this.pictureBoxSearchGoal.Location = new System.Drawing.Point(107, 91);
      this.pictureBoxSearchGoal.Name = "pictureBoxSearchGoal";
      this.pictureBoxSearchGoal.Size = new System.Drawing.Size(41, 40);
      this.pictureBoxSearchGoal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBoxSearchGoal.TabIndex = 6;
      this.pictureBoxSearchGoal.TabStop = false;
      // 
      // lblTitleConnections
      // 
      this.lblTitleConnections.AutoSize = true;
      this.lblTitleConnections.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblTitleConnections.Location = new System.Drawing.Point(775, 47);
      this.lblTitleConnections.Name = "lblTitleConnections";
      this.lblTitleConnections.Size = new System.Drawing.Size(243, 47);
      this.lblTitleConnections.TabIndex = 4;
      this.lblTitleConnections.Text = "Verbindungen";
      // 
      // cmbxDestination
      // 
      this.cmbxDestination.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.cmbxDestination.FormattingEnabled = true;
      this.cmbxDestination.Location = new System.Drawing.Point(154, 91);
      this.cmbxDestination.Name = "cmbxDestination";
      this.cmbxDestination.Size = new System.Drawing.Size(281, 40);
      this.cmbxDestination.TabIndex = 2;
      // 
      // cmbxStartLocation
      // 
      this.cmbxStartLocation.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.cmbxStartLocation.FormattingEnabled = true;
      this.cmbxStartLocation.Location = new System.Drawing.Point(154, 37);
      this.cmbxStartLocation.Name = "cmbxStartLocation";
      this.cmbxStartLocation.Size = new System.Drawing.Size(281, 40);
      this.cmbxStartLocation.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(28, 172);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(68, 25);
      this.label1.TabIndex = 1;
      this.label1.Text = "Datum";
      // 
      // lblDestination
      // 
      this.lblDestination.AutoSize = true;
      this.lblDestination.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblDestination.Location = new System.Drawing.Point(34, 102);
      this.lblDestination.Name = "lblDestination";
      this.lblDestination.Size = new System.Drawing.Size(53, 32);
      this.lblDestination.TabIndex = 1;
      this.lblDestination.Text = "Ziel";
      // 
      // lblStartLocation
      // 
      this.lblStartLocation.AutoSize = true;
      this.lblStartLocation.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblStartLocation.Location = new System.Drawing.Point(34, 40);
      this.lblStartLocation.Name = "lblStartLocation";
      this.lblStartLocation.Size = new System.Drawing.Size(62, 32);
      this.lblStartLocation.TabIndex = 0;
      this.lblStartLocation.Text = "Start";
      // 
      // tabPgStations
      // 
      this.tabPgStations.Controls.Add(this.webViewStationLocation);
      this.tabPgStations.Controls.Add(this.lblTitleStation);
      this.tabPgStations.Location = new System.Drawing.Point(4, 41);
      this.tabPgStations.Name = "tabPgStations";
      this.tabPgStations.Padding = new System.Windows.Forms.Padding(3);
      this.tabPgStations.Size = new System.Drawing.Size(1210, 514);
      this.tabPgStations.TabIndex = 1;
      this.tabPgStations.Text = "Stationssuche";
      this.tabPgStations.UseVisualStyleBackColor = true;
      // 
      // webViewStationLocation
      // 
      this.webViewStationLocation.AllowExternalDrop = true;
      this.webViewStationLocation.CreationProperties = null;
      this.webViewStationLocation.DefaultBackgroundColor = System.Drawing.Color.White;
      this.webViewStationLocation.Location = new System.Drawing.Point(190, 113);
      this.webViewStationLocation.Name = "webViewStationLocation";
      this.webViewStationLocation.Size = new System.Drawing.Size(823, 384);
      this.webViewStationLocation.TabIndex = 6;
      this.webViewStationLocation.ZoomFactor = 1D;
      // 
      // lblTitleStation
      // 
      this.lblTitleStation.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.lblTitleStation.AutoSize = true;
      this.lblTitleStation.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblTitleStation.Location = new System.Drawing.Point(488, 14);
      this.lblTitleStation.Name = "lblTitleStation";
      this.lblTitleStation.Size = new System.Drawing.Size(237, 47);
      this.lblTitleStation.TabIndex = 5;
      this.lblTitleStation.Text = "Stationssuche";
      // 
      // tabPgDepartures
      // 
      this.tabPgDepartures.Controls.Add(this.btnDeparturesSearch);
      this.tabPgDepartures.Controls.Add(this.comboBox2);
      this.tabPgDepartures.Controls.Add(this.label2);
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
      this.btnDeparturesSearch.Location = new System.Drawing.Point(763, 63);
      this.btnDeparturesSearch.Name = "btnDeparturesSearch";
      this.btnDeparturesSearch.Size = new System.Drawing.Size(114, 40);
      this.btnDeparturesSearch.TabIndex = 15;
      this.btnDeparturesSearch.Text = "Suchen";
      this.btnDeparturesSearch.UseVisualStyleBackColor = true;
      // 
      // comboBox2
      // 
      this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Location = new System.Drawing.Point(462, 63);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new System.Drawing.Size(281, 40);
      this.comboBox2.TabIndex = 13;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label2.Location = new System.Drawing.Point(352, 66);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(88, 32);
      this.label2.TabIndex = 12;
      this.label2.Text = "Station";
      // 
      // dataGridViewDepartures
      // 
      this.dataGridViewDepartures.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
      this.dataGridViewDepartures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewDepartures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFromStation,
            this.colDirection,
            this.colDepartureTime});
      this.dataGridViewDepartures.Location = new System.Drawing.Point(166, 138);
      this.dataGridViewDepartures.Name = "dataGridViewDepartures";
      this.dataGridViewDepartures.RowTemplate.Height = 25;
      this.dataGridViewDepartures.Size = new System.Drawing.Size(865, 369);
      this.dataGridViewDepartures.TabIndex = 7;
      // 
      // colFromStation
      // 
      this.colFromStation.HeaderText = "Von";
      this.colFromStation.Name = "colFromStation";
      this.colFromStation.Width = 300;
      // 
      // colDirection
      // 
      this.colDirection.HeaderText = "Nach";
      this.colDirection.Name = "colDirection";
      this.colDirection.Width = 270;
      // 
      // colDepartureTime
      // 
      this.colDepartureTime.HeaderText = "Abfahrtszeit";
      this.colDepartureTime.Name = "colDepartureTime";
      this.colDepartureTime.Width = 250;
      // 
      // lblTitleDepartures
      // 
      this.lblTitleDepartures.AutoSize = true;
      this.lblTitleDepartures.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblTitleDepartures.Location = new System.Drawing.Point(491, 13);
      this.lblTitleDepartures.Name = "lblTitleDepartures";
      this.lblTitleDepartures.Size = new System.Drawing.Size(228, 47);
      this.lblTitleDepartures.TabIndex = 6;
      this.lblTitleDepartures.Text = "Abfahrtstafel";
      // 
      // pnlControl
      // 
      this.pnlControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.pnlControl.Controls.Add(this.lblTitle);
      this.pnlControl.Location = new System.Drawing.Point(0, 0);
      this.pnlControl.Name = "pnlControl";
      this.pnlControl.Size = new System.Drawing.Size(1214, 80);
      this.pnlControl.TabIndex = 2;
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
      this.lblTitle.Location = new System.Drawing.Point(1056, 9);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(139, 47);
      this.lblTitle.TabIndex = 1;
      this.lblTitle.Text = "öV App";
      // 
      // oeVApp
      // 
      this.AcceptButton = this.btnConnectionsSearch;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1216, 646);
      this.Controls.Add(this.pnlControl);
      this.Controls.Add(this.tabCtrl);
      this.Name = "oeVApp";
      this.Text = "öV App";
      this.tabCtrl.ResumeLayout(false);
      this.tabPgConnections.ResumeLayout(false);
      this.tabPgConnections.PerformLayout();
      this.groupBoxFavorites.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalendar)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchStart)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchGoal)).EndInit();
      this.tabPgStations.ResumeLayout(false);
      this.tabPgStations.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.webViewStationLocation)).EndInit();
      this.tabPgDepartures.ResumeLayout(false);
      this.tabPgDepartures.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartures)).EndInit();
      this.pnlControl.ResumeLayout(false);
      this.pnlControl.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private TabControl tabCtrl;
    private TabPage tabPgConnections;
    private Button btnConnectionsSearch;
    private GroupBox groupBoxFavorites;
    private ListBox listBoxFavorites;
    private PictureBox pictureBoxCalendar;
    private ListBox listBoxConnections;
    private DateTimePicker dateTimePickerDepartureTime;
    private PictureBox pictureBoxSearchStart;
    private PictureBox pictureBoxSearchGoal;
    private Label lblTitleConnections;
    private ComboBox cmbxDestination;
    private ComboBox cmbxStartLocation;
    private Label label1;
    private Label lblDestination;
    private Label lblStartLocation;
    private TabPage tabPgStations;
    private Label lblTitleStation;
    private TabPage tabPgDepartures;
    private DataGridView dataGridViewDepartures;
    private Label lblTitleDepartures;
    private Panel pnlControl;
    private Label lblTitle;
    private Microsoft.Web.WebView2.WinForms.WebView2 webViewStationLocation;
    private DataGridViewTextBoxColumn colFromStation;
    private DataGridViewTextBoxColumn colDirection;
    private DataGridViewTextBoxColumn colDepartureTime;
    private Button btnDeparturesSearch;
    private ComboBox comboBox2;
    private Label label2;
  }
}