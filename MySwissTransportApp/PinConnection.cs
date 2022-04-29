using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace MySwissTransportApp {
  public class PinConnection {
    public PinConnection() {
      Destination = null;
      StartLocation = null;
    }

    public string Destination { get; set; }
    public string StartLocation { get; set; }

    public bool IsPinned { get; set; }


    public bool IsThisConnectionPinned(string start, string dest) {

      foreach (PinConnection connection in OeVApp.PinnedConnections) {

        if (connection.Destination == dest && connection.StartLocation == start) {
          return true;

        }

        break;
      }

      return false;
    }

    public void RemovePinnedConnection(PinConnection pinnedConnection) {

      foreach (PinConnection pinnedItems in OeVApp.PinnedConnections) {

        if (pinnedItems.StartLocation == pinnedConnection.StartLocation && pinnedItems.Destination == pinnedConnection.Destination) {
          OeVApp.PinnedConnections.Remove(pinnedItems);
          break;
        }
      }
    }
  }
}
