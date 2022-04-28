using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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



    private void btnConnectionsSearch_Click(object sender, EventArgs e) {
      if (!string.IsNullOrWhiteSpace(cmbxStartLocation.Text) && !string.IsNullOrWhiteSpace(cmbxDestination.Text) && string.IsNullOrWhiteSpace(listBoxConnections.Text)) {
        string StartLocation = cmbxStartLocation.Text;
        string Destination = cmbxDestination.Text;

        ITransport t = new Transport();
        var kek = t.GetConnections(StartLocation, Destination);
        
        foreach (Connection connection in kek.ConnectionList) {
          DateTime departureTime = connection.From.Departure.Value.Date;
          departureTime.ToString("HH:mm");
          DateTime arrivalTime = connection.To.Arrival.Value.Date;
          arrivalTime.ToString("HH:mm");

          listBoxConnections.Items.Add(connection.From.Station.Name + "\t" + connection.To.Station.Name);
          listBoxConnections.Items.Add(departureTime + "\t" + arrivalTime + "\n\n");

        }

      }

      else if (!string.IsNullOrWhiteSpace(listBoxConnections.Text)) {

      }

      else MessageBox.Show("Bitte geben Sie Start und Ziel ein.");
    }
  }
}