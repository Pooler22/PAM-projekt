namespace FaceRecognition
{
	partial class Form1
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
			this.textBoxTimerInfoOutput = new System.Windows.Forms.TextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.interfejs = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.buttonWonsy = new System.Windows.Forms.Button();
			this.buttonPeruka = new System.Windows.Forms.Button();
			this.buttonOkulary = new System.Windows.Forms.Button();
			this.buttonCzapka = new System.Windows.Forms.Button();
			this.buttonBroda = new System.Windows.Forms.Button();
			this.buttonMuszka = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.labelManipulacjaObrazem = new System.Windows.Forms.Label();
			this.tableLayoutPanelColorTrackBars = new System.Windows.Forms.TableLayoutPanel();
			this.trackBarYellowColor = new System.Windows.Forms.TrackBar();
			this.trackBarMagentaColor = new System.Windows.Forms.TrackBar();
			this.trackBarCyjanColor = new System.Windows.Forms.TrackBar();
			this.labelCyjan = new System.Windows.Forms.Label();
			this.labelMagenta = new System.Windows.Forms.Label();
			this.labelYellow = new System.Windows.Forms.Label();
			this.tableLayoutPanelColorButtons = new System.Windows.Forms.TableLayoutPanel();
			this.buttonColor = new System.Windows.Forms.Button();
			this.buttonFlip = new System.Windows.Forms.Button();
			this.buttonBlur = new System.Windows.Forms.Button();
			this.tableLayoutPanelBlurOptions = new System.Windows.Forms.TableLayoutPanel();
			this.labelHoriznotalBlur = new System.Windows.Forms.Label();
			this.labelVerticalBlur = new System.Windows.Forms.Label();
			this.trackBarHorizontalBlur = new System.Windows.Forms.TrackBar();
			this.trackBarVerticalBlur = new System.Windows.Forms.TrackBar();
			this.tableLayoutPanelFlipOptions = new System.Windows.Forms.TableLayoutPanel();
			this.radioButtonVerticalFlip = new System.Windows.Forms.RadioButton();
			this.radioButtonHorizontalFlip = new System.Windows.Forms.RadioButton();
			this.radioButtonNoneFlip = new System.Windows.Forms.RadioButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.interfejs.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.tableLayoutPanelColorTrackBars.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarYellowColor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarMagentaColor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarCyjanColor)).BeginInit();
			this.tableLayoutPanelColorButtons.SuspendLayout();
			this.tableLayoutPanelBlurOptions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarHorizontalBlur)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarVerticalBlur)).BeginInit();
			this.tableLayoutPanelFlipOptions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxTimerInfoOutput
			// 
			this.textBoxTimerInfoOutput.Location = new System.Drawing.Point(3, 393);
			this.textBoxTimerInfoOutput.Name = "textBoxTimerInfoOutput";
			this.textBoxTimerInfoOutput.Size = new System.Drawing.Size(412, 20);
			this.textBoxTimerInfoOutput.TabIndex = 1;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.interfejs, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(707, 422);
			this.tableLayoutPanel1.TabIndex = 6;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.textBoxTimerInfoOutput, 0, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(418, 416);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// interfejs
			// 
			this.interfejs.ColumnCount = 1;
			this.interfejs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.interfejs.Controls.Add(this.label1, 0, 0);
			this.interfejs.Controls.Add(this.tableLayoutPanel5, 0, 2);
			this.interfejs.Controls.Add(this.label2, 0, 1);
			this.interfejs.Controls.Add(this.labelManipulacjaObrazem, 0, 3);
			this.interfejs.Controls.Add(this.tableLayoutPanelColorTrackBars, 0, 5);
			this.interfejs.Controls.Add(this.tableLayoutPanelColorButtons, 0, 4);
			this.interfejs.Controls.Add(this.tableLayoutPanelBlurOptions, 0, 6);
			this.interfejs.Controls.Add(this.tableLayoutPanelFlipOptions, 0, 7);
			this.interfejs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.interfejs.Location = new System.Drawing.Point(427, 3);
			this.interfejs.Name = "interfejs";
			this.interfejs.RowCount = 8;
			this.interfejs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.interfejs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.interfejs.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.interfejs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.interfejs.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.interfejs.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.interfejs.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.interfejs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.interfejs.Size = new System.Drawing.Size(277, 416);
			this.interfejs.TabIndex = 1;
			this.interfejs.Visible = false;
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(271, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "Interfejs";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.ColumnCount = 3;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel5.Controls.Add(this.buttonWonsy, 0, 0);
			this.tableLayoutPanel5.Controls.Add(this.buttonPeruka, 1, 0);
			this.tableLayoutPanel5.Controls.Add(this.buttonOkulary, 2, 0);
			this.tableLayoutPanel5.Controls.Add(this.buttonCzapka, 0, 1);
			this.tableLayoutPanel5.Controls.Add(this.buttonBroda, 1, 1);
			this.tableLayoutPanel5.Controls.Add(this.buttonMuszka, 2, 1);
			this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 43);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 2;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(271, 128);
			this.tableLayoutPanel5.TabIndex = 9;
			// 
			// buttonWonsy
			// 
			this.buttonWonsy.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonWonsy.Location = new System.Drawing.Point(3, 3);
			this.buttonWonsy.Name = "buttonWonsy";
			this.buttonWonsy.Size = new System.Drawing.Size(84, 58);
			this.buttonWonsy.TabIndex = 0;
			this.buttonWonsy.Text = "Wonsy";
			this.buttonWonsy.UseVisualStyleBackColor = true;
			this.buttonWonsy.Click += new System.EventHandler(this.buttonWonsy_Click);
			// 
			// buttonPeruka
			// 
			this.buttonPeruka.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonPeruka.Location = new System.Drawing.Point(93, 3);
			this.buttonPeruka.Name = "buttonPeruka";
			this.buttonPeruka.Size = new System.Drawing.Size(84, 58);
			this.buttonPeruka.TabIndex = 1;
			this.buttonPeruka.Text = "Peruka";
			this.buttonPeruka.UseVisualStyleBackColor = true;
			this.buttonPeruka.Click += new System.EventHandler(this.buttonPeruka_Click);
			// 
			// buttonOkulary
			// 
			this.buttonOkulary.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonOkulary.Location = new System.Drawing.Point(183, 3);
			this.buttonOkulary.Name = "buttonOkulary";
			this.buttonOkulary.Size = new System.Drawing.Size(85, 58);
			this.buttonOkulary.TabIndex = 2;
			this.buttonOkulary.Text = "Okulary";
			this.buttonOkulary.UseVisualStyleBackColor = true;
			this.buttonOkulary.Click += new System.EventHandler(this.buttonOkulary_Click);
			// 
			// buttonCzapka
			// 
			this.buttonCzapka.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonCzapka.Location = new System.Drawing.Point(3, 67);
			this.buttonCzapka.Name = "buttonCzapka";
			this.buttonCzapka.Size = new System.Drawing.Size(84, 58);
			this.buttonCzapka.TabIndex = 3;
			this.buttonCzapka.Text = "Czapka";
			this.buttonCzapka.UseVisualStyleBackColor = true;
			this.buttonCzapka.Click += new System.EventHandler(this.buttonCzapka_Click);
			// 
			// buttonBroda
			// 
			this.buttonBroda.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonBroda.Location = new System.Drawing.Point(93, 67);
			this.buttonBroda.Name = "buttonBroda";
			this.buttonBroda.Size = new System.Drawing.Size(84, 58);
			this.buttonBroda.TabIndex = 4;
			this.buttonBroda.Text = "Broda";
			this.buttonBroda.UseVisualStyleBackColor = true;
			this.buttonBroda.Click += new System.EventHandler(this.buttonBroda_Click);
			// 
			// buttonMuszka
			// 
			this.buttonMuszka.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonMuszka.Location = new System.Drawing.Point(183, 67);
			this.buttonMuszka.Name = "buttonMuszka";
			this.buttonMuszka.Size = new System.Drawing.Size(85, 58);
			this.buttonMuszka.TabIndex = 5;
			this.buttonMuszka.Text = "Muszka";
			this.buttonMuszka.UseVisualStyleBackColor = true;
			this.buttonMuszka.Click += new System.EventHandler(this.buttonMuszka_Click);
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(271, 20);
			this.label2.TabIndex = 10;
			this.label2.Text = "Dodatki:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelManipulacjaObrazem
			// 
			this.labelManipulacjaObrazem.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelManipulacjaObrazem.Location = new System.Drawing.Point(3, 174);
			this.labelManipulacjaObrazem.Name = "labelManipulacjaObrazem";
			this.labelManipulacjaObrazem.Size = new System.Drawing.Size(271, 17);
			this.labelManipulacjaObrazem.TabIndex = 11;
			this.labelManipulacjaObrazem.Text = "Manipulacja obrazem:";
			this.labelManipulacjaObrazem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tableLayoutPanelColorTrackBars
			// 
			this.tableLayoutPanelColorTrackBars.ColumnCount = 3;
			this.tableLayoutPanelColorTrackBars.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelColorTrackBars.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelColorTrackBars.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelColorTrackBars.Controls.Add(this.trackBarYellowColor, 2, 1);
			this.tableLayoutPanelColorTrackBars.Controls.Add(this.trackBarMagentaColor, 1, 1);
			this.tableLayoutPanelColorTrackBars.Controls.Add(this.trackBarCyjanColor, 0, 1);
			this.tableLayoutPanelColorTrackBars.Controls.Add(this.labelCyjan, 0, 0);
			this.tableLayoutPanelColorTrackBars.Controls.Add(this.labelMagenta, 1, 0);
			this.tableLayoutPanelColorTrackBars.Controls.Add(this.labelYellow, 2, 0);
			this.tableLayoutPanelColorTrackBars.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanelColorTrackBars.Location = new System.Drawing.Point(3, 264);
			this.tableLayoutPanelColorTrackBars.Name = "tableLayoutPanelColorTrackBars";
			this.tableLayoutPanelColorTrackBars.RowCount = 2;
			this.tableLayoutPanelColorTrackBars.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelColorTrackBars.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
			this.tableLayoutPanelColorTrackBars.Size = new System.Drawing.Size(271, 61);
			this.tableLayoutPanelColorTrackBars.TabIndex = 12;
			this.tableLayoutPanelColorTrackBars.Visible = false;
			// 
			// trackBarYellowColor
			// 
			this.trackBarYellowColor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.trackBarYellowColor.Location = new System.Drawing.Point(183, 25);
			this.trackBarYellowColor.Maximum = 255;
			this.trackBarYellowColor.Name = "trackBarYellowColor";
			this.trackBarYellowColor.Size = new System.Drawing.Size(85, 33);
			this.trackBarYellowColor.TabIndex = 2;
			this.trackBarYellowColor.Scroll += new System.EventHandler(this.trackBarYellowColor_Scroll);
			// 
			// trackBarMagentaColor
			// 
			this.trackBarMagentaColor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.trackBarMagentaColor.Location = new System.Drawing.Point(93, 25);
			this.trackBarMagentaColor.Maximum = 255;
			this.trackBarMagentaColor.Name = "trackBarMagentaColor";
			this.trackBarMagentaColor.Size = new System.Drawing.Size(84, 33);
			this.trackBarMagentaColor.TabIndex = 1;
			this.trackBarMagentaColor.Scroll += new System.EventHandler(this.trackBarMagentaColor_Scroll);
			// 
			// trackBarCyjanColor
			// 
			this.trackBarCyjanColor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.trackBarCyjanColor.Location = new System.Drawing.Point(3, 25);
			this.trackBarCyjanColor.Maximum = 255;
			this.trackBarCyjanColor.Name = "trackBarCyjanColor";
			this.trackBarCyjanColor.Size = new System.Drawing.Size(84, 33);
			this.trackBarCyjanColor.TabIndex = 0;
			this.trackBarCyjanColor.Scroll += new System.EventHandler(this.trackBarCyjanColor_Scroll);
			// 
			// labelCyjan
			// 
			this.labelCyjan.AutoSize = true;
			this.labelCyjan.Location = new System.Drawing.Point(3, 0);
			this.labelCyjan.Name = "labelCyjan";
			this.labelCyjan.Size = new System.Drawing.Size(33, 13);
			this.labelCyjan.TabIndex = 3;
			this.labelCyjan.Text = "Cyjan";
			// 
			// labelMagenta
			// 
			this.labelMagenta.AutoSize = true;
			this.labelMagenta.Location = new System.Drawing.Point(93, 0);
			this.labelMagenta.Name = "labelMagenta";
			this.labelMagenta.Size = new System.Drawing.Size(52, 13);
			this.labelMagenta.TabIndex = 4;
			this.labelMagenta.Text = "Magenta ";
			// 
			// labelYellow
			// 
			this.labelYellow.AutoSize = true;
			this.labelYellow.Location = new System.Drawing.Point(183, 0);
			this.labelYellow.Name = "labelYellow";
			this.labelYellow.Size = new System.Drawing.Size(41, 13);
			this.labelYellow.TabIndex = 5;
			this.labelYellow.Text = "Yellow ";
			// 
			// tableLayoutPanelColorButtons
			// 
			this.tableLayoutPanelColorButtons.ColumnCount = 3;
			this.tableLayoutPanelColorButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelColorButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelColorButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelColorButtons.Controls.Add(this.buttonColor, 0, 0);
			this.tableLayoutPanelColorButtons.Controls.Add(this.buttonFlip, 1, 0);
			this.tableLayoutPanelColorButtons.Controls.Add(this.buttonBlur, 2, 0);
			this.tableLayoutPanelColorButtons.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanelColorButtons.Location = new System.Drawing.Point(3, 197);
			this.tableLayoutPanelColorButtons.Name = "tableLayoutPanelColorButtons";
			this.tableLayoutPanelColorButtons.RowCount = 1;
			this.tableLayoutPanelColorButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelColorButtons.Size = new System.Drawing.Size(271, 61);
			this.tableLayoutPanelColorButtons.TabIndex = 8;
			// 
			// buttonColor
			// 
			this.buttonColor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonColor.Location = new System.Drawing.Point(3, 3);
			this.buttonColor.Name = "buttonColor";
			this.buttonColor.Size = new System.Drawing.Size(84, 55);
			this.buttonColor.TabIndex = 0;
			this.buttonColor.Text = "Color";
			this.buttonColor.UseVisualStyleBackColor = true;
			this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
			// 
			// buttonFlip
			// 
			this.buttonFlip.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonFlip.Location = new System.Drawing.Point(93, 3);
			this.buttonFlip.Name = "buttonFlip";
			this.buttonFlip.Size = new System.Drawing.Size(84, 55);
			this.buttonFlip.TabIndex = 1;
			this.buttonFlip.Text = "Flip";
			this.buttonFlip.UseVisualStyleBackColor = true;
			this.buttonFlip.Click += new System.EventHandler(this.buttonFlip_Click);
			// 
			// buttonBlur
			// 
			this.buttonBlur.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonBlur.Location = new System.Drawing.Point(183, 3);
			this.buttonBlur.Name = "buttonBlur";
			this.buttonBlur.Size = new System.Drawing.Size(85, 55);
			this.buttonBlur.TabIndex = 2;
			this.buttonBlur.Text = "Blur";
			this.buttonBlur.UseVisualStyleBackColor = true;
			this.buttonBlur.Click += new System.EventHandler(this.buttonBlur_Click);
			// 
			// tableLayoutPanelBlurOptions
			// 
			this.tableLayoutPanelBlurOptions.ColumnCount = 2;
			this.tableLayoutPanelBlurOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelBlurOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelBlurOptions.Controls.Add(this.labelHoriznotalBlur, 0, 0);
			this.tableLayoutPanelBlurOptions.Controls.Add(this.labelVerticalBlur, 1, 0);
			this.tableLayoutPanelBlurOptions.Controls.Add(this.trackBarHorizontalBlur, 0, 1);
			this.tableLayoutPanelBlurOptions.Controls.Add(this.trackBarVerticalBlur, 1, 1);
			this.tableLayoutPanelBlurOptions.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanelBlurOptions.Location = new System.Drawing.Point(3, 331);
			this.tableLayoutPanelBlurOptions.Name = "tableLayoutPanelBlurOptions";
			this.tableLayoutPanelBlurOptions.RowCount = 2;
			this.tableLayoutPanelBlurOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelBlurOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelBlurOptions.Size = new System.Drawing.Size(271, 55);
			this.tableLayoutPanelBlurOptions.TabIndex = 13;
			// 
			// labelHoriznotalBlur
			// 
			this.labelHoriznotalBlur.AutoSize = true;
			this.labelHoriznotalBlur.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelHoriznotalBlur.Location = new System.Drawing.Point(3, 0);
			this.labelHoriznotalBlur.Name = "labelHoriznotalBlur";
			this.labelHoriznotalBlur.Size = new System.Drawing.Size(129, 13);
			this.labelHoriznotalBlur.TabIndex = 0;
			this.labelHoriznotalBlur.Text = "Horizontal Blur";
			// 
			// labelVerticalBlur
			// 
			this.labelVerticalBlur.AutoSize = true;
			this.labelVerticalBlur.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelVerticalBlur.Location = new System.Drawing.Point(138, 0);
			this.labelVerticalBlur.Name = "labelVerticalBlur";
			this.labelVerticalBlur.Size = new System.Drawing.Size(130, 13);
			this.labelVerticalBlur.TabIndex = 1;
			this.labelVerticalBlur.Text = "Vertical Blur";
			// 
			// trackBarHorizontalBlur
			// 
			this.trackBarHorizontalBlur.Dock = System.Windows.Forms.DockStyle.Top;
			this.trackBarHorizontalBlur.Location = new System.Drawing.Point(3, 23);
			this.trackBarHorizontalBlur.Maximum = 80;
			this.trackBarHorizontalBlur.Minimum = 1;
			this.trackBarHorizontalBlur.Name = "trackBarHorizontalBlur";
			this.trackBarHorizontalBlur.Size = new System.Drawing.Size(129, 45);
			this.trackBarHorizontalBlur.TabIndex = 2;
			this.trackBarHorizontalBlur.Value = 1;
			this.trackBarHorizontalBlur.Scroll += new System.EventHandler(this.trackBarHorizontalBlur_Scroll);
			// 
			// trackBarVerticalBlur
			// 
			this.trackBarVerticalBlur.Dock = System.Windows.Forms.DockStyle.Top;
			this.trackBarVerticalBlur.Location = new System.Drawing.Point(138, 23);
			this.trackBarVerticalBlur.Maximum = 80;
			this.trackBarVerticalBlur.Minimum = 1;
			this.trackBarVerticalBlur.Name = "trackBarVerticalBlur";
			this.trackBarVerticalBlur.Size = new System.Drawing.Size(130, 45);
			this.trackBarVerticalBlur.TabIndex = 3;
			this.trackBarVerticalBlur.Value = 1;
			this.trackBarVerticalBlur.Scroll += new System.EventHandler(this.trackBarVerticalBlur_Scroll);
			// 
			// tableLayoutPanelFlipOptions
			// 
			this.tableLayoutPanelFlipOptions.ColumnCount = 3;
			this.tableLayoutPanelFlipOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanelFlipOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanelFlipOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanelFlipOptions.Controls.Add(this.radioButtonVerticalFlip, 0, 0);
			this.tableLayoutPanelFlipOptions.Controls.Add(this.radioButtonHorizontalFlip, 1, 0);
			this.tableLayoutPanelFlipOptions.Controls.Add(this.radioButtonNoneFlip, 2, 0);
			this.tableLayoutPanelFlipOptions.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanelFlipOptions.Location = new System.Drawing.Point(3, 392);
			this.tableLayoutPanelFlipOptions.Name = "tableLayoutPanelFlipOptions";
			this.tableLayoutPanelFlipOptions.RowCount = 1;
			this.tableLayoutPanelFlipOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelFlipOptions.Size = new System.Drawing.Size(271, 21);
			this.tableLayoutPanelFlipOptions.TabIndex = 14;
			// 
			// radioButtonVerticalFlip
			// 
			this.radioButtonVerticalFlip.AutoSize = true;
			this.radioButtonVerticalFlip.Dock = System.Windows.Forms.DockStyle.Top;
			this.radioButtonVerticalFlip.Location = new System.Drawing.Point(3, 3);
			this.radioButtonVerticalFlip.Name = "radioButtonVerticalFlip";
			this.radioButtonVerticalFlip.Size = new System.Drawing.Size(84, 17);
			this.radioButtonVerticalFlip.TabIndex = 7;
			this.radioButtonVerticalFlip.Text = "Vertical Flip";
			this.radioButtonVerticalFlip.UseVisualStyleBackColor = true;
			this.radioButtonVerticalFlip.Click += new System.EventHandler(this.radioButtonVerticalFlip_Click);
			// 
			// radioButtonHorizontalFlip
			// 
			this.radioButtonHorizontalFlip.AutoSize = true;
			this.radioButtonHorizontalFlip.Dock = System.Windows.Forms.DockStyle.Top;
			this.radioButtonHorizontalFlip.Location = new System.Drawing.Point(93, 3);
			this.radioButtonHorizontalFlip.Name = "radioButtonHorizontalFlip";
			this.radioButtonHorizontalFlip.Size = new System.Drawing.Size(84, 17);
			this.radioButtonHorizontalFlip.TabIndex = 3;
			this.radioButtonHorizontalFlip.Text = "Horizontal Flip";
			this.radioButtonHorizontalFlip.UseVisualStyleBackColor = true;
			this.radioButtonHorizontalFlip.Click += new System.EventHandler(this.radioButtonHorizontalFlip_Click);
			// 
			// radioButtonNoneFlip
			// 
			this.radioButtonNoneFlip.AutoSize = true;
			this.radioButtonNoneFlip.Checked = true;
			this.radioButtonNoneFlip.Dock = System.Windows.Forms.DockStyle.Top;
			this.radioButtonNoneFlip.Location = new System.Drawing.Point(183, 3);
			this.radioButtonNoneFlip.Name = "radioButtonNoneFlip";
			this.radioButtonNoneFlip.Size = new System.Drawing.Size(85, 17);
			this.radioButtonNoneFlip.TabIndex = 5;
			this.radioButtonNoneFlip.TabStop = true;
			this.radioButtonNoneFlip.Text = "None";
			this.radioButtonNoneFlip.UseVisualStyleBackColor = true;
			this.radioButtonNoneFlip.Click += new System.EventHandler(this.radioButtonNoneFlip_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(412, 384);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(707, 422);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.interfejs.ResumeLayout(false);
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanelColorTrackBars.ResumeLayout(false);
			this.tableLayoutPanelColorTrackBars.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarYellowColor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarMagentaColor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarCyjanColor)).EndInit();
			this.tableLayoutPanelColorButtons.ResumeLayout(false);
			this.tableLayoutPanelBlurOptions.ResumeLayout(false);
			this.tableLayoutPanelBlurOptions.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarHorizontalBlur)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarVerticalBlur)).EndInit();
			this.tableLayoutPanelFlipOptions.ResumeLayout(false);
			this.tableLayoutPanelFlipOptions.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxTimerInfoOutput;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel interfejs;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelColorButtons;
		private System.Windows.Forms.Button buttonColor;
		private System.Windows.Forms.Button buttonFlip;
		private System.Windows.Forms.Button buttonBlur;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.Button buttonWonsy;
		private System.Windows.Forms.Button buttonPeruka;
		private System.Windows.Forms.Button buttonOkulary;
		private System.Windows.Forms.Button buttonCzapka;
		private System.Windows.Forms.Button buttonBroda;
		private System.Windows.Forms.Button buttonMuszka;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelManipulacjaObrazem;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelColorTrackBars;
		private System.Windows.Forms.TrackBar trackBarCyjanColor;
		private System.Windows.Forms.TrackBar trackBarMagentaColor;
		private System.Windows.Forms.TrackBar trackBarYellowColor;
		private System.Windows.Forms.Label labelCyjan;
		private System.Windows.Forms.Label labelMagenta;
		private System.Windows.Forms.Label labelYellow;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBlurOptions;
		private System.Windows.Forms.Label labelHoriznotalBlur;
		private System.Windows.Forms.Label labelVerticalBlur;
		private System.Windows.Forms.TrackBar trackBarHorizontalBlur;
		private System.Windows.Forms.TrackBar trackBarVerticalBlur;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFlipOptions;
		private System.Windows.Forms.RadioButton radioButtonHorizontalFlip;
		private System.Windows.Forms.RadioButton radioButtonNoneFlip;
		private System.Windows.Forms.RadioButton radioButtonVerticalFlip;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

