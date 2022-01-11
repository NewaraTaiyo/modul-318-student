
namespace MyTransportApp {
    partial class Form1 {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.startingStationTextBox = new System.Windows.Forms.TextBox();
            this.endStationTextBox = new System.Windows.Forms.TextBox();
            this.searchConnectionsButton = new System.Windows.Forms.Button();
            this.connectionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.connectionAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.stationsNearbyButton = new System.Windows.Forms.Button();
            this.travleButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.connectionListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.connectionAmountNumericUpDown)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startingStationTextBox
            // 
            this.startingStationTextBox.Location = new System.Drawing.Point(25, 26);
            this.startingStationTextBox.Name = "startingStationTextBox";
            this.startingStationTextBox.Size = new System.Drawing.Size(709, 20);
            this.startingStationTextBox.TabIndex = 0;
            this.startingStationTextBox.Text = "Startstation";
            // 
            // endStationTextBox
            // 
            this.endStationTextBox.Location = new System.Drawing.Point(25, 63);
            this.endStationTextBox.Name = "endStationTextBox";
            this.endStationTextBox.Size = new System.Drawing.Size(709, 20);
            this.endStationTextBox.TabIndex = 1;
            this.endStationTextBox.Text = "Endstation";
            // 
            // searchConnectionsButton
            // 
            this.searchConnectionsButton.Location = new System.Drawing.Point(604, 89);
            this.searchConnectionsButton.Name = "searchConnectionsButton";
            this.searchConnectionsButton.Size = new System.Drawing.Size(130, 23);
            this.searchConnectionsButton.TabIndex = 2;
            this.searchConnectionsButton.Text = "Verbindungen suchen";
            this.searchConnectionsButton.UseVisualStyleBackColor = true;
            this.searchConnectionsButton.Click += new System.EventHandler(this.searchConnectionsButton_Click);
            // 
            // connectionDateTimePicker
            // 
            this.connectionDateTimePicker.Location = new System.Drawing.Point(534, 145);
            this.connectionDateTimePicker.Name = "connectionDateTimePicker";
            this.connectionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.connectionDateTimePicker.TabIndex = 3;
            // 
            // connectionAmountNumericUpDown
            // 
            this.connectionAmountNumericUpDown.Location = new System.Drawing.Point(139, 143);
            this.connectionAmountNumericUpDown.Name = "connectionAmountNumericUpDown";
            this.connectionAmountNumericUpDown.Size = new System.Drawing.Size(66, 20);
            this.connectionAmountNumericUpDown.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Anzahl Verbindungen:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.stationsNearbyButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.travleButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button5, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 869);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(762, 53);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 47);
            this.button2.TabIndex = 7;
            this.button2.Text = "Abfahrtsstafel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // stationsNearbyButton
            // 
            this.stationsNearbyButton.Location = new System.Drawing.Point(193, 3);
            this.stationsNearbyButton.Name = "stationsNearbyButton";
            this.stationsNearbyButton.Size = new System.Drawing.Size(184, 47);
            this.stationsNearbyButton.TabIndex = 8;
            this.stationsNearbyButton.Text = "Station in der Nähe";
            this.stationsNearbyButton.UseVisualStyleBackColor = true;
            // 
            // travleButton
            // 
            this.travleButton.Location = new System.Drawing.Point(383, 3);
            this.travleButton.Name = "travleButton";
            this.travleButton.Size = new System.Drawing.Size(184, 47);
            this.travleButton.TabIndex = 9;
            this.travleButton.Text = "Reisen";
            this.travleButton.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(573, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(186, 47);
            this.button5.TabIndex = 10;
            this.button5.Text = "Wo ist meine Station";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // connectionListBox
            // 
            this.connectionListBox.FormattingEnabled = true;
            this.connectionListBox.Location = new System.Drawing.Point(25, 191);
            this.connectionListBox.Name = "connectionListBox";
            this.connectionListBox.Size = new System.Drawing.Size(697, 563);
            this.connectionListBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 924);
            this.Controls.Add(this.connectionListBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connectionAmountNumericUpDown);
            this.Controls.Add(this.connectionDateTimePicker);
            this.Controls.Add(this.searchConnectionsButton);
            this.Controls.Add(this.endStationTextBox);
            this.Controls.Add(this.startingStationTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.connectionAmountNumericUpDown)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox startingStationTextBox;
        private System.Windows.Forms.TextBox endStationTextBox;
        private System.Windows.Forms.Button searchConnectionsButton;
        private System.Windows.Forms.DateTimePicker connectionDateTimePicker;
        private System.Windows.Forms.NumericUpDown connectionAmountNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button stationsNearbyButton;
        private System.Windows.Forms.Button travleButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox connectionListBox;
    }
}

