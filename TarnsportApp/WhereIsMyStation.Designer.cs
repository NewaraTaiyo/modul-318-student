
namespace TransportApp {
    partial class WhereIsMyStation {
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
            this.whereAmIButton = new System.Windows.Forms.Button();
            this.findMeAWayButton = new System.Windows.Forms.Button();
            this.connectionBoardOfStationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.distanceAwayFromTargetLable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tableLayoutPanel1.TabIndex = 3;
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
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(698, 659);
            this.splitContainer1.SplitterDistance = 329;
            this.splitContainer1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.distanceAwayFromTargetLable);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.connectionBoardOfStationButton);
            this.groupBox1.Controls.Add(this.findMeAWayButton);
            this.groupBox1.Controls.Add(this.whereAmIButton);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infos";
            // 
            // whereAmIButton
            // 
            this.whereAmIButton.Location = new System.Drawing.Point(479, 22);
            this.whereAmIButton.Name = "whereAmIButton";
            this.whereAmIButton.Size = new System.Drawing.Size(75, 23);
            this.whereAmIButton.TabIndex = 0;
            this.whereAmIButton.Text = "Wo bin ich";
            this.whereAmIButton.UseVisualStyleBackColor = true;
            // 
            // findMeAWayButton
            // 
            this.findMeAWayButton.Location = new System.Drawing.Point(560, 22);
            this.findMeAWayButton.Name = "findMeAWayButton";
            this.findMeAWayButton.Size = new System.Drawing.Size(123, 23);
            this.findMeAWayButton.TabIndex = 1;
            this.findMeAWayButton.Text = "Finde mir den Weg";
            this.findMeAWayButton.UseVisualStyleBackColor = true;
            // 
            // connectionBoardOfStationButton
            // 
            this.connectionBoardOfStationButton.Location = new System.Drawing.Point(479, 220);
            this.connectionBoardOfStationButton.Name = "connectionBoardOfStationButton";
            this.connectionBoardOfStationButton.Size = new System.Drawing.Size(204, 75);
            this.connectionBoardOfStationButton.TabIndex = 2;
            this.connectionBoardOfStationButton.Text = "Abfahrtstafel der Station";
            this.connectionBoardOfStationButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Distanz: ";
            // 
            // distanceAwayFromTargetLable
            // 
            this.distanceAwayFromTargetLable.AutoSize = true;
            this.distanceAwayFromTargetLable.Location = new System.Drawing.Point(104, 29);
            this.distanceAwayFromTargetLable.Name = "distanceAwayFromTargetLable";
            this.distanceAwayFromTargetLable.Size = new System.Drawing.Size(13, 15);
            this.distanceAwayFromTargetLable.TabIndex = 4;
            this.distanceAwayFromTargetLable.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "m";
            // 
            // WhereIsMyStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(698, 735);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WhereIsMyStation";
            this.Text = "WhereIsMyStation";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button connectionBoardOfStationButton;
        private System.Windows.Forms.Button findMeAWayButton;
        private System.Windows.Forms.Button whereAmIButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label distanceAwayFromTargetLable;
        private System.Windows.Forms.Label label1;
    }
}