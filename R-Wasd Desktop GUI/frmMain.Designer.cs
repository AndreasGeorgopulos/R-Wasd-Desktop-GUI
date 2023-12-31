﻿namespace R_Wasd_Desktop_GUI
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.comboBox20 = new System.Windows.Forms.ComboBox();
            this.comboBox19 = new System.Windows.Forms.ComboBox();
            this.comboBox18 = new System.Windows.Forms.ComboBox();
            this.comboBox17 = new System.Windows.Forms.ComboBox();
            this.comboBox16 = new System.Windows.Forms.ComboBox();
            this.comboBox15 = new System.Windows.Forms.ComboBox();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonSetDefault = new System.Windows.Forms.Button();
            this.buttonGetSettings = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelFirmwareVersion = new System.Windows.Forms.Label();
            this.labelAppVersion = new System.Windows.Forms.Label();
            this.buttonCheckUpdate = new System.Windows.Forms.Button();
            this.groupBoxFirmwareUpdate = new System.Windows.Forms.GroupBox();
            this.labelFirmwareDescription = new System.Windows.Forms.Label();
            this.labelFirmwareNewVersion = new System.Windows.Forms.Label();
            this.labelFirmwareTitle = new System.Windows.Forms.Label();
            this.buttonFirmwareCancel = new System.Windows.Forms.Button();
            this.buttonFirmwareUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBoxFirmwareUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DtrEnable = true;
            this.serialPort1.Handshake = System.IO.Ports.Handshake.XOnXOff;
            this.serialPort1.RtsEnable = true;
            this.serialPort1.WriteTimeout = 500;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 834);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1580, 23);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(169, 18);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // comboBox20
            // 
            this.comboBox20.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox20.BackColor = System.Drawing.Color.White;
            this.comboBox20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox20.Enabled = false;
            this.comboBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox20.ForeColor = System.Drawing.Color.Black;
            this.comboBox20.FormattingEnabled = true;
            this.comboBox20.Location = new System.Drawing.Point(1434, 692);
            this.comboBox20.Name = "comboBox20";
            this.comboBox20.Size = new System.Drawing.Size(105, 26);
            this.comboBox20.TabIndex = 23;
            this.comboBox20.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
            this.comboBox20.Enter += new System.EventHandler(this.comboBox_Enter);
            // 
            // comboBox19
            // 
            this.comboBox19.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox19.BackColor = System.Drawing.Color.White;
            this.comboBox19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox19.Enabled = false;
            this.comboBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox19.ForeColor = System.Drawing.Color.Black;
            this.comboBox19.FormattingEnabled = true;
            this.comboBox19.Location = new System.Drawing.Point(1340, 741);
            this.comboBox19.Name = "comboBox19";
            this.comboBox19.Size = new System.Drawing.Size(105, 26);
            this.comboBox19.TabIndex = 24;
            this.comboBox19.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
            this.comboBox19.Enter += new System.EventHandler(this.comboBox_Enter);
            // 
            // comboBox18
            // 
            this.comboBox18.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox18.BackColor = System.Drawing.Color.White;
            this.comboBox18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox18.Enabled = false;
            this.comboBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox18.ForeColor = System.Drawing.Color.Black;
            this.comboBox18.FormattingEnabled = true;
            this.comboBox18.Location = new System.Drawing.Point(1244, 692);
            this.comboBox18.Name = "comboBox18";
            this.comboBox18.Size = new System.Drawing.Size(105, 26);
            this.comboBox18.TabIndex = 22;
            this.comboBox18.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
            this.comboBox18.Enter += new System.EventHandler(this.comboBox_Enter);
            // 
            // comboBox17
            // 
            this.comboBox17.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox17.BackColor = System.Drawing.Color.White;
            this.comboBox17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox17.Enabled = false;
            this.comboBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox17.ForeColor = System.Drawing.Color.Black;
            this.comboBox17.FormattingEnabled = true;
            this.comboBox17.Location = new System.Drawing.Point(1341, 643);
            this.comboBox17.Name = "comboBox17";
            this.comboBox17.Size = new System.Drawing.Size(105, 26);
            this.comboBox17.TabIndex = 21;
            this.comboBox17.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
            this.comboBox17.Enter += new System.EventHandler(this.comboBox_Enter);
            // 
            // comboBox16
            // 
            this.comboBox16.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox16.BackColor = System.Drawing.Color.White;
            this.comboBox16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox16.Enabled = false;
            this.comboBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox16.ForeColor = System.Drawing.Color.Black;
            this.comboBox16.FormattingEnabled = true;
            this.comboBox16.Location = new System.Drawing.Point(1328, 354);
            this.comboBox16.Name = "comboBox16";
            this.comboBox16.Size = new System.Drawing.Size(105, 26);
            this.comboBox16.TabIndex = 18;
            this.comboBox16.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
            this.comboBox16.Enter += new System.EventHandler(this.comboBox_Enter);
            // 
            // comboBox15
            // 
            this.comboBox15.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox15.BackColor = System.Drawing.Color.White;
            this.comboBox15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox15.Enabled = false;
            this.comboBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox15.ForeColor = System.Drawing.Color.Black;
            this.comboBox15.FormattingEnabled = true;
            this.comboBox15.Location = new System.Drawing.Point(1122, 692);
            this.comboBox15.Name = "comboBox15";
            this.comboBox15.Size = new System.Drawing.Size(105, 26);
            this.comboBox15.TabIndex = 19;
            this.comboBox15.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
            this.comboBox15.Enter += new System.EventHandler(this.comboBox_Enter);
            // 
            // comboBox14
            // 
            this.comboBox14.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox14.BackColor = System.Drawing.Color.White;
            this.comboBox14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox14.Enabled = false;
            this.comboBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox14.ForeColor = System.Drawing.Color.Black;
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Location = new System.Drawing.Point(1328, 146);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(105, 26);
            this.comboBox14.TabIndex = 15;
            this.comboBox14.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
            this.comboBox14.Enter += new System.EventHandler(this.comboBox_Enter);
            // 
            // comboBox13
            // 
            this.comboBox13.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox13.BackColor = System.Drawing.Color.White;
            this.comboBox13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox13.Enabled = false;
            this.comboBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox13.ForeColor = System.Drawing.Color.Black;
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Location = new System.Drawing.Point(1327, 245);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(105, 26);
            this.comboBox13.TabIndex = 17;
            this.comboBox13.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
            this.comboBox13.Enter += new System.EventHandler(this.comboBox_Enter);
            // 
            // comboBox12
            // 
            this.comboBox12.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox12.BackColor = System.Drawing.Color.White;
            this.comboBox12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox12.Enabled = false;
            this.comboBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox12.ForeColor = System.Drawing.Color.Black;
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Location = new System.Drawing.Point(1190, 91);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(105, 26);
            this.comboBox12.TabIndex = 16;
            this.comboBox12.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
            this.comboBox12.Enter += new System.EventHandler(this.comboBox_Enter);
            // 
            // comboBox11
            // 
            this.comboBox11.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox11.BackColor = System.Drawing.Color.White;
            this.comboBox11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox11.Enabled = false;
            this.comboBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox11.ForeColor = System.Drawing.Color.Black;
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Location = new System.Drawing.Point(1329, 457);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(105, 26);
            this.comboBox11.TabIndex = 14;
            this.comboBox11.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
            this.comboBox11.Enter += new System.EventHandler(this.comboBox_Enter);
            // 
            // comboBox10
            // 
            this.comboBox10.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox10.BackColor = System.Drawing.Color.White;
            this.comboBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox10.Enabled = false;
            this.comboBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox10.ForeColor = System.Drawing.Color.Black;
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(943, 91);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(105, 26);
            this.comboBox10.TabIndex = 13;
            this.comboBox10.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
            this.comboBox10.Enter += new System.EventHandler(this.comboBox_Enter);
            // 
            // comboBox9
            // 
            this.comboBox9.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox9.BackColor = System.Drawing.Color.White;
            this.comboBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox9.Enabled = false;
            this.comboBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox9.ForeColor = System.Drawing.Color.Black;
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(1067, 91);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(105, 26);
            this.comboBox9.TabIndex = 12;
            this.comboBox9.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
            this.comboBox9.Enter += new System.EventHandler(this.comboBox_Enter);
            // 
            // comboBox8
            // 
            this.comboBox8.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox8.BackColor = System.Drawing.Color.White;
            this.comboBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox8.Enabled = false;
            this.comboBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox8.ForeColor = System.Drawing.Color.Black;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(820, 91);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(105, 26);
            this.comboBox8.TabIndex = 11;
            this.comboBox8.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
            this.comboBox8.Enter += new System.EventHandler(this.comboBox_Enter);
            // 
            // comboBox7
            // 
            this.comboBox7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox7.BackColor = System.Drawing.Color.White;
            this.comboBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox7.Enabled = false;
            this.comboBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox7.ForeColor = System.Drawing.Color.Black;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(650, 140);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(105, 26);
            this.comboBox7.TabIndex = 10;
            this.comboBox7.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
            this.comboBox7.Enter += new System.EventHandler(this.comboBox_Enter);
            // 
            // comboBox6
            // 
            this.comboBox6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox6.BackColor = System.Drawing.Color.White;
            this.comboBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox6.Enabled = false;
            this.comboBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox6.ForeColor = System.Drawing.Color.Black;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(650, 222);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(105, 26);
            this.comboBox6.TabIndex = 9;
            this.comboBox6.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
            this.comboBox6.Enter += new System.EventHandler(this.comboBox_Enter);
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox2.Enabled = false;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox2.ForeColor = System.Drawing.Color.Black;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(1327, 542);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(105, 26);
            this.comboBox2.TabIndex = 20;
            this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
            this.comboBox2.Enter += new System.EventHandler(this.comboBox_Enter);
            // 
            // comboBox3
            // 
            this.comboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox3.BackColor = System.Drawing.Color.White;
            this.comboBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox3.Enabled = false;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox3.ForeColor = System.Drawing.Color.Black;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(650, 561);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(105, 26);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
            this.comboBox3.Enter += new System.EventHandler(this.comboBox_Enter);
            // 
            // comboBox4
            // 
            this.comboBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox4.BackColor = System.Drawing.Color.White;
            this.comboBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox4.Enabled = false;
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox4.ForeColor = System.Drawing.Color.Black;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(650, 461);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(105, 26);
            this.comboBox4.TabIndex = 6;
            this.comboBox4.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
            this.comboBox4.Enter += new System.EventHandler(this.comboBox_Enter);
            // 
            // comboBox5
            // 
            this.comboBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox5.BackColor = System.Drawing.Color.White;
            this.comboBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox5.Enabled = false;
            this.comboBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox5.ForeColor = System.Drawing.Color.Black;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(650, 379);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(105, 26);
            this.comboBox5.TabIndex = 7;
            this.comboBox5.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
            this.comboBox5.Enter += new System.EventHandler(this.comboBox_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.Enabled = false;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(650, 297);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(105, 26);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
            this.comboBox1.Enter += new System.EventHandler(this.comboBox_Enter);
            // 
            // buttonSetDefault
            // 
            this.buttonSetDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(71)))), ((int)(((byte)(46)))));
            this.buttonSetDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSetDefault.Enabled = false;
            this.buttonSetDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSetDefault.ForeColor = System.Drawing.Color.White;
            this.buttonSetDefault.Location = new System.Drawing.Point(181, 371);
            this.buttonSetDefault.Name = "buttonSetDefault";
            this.buttonSetDefault.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.buttonSetDefault.Size = new System.Drawing.Size(272, 37);
            this.buttonSetDefault.TabIndex = 3;
            this.buttonSetDefault.Text = "Set as default";
            this.buttonSetDefault.UseCompatibleTextRendering = true;
            this.buttonSetDefault.UseVisualStyleBackColor = false;
            this.buttonSetDefault.Click += new System.EventHandler(this.buttonSetDefault_Click);
            // 
            // buttonGetSettings
            // 
            this.buttonGetSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(71)))), ((int)(((byte)(46)))));
            this.buttonGetSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGetSettings.Enabled = false;
            this.buttonGetSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGetSettings.ForeColor = System.Drawing.Color.White;
            this.buttonGetSettings.Location = new System.Drawing.Point(181, 265);
            this.buttonGetSettings.Name = "buttonGetSettings";
            this.buttonGetSettings.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.buttonGetSettings.Size = new System.Drawing.Size(272, 37);
            this.buttonGetSettings.TabIndex = 1;
            this.buttonGetSettings.Text = "Get settings from device";
            this.buttonGetSettings.UseCompatibleTextRendering = true;
            this.buttonGetSettings.UseVisualStyleBackColor = false;
            this.buttonGetSettings.Click += new System.EventHandler(this.buttonGetSettings_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(71)))), ((int)(((byte)(46)))));
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Enabled = false;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(181, 315);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.buttonSave.Size = new System.Drawing.Size(272, 37);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save settings to device";
            this.buttonSave.UseCompatibleTextRendering = true;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(71)))), ((int)(((byte)(46)))));
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(181, 429);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.buttonExit.Size = new System.Drawing.Size(272, 37);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseCompatibleTextRendering = true;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelFirmwareVersion
            // 
            this.labelFirmwareVersion.AutoSize = true;
            this.labelFirmwareVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelFirmwareVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFirmwareVersion.ForeColor = System.Drawing.Color.Black;
            this.labelFirmwareVersion.Location = new System.Drawing.Point(1388, 809);
            this.labelFirmwareVersion.Name = "labelFirmwareVersion";
            this.labelFirmwareVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelFirmwareVersion.Size = new System.Drawing.Size(172, 16);
            this.labelFirmwareVersion.TabIndex = 40;
            this.labelFirmwareVersion.Text = "Device firmware version: ----";
            // 
            // labelAppVersion
            // 
            this.labelAppVersion.AutoSize = true;
            this.labelAppVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelAppVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAppVersion.ForeColor = System.Drawing.Color.Black;
            this.labelAppVersion.Location = new System.Drawing.Point(1187, 809);
            this.labelAppVersion.Name = "labelAppVersion";
            this.labelAppVersion.Size = new System.Drawing.Size(143, 16);
            this.labelAppVersion.TabIndex = 41;
            this.labelAppVersion.Text = "Application version: ----";
            // 
            // buttonCheckUpdate
            // 
            this.buttonCheckUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(71)))), ((int)(((byte)(46)))));
            this.buttonCheckUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheckUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCheckUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonCheckUpdate.Location = new System.Drawing.Point(181, 489);
            this.buttonCheckUpdate.Name = "buttonCheckUpdate";
            this.buttonCheckUpdate.Size = new System.Drawing.Size(272, 37);
            this.buttonCheckUpdate.TabIndex = 42;
            this.buttonCheckUpdate.Text = "Check for firmware update";
            this.buttonCheckUpdate.UseVisualStyleBackColor = false;
            this.buttonCheckUpdate.Click += new System.EventHandler(this.buttonCheckUpdate_ClickAsync);
            // 
            // groupBoxFirmwareUpdate
            // 
            this.groupBoxFirmwareUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(149)))), ((int)(((byte)(172)))));
            this.groupBoxFirmwareUpdate.Controls.Add(this.labelFirmwareDescription);
            this.groupBoxFirmwareUpdate.Controls.Add(this.labelFirmwareNewVersion);
            this.groupBoxFirmwareUpdate.Controls.Add(this.labelFirmwareTitle);
            this.groupBoxFirmwareUpdate.Controls.Add(this.buttonFirmwareCancel);
            this.groupBoxFirmwareUpdate.Controls.Add(this.buttonFirmwareUpdate);
            this.groupBoxFirmwareUpdate.Controls.Add(this.label3);
            this.groupBoxFirmwareUpdate.Controls.Add(this.label2);
            this.groupBoxFirmwareUpdate.Controls.Add(this.label1);
            this.groupBoxFirmwareUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxFirmwareUpdate.ForeColor = System.Drawing.Color.White;
            this.groupBoxFirmwareUpdate.Location = new System.Drawing.Point(183, 546);
            this.groupBoxFirmwareUpdate.Name = "groupBoxFirmwareUpdate";
            this.groupBoxFirmwareUpdate.Size = new System.Drawing.Size(267, 266);
            this.groupBoxFirmwareUpdate.TabIndex = 43;
            this.groupBoxFirmwareUpdate.TabStop = false;
            this.groupBoxFirmwareUpdate.Text = "Available new firmware update";
            this.groupBoxFirmwareUpdate.Visible = false;
            // 
            // labelFirmwareDescription
            // 
            this.labelFirmwareDescription.AutoSize = true;
            this.labelFirmwareDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFirmwareDescription.Location = new System.Drawing.Point(16, 135);
            this.labelFirmwareDescription.Name = "labelFirmwareDescription";
            this.labelFirmwareDescription.Size = new System.Drawing.Size(160, 16);
            this.labelFirmwareDescription.TabIndex = 7;
            this.labelFirmwareDescription.Text = "labelFirmwareDescription";
            // 
            // labelFirmwareNewVersion
            // 
            this.labelFirmwareNewVersion.AutoSize = true;
            this.labelFirmwareNewVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFirmwareNewVersion.Location = new System.Drawing.Point(15, 92);
            this.labelFirmwareNewVersion.Name = "labelFirmwareNewVersion";
            this.labelFirmwareNewVersion.Size = new System.Drawing.Size(165, 16);
            this.labelFirmwareNewVersion.TabIndex = 6;
            this.labelFirmwareNewVersion.Text = "labelFirmwareNewVersion";
            // 
            // labelFirmwareTitle
            // 
            this.labelFirmwareTitle.AutoSize = true;
            this.labelFirmwareTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFirmwareTitle.Location = new System.Drawing.Point(16, 51);
            this.labelFirmwareTitle.Name = "labelFirmwareTitle";
            this.labelFirmwareTitle.Size = new System.Drawing.Size(118, 16);
            this.labelFirmwareTitle.TabIndex = 5;
            this.labelFirmwareTitle.Text = "labelFirmwareTitle";
            // 
            // buttonFirmwareCancel
            // 
            this.buttonFirmwareCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(142)))), ((int)(((byte)(94)))));
            this.buttonFirmwareCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFirmwareCancel.Location = new System.Drawing.Point(137, 217);
            this.buttonFirmwareCancel.Name = "buttonFirmwareCancel";
            this.buttonFirmwareCancel.Size = new System.Drawing.Size(92, 33);
            this.buttonFirmwareCancel.TabIndex = 4;
            this.buttonFirmwareCancel.Text = "Cancel";
            this.buttonFirmwareCancel.UseVisualStyleBackColor = false;
            this.buttonFirmwareCancel.Click += new System.EventHandler(this.buttonFirmwareCancel_Click);
            // 
            // buttonFirmwareUpdate
            // 
            this.buttonFirmwareUpdate.BackColor = System.Drawing.Color.Red;
            this.buttonFirmwareUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFirmwareUpdate.Location = new System.Drawing.Point(41, 217);
            this.buttonFirmwareUpdate.Name = "buttonFirmwareUpdate";
            this.buttonFirmwareUpdate.Size = new System.Drawing.Size(90, 33);
            this.buttonFirmwareUpdate.TabIndex = 3;
            this.buttonFirmwareUpdate.Text = "Update";
            this.buttonFirmwareUpdate.UseVisualStyleBackColor = false;
            this.buttonFirmwareUpdate.Click += new System.EventHandler(this.buttonFirmwareUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(14, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Version:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(16, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1580, 857);
            this.Controls.Add(this.groupBoxFirmwareUpdate);
            this.Controls.Add(this.buttonCheckUpdate);
            this.Controls.Add(this.labelAppVersion);
            this.Controls.Add(this.labelFirmwareVersion);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox20);
            this.Controls.Add(this.comboBox18);
            this.Controls.Add(this.comboBox17);
            this.Controls.Add(this.comboBox19);
            this.Controls.Add(this.comboBox15);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox11);
            this.Controls.Add(this.comboBox9);
            this.Controls.Add(this.comboBox14);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.comboBox12);
            this.Controls.Add(this.comboBox10);
            this.Controls.Add(this.comboBox16);
            this.Controls.Add(this.comboBox13);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonGetSettings);
            this.Controls.Add(this.buttonSetDefault);
            this.Controls.Add(this.statusStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "r-WASD Desktoip GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxFirmwareUpdate.ResumeLayout(false);
            this.groupBoxFirmwareUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ComboBox comboBox20;
        private System.Windows.Forms.ComboBox comboBox19;
        private System.Windows.Forms.ComboBox comboBox18;
        private System.Windows.Forms.ComboBox comboBox17;
        private System.Windows.Forms.ComboBox comboBox16;
        private System.Windows.Forms.ComboBox comboBox15;
        private System.Windows.Forms.ComboBox comboBox14;
        private System.Windows.Forms.ComboBox comboBox13;
        private System.Windows.Forms.ComboBox comboBox12;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonSetDefault;
        private System.Windows.Forms.Button buttonGetSettings;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExit;
        public System.Windows.Forms.Label labelFirmwareVersion;
        private System.Windows.Forms.Label labelAppVersion;
        private System.Windows.Forms.Button buttonCheckUpdate;
        private System.Windows.Forms.GroupBox groupBoxFirmwareUpdate;
        private System.Windows.Forms.Label labelFirmwareTitle;
        private System.Windows.Forms.Button buttonFirmwareCancel;
        private System.Windows.Forms.Button buttonFirmwareUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFirmwareNewVersion;
        private System.Windows.Forms.Label labelFirmwareDescription;
    }
}

