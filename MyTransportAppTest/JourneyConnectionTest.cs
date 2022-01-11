using NUnit.Framework;
using MyTransportApp;
using SwissTransport;

namespace MyTransportAppTest {
    public class Tests {
        private JourneyConnections journeyConnections;

        [SetUp]
        public void Setup() {
            this.journeyConnections = new JourneyConnections();
        }

        [Test]
        public void allConnectionsBetweenLuzernAndBern() {
            List<Connection> connectionsBetweenStations = new List<Connection>();
            connectionsBetweenStations = journeyConnections.getConnectionsBetweenStations("Luzern", "Bern");
            Assert.NotNull(connectionsBetweenStations);
        }
    }
}