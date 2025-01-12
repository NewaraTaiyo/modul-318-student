﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport.Models;
using SwissTransport.Core;
using TarnsportApp;

namespace TransportApp {
    public partial class ConnectionBoard : Form {
        public ConnectionBoard() {
            InitializeComponent();
        }

        transportConnections transportConnections = new transportConnections();

        private void currentStationTextBox_KeyUp(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                foreach (StationBoard connection in transportConnections.getStationBoardEntries(currentStationComboBox.Text)) {
                    stationBoardDataGridView.Rows.Add(connection.To, connection.Stop.Departure);
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
            FromToConnections fromToConnectionsForm = new FromToConnections();
            reasingForms(fromToConnectionsForm);
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

        private void currentStationComboBox_TextChanged(object sender, EventArgs e) {
            try { 
                if(currentStationComboBox.Text != null) {
                    Station[] possibleStations = transportConnections.getStationList(currentStationComboBox.Text);
                    foreach (Station station in possibleStations) {
                        currentStationComboBox.Items.Add(station.Name);
                    }
                }
            }catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
