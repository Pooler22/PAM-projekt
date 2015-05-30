using System;
using System.Windows.Forms;
using System.Drawing;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Reflection;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.Collections;

namespace FaceRecognition
{
	public partial class Form1 : Form
	{
		private Bgr colorEfect;
		private Bitmap finalFrame;
		private Capture capture;
		private HaarCascade haarCascade;
		private Image<Bgr, byte> nextFrame, masterFrame, temp;
		private Image<Gray, byte> grayframe;
		private List<Bitmap> items;
		private MCvAvgComp[] faces;
		private Bgr rectColour = new Bgr(0, double.MaxValue, 0);

		private int[,] coords;              //wspolrzedne dla wasow
		private int timerCounter;
		private int vBlur;
		private int hBlur;
		private int timeEnableUI;

		private bool colorFlag, flipFlag, blurFlag;
		private bool wonsyFlag, perukaFlag, okularyFlag, brodaFlag, czapkaFlag, muszkaFlag;

		public Form1()
		{
			InitializeComponent();

			reset_Flags();

			colorEfect = new Bgr(0, 0, 0);
			items = new List<Bitmap>();
			coords = new int[10, 2];

			timerCounter = 1;
			timeEnableUI = 11;
			vBlur = 1;
			hBlur = 1;
		}

		void emguCalculation(object sender, EventArgs args)
		{
			faces = null;

			using (nextFrame = capture.QueryFrame())
			{
				if (nextFrame != null)
				{
					// there's only one channel (greyscale), hence the zero index
					//var faces = nextFrame.DetectHaarCascade(haar)[0];
					grayframe = nextFrame.Convert<Gray, byte>();
					faces = grayframe.DetectHaarCascade(
									haarCascade, 1.4, 4,
									HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
									new Size(nextFrame.Width / 8, nextFrame.Height / 8)
									)[0];
					finalFrame = new Bitmap(nextFrame.Width, nextFrame.Height);

					if (faces.Length != 0)
					{
						//faceDetected = true;
						interfejs.Visible = true;
						System.Console.WriteLine("asd");
						timer1.Start();
						timerCounter = timeEnableUI;
					}


					finalFrame = nextFrame.ToBitmap();
					if (muszkaFlag)
					{
						add_Item(-2, 1, -4, 1, 4, 1, 1, 1, PAM_projekt.Properties.Resources.muszka);
					}
					if (brodaFlag)
					{
						add_Item(-8, 1, -4, 1, 16, 1, 2, 1, PAM_projekt.Properties.Resources.broda);
					}
					if (wonsyFlag)
					{
						add_Item(1, 0, -2, 1, 1, 0, 2, 1, PAM_projekt.Properties.Resources.moustache);
					}
					if (perukaFlag)
					{
						add_Item(4, 1, 4, 1, -8, 1, -3, 1, PAM_projekt.Properties.Resources.peruka);
					}
					if (czapkaFlag)
					{
						add_Item(4, 1, 4, 1, -4, 1, -2, 1, PAM_projekt.Properties.Resources.czapka);
					}
					if (okularyFlag)
					{
						add_Item(1, 0, -8, 1, 1, 0, 1, 0, PAM_projekt.Properties.Resources.okulary);
					}

					temp = new Image<Bgr, byte>(finalFrame);
					masterFrame = temp;
					if (colorFlag)
					{
						tableLayoutPanelColorTrackBars.Visible = true;
						masterFrame = temp.Sub(colorEfect);
						temp = masterFrame;
					}
					else
					{
						tableLayoutPanelColorTrackBars.Visible = false;
					}

					if (blurFlag == true)
					{
						tableLayoutPanelBlurOptions.Visible = true;
						masterFrame = temp.SmoothBlur(hBlur, vBlur);
						temp = masterFrame;
					}
					else
					{
						tableLayoutPanelBlurOptions.Visible = false;
					}

					if (flipFlag == true)
					{
						tableLayoutPanelFlipOptions.Visible = true;
						if (radioButtonHorizontalFlip.Checked)
							masterFrame = temp.Flip(FLIP.HORIZONTAL);
						else if (radioButtonVerticalFlip.Checked)
							masterFrame = temp.Flip(FLIP.VERTICAL);
						temp = masterFrame;
					}
					else
					{
						tableLayoutPanelFlipOptions.Visible = false;
					}

					finalFrame = masterFrame.ToBitmap();
					pictureBox1.Image = finalFrame;
				}
			}
		}

		private void reset_Flags()
		{
			colorFlag = false;
			flipFlag = false;
			blurFlag = false;
			wonsyFlag = false;
			perukaFlag = false;
			okularyFlag = false;
			brodaFlag = false;
			czapkaFlag = false;
			muszkaFlag = false;
		}

