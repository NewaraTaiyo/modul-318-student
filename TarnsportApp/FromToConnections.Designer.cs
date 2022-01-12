
namespace TarnsportApp {
    partial class FromToConnections {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.connectionBoardButton = new System.Windows.Forms.Button();
            this.stationsNearbyButton = new System.Windows.Forms.Button();
            this.connectionsButton = new System.Windows.Forms.Button();
            this.whereIsMyStationButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.amountOfConectionsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.connectionsDataGridView = new System.Windows.Forms.DataGridView();
            this.startStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departurePlatform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchConnectionsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hourNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minuteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.startStationComboBox = new System.Windows.Forms.ComboBox();
            this.endStationComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountOfConectionsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNumericUpDown)).BeginInit();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 662);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(698, 73);
            this.tableLayoutPanel1.TabIndex = 0;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(462, 176);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 23);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Anzahl Verbindungen:";
            // 
            // amountOfConectionsNumericUpDown
            // 
            this.amountOfConectionsNumericUpDown.Location = new System.Drawing.Point(165, 174);
            this.amountOfConectionsNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.amountOfConectionsNumericUpDown.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.amountOfConectionsNumericUpDown.Name = "amountOfConectionsNumericUpDown";
            this.amountOfConectionsNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.amountOfConectionsNumericUpDown.TabIndex = 5;
            this.amountOfConectionsNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // connectionsDataGridView
            // 
            this.connectionsDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.connectionsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.connectionsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.connectionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.connectionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startStation,
            this.endStation,
            this.departurePlatform,
            this.departureTime,
            this.timeDuration});
            this.connectionsDataGridView.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.connectionsDataGridView.Location = new System.Drawing.Point(36, 249);
            this.connectionsDataGridView.Name = "connectionsDataGridView";
            this.connectionsDataGridView.RowTemplate.Height = 25;
            this.connectionsDataGridView.Size = new System.Drawing.Size(636, 371);
            this.connectionsDataGridView.TabIndex = 6;
            // 
            // startStation
            // 
            this.startStation.HeaderText = "Startstation";
            this.startStation.Name = "startStation";
            // 
            // endStation
            // 
            this.endStation.HeaderText = "Endstation";
            this.endStation.Name = "endStation";
            // 
            // departurePlatform
            // 
            this.departurePlatform.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departurePlatform.HeaderText = "Gleis";
            this.departurePlatform.Name = "departurePlatform";
            // 
            // departureTime
            // 
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            this.departureTime.DefaultCellStyle = dataGridViewCellStyle1;
            this.departureTime.HeaderText = "Abfahrt";
            this.departureTime.Name = "departureTime";
            this.departureTime.Width = 147;
            // 
            // timeDuration
            // 
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            this.timeDuration.DefaultCellStyle = dataGridViewCellStyle2;
            this.timeDuration.HeaderText = "Dauer";
            this.timeDuration.Name = "timeDuration";
            // 
            // searchConnectionsButton
            // 
            this.searchConnectionsButton.Location = new System.Drawing.Point(524, 125);
            this.searchConnectionsButton.Name = "searchConnectionsButton";
            this.searchConnectionsButton.Size = new System.Drawing.Size(148, 23);
            this.searchConnectionsButton.TabIndex = 3;
            this.searchConnectionsButton.Text = "Verbindungen suchen";
            this.searchConnectionsButton.UseVisualStyleBackColor = true;
            this.searchConnectionsButton.Click += new System.EventHandler(this.searchConnectionsButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Startstation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Endstation";
            // 
            // hourNumericUpDown
            // 
            this.hourNumericUpDown.Location = new System.Drawing.Point(575, 205);
            this.hourNumericUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hourNumericUpDown.Name = "hourNumericUpDown";
            this.hourNumericUpDown.Size = new System.Drawing.Size(38, 23);
            this.hourNumericUpDown.TabIndex = 10;
            // 
            // minuteNumericUpDown
            // 
            this.minuteNumericUpDown.Location = new System.Drawing.Point(634, 205);
            this.minuteNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minuteNumericUpDown.Name = "minuteNumericUpDown";
            this.minuteNumericUpDown.Size = new System.Drawing.Size(38, 23);
            this.minuteNumericUpDown.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(618, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = ":";
            // 
            // startStationComboBox
            // 
            this.startStationComboBox.FormattingEnabled = true;
            this.startStationComboBox.Location = new System.Drawing.Point(36, 35);
            this.startStationComboBox.Name = "startStationComboBox";
            this.startStationComboBox.Size = new System.Drawing.Size(636, 23);
            this.startStationComboBox.TabIndex = 13;
            this.startStationComboBox.TextChanged += new System.EventHandler(this.comboBox_TextChanged);
            // 
            // endStationComboBox
            // 
            this.endStationComboBox.FormattingEnabled = true;
            this.endStationComboBox.Location = new System.Drawing.Point(36, 87);
            this.endStationComboBox.Name = "endStationComboBox";
            this.endStationComboBox.Size = new System.Drawing.Size(636, 23);
            this.endStationComboBox.TabIndex = 14;
            this.endStationComboBox.TextChanged += new System.EventHandler(this.endStationComboBox_TextChanged);
            this.endStationComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.endStationComboBox_KeyUp);
            // 
            // FromToConnections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 735);
            this.Controls.Add(this.endStationComboBox);
            this.Controls.Add(this.startStationComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.minuteNumericUpDown);
            this.Controls.Add(this.hourNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchConnectionsButton);
            this.Controls.Add(this.connectionsDataGridView);
            this.Controls.Add(this.amountOfConectionsNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FromToConnections";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.amountOfConectionsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button connectionBoardButton;
        private System.Windows.Forms.Button stationsNearbyButton;
        private System.Windows.Forms.Button connectionsButton;
        private System.Windows.Forms.Button whereIsMyStationButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown amountOfConectionsNumericUpDown;
        private System.Windows.Forms.DataGridView connectionsDataGridView;
        private System.Windows.Forms.Button searchConnectionsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn startStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn endStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn departurePlatform;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDuration;
        private System.Windows.Forms.NumericUpDown hourNumericUpDown;
        private System.Windows.Forms.NumericUpDown minuteNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox startStationComboBox;
        private System.Windows.Forms.ComboBox endStationComboBox;
    }
}

