using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport.Core;
using SwissTransport.Models;

namespace TarnsportApp {
    public class JourneyConnections {
        private ITransport transport = new Transport();

        public List<Connection> getConnectionsBetweenStations(string startStation, string endStation, decimal limit) {
            return transport.GetConnections(startStation, endStation, limit).ConnectionList;
        }
    }
}
