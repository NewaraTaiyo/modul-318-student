namespace SwissTransport
{
    using FluentAssertions;
    using SwissTransport.Core;
    using SwissTransport.Models;
    using System;
    using Xunit;

    public class TransportTest
    {
        private readonly ITransport testee;

        public TransportTest()
        {
            this.testee = new Transport();
        }

        [Fact]
        public void Locations_Sursee()
        {
            Stations stations = this.testee.GetStations("Sursee,");

            stations.StationList.Should().HaveCount(10);
        }

        [Fact]
        public void StationBoardWithId()
        {
            StationBoardRoot stationBoard = this.testee.GetStationBoardWithId("Sursee", "8502007");

            stationBoard.Should().NotBeNull();
        }

        [Fact]
        public void Connections_Sursee_Luzern()
        {
            Connections connections = this.testee.GetConnections("Sursee", "Luzern");

            connections.Should().NotBeNull();
        }

        [Fact]
        public void StationBoard_Sursee() {
            StationBoardRoot stationBoard = this.testee.GetStationBoard("Sursee");

            stationBoard.Should().NotBeNull();
        }

        [Fact]
        public void ConnectionsWithLimit_Sursee_Luzern() {
            Connections connections = this.testee.GetConnectionsWithLimit("Sursee", "Luzern", 17);

            connections.ConnectionList.Count.Should().Be(17);
        }

        [Fact]
        public void ConnectionsWithLimitAndTime_Sursee_Luzern() {
            Connections connections = this.testee.GetConnectionsWithLimitAndTime("Sursee", "Luzern", 11, DateTime.Now.AddDays(1));

            connections.ConnectionList.Count.Should().Be(11);
        }
    }
}