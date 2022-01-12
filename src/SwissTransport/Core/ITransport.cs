namespace SwissTransport.Core
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using SwissTransport.Models;

    public interface ITransport
    {
        Stations GetStations(string query);

        StationBoardRoot GetStationBoard(string station);

        StationBoardRoot GetStationBoardWithId(string station, string id);

        Connections GetConnections(string fromStation, string toStation);

        Connections GetConnectionsWithLimit(string fromStation, string toStation, decimal limit);

        Connections GetConnectionsWithLimitAndTime(string fromStation, string toStation, decimal limit, DateTime dateTimeOfTravle);
    }
}