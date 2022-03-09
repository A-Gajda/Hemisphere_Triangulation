
namespace projekt2
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.canva = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.kLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.kTrackBar = new System.Windows.Forms.TrackBar();
            this.wybierzMapeButton = new System.Windows.Forms.Button();
            this.wektoryNormalneCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pokazLinieCheck = new System.Windows.Forms.CheckBox();
            this.dokladnoscTriangulacjiTrackBar = new System.Windows.Forms.TrackBar();
            this.dokladnoscTriangulacjiLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ksTrackBar = new System.Windows.Forms.TrackBar();
            this.kdTrackBar = new System.Windows.Forms.TrackBar();
            this.ksLabel = new System.Windows.Forms.Label();
            this.kdLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mTrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.wybierzTekstureButton = new System.Windows.Forms.Button();
            this.wybierzKolorButton = new System.Windows.Forms.Button();
            this.wypelnijTeksturaRadioButton = new System.Windows.Forms.RadioButton();
            this.wypelnijKoloremRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.kolorInterpolacjaRadioButton = new System.Windows.Forms.RadioButton();
            this.kolorDokladnyRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.wybierzKolorSwiatlaButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.startstopButton = new System.Windows.Forms.Button();
            this.lightSourceZLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lightSourceZTrackBar = new System.Windows.Forms.TrackBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canva)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kTrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dokladnoscTriangulacjiTrackBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ksTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTrackBar)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lightSourceZTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer1.Size = new System.Drawing.Size(1385, 903);
            this.splitContainer1.SplitterDistance = 903;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.canva, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(903, 903);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // canva
            // 
            this.canva.Location = new System.Drawing.Point(3, 3);
            this.canva.Name = "canva";
            this.canva.Size = new System.Drawing.Size(897, 897);
            this.canva.TabIndex = 0;
            this.canva.TabStop = false;
            this.canva.Paint += new System.Windows.Forms.PaintEventHandler(this.canva_Paint);
            this.canva.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canva_MouseClick);
            this.canva.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.canva_MouseDoubleClick);
            this.canva.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canva_MouseMove);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1011, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(945, 877);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox4, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.groupBox5, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.groupBox6, 0, 5);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(472, 897);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.kLabel);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.kTrackBar);
            this.groupBox4.Controls.Add(this.wybierzMapeButton);
            this.groupBox4.Controls.Add(this.wektoryNormalneCheckBox);
            this.groupBox4.Location = new System.Drawing.Point(3, 480);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(466, 140);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mapa wektorów normalnych";
            // 
            // kLabel
            // 
            this.kLabel.AutoSize = true;
            this.kLabel.Location = new System.Drawing.Point(420, 82);
            this.kLabel.Name = "kLabel";
            this.kLabel.Size = new System.Drawing.Size(31, 21);
            this.kLabel.TabIndex = 4;
            this.kLabel.Text = "0,5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "k";
            // 
            // kTrackBar
            // 
            this.kTrackBar.Enabled = false;
            this.kTrackBar.Location = new System.Drawing.Point(46, 82);
            this.kTrackBar.Maximum = 100;
            this.kTrackBar.Name = "kTrackBar";
            this.kTrackBar.Size = new System.Drawing.Size(368, 56);
            this.kTrackBar.TabIndex = 2;
            this.kTrackBar.TickFrequency = 10;
            this.kTrackBar.Value = 50;
            this.kTrackBar.ValueChanged += new System.EventHandler(this.kTrackBar_ValueChanged);
            // 
            // wybierzMapeButton
            // 
            this.wybierzMapeButton.Enabled = false;
            this.wybierzMapeButton.Location = new System.Drawing.Point(295, 33);
            this.wybierzMapeButton.Name = "wybierzMapeButton";
            this.wybierzMapeButton.Size = new System.Drawing.Size(159, 29);
            this.wybierzMapeButton.TabIndex = 1;
            this.wybierzMapeButton.Text = "Wybierz mapę";
            this.wybierzMapeButton.UseVisualStyleBackColor = true;
            this.wybierzMapeButton.Click += new System.EventHandler(this.wybierzMapeButton_Click);
            // 
            // wektoryNormalneCheckBox
            // 
            this.wektoryNormalneCheckBox.AutoSize = true;
            this.wektoryNormalneCheckBox.Location = new System.Drawing.Point(17, 36);
            this.wektoryNormalneCheckBox.Name = "wektoryNormalneCheckBox";
            this.wektoryNormalneCheckBox.Size = new System.Drawing.Size(263, 25);
            this.wektoryNormalneCheckBox.TabIndex = 0;
            this.wektoryNormalneCheckBox.Text = "użyj mapy wektorów normalnych";
            this.wektoryNormalneCheckBox.UseVisualStyleBackColor = true;
            this.wektoryNormalneCheckBox.CheckedChanged += new System.EventHandler(this.wektoryNormalneCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pokazLinieCheck);
            this.groupBox1.Controls.Add(this.dokladnoscTriangulacjiTrackBar);
            this.groupBox1.Controls.Add(this.dokladnoscTriangulacjiLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Triangulacja";
            // 
            // pokazLinieCheck
            // 
            this.pokazLinieCheck.AutoSize = true;
            this.pokazLinieCheck.Checked = true;
            this.pokazLinieCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pokazLinieCheck.Location = new System.Drawing.Point(21, 99);
            this.pokazLinieCheck.Name = "pokazLinieCheck";
            this.pokazLinieCheck.Size = new System.Drawing.Size(145, 25);
            this.pokazLinieCheck.TabIndex = 3;
            this.pokazLinieCheck.Text = "Pokaż linie siatki";
            this.pokazLinieCheck.UseVisualStyleBackColor = true;
            this.pokazLinieCheck.CheckedChanged += new System.EventHandler(this.pokazLinieCheck_CheckedChanged);
            // 
            // dokladnoscTriangulacjiTrackBar
            // 
            this.dokladnoscTriangulacjiTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dokladnoscTriangulacjiTrackBar.Location = new System.Drawing.Point(16, 49);
            this.dokladnoscTriangulacjiTrackBar.Maximum = 30;
            this.dokladnoscTriangulacjiTrackBar.Minimum = 5;
            this.dokladnoscTriangulacjiTrackBar.Name = "dokladnoscTriangulacjiTrackBar";
            this.dokladnoscTriangulacjiTrackBar.Size = new System.Drawing.Size(432, 56);
            this.dokladnoscTriangulacjiTrackBar.TabIndex = 2;
            this.dokladnoscTriangulacjiTrackBar.TickFrequency = 2;
            this.dokladnoscTriangulacjiTrackBar.Value = 15;
            this.dokladnoscTriangulacjiTrackBar.ValueChanged += new System.EventHandler(this.dokladnoscTriangulacjiTrackBar_ValueChanged);
            // 
            // dokladnoscTriangulacjiLabel
            // 
            this.dokladnoscTriangulacjiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dokladnoscTriangulacjiLabel.AutoSize = true;
            this.dokladnoscTriangulacjiLabel.Location = new System.Drawing.Point(420, 25);
            this.dokladnoscTriangulacjiLabel.Name = "dokladnoscTriangulacjiLabel";
            this.dokladnoscTriangulacjiLabel.Size = new System.Drawing.Size(28, 21);
            this.dokladnoscTriangulacjiLabel.TabIndex = 1;
            this.dokladnoscTriangulacjiLabel.Text = "15";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dokładność triangulacji";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ksTrackBar);
            this.groupBox2.Controls.Add(this.kdTrackBar);
            this.groupBox2.Controls.Add(this.ksLabel);
            this.groupBox2.Controls.Add(this.kdLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.mLabel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.mTrackBar);
            this.groupBox2.Location = new System.Drawing.Point(3, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 210);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Współczynniki odbicia";
            // 
            // ksTrackBar
            // 
            this.ksTrackBar.Location = new System.Drawing.Point(46, 152);
            this.ksTrackBar.Maximum = 99;
            this.ksTrackBar.Minimum = 1;
            this.ksTrackBar.Name = "ksTrackBar";
            this.ksTrackBar.Size = new System.Drawing.Size(368, 56);
            this.ksTrackBar.TabIndex = 8;
            this.ksTrackBar.TickFrequency = 10;
            this.ksTrackBar.Value = 75;
            this.ksTrackBar.ValueChanged += new System.EventHandler(this.ksTrackBar_ValueChanged);
            // 
            // kdTrackBar
            // 
            this.kdTrackBar.Location = new System.Drawing.Point(46, 90);
            this.kdTrackBar.Maximum = 99;
            this.kdTrackBar.Minimum = 1;
            this.kdTrackBar.Name = "kdTrackBar";
            this.kdTrackBar.Size = new System.Drawing.Size(368, 56);
            this.kdTrackBar.TabIndex = 7;
            this.kdTrackBar.TickFrequency = 10;
            this.kdTrackBar.Value = 75;
            this.kdTrackBar.ValueChanged += new System.EventHandler(this.kdTrackBar_ValueChanged);
            // 
            // ksLabel
            // 
            this.ksLabel.AutoSize = true;
            this.ksLabel.Location = new System.Drawing.Point(420, 150);
            this.ksLabel.Name = "ksLabel";
            this.ksLabel.Size = new System.Drawing.Size(40, 21);
            this.ksLabel.TabIndex = 6;
            this.ksLabel.Text = "0,25";
            // 
            // kdLabel
            // 
            this.kdLabel.AutoSize = true;
            this.kdLabel.Location = new System.Drawing.Point(420, 90);
            this.kdLabel.Name = "kdLabel";
            this.kdLabel.Size = new System.Drawing.Size(40, 21);
            this.kdLabel.TabIndex = 5;
            this.kdLabel.Text = "0,25";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "ks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "kd";
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.Location = new System.Drawing.Point(420, 28);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(28, 21);
            this.mLabel.TabIndex = 2;
            this.mLabel.Text = "25";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "m";
            // 
            // mTrackBar
            // 
            this.mTrackBar.Location = new System.Drawing.Point(46, 28);
            this.mTrackBar.Maximum = 100;
            this.mTrackBar.Minimum = 1;
            this.mTrackBar.Name = "mTrackBar";
            this.mTrackBar.Size = new System.Drawing.Size(368, 56);
            this.mTrackBar.TabIndex = 0;
            this.mTrackBar.TickFrequency = 10;
            this.mTrackBar.Value = 50;
            this.mTrackBar.ValueChanged += new System.EventHandler(this.mTrackBar_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.wybierzTekstureButton);
            this.groupBox3.Controls.Add(this.wybierzKolorButton);
            this.groupBox3.Controls.Add(this.wypelnijTeksturaRadioButton);
            this.groupBox3.Controls.Add(this.wypelnijKoloremRadioButton);
            this.groupBox3.Location = new System.Drawing.Point(3, 362);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(466, 112);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tekstura";
            // 
            // wybierzTekstureButton
            // 
            this.wybierzTekstureButton.Enabled = false;
            this.wybierzTekstureButton.Location = new System.Drawing.Point(295, 74);
            this.wybierzTekstureButton.Name = "wybierzTekstureButton";
            this.wybierzTekstureButton.Size = new System.Drawing.Size(159, 29);
            this.wybierzTekstureButton.TabIndex = 3;
            this.wybierzTekstureButton.Text = "Wybierz teksturę";
            this.wybierzTekstureButton.UseVisualStyleBackColor = true;
            this.wybierzTekstureButton.Click += new System.EventHandler(this.wybierzTekstureButton_Click);
            // 
            // wybierzKolorButton
            // 
            this.wybierzKolorButton.Location = new System.Drawing.Point(295, 26);
            this.wybierzKolorButton.Name = "wybierzKolorButton";
            this.wybierzKolorButton.Size = new System.Drawing.Size(159, 29);
            this.wybierzKolorButton.TabIndex = 2;
            this.wybierzKolorButton.Text = "Wybierz kolor";
            this.wybierzKolorButton.UseVisualStyleBackColor = true;
            this.wybierzKolorButton.Click += new System.EventHandler(this.wybierzKolorButton_Click);
            // 
            // wypelnijTeksturaRadioButton
            // 
            this.wypelnijTeksturaRadioButton.AutoSize = true;
            this.wypelnijTeksturaRadioButton.Location = new System.Drawing.Point(16, 76);
            this.wypelnijTeksturaRadioButton.Name = "wypelnijTeksturaRadioButton";
            this.wypelnijTeksturaRadioButton.Size = new System.Drawing.Size(149, 25);
            this.wypelnijTeksturaRadioButton.TabIndex = 1;
            this.wypelnijTeksturaRadioButton.Text = "wypełnij teksturą";
            this.wypelnijTeksturaRadioButton.UseVisualStyleBackColor = true;
            this.wypelnijTeksturaRadioButton.CheckedChanged += new System.EventHandler(this.wypelnijTeksturaRadioButton_CheckedChanged);
            // 
            // wypelnijKoloremRadioButton
            // 
            this.wypelnijKoloremRadioButton.AutoSize = true;
            this.wypelnijKoloremRadioButton.Checked = true;
            this.wypelnijKoloremRadioButton.Location = new System.Drawing.Point(17, 28);
            this.wypelnijKoloremRadioButton.Name = "wypelnijKoloremRadioButton";
            this.wypelnijKoloremRadioButton.Size = new System.Drawing.Size(151, 25);
            this.wypelnijKoloremRadioButton.TabIndex = 0;
            this.wypelnijKoloremRadioButton.TabStop = true;
            this.wypelnijKoloremRadioButton.Text = "wypełnij kolorem";
            this.wypelnijKoloremRadioButton.UseVisualStyleBackColor = true;
            this.wypelnijKoloremRadioButton.CheckedChanged += new System.EventHandler(this.wypelnijKoloremRadioButton_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.kolorInterpolacjaRadioButton);
            this.groupBox5.Controls.Add(this.kolorDokladnyRadioButton);
            this.groupBox5.Location = new System.Drawing.Point(3, 626);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(466, 108);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Kolor wypełnienia";
            // 
            // kolorInterpolacjaRadioButton
            // 
            this.kolorInterpolacjaRadioButton.AutoSize = true;
            this.kolorInterpolacjaRadioButton.Location = new System.Drawing.Point(17, 71);
            this.kolorInterpolacjaRadioButton.Name = "kolorInterpolacjaRadioButton";
            this.kolorInterpolacjaRadioButton.Size = new System.Drawing.Size(98, 25);
            this.kolorInterpolacjaRadioButton.TabIndex = 1;
            this.kolorInterpolacjaRadioButton.Text = "interpoluj";
            this.kolorInterpolacjaRadioButton.UseVisualStyleBackColor = true;
            this.kolorInterpolacjaRadioButton.CheckedChanged += new System.EventHandler(this.kolorInterpolacjaRadioButton_CheckedChanged);
            // 
            // kolorDokladnyRadioButton
            // 
            this.kolorDokladnyRadioButton.AutoSize = true;
            this.kolorDokladnyRadioButton.Checked = true;
            this.kolorDokladnyRadioButton.Location = new System.Drawing.Point(17, 28);
            this.kolorDokladnyRadioButton.Name = "kolorDokladnyRadioButton";
            this.kolorDokladnyRadioButton.Size = new System.Drawing.Size(161, 25);
            this.kolorDokladnyRadioButton.TabIndex = 0;
            this.kolorDokladnyRadioButton.TabStop = true;
            this.kolorDokladnyRadioButton.Text = "wyznacz dokładnie";
            this.kolorDokladnyRadioButton.UseVisualStyleBackColor = true;
            this.kolorDokladnyRadioButton.CheckedChanged += new System.EventHandler(this.kolorDokladnyRadioButton_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.wybierzKolorSwiatlaButton);
            this.groupBox6.Controls.Add(this.resetButton);
            this.groupBox6.Controls.Add(this.startstopButton);
            this.groupBox6.Controls.Add(this.lightSourceZLabel);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.lightSourceZTrackBar);
            this.groupBox6.Location = new System.Drawing.Point(3, 740);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(466, 154);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Źródło światła";
            // 
            // wybierzKolorSwiatlaButton
            // 
            this.wybierzKolorSwiatlaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wybierzKolorSwiatlaButton.Location = new System.Drawing.Point(6, 80);
            this.wybierzKolorSwiatlaButton.Name = "wybierzKolorSwiatlaButton";
            this.wybierzKolorSwiatlaButton.Size = new System.Drawing.Size(454, 31);
            this.wybierzKolorSwiatlaButton.TabIndex = 5;
            this.wybierzKolorSwiatlaButton.Text = "Wybierz kolor światła";
            this.wybierzKolorSwiatlaButton.UseVisualStyleBackColor = true;
            this.wybierzKolorSwiatlaButton.Click += new System.EventHandler(this.wybierzKolorSwiatlaButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.Location = new System.Drawing.Point(238, 119);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(222, 29);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Zresetuj ruch";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // startstopButton
            // 
            this.startstopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startstopButton.Location = new System.Drawing.Point(6, 119);
            this.startstopButton.Name = "startstopButton";
            this.startstopButton.Size = new System.Drawing.Size(222, 29);
            this.startstopButton.TabIndex = 3;
            this.startstopButton.Text = "Rozpocznij ruch";
            this.startstopButton.UseVisualStyleBackColor = true;
            this.startstopButton.Click += new System.EventHandler(this.startstopButton_Click);
            // 
            // lightSourceZLabel
            // 
            this.lightSourceZLabel.AutoSize = true;
            this.lightSourceZLabel.Location = new System.Drawing.Point(414, 33);
            this.lightSourceZLabel.Name = "lightSourceZLabel";
            this.lightSourceZLabel.Size = new System.Drawing.Size(46, 21);
            this.lightSourceZLabel.TabIndex = 2;
            this.lightSourceZLabel.Text = "1500";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "z";
            // 
            // lightSourceZTrackBar
            // 
            this.lightSourceZTrackBar.LargeChange = 500;
            this.lightSourceZTrackBar.Location = new System.Drawing.Point(46, 33);
            this.lightSourceZTrackBar.Maximum = 3000;
            this.lightSourceZTrackBar.Minimum = 1000;
            this.lightSourceZTrackBar.Name = "lightSourceZTrackBar";
            this.lightSourceZTrackBar.Size = new System.Drawing.Size(368, 56);
            this.lightSourceZTrackBar.SmallChange = 100;
            this.lightSourceZTrackBar.TabIndex = 0;
            this.lightSourceZTrackBar.TickFrequency = 200;
            this.lightSourceZTrackBar.Value = 2000;
            this.lightSourceZTrackBar.ValueChanged += new System.EventHandler(this.lightSourceZTrackBar_ValueChanged);
            // 
            // timer
            // 
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 903);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(1403, 950);
            this.MinimumSize = new System.Drawing.Size(1403, 950);
            this.Name = "Form1";
            this.Text = "Triangulacja półkuli";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.canva_Paint);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canva)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kTrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dokladnoscTriangulacjiTrackBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ksTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTrackBar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lightSourceZTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar dokladnoscTriangulacjiTrackBar;
        private System.Windows.Forms.Label dokladnoscTriangulacjiLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox pokazLinieCheck;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar mTrackBar;
        private System.Windows.Forms.Label ksLabel;
        private System.Windows.Forms.Label kdLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar ksTrackBar;
        private System.Windows.Forms.TrackBar kdTrackBar;
        private System.Windows.Forms.PictureBox canva;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button wybierzTekstureButton;
        private System.Windows.Forms.Button wybierzKolorButton;
        private System.Windows.Forms.RadioButton wypelnijTeksturaRadioButton;
        private System.Windows.Forms.RadioButton wypelnijKoloremRadioButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button wybierzMapeButton;
        private System.Windows.Forms.CheckBox wektoryNormalneCheckBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton kolorInterpolacjaRadioButton;
        private System.Windows.Forms.RadioButton kolorDokladnyRadioButton;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lightSourceZLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar lightSourceZTrackBar;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button startstopButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button wybierzKolorSwiatlaButton;
        private System.Windows.Forms.TrackBar kTrackBar;
        private System.Windows.Forms.Label kLabel;
        private System.Windows.Forms.Label label6;
    }
}

