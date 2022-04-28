using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport.Core;
using SwissTransport.Models;

namespace MySwissTransportApp {
  public partial class oeVApp : System.Windows.Forms.Form {
    public oeVApp() {
      InitializeComponent();
    }



    //-------------------Global Variables-------------------

    public static List<PinConnection> PinnedConnections = new List<PinConnection>();
    public ITransport Transport = new Transport();
    public bool TableContainsItems = false;
    public bool IsPinned = false;



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

        dataGridViewConnections.Rows.Clear();

        SearchForConnections();
      }

      else MessageBox.Show("Bitte geben Sie Start und Ziel ein.");
    }

    private void OutputPinnedConnections() {
      listBoxPinned.Items.Clear();

      if (PinnedConnections.Count > 0) {

        foreach (PinConnection connection in PinnedConnections) {

          listBoxPinned.Items.Add(connection.StartLocation + "\t" + connection.Destination);
        }
      }

    }

    private void SearchRecommendations(ComboBox station) {
      try {
        var stationList = Transport.GetStations(station.Text);
        List<string> dropDownList = new List<string>();

        foreach (var stationItem in stationList.StationList) {
          dropDownList.Add(stationItem.Name);
        }

        if (dropDownList != null) {
          foreach (var dropDownItem in dropDownList) {
            station.Items.Add(dropDownItem);
          }
        }

        station.DroppedDown = true;
      }
      catch (Exception ex) {
        MessageBox.Show(ex.ToString());
        throw;
      }
      
    }


    
    //-----------------------Events----------------------

    private void btnConnectionsSearch_Click(object sender, EventArgs e) {

      SearchForConnections();
    }

    private void btnPinConnections_Click(object sender, EventArgs e) {
      PinConnection pinConnection = new PinConnection();

      pinConnection.StartLocation = cmbxStartLocation.Text;
      pinConnection.Destination = cmbxDestination.Text;

      if (!pinConnection.IsThisConnectionPinned(cmbxStartLocation.Text, cmbxDestination.Text) && PinnedConnections.Count < 5) {
        PinnedConnections.Add(pinConnection);

        btnPinConnections.Image = Properties.Resources.icons8_pin_24px_1;

        IsPinned = true;

        OutputPinnedConnections();
      }

      else if (pinConnection.IsThisConnectionPinned(cmbxStartLocation.Text, cmbxDestination.Text)) {
        pinConnection.RemovePinnedConnection(pinConnection);

        btnPinConnections.Image = Properties.Resources.icons8_pin_24px;

        IsPinned = false;

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
      if (IsPinned) {
        System.Windows.Forms.ToolTip toolTipSearchButton = new System.Windows.Forms.ToolTip();
        toolTipSearchButton.SetToolTip(this.btnPinConnections, "Entheften");
      }

      if (!IsPinned) {
        System.Windows.Forms.ToolTip toolTipSearchButton = new System.Windows.Forms.ToolTip();
        toolTipSearchButton.SetToolTip(this.btnPinConnections, "Anheften");
      }
    }

    private void cmbxStartLocation_TextChanged(object sender, EventArgs e) {
      SearchRecommendations(cmbxStartLocation);
    }

    private void cmbxDestination_TextChanged(object sender, EventArgs e) {
      SearchRecommendations(cmbxDestination);
    }

    private void cmbxDepartureStation_TextChanged(object sender, EventArgs e) {
      SearchRecommendations(cmbxDepartureStation);
    }
  }
}