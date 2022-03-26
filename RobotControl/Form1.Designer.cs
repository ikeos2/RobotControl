
namespace RobotControl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.portSelector = new System.Windows.Forms.ComboBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.BaudRateLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.baudRateSelector = new System.Windows.Forms.NumericUpDown();
            this.controlsTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.joint1 = new System.Windows.Forms.Label();
            this.joint1Control = new System.Windows.Forms.NumericUpDown();
            this.joint2Control = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.baseServoLabel = new System.Windows.Forms.Label();
            this.servo1Control = new System.Windows.Forms.NumericUpDown();
            this.sendTest = new System.Windows.Forms.Button();
            this.connectionStatusLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.settingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baudRateSelector)).BeginInit();
            this.controlsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.joint1Control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joint2Control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo1Control)).BeginInit();
            this.SuspendLayout();
            // 
            // portSelector
            // 
            this.portSelector.FormattingEnabled = true;
            this.portSelector.Location = new System.Drawing.Point(73, 20);
            this.portSelector.Name = "portSelector";
            this.portSelector.Size = new System.Drawing.Size(121, 23);
            this.portSelector.TabIndex = 0;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(38, 28);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(29, 15);
            this.portLabel.TabIndex = 1;
            this.portLabel.Text = "Port";
            // 
            // BaudRateLabel
            // 
            this.BaudRateLabel.AutoSize = true;
            this.BaudRateLabel.Location = new System.Drawing.Point(8, 51);
            this.BaudRateLabel.Name = "BaudRateLabel";
            this.BaudRateLabel.Size = new System.Drawing.Size(60, 15);
            this.BaudRateLabel.TabIndex = 2;
            this.BaudRateLabel.Text = "Baud Rate";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(183, 275);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 100;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.settingsTab);
            this.tabControl1.Controls.Add(this.controlsTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(250, 257);
            this.tabControl1.TabIndex = 5;
            // 
            // settingsTab
            // 
            this.settingsTab.Controls.Add(this.baudRateSelector);
            this.settingsTab.Controls.Add(this.portSelector);
            this.settingsTab.Controls.Add(this.portLabel);
            this.settingsTab.Controls.Add(this.BaudRateLabel);
            this.settingsTab.Location = new System.Drawing.Point(4, 24);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(242, 229);
            this.settingsTab.TabIndex = 0;
            this.settingsTab.Text = "Settings";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // baudRateSelector
            // 
            this.baudRateSelector.Location = new System.Drawing.Point(74, 49);
            this.baudRateSelector.Maximum = new decimal(new int[] {
            115200,
            0,
            0,
            0});
            this.baudRateSelector.Name = "baudRateSelector";
            this.baudRateSelector.Size = new System.Drawing.Size(120, 23);
            this.baudRateSelector.TabIndex = 4;
            // 
            // controlsTab
            // 
            this.controlsTab.Controls.Add(this.button1);
            this.controlsTab.Controls.Add(this.joint1);
            this.controlsTab.Controls.Add(this.joint1Control);
            this.controlsTab.Controls.Add(this.joint2Control);
            this.controlsTab.Controls.Add(this.label1);
            this.controlsTab.Controls.Add(this.baseServoLabel);
            this.controlsTab.Controls.Add(this.servo1Control);
            this.controlsTab.Controls.Add(this.sendTest);
            this.controlsTab.Location = new System.Drawing.Point(4, 24);
            this.controlsTab.Name = "controlsTab";
            this.controlsTab.Padding = new System.Windows.Forms.Padding(3);
            this.controlsTab.Size = new System.Drawing.Size(242, 229);
            this.controlsTab.TabIndex = 1;
            this.controlsTab.Text = "Controls";
            this.controlsTab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sweep";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Sweep);
            // 
            // joint1
            // 
            this.joint1.AutoSize = true;
            this.joint1.Location = new System.Drawing.Point(28, 46);
            this.joint1.Name = "joint1";
            this.joint1.Size = new System.Drawing.Size(41, 15);
            this.joint1.TabIndex = 8999;
            this.joint1.Text = "Joint 1";
            // 
            // joint1Control
            // 
            this.joint1Control.Location = new System.Drawing.Point(81, 44);
            this.joint1Control.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.joint1Control.Name = "joint1Control";
            this.joint1Control.Size = new System.Drawing.Size(120, 23);
            this.joint1Control.TabIndex = 2;
            // 
            // joint2Control
            // 
            this.joint2Control.Location = new System.Drawing.Point(81, 73);
            this.joint2Control.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.joint2Control.Name = "joint2Control";
            this.joint2Control.Size = new System.Drawing.Size(120, 23);
            this.joint2Control.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 9999;
            this.label1.Text = "Joint 2";
            // 
            // baseServoLabel
            // 
            this.baseServoLabel.AutoSize = true;
            this.baseServoLabel.Location = new System.Drawing.Point(6, 17);
            this.baseServoLabel.Name = "baseServoLabel";
            this.baseServoLabel.Size = new System.Drawing.Size(63, 15);
            this.baseServoLabel.TabIndex = 999;
            this.baseServoLabel.Text = "Base Servo";
            // 
            // servo1Control
            // 
            this.servo1Control.Location = new System.Drawing.Point(81, 15);
            this.servo1Control.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.servo1Control.Name = "servo1Control";
            this.servo1Control.Size = new System.Drawing.Size(120, 23);
            this.servo1Control.TabIndex = 1;
            // 
            // sendTest
            // 
            this.sendTest.Location = new System.Drawing.Point(81, 102);
            this.sendTest.Name = "sendTest";
            this.sendTest.Size = new System.Drawing.Size(75, 23);
            this.sendTest.TabIndex = 4;
            this.sendTest.Text = "Send Data";
            this.sendTest.UseVisualStyleBackColor = true;
            this.sendTest.Click += new System.EventHandler(this.SendTest_Click);
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.AutoSize = true;
            this.connectionStatusLabel.Location = new System.Drawing.Point(12, 279);
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(99, 15);
            this.connectionStatusLabel.TabIndex = 6;
            this.connectionStatusLabel.Text = "connectionStatus";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 330);
            this.Controls.Add(this.connectionStatusLabel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.connectButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.settingsTab.ResumeLayout(false);
            this.settingsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baudRateSelector)).EndInit();
            this.controlsTab.ResumeLayout(false);
            this.controlsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.joint1Control)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joint2Control)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo1Control)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox portSelector;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label BaudRateLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.TabPage controlsTab;
        private System.Windows.Forms.Label connectionStatusLabel;
        private System.Windows.Forms.NumericUpDown baudRateSelector;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button sendTest;
        private System.Windows.Forms.NumericUpDown servo1Control;
        private System.Windows.Forms.Label joint1;
        private System.Windows.Forms.NumericUpDown joint1Control;
        private System.Windows.Forms.NumericUpDown joint2Control;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label baseServoLabel;
        private System.Windows.Forms.Button button1;
    }
}

