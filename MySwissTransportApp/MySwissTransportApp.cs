using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SwissTransport.Core;
using SwissTransport.Models;

namespace MySwissTransportApp {
  public partial class OeVApp : System.Windows.Forms.Form {
    public OeVApp() {
      InitializeComponent();
    }



    //-------------------Global Variables-------------------

    public static string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
    public string PinnedConnectionsPath = @"%TEMP%";
    public static List<PinConnection> PinnedConnections = new List<PinConnection>();

    public ITransport Transport = new Transport();
    public bool TableContainsItems = false;



    //-----------------------Functions----------------------

    private void SearchForConnections() {

      if (!string.IsNullOrWhiteSpace(cmbxStartLocation.Text) && !string.IsNullOrWhiteSpace(cmbxDestination.Text) && !TableContainsItems) {
        string startLocation = cmbxStartLocation.Text;
        string destination = cmbxDestination.Text;



        var ConnectionList = Transport.GetConnections(startLocation, destination);

        foreach (Connection connection in ConnectionList.ConnectionList) {
          string departureTime = connection.From.Departure?.ToString("HH:mm") ?? "";
          string arrivalTime = connection.To.Arrival?.ToString("HH:mm") ?? "";

          string fromStation = connection.From.Station.Name;
          string toStation = connection.To.Station.Name;


          this.dataGridViewConnections.Rows.Add(fromStation, toStation, departureTime, arrivalTime);
          TableContainsItems = true;
          btnPinConnections.Enabled = true;
        }

      }

      else if (TableContainsItems) {

        TableContainsItems = false;

        dataGridViewConnections.Rows.Clear();

        SearchForConnections();
        
      }

      else MessageBox.Show("Bitte geben Sie Start und Ziel ein.");
    }

    private void OutputPinnedConnections() {
      listBoxPinned.Items.Clear();

      if (PinnedConnections.Count > 0) {

        foreach (PinConnection connection in PinnedConnections) {

          listBoxPinned.Items.Add(connection.StartLocation + " --> " + connection.Destination);
        }
      }

    }

    private void SearchRecommendations(ComboBox station) {

      if (string.IsNullOrEmpty(station.Text)) {
        return;
      }

      try {

        if (station.Text.Length >= 4) {
          station.DroppedDown = true;
          Cursor.Current = Cursors.Default;

          List<string> dropDownList = new List<string>();
          station.Items.Clear();

          var stationList = Transport.GetStations(station.Text);

          station.SelectionStart = station.Text.Length + 1;

          foreach (var stationItem in stationList.StationList) {
            dropDownList.Add(stationItem.Name);
          }

          if (dropDownList != null) {

            foreach (var dropDownItem in dropDownList) {
              station.Items.Add(dropDownItem);
            }
          }

        }
      }

      catch {
        station.Items.Clear();
        station.SelectionStart = station.Text.Length + 1;
        station.Items.Add("Keine Übereinstimmung.");
      }


    }

    private void CheckIfTabIsChanged() {
      if (tabControlTabs.SelectedTab == tabPgDepartures) {
        AcceptButton = btnDeparturesSearch;
      }

      else AcceptButton = btnConnectionsSearch;
    }



    //-----------------------Events----------------------

    private void btnConnectionsSearch_Click(object sender, EventArgs e) {

      SearchForConnections();
    }

    private void btnPinConnections_Click(object sender, EventArgs e) {
      PinConnection pinConnection = new PinConnection();
      pinConnection.IsPinned = false;

      pinConnection.StartLocation = cmbxStartLocation.Text;
      pinConnection.Destination = cmbxDestination.Text;

      if (!pinConnection.IsThisConnectionPinned(cmbxStartLocation.Text, cmbxDestination.Text) && PinnedConnections.Count < 5) {

        PinnedConnections.Add(pinConnection);

        OutputPinnedConnections();
      }

      else if (pinConnection.IsThisConnectionPinned(cmbxStartLocation.Text, cmbxDestination.Text)) {

        pinConnection.RemovePinnedConnection(pinConnection);

        OutputPinnedConnections();
      }

      else if (PinnedConnections.Count >= 5) MessageBox.Show("Man kann nicht mehr als 5 Verbindungen anheften.");

    }