		private void add_Item(int sizeX, int sizeXFlag, int sizeY, int sizeYFlag,
							  int coordX, int coordXFlag, int coordY, int coordYFlag,
							  Image img)
		{
			int j = 0;

			//finalFrame = nextFrame.ToBitmap();
			foreach (var face in faces)
			{
				//nextFrame.Draw(face.rect, rectColour, 3);
				items.Add(new Bitmap(img, new Size(face.rect.Width + (face.rect.Width / sizeX) * sizeXFlag,
												   face.rect.Height + (face.rect.Height / sizeY) * sizeYFlag)));
				coords[j, 0] = face.rect.X + (face.rect.Width / coordX) * coordXFlag;
				coords[j, 1] = face.rect.Y + (face.rect.Height / coordY) * coordYFlag;
				j++;
			}
			using (Graphics g = Graphics.FromImage(finalFrame))
			{
				//g.DrawImage(nextFrame.ToBitmap(), new Point(0, 0));
				g.DrawImage(finalFrame, new Point(0, 0));
				for (int i = 0; i < items.Count; i++)
				{
					g.DrawImage(items[i], new Point(coords[i, 0], coords[i, 1]));
				}
			}
			items.Clear();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// passing 0 gets zeroth webcam
			capture = new Capture();

			Application.Idle += emguCalculation;

			// Alt + Shift + F10 << do importowania bibliotek
			// adjust path to find your xml

			try
			{	//Łukasz
				haarCascade = new HaarCascade(@"D:\PROGRAMY\EmguCV\emgucv-windows-universal-cuda 2.4.10.1940\bin\haarcascade_frontalface_default.xml");
			}
			catch (Exception) { }
			try
			{	//Pawel
				haarCascade = new HaarCascade(@"C:\Emgu\emgucv-windows-universal-cuda 2.4.10.1940\bin\haarcascade_frontalface_default.xml");
			}
			catch (Exception) {}
			try
			{	//Monika
				haarCascade = new HaarCascade(@"C:\Emgu\emgucv-windows-universal-cuda 2.4.10.1940\bin\haarcascade_frontalface_default.xml");
			}
			catch (Exception) {}
			try
			{	//Rafal
				haarCascade = new HaarCascade("C:\\haarcascade_frontalface_default.xml");
			}
			catch (Exception) { }
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			timerCounter--;
			if (timerCounter == 0)
			{
				textBoxTimerInfoOutput.Text = "Brak mordki";
				interfejs.Visible = false;
				reset_Flags();
				timer1.Stop();
				resetFlipSettings();
				resetColorSettings();
				resetBlurSettings();
			}
			else
			{
				textBoxTimerInfoOutput.Text = "Mordka znaleziona - za " + timerCounter + "s. zgasnie GUI jak ja zakryjesz";
			}
		}

		private void trackBarCyjanColor_Scroll(object sender, EventArgs e)
		{
			colorEfect.Red = trackBarCyjanColor.Value;
		}

		private void trackBarMagentaColor_Scroll(object sender, EventArgs e)
		{
			colorEfect.Green = trackBarMagentaColor.Value;
		}

		private void trackBarYellowColor_Scroll(object sender, EventArgs e)
		{
			colorEfect.Blue = trackBarYellowColor.Value;
		}

		private void trackBarHorizontalBlur_Scroll(object sender, EventArgs e)
		{
			hBlur = trackBarHorizontalBlur.Value;
		}

		private void trackBarVerticalBlur_Scroll(object sender, EventArgs e)
		{
			vBlur = trackBarVerticalBlur.Value;
		}

		private void radioButtonNoneFlip_Click(object sender, EventArgs e)
		{
			radioButtonVerticalFlip.Checked = false;
			radioButtonHorizontalFlip.Checked = false;
			radioButtonNoneFlip.Checked = true;
		}

		private void radioButtonVerticalFlip_Click(object sender, EventArgs e)
		{
			radioButtonVerticalFlip.Checked = true;
			radioButtonHorizontalFlip.Checked = false;
			radioButtonNoneFlip.Checked = false;
		}

		private void radioButtonHorizontalFlip_Click(object sender, EventArgs e)
		{
			radioButtonVerticalFlip.Checked = false;
			radioButtonHorizontalFlip.Checked = true;
			radioButtonNoneFlip.Checked = false;
		}

		private void buttonWonsy_Click(object sender, EventArgs e)
		{
			wonsyFlag = !wonsyFlag;
		}

		private void buttonPeruka_Click(object sender, EventArgs e)
		{
			perukaFlag = !perukaFlag;
		}

		private void buttonOkulary_Click(object sender, EventArgs e)
		{
			okularyFlag = !okularyFlag;
		}

		private void buttonCzapka_Click(object sender, EventArgs e)
		{
			czapkaFlag = !czapkaFlag;
		}

		private void buttonBroda_Click(object sender, EventArgs e)
		{
			brodaFlag = !brodaFlag;
		}

		private void buttonMuszka_Click(object sender, EventArgs e)
		{
			muszkaFlag = !muszkaFlag;
		}

		private void buttonColor_Click(object sender, EventArgs e)
		{
			if (colorFlag == true)
			{
				resetColorSettings();
			}
			colorFlag = !colorFlag;
		}

		private void buttonFlip_Click(object sender, EventArgs e)
		{
			if (flipFlag == true)
			{
				resetFlipSettings();
			}
			flipFlag = !flipFlag;
		}

		private void buttonBlur_Click(object sender, EventArgs e)
		{
			if (blurFlag == true)
			{
				resetBlurSettings();
			}
			blurFlag = !blurFlag;
		}

		private void resetColorSettings()
		{
			colorEfect = new Bgr(0, 0, 0);
			trackBarYellowColor.Value = 0;
			trackBarCyjanColor.Value = 0;
			trackBarMagentaColor.Value = 0;
		}

		private void resetFlipSettings()
		{
			radioButtonHorizontalFlip.Checked = false;
			radioButtonVerticalFlip.Checked = false;
			radioButtonNoneFlip.Checked = true;
		}

		private void resetBlurSettings()
		{
			hBlur = 1;
			vBlur = 1;
			trackBarVerticalBlur.Value = 1;
			trackBarHorizontalBlur.Value = 1;
		}
	}
}