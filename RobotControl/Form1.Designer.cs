
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
            this.liveModeToggle = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.joint1 = new System.Windows.Forms.Label();
            this.joint1Control = new System.Windows.Forms.NumericUpDown();
            this.joint2Control = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.baseServoLabel = new System.Windows.Forms.Label();
            this.baseServoControl = new System.Windows.Forms.NumericUpDown();
            this.sendDataButton = new System.Windows.Forms.Button();
            this.macroTab = new System.Windows.Forms.TabPage();
            this.playMacroButton = new System.Windows.Forms.Button();
            this.OpenMacroButton = new System.Windows.Forms.Button();
            this.macroFilePath = new System.Windows.Forms.TextBox();
            this.connectionStatusLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.settingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baudRateSelector)).BeginInit();
            this.controlsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.joint1Control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joint2Control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseServoControl)).BeginInit();
            this.macroTab.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.macroTab);
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
            this.controlsTab.Controls.Add(this.liveModeToggle);
            this.controlsTab.Controls.Add(this.button1);
            this.controlsTab.Controls.Add(this.joint1);
            this.controlsTab.Controls.Add(this.joint1Control);
            this.controlsTab.Controls.Add(this.joint2Control);
            this.controlsTab.Controls.Add(this.label1);
            this.controlsTab.Controls.Add(this.baseServoLabel);
            this.controlsTab.Controls.Add(this.baseServoControl);
            this.controlsTab.Controls.Add(this.sendDataButton);
            this.controlsTab.Location = new System.Drawing.Point(4, 24);
            this.controlsTab.Name = "controlsTab";
            this.controlsTab.Padding = new System.Windows.Forms.Padding(3);
            this.controlsTab.Size = new System.Drawing.Size(242, 229);
            this.controlsTab.TabIndex = 1;
            this.controlsTab.Text = "Controls";
            this.controlsTab.UseVisualStyleBackColor = true;
            // 
            // liveModeToggle
            // 
            this.liveModeToggle.AutoSize = true;
            this.liveModeToggle.Location = new System.Drawing.Point(163, 105);
            this.liveModeToggle.Name = "liveModeToggle";
            this.liveModeToggle.Size = new System.Drawing.Size(81, 19);
            this.liveModeToggle.TabIndex = 10000;
            this.liveModeToggle.Text = "Live Mode";
            this.liveModeToggle.UseVisualStyleBackColor = true;
            this.liveModeToggle.CheckedChanged += new System.EventHandler(this.LiveModeToggle_CheckedChanged);
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
            this.joint1Control.ValueChanged += new System.EventHandler(this.ServoUpdate);
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
            this.joint2Control.ValueChanged += new System.EventHandler(this.ServoUpdate);
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
            // baseServoControl
            // 
            this.baseServoControl.Location = new System.Drawing.Point(81, 15);
            this.baseServoControl.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.baseServoControl.Name = "baseServoControl";
            this.baseServoControl.Size = new System.Drawing.Size(120, 23);
            this.baseServoControl.TabIndex = 1;
            this.baseServoControl.ValueChanged += new System.EventHandler(this.ServoUpdate);
            // 
            // sendDataButton
            // 
            this.sendDataButton.Location = new System.Drawing.Point(81, 102);
            this.sendDataButton.Name = "sendDataButton";
            this.sendDataButton.Size = new System.Drawing.Size(75, 23);
            this.sendDataButton.TabIndex = 4;
            this.sendDataButton.Text = "Send Data";
            this.sendDataButton.UseVisualStyleBackColor = true;
            this.sendDataButton.Click += new System.EventHandler(this.SendCommand);
            // 
            // macroTab
            // 
            this.macroTab.Controls.Add(this.playMacroButton);
            this.macroTab.Controls.Add(this.OpenMacroButton);
            this.macroTab.Controls.Add(this.macroFilePath);
            this.macroTab.Location = new System.Drawing.Point(4, 24);
            this.macroTab.Name = "macroTab";
            this.macroTab.Size = new System.Drawing.Size(242, 229);
            this.macroTab.TabIndex = 2;
            this.macroTab.Text = "Macros";
            this.macroTab.UseVisualStyleBackColor = true;
            // 
            // playMacroButton
            // 
            this.playMacroButton.Location = new System.Drawing.Point(81, 119);
            this.playMacroButton.Name = "playMacroButton";
            this.playMacroButton.Size = new System.Drawing.Size(75, 23);
            this.playMacroButton.TabIndex = 4;
            this.playMacroButton.Text = "Play";
            this.playMacroButton.UseVisualStyleBackColor = true;
            this.playMacroButton.Click += new System.EventHandler(this.PlayMacro);
            // 
            // OpenMacroButton
            // 
            this.OpenMacroButton.Location = new System.Drawing.Point(153, 41);
            this.OpenMacroButton.Name = "OpenMacroButton";
            this.OpenMacroButton.Size = new System.Drawing.Size(75, 23);
            this.OpenMacroButton.TabIndex = 3;
            this.OpenMacroButton.Text = "Open";
            this.OpenMacroButton.UseVisualStyleBackColor = true;
            this.OpenMacroButton.Click += new System.EventHandler(this.OpenFile);
            // 
            // macroFilePath
            // 
            this.macroFilePath.Location = new System.Drawing.Point(12, 12);
            this.macroFilePath.Name = "macroFilePath";
            this.macroFilePath.Size = new System.Drawing.Size(216, 23);
            this.macroFilePath.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)(this.baseServoControl)).EndInit();
            this.macroTab.ResumeLayout(false);
            this.macroTab.PerformLayout();
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
        private System.Windows.Forms.Button sendDataButton;
        private System.Windows.Forms.NumericUpDown baseServoControl;
        private System.Windows.Forms.Label joint1;
        private System.Windows.Forms.NumericUpDown joint1Control;
        private System.Windows.Forms.NumericUpDown joint2Control;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label baseServoLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox liveModeToggle;
        private System.Windows.Forms.TabPage macroTab;
        private System.Windows.Forms.TextBox macroFilePath;
        private System.Windows.Forms.Button OpenMacroButton;
        private System.Windows.Forms.Button playMacroButton;
    }
}

