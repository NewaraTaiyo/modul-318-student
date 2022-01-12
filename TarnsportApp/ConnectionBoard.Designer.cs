
namespace TransportApp {
    partial class ConnectionBoard {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.connectionBoardButton = new System.Windows.Forms.Button();
            this.stationsNearbyButton = new System.Windows.Forms.Button();
            this.connectionsButton = new System.Windows.Forms.Button();
            this.whereIsMyStationButton = new System.Windows.Forms.Button();
            this.stationBoardDataGridView = new System.Windows.Forms.DataGridView();
            this.destenationStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentStationTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationBoardDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.connectionBoardButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.stationsNearbyButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.connectionsButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.whereIsMyStationButton, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 662);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(698, 73);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // connectionBoardButton
            // 
            this.connectionBoardButton.Location = new System.Drawing.Point(0, 0);
            this.connectionBoardButton.Margin = new System.Windows.Forms.Padding(0);
            this.connectionBoardButton.Name = "connectionBoardButton";
            this.connectionBoardButton.Size = new System.Drawing.Size(174, 73);
            this.connectionBoardButton.TabIndex = 0;
            this.connectionBoardButton.Text = "Abfahrtstafel";
            this.connectionBoardButton.UseVisualStyleBackColor = true;
            this.connectionBoardButton.Click += new System.EventHandler(this.connectionBoardButton_Click);
            // 
            // stationsNearbyButton
            // 
            this.stationsNearbyButton.Location = new System.Drawing.Point(174, 0);
            this.stationsNearbyButton.Margin = new System.Windows.Forms.Padding(0);
            this.stationsNearbyButton.Name = "stationsNearbyButton";
            this.stationsNearbyButton.Size = new System.Drawing.Size(174, 73);
            this.stationsNearbyButton.TabIndex = 1;
            this.stationsNearbyButton.Text = "Stationen in der Nähe";
            this.stationsNearbyButton.UseVisualStyleBackColor = true;
            this.stationsNearbyButton.Click += new System.EventHandler(this.stationsNearbyButton_Click);
            // 
            // connectionsButton
            // 
            this.connectionsButton.Location = new System.Drawing.Point(348, 0);
            this.connectionsButton.Margin = new System.Windows.Forms.Padding(0);
            this.connectionsButton.Name = "connectionsButton";
            this.connectionsButton.Size = new System.Drawing.Size(174, 73);
            this.connectionsButton.TabIndex = 2;
            this.connectionsButton.Text = "Reisen";
            this.connectionsButton.UseVisualStyleBackColor = true;
            this.connectionsButton.Click += new System.EventHandler(this.connectionsButton_Click);
            // 
            // whereIsMyStationButton
            // 
            this.whereIsMyStationButton.Location = new System.Drawing.Point(522, 0);
            this.whereIsMyStationButton.Margin = new System.Windows.Forms.Padding(0);
            this.whereIsMyStationButton.Name = "whereIsMyStationButton";
            this.whereIsMyStationButton.Size = new System.Drawing.Size(176, 73);
            this.whereIsMyStationButton.TabIndex = 3;
            this.whereIsMyStationButton.Text = "Wo ist meine Station";
            this.whereIsMyStationButton.UseVisualStyleBackColor = true;
            this.whereIsMyStationButton.Click += new System.EventHandler(this.whereIsMyStationButton_Click);
            // 
            // stationBoardDataGridView
            // 
            this.stationBoardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stationBoardDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.destenationStation,
            this.departureTime});
            this.stationBoardDataGridView.Location = new System.Drawing.Point(50, 127);
            this.stationBoardDataGridView.Name = "stationBoardDataGridView";
            this.stationBoardDataGridView.RowTemplate.Height = 25;
            this.stationBoardDataGridView.Size = new System.Drawing.Size(589, 510);
            this.stationBoardDataGridView.TabIndex = 2;
            // 
            // destenationStation
            // 
            this.destenationStation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.destenationStation.HeaderText = "Zielort";
            this.destenationStation.Name = "destenationStation";
            // 
            // departureTime
            // 
            this.departureTime.HeaderText = "Abfahrt";
            this.departureTime.Name = "departureTime";
            // 
            // currentStationTextBox
            // 
            this.currentStationTextBox.Location = new System.Drawing.Point(50, 56);
            this.currentStationTextBox.Name = "currentStationTextBox";
            this.currentStationTextBox.Size = new System.Drawing.Size(589, 23);
            this.currentStationTextBox.TabIndex = 3;
            this.currentStationTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.currentStationTextBox_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aktuelle Station";
            // 
            // ConnectionBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 735);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentStationTextBox);
            this.Controls.Add(this.stationBoardDataGridView);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ConnectionBoard";
            this.Text = "StationBoard";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stationBoardDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button connectionBoardButton;
        private System.Windows.Forms.Button stationsNearbyButton;
        private System.Windows.Forms.Button connectionsButton;
        private System.Windows.Forms.Button whereIsMyStationButton;
        private System.Windows.Forms.DataGridView stationBoardDataGridView;
        private System.Windows.Forms.TextBox currentStationTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn destenationStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTime;
    }
}