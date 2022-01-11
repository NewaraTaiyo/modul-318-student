using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport;
using System.string;
using System.Object;
using System.List;

namespace MyTransportApp {
    public class JourneyConnections {
        private ITransport transport = new Transport();

        public List<Connections> getConnectionsBetweenStations(string startStation, string endStation) {
            return this.transport.getConnections(startStation, endStation); ;
        }
    }
}
