using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport.Core;
using SwissTransport.Models;

namespace TarnsportApp {
    public class transportConnections {
        private ITransport transport = new Transport();

        public List<Connection> getConnectionsBetweenStations(string startStation, string endStation, decimal limit) {
            return transport.GetConnectionsWithLimit(startStation, endStation, limit).ConnectionList;
        }

        public List<Connection> getConnectionsBetweenStationsWithDateTime(string startStation, string endStation, decimal limit, DateTime dateTimeOfTravle) {
            return transport.GetConnectionsWithLimitAndTime(startStation, endStation, limit, dateTimeOfTravle).ConnectionList;
        }

        public Station[] getStationList(string currentStationName) {
            return transport.GetStations(currentStationName).StationList.ToArray();
        }

        public List<StationBoard> getStationBoardEntries(string currentStationName) {
            return transport.GetStationBoard(currentStationName).Entries;
        }
    }
}
