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
using TransportApp;

namespace TarnsportApp {
    public partial class FromToConnections : Form {
        public FromToConnections() {
            InitializeComponent();
        }

        private transportConnections journeyConnections = new transportConnections();
        private ITransport transport = new Transport();

        private void searchConnectionsButton_Click(object sender, EventArgs e) {
            connectionsDataGridView.Rows.Clear();
            if (hourNumericUpDown.Value == 0 && minuteNumericUpDown.Value == 0 && dateTimePicker1.Value.Date == DateTime.Today) {
                foreach (Connection connection in journeyConnections.getConnectionsBetweenStations(startStationComboBox.Text, endStationComboBox.Text, amountOfConectionsNumericUpDown.Value)) {
                    connectionsDataGridView.Rows.Add(connection.From.Station.Name, connection.To.Station.Name, connection.From.Platform, connection.From.Departure, connection.Duration);
                }
            } else if(dateTimePicker1.Value < DateTime.Now) { 
            }else {
                DateTime dateTimeOfTravle = dateTimePicker1.Value.Date.AddHours((int)hourNumericUpDown.Value).AddMinutes((int)minuteNumericUpDown.Value);
                foreach (Connection connection in journeyConnections.getConnectionsBetweenStationsWithDateTime(startStationComboBox.Text, endStationComboBox.Text, amountOfConectionsNumericUpDown.Value, dateTimeOfTravle)) {
                    connectionsDataGridView.Rows.Add(connection.From.Station.Name, connection.To.Station.Name, connection.From.Platform, connection.From.Departure, connection.Duration);
                }
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

        private void comboBox_TextChanged(object sender, EventArgs e) {
            try {
                if (startStationComboBox.Text != null) {
                    Station[] possibleStations = transport.GetStations(startStationComboBox.Text).StationList.ToArray();
                    foreach (Station station in possibleStations) {
                        startStationComboBox.Items.Add(station.Name);
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void endStationComboBox_TextChanged(object sender, EventArgs e) {
            try {
                if (endStationComboBox.Text != null) {
                    Station[] possibleStations = transport.GetStations(endStationComboBox.Text).StationList.ToArray();
                    foreach (Station station in possibleStations) {
                        endStationComboBox.Items.Add(station.Name);
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void endStationComboBox_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                searchConnectionsButton_Click(sender, e);
            }
        }
    }
}
