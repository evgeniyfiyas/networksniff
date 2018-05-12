namespace NetworkSniff.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.adapters = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.packetsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalPacketsLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.broadcastLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.avgLengthLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adapters
            // 
            this.adapters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.adapters.FormattingEnabled = true;
            this.adapters.Location = new System.Drawing.Point(150, 25);
            this.adapters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adapters.Name = "adapters";
            this.adapters.Size = new System.Drawing.Size(616, 21);
            this.adapters.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start capture on interface:";
            // 
            // packetsListView
            // 
            this.packetsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.packetsListView.FullRowSelect = true;
            this.packetsListView.GridLines = true;
            this.packetsListView.Location = new System.Drawing.Point(19, 73);
            this.packetsListView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.packetsListView.Name = "packetsListView";
            this.packetsListView.Size = new System.Drawing.Size(747, 307);
            this.packetsListView.TabIndex = 2;
            this.packetsListView.UseCompatibleStateImageBehavior = false;
            this.packetsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Time";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Source";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Destination";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Protocol";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Length";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Contents";
            this.columnHeader6.Width = 100;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(786, 44);
            this.startButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(142, 29);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start capturing";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(942, 25);
            this.stopButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(142, 47);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "Stop capturing";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(786, 25);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(135, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Dump results to out.dat";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Average packet length:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalPacketsLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.broadcastLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.avgLengthLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(786, 97);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(298, 91);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics:";
            // 
            // totalPacketsLabel
            // 
            this.totalPacketsLabel.AutoSize = true;
            this.totalPacketsLabel.Location = new System.Drawing.Point(214, 22);
            this.totalPacketsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalPacketsLabel.Name = "totalPacketsLabel";
            this.totalPacketsLabel.Size = new System.Drawing.Size(13, 13);
            this.totalPacketsLabel.TabIndex = 15;
            this.totalPacketsLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total packets captured:";
            // 
            // broadcastLabel
            // 
            this.broadcastLabel.AutoSize = true;
            this.broadcastLabel.Location = new System.Drawing.Point(214, 62);
            this.broadcastLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.broadcastLabel.Name = "broadcastLabel";
            this.broadcastLabel.Size = new System.Drawing.Size(13, 13);
            this.broadcastLabel.TabIndex = 11;
            this.broadcastLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Broadcast packets:";
            // 
            // avgLengthLabel
            // 
            this.avgLengthLabel.AutoSize = true;
            this.avgLengthLabel.Location = new System.Drawing.Point(214, 42);
            this.avgLengthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgLengthLabel.Name = "avgLengthLabel";
            this.avgLengthLabel.Size = new System.Drawing.Size(13, 13);
            this.avgLengthLabel.TabIndex = 7;
            this.avgLengthLabel.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 399);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.packetsListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adapters);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "NetworkSniff";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox adapters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView packetsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label avgLengthLabel;
        private System.Windows.Forms.Label broadcastLabel;
        private System.Windows.Forms.Label totalPacketsLabel;
        private System.Windows.Forms.Label label3;
    }
}

