
namespace SoundBoardV2
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.navigationPanel = new System.Windows.Forms.TableLayoutPanel();
            this.siteSwitchPanel = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxSpam = new System.Windows.Forms.CheckBox();
            this.checkBoxConfig = new System.Windows.Forms.CheckBox();
            this.buttonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.soundLabelHead = new System.Windows.Forms.Label();
            this.soundLabelOut = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.mainLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.nextSite = new System.Windows.Forms.Button();
            this.prevSite = new System.Windows.Forms.Button();
            this.soundStop = new System.Windows.Forms.Button();
            this.soundPause = new System.Windows.Forms.Button();
            this.soundResume = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.navigationPanel.SuspendLayout();
            this.siteSwitchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPanel
            // 
            this.navigationPanel.ColumnCount = 3;
            this.navigationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.navigationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.navigationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.navigationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.navigationPanel.Controls.Add(this.siteSwitchPanel, 2, 0);
            this.navigationPanel.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.navigationPanel.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanel.Location = new System.Drawing.Point(3, 315);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.RowCount = 1;
            this.navigationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.navigationPanel.Size = new System.Drawing.Size(704, 72);
            this.navigationPanel.TabIndex = 1;
            this.navigationPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.navigationPanel_Paint);
            // 
            // siteSwitchPanel
            // 
            this.siteSwitchPanel.ColumnCount = 3;
            this.siteSwitchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.siteSwitchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.siteSwitchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.siteSwitchPanel.Controls.Add(this.nextSite, 2, 0);
            this.siteSwitchPanel.Controls.Add(this.prevSite, 0, 0);
            this.siteSwitchPanel.Controls.Add(this.numericUpDown1, 1, 0);
            this.siteSwitchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siteSwitchPanel.Location = new System.Drawing.Point(471, 3);
            this.siteSwitchPanel.Name = "siteSwitchPanel";
            this.siteSwitchPanel.RowCount = 1;
            this.siteSwitchPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.siteSwitchPanel.Size = new System.Drawing.Size(230, 66);
            this.siteSwitchPanel.TabIndex = 0;
            this.siteSwitchPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.siteSwitchPanel_Paint);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.numericUpDown1.Location = new System.Drawing.Point(79, 43);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(70, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.soundStop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.soundPause, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.soundResume, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(237, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(228, 66);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(228, 66);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.checkBoxSpam, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.checkBoxConfig, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(222, 27);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // checkBoxSpam
            // 
            this.checkBoxSpam.AutoSize = true;
            this.checkBoxSpam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxSpam.ForeColor = System.Drawing.Color.White;
            this.checkBoxSpam.Location = new System.Drawing.Point(3, 3);
            this.checkBoxSpam.Name = "checkBoxSpam";
            this.checkBoxSpam.Size = new System.Drawing.Size(105, 21);
            this.checkBoxSpam.TabIndex = 1;
            this.checkBoxSpam.Text = "Spam mode";
            this.checkBoxSpam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxSpam.UseVisualStyleBackColor = true;
            // 
            // checkBoxConfig
            // 
            this.checkBoxConfig.AutoSize = true;
            this.checkBoxConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxConfig.ForeColor = System.Drawing.Color.White;
            this.checkBoxConfig.Location = new System.Drawing.Point(114, 3);
            this.checkBoxConfig.Name = "checkBoxConfig";
            this.checkBoxConfig.Size = new System.Drawing.Size(105, 21);
            this.checkBoxConfig.TabIndex = 2;
            this.checkBoxConfig.Text = "Config";
            this.checkBoxConfig.UseVisualStyleBackColor = true;
            this.checkBoxConfig.CheckedChanged += new System.EventHandler(this.checkBoxConfig_CheckedChanged);
            // 
            // buttonPanel
            // 
            this.buttonPanel.ColumnCount = 6;
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPanel.Location = new System.Drawing.Point(3, 81);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.RowCount = 4;
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonPanel.Size = new System.Drawing.Size(704, 228);
            this.buttonPanel.TabIndex = 0;
            this.buttonPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonPanel_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Output-Vol";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // soundLabelHead
            // 
            this.soundLabelHead.AutoSize = true;
            this.soundLabelHead.ForeColor = System.Drawing.Color.White;
            this.soundLabelHead.Location = new System.Drawing.Point(3, 13);
            this.soundLabelHead.Name = "soundLabelHead";
            this.soundLabelHead.Size = new System.Drawing.Size(23, 13);
            this.soundLabelHead.TabIndex = 1;
            this.soundLabelHead.Text = "null";
            this.soundLabelHead.Click += new System.EventHandler(this.label4_Click);
            // 
            // soundLabelOut
            // 
            this.soundLabelOut.AutoSize = true;
            this.soundLabelOut.ForeColor = System.Drawing.Color.White;
            this.soundLabelOut.Location = new System.Drawing.Point(3, 13);
            this.soundLabelOut.Name = "soundLabelOut";
            this.soundLabelOut.Size = new System.Drawing.Size(23, 13);
            this.soundLabelOut.TabIndex = 1;
            this.soundLabelOut.Text = "null";
            this.soundLabelOut.Click += new System.EventHandler(this.soundLabelOut_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 1;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Controls.Add(this.buttonPanel, 0, 1);
            this.mainPanel.Controls.Add(this.navigationPanel, 0, 2);
            this.mainPanel.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 3;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.mainPanel.Size = new System.Drawing.Size(710, 390);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.mainLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(704, 72);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.77686F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.22314F));
            this.tableLayoutPanel5.Controls.Add(this.trackBar2, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.trackBar1, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(495, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(206, 66);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // trackBar2
            // 
            this.trackBar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar2.Location = new System.Drawing.Point(78, 36);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(125, 27);
            this.trackBar2.TabIndex = 0;
            this.trackBar2.Value = 50;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.Location = new System.Drawing.Point(78, 3);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(125, 27);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.soundLabelHead, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(69, 27);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Head-Vol";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.soundLabelOut, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 36);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(69, 27);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLabel.Font = new System.Drawing.Font("Impact", 36F);
            this.mainLabel.ForeColor = System.Drawing.Color.White;
            this.mainLabel.Location = new System.Drawing.Point(214, 0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(275, 72);
            this.mainLabel.TabIndex = 1;
            this.mainLabel.Text = "Soundboard";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(205, 66);
            this.tableLayoutPanel9.TabIndex = 2;
            // 
            // nextSite
            // 
            this.nextSite.BackColor = System.Drawing.Color.Gray;
            this.nextSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nextSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextSite.Image = global::SoundBoardV2.Properties.Resources.right_arrow;
            this.nextSite.Location = new System.Drawing.Point(155, 3);
            this.nextSite.Name = "nextSite";
            this.nextSite.Size = new System.Drawing.Size(72, 60);
            this.nextSite.TabIndex = 0;
            this.nextSite.UseVisualStyleBackColor = false;
            this.nextSite.Click += new System.EventHandler(this.nextSite_Click);
            // 
            // prevSite
            // 
            this.prevSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.prevSite.BackColor = System.Drawing.Color.Gray;
            this.prevSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prevSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevSite.ForeColor = System.Drawing.Color.Black;
            this.prevSite.Image = global::SoundBoardV2.Properties.Resources.left__arrow;
            this.prevSite.Location = new System.Drawing.Point(3, 3);
            this.prevSite.Name = "prevSite";
            this.prevSite.Size = new System.Drawing.Size(70, 60);
            this.prevSite.TabIndex = 1;
            this.prevSite.UseVisualStyleBackColor = false;
            this.prevSite.Click += new System.EventHandler(this.prevSite_Click);
            // 
            // soundStop
            // 
            this.soundStop.BackColor = System.Drawing.Color.Gray;
            this.soundStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soundStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soundStop.Image = global::SoundBoardV2.Properties.Resources.halt;
            this.soundStop.Location = new System.Drawing.Point(3, 3);
            this.soundStop.Name = "soundStop";
            this.soundStop.Size = new System.Drawing.Size(70, 60);
            this.soundStop.TabIndex = 0;
            this.soundStop.UseVisualStyleBackColor = false;
            this.soundStop.Click += new System.EventHandler(this.soundStop_Click);
            // 
            // soundPause
            // 
            this.soundPause.BackColor = System.Drawing.Color.Gray;
            this.soundPause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soundPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soundPause.Image = global::SoundBoardV2.Properties.Resources.pause__1_;
            this.soundPause.Location = new System.Drawing.Point(79, 3);
            this.soundPause.Name = "soundPause";
            this.soundPause.Size = new System.Drawing.Size(70, 60);
            this.soundPause.TabIndex = 1;
            this.soundPause.UseVisualStyleBackColor = false;
            this.soundPause.Click += new System.EventHandler(this.soundPause_Click);
            // 
            // soundResume
            // 
            this.soundResume.BackColor = System.Drawing.Color.Gray;
            this.soundResume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soundResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soundResume.Image = global::SoundBoardV2.Properties.Resources.pfeilspitze_der_wiedergabetaste;
            this.soundResume.Location = new System.Drawing.Point(155, 3);
            this.soundResume.Name = "soundResume";
            this.soundResume.Size = new System.Drawing.Size(70, 60);
            this.soundResume.TabIndex = 2;
            this.soundResume.UseVisualStyleBackColor = false;
            this.soundResume.Click += new System.EventHandler(this.soundPlay_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::SoundBoardV2.Properties.Resources._1904675_configuration_edit_gear_options_preferences_setting_settings_122525__1_;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 60);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::SoundBoardV2.Properties.Resources.downloadupdates_theapplication_thearrow_descarg_2915__1_;
            this.button2.Location = new System.Drawing.Point(71, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 60);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(710, 390);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "Soundboard";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.navigationPanel.ResumeLayout(false);
            this.siteSwitchPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel navigationPanel;
        private System.Windows.Forms.TableLayoutPanel siteSwitchPanel;
        private System.Windows.Forms.Button nextSite;
        private System.Windows.Forms.Button prevSite;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button soundStop;
        private System.Windows.Forms.Button soundPause;
        private System.Windows.Forms.Button soundResume;
        private System.Windows.Forms.TableLayoutPanel buttonPanel;
        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label soundLabelOut;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label soundLabelHead;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBoxSpam;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.CheckBox checkBoxConfig;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

