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
using SwissTransport.Core;
using TarnsportApp;

namespace TransportApp {
    public partial class StationsNearby : Form {
        public StationsNearby() {
            InitializeComponent();
            webBrowser = new WebBrowser();
            webBrowser.Navigate("http://www.google.com/maps");
            //this.splitContainer1.Panel1.Container.Add(webBrowser);
        }

        ITransport transport = new Transport();
        private WebBrowser webBrowser;

        private void StationsNearby_Load(object sender, EventArgs e) {
            
            webBrowser.Navigate("https://www.google.ch/maps/");
        }

        private void stationsNearbyButton_Click(object sender, EventArgs e) {
            this.Refresh();
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

        private void searchButton_Click(object sender, EventArgs e) {
            stationsNearbyListBox.Items.Clear();
            foreach (Station station in transport.GetStations(currentStationTextBox.Text).StationList) {
                if(station.Distance < (double)searchRadiusNumericUpDown.Value * 1000) {
                    stationsNearbyListBox.Items.Add(station.Name);
                }
            }
        }
    }
}
