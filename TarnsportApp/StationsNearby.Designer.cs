
namespace TransportApp {
    partial class StationsNearby {
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stationsNearbyListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchRadiusNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.currentStationTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchRadiusNumericUpDown)).BeginInit();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 664);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(698, 73);
            this.tableLayoutPanel1.TabIndex = 2;
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
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Location = new System.Drawing.Point(1, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(698, 661);
            this.splitContainer1.SplitterDistance = 443;
            this.splitContainer1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.currentStationTextBox);
            this.groupBox1.Controls.Add(this.stationsNearbyListBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.searchRadiusNumericUpDown);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stationen in der Nähe";
            // 
            // stationsNearbyListBox
            // 
            this.stationsNearbyListBox.FormattingEnabled = true;
            this.stationsNearbyListBox.ItemHeight = 15;
            this.stationsNearbyListBox.Location = new System.Drawing.Point(8, 24);
            this.stationsNearbyListBox.Name = "stationsNearbyListBox";
            this.stationsNearbyListBox.Size = new System.Drawing.Size(337, 184);
            this.stationsNearbyListBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(662, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "km";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Radius:";
            // 
            // searchRadiusNumericUpDown
            // 
            this.searchRadiusNumericUpDown.Location = new System.Drawing.Point(594, 22);
            this.searchRadiusNumericUpDown.Name = "searchRadiusNumericUpDown";
            this.searchRadiusNumericUpDown.Size = new System.Drawing.Size(61, 23);
            this.searchRadiusNumericUpDown.TabIndex = 1;
            this.searchRadiusNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // currentStationTextBox
            // 
            this.currentStationTextBox.Location = new System.Drawing.Point(380, 95);
            this.currentStationTextBox.Name = "currentStationTextBox";
            this.currentStationTextBox.Size = new System.Drawing.Size(275, 23);
            this.currentStationTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aktuelle Station";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(580, 124);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Suchen";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // StationsNearby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 735);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StationsNearby";
            this.Text = "StationsNearby";
            this.Load += new System.EventHandler(this.StationsNearby_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchRadiusNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button connectionBoardButton;
        private System.Windows.Forms.Button stationsNearbyButton;
        private System.Windows.Forms.Button connectionsButton;
        private System.Windows.Forms.Button whereIsMyStationButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown searchRadiusNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox stationsNearbyListBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox currentStationTextBox;
    }
}