    private void btnDeparturesSearch_Click(object sender, EventArgs e) {
      dataGridViewDepartures.Rows.Clear();

      if (!string.IsNullOrWhiteSpace(cmbxDepartureStation.Text)) {

        string departureStation = cmbxDepartureStation.Text;
        var stationList = Transport.GetStations(cmbxDepartureStation.Text);
        var stationBoard = Transport.GetStationBoard(cmbxDepartureStation.Text, stationList.StationList.First().Id);

        foreach (StationBoard stationBoardItem in stationBoard.Entries) {
          string stationDirection = stationBoardItem.To;
          string stationDepartureTime = stationBoardItem.Stop.Departure.ToString("HH:mm") ?? "";

          dataGridViewDepartures.Rows.Add(departureStation, stationDirection, stationDepartureTime);
        }
      }

      else MessageBox.Show("Bitte geben Sie eine Station ein.");
    }

    private void btnConnectionsSearch_MouseHover(object sender, EventArgs e) {
      System.Windows.Forms.ToolTip toolTipSearchButton = new System.Windows.Forms.ToolTip();
      toolTipSearchButton.SetToolTip(this.btnConnectionsSearch, "Suchen");
    }

    private void btnPinConnections_MouseHover(object sender, EventArgs e) {
      System.Windows.Forms.ToolTip toolTipSearchButton = new System.Windows.Forms.ToolTip();
      toolTipSearchButton.SetToolTip(this.btnPinConnections, "An- oder Abheften");
    }

    private void cmbxStartLocation_KeyUp(object sender, KeyEventArgs e) {
      CheckIfTabIsChanged();

      if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up) ;

      else if (e.KeyCode == Keys.Enter) {

        if (cmbxStartLocation.Text.Length > 0) {
          cmbxDestination.Select();
        }
      }

      else SearchRecommendations(cmbxStartLocation);

    }

    private void cmbxDestination_KeyUp(object sender, KeyEventArgs e) {
      CheckIfTabIsChanged();

      if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up || e.KeyCode == Keys.Enter) ;

      else SearchRecommendations(cmbxDestination);

    }

    private void cmbxDepartureStation_KeyUp(object sender, KeyEventArgs e) {
      CheckIfTabIsChanged();

      if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up || e.KeyCode == Keys.Enter) ;

      else SearchRecommendations(cmbxDepartureStation);

    }

    private void listBoxPinned_MouseDoubleClick(object sender, MouseEventArgs e) {
      if (listBoxPinned.Items.Count > 0) {
        string[] subStringStations = null;

        string selectedItem = listBoxPinned.SelectedItem.ToString();
        subStringStations = selectedItem.Split(" --> ");


        cmbxStartLocation.Text = subStringStations[0];
        cmbxDestination.Text = subStringStations[1];

        SearchForConnections();
      }

      else;
    }

    private void oeVApp_Load(object sender, EventArgs e) {
      //using (FileStream fs = File.Create(PinnedConnectionsPath)) ;

      if (File.Exists(PinnedConnectionsPath)) {
        string[] lines = File.ReadAllLines(PinnedConnectionsPath);

        foreach (string line in lines) {
          listBoxPinned.Items.Add(line);
        }
      }

      else;
    }

    private void oeVApp_FormClosing(object sender, FormClosingEventArgs e) {
      List<string> JoinArray = new List<string>();

      foreach (string pinnedItem in listBoxPinned.Items) {
        JoinArray.Add(pinnedItem);
      }
      
      //string.Join("\n", JoinArray)
      File.WriteAllText(Path.Combine(PinnedConnectionsPath, ""), string.Join("\n", JoinArray));


    }
  }
}