using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport.Models;
using TransportApp;

namespace TarnsportApp {
    public partial class Connections : Form {
        public Connections() {
            InitializeComponent();
        }

        private JourneyConnections journeyConnections = new JourneyConnections();

        private void searchConnectionsButton_Click(object sender, EventArgs e) {
            connectionsDataGridView.Rows.Clear();
            foreach(Connection connection in journeyConnections.getConnectionsBetweenStations(startStationTextBox.Text, endStationTextBox.Text, amountOfConectionsNumericUpDown.Value)) {
                connectionsDataGridView.Rows.Add(connection.From.Station.Name, connection.To.Station.Name, connection.From.Platform, connection.From.Departure, connection.Duration);
            }

        }

        private void stationsNearbyButton_Click(object sender, EventArgs e) {
            StationsNearby stationsNearbyForm = new StationsNearby();
            reasingForms(stationsNearbyForm);
        }

        private void connectionBoardButton_Click(object sender, EventArgs e) {
            ConnectionBoard connectionBoardForm = new ConnectionBoard();
            reasingForms(connectionBoardForm);
        }

        private void connectionsButton_Click(object sender, EventArgs e) {
            ConnectionBoard connectionBoardForm = new ConnectionBoard();
            reasingForms(connectionBoardForm);
        }

        private void whereIsMyStationButton_Click(object sender, EventArgs e) {
            WhereIsMyStation whereIsMyStationForm = new WhereIsMyStation();
            reasingForms(whereIsMyStationForm);
        }

        private void reasingForms(Form newForm) {
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }
    }
}
