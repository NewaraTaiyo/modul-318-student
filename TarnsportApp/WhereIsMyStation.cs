using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportApp {
    public partial class WhereIsMyStation : Form {
        public WhereIsMyStation() {
            InitializeComponent();
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
