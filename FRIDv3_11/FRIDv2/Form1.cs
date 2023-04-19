using System;
using System.Data;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Threading;
using System.Drawing;
using System.IO.Ports;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading.Tasks;

//using Emgu.CV;
//using Emgu.CV.Face;
//using Emgu.CV.Structure;
//using Emgu.CV.CvEnum;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;

namespace FRIDv2
{
    public partial class Form1 : Form
    {
        //private Capture videoCapture = null;
        //private Image<Bgr, Byte> currentFrame = null;
        //Mat frame = new Mat();
        //private bool facesDetectionEnabled = false;
        //CascadeClassifier faceCasacdeClassifier = new CascadeClassifier("haarcascade_frontalface_alt.xml");
        //List<Image<Gray, Byte>> TrainedFaces = new List<Image<Gray, byte>>();
        //List<int> PersonsLabes = new List<int>();

        //private bool isTrained = false;
        //EigenFaceRecognizer recognizer;
        //List<string> PersonsNames = new List<string>();

        DataTable dt = new DataTable();
        user person = new user();
        DateTime nowday = DateTime.Now;
        public int enterCount = 0;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "4HGFTg2AavlUY70DLKbfNjsbvbtFjcSYjKfvsmXl",
            BasePath = "https://door-78c3e-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        public Form1()
        {
            InitializeComponent();
            ss = new SpeechSynthesizer();
            ss.SpeakAsync("Welcome to system door");

        }

        #region khai báo âm thanh      
        private SpeechSynthesizer ss;
        private SpeechRecognitionEngine sre;
        private Choices clist;
        private Grammar gr;
        private bool isSpeechRecognitionEngineRunning;
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            cbbCom.DataSource = SerialPort.GetPortNames();
            cbbCom.Hide();
            btnKetNoi.Hide();
            btnNgatKN.Hide();
            lbCOM.Hide();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            // Ẩn thanh taskbar
            Rectangle screenSize = Screen.PrimaryScreen.Bounds;
            this.Bounds = new Rectangle(0, 0, screenSize.Width, screenSize.Height);

            picSetting_Click(picSetting, EventArgs.Empty);
            Thread.Sleep(3000);
            btnKetNoi_Click(btnKetNoi, EventArgs.Empty);
            //talkingdetect();
        }

        private async void txtIDCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            string luutamid = txtIDCard.Text;
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    if (txtIDCard.Text != null)
                    {
                        txtIDCard.ResetText();
                        txtUserVao.ResetText();
                        txtTimeVao.ResetText();
                        lbVao.Text = "";
                        txtIDCard.ResetText();
                        txtUserRa.ResetText();
                        txtTimeRa.ResetText();
                        lbRa.Text = "";
                        if (CheckInternetConnection())
                        {
                            client = new FireSharp.FirebaseClient(config);
                            FirebaseResponse response = await client.GetAsync(luutamid);

                            if (response.ResultAs<user>() != null)
                            {
                                user person = response.ResultAs<user>();
                                if (person.status == "1")
                                {
                                    serialPort1.Write("{1}");
                                    ss = new SpeechSynthesizer();
                                    ss.SpeakAsync("Opening the door, please wait.");
                                    txtUserVao.Text = person.name;
                                    txtTimeVao.Text = nowday.ToString("dd/MM/yyyy HH:mm");
                                    lbVao.Text = "ĐÃ VÀO";
                                    PushResponse x = await client.PushAsync(luutamid + "/timein", txtTimeVao.Text);
                                    SetResponse p = await client.SetAsync(luutamid + "/status", "0");
                                }
                                else if (person.status == "0")
                                {
                                    serialPort1.Write("{1}");
                                    ss = new SpeechSynthesizer();
                                    ss.SpeakAsync("Opening the door, please wait.");
                                    txtUserRa.Text = person.name;
                                    txtTimeRa.Text = nowday.ToString("dd/MM/yyyy HH:mm");
                                    lbRa.Text = "ĐÃ RA";
                                    PushResponse x = await client.PushAsync(luutamid + "/timeout", txtTimeRa.Text);
                                    SetResponse p = await client.SetAsync(luutamid + "/status", "1");
                                }
                                else
                                {
                                    txtIDCard.ResetText();
                                }
                                luutamid = "";
                            }
                        }
                        else
                        {
                            offline(luutamid);
                        }
                    }
                }
                catch
                {

                }

                Thread.Sleep(5000);
                serialPort1.Write("{0}");
            }
        }

        #region check connect internet
        public static bool CheckInternetConnection()
        {
            try
            {
                using (var ping = new Ping())
                {
                    var result = ping.Send("8.8.8.8");
                    return (result.Status == IPStatus.Success);
                }
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region code offline
        private void offline(string maoff)
        {
            try
            {
                if (maoff == "0898975387" || maoff == "3305935531" || maoff == "3305360172" || maoff == "3305358913" || maoff == "3305356597" || maoff == "3305350594" || maoff == "3305336533" || maoff == "3305332624")
                {
                    serialPort1.Write("{1}");
                    ss = new SpeechSynthesizer();
                    ss.SpeakAsync("Opening the door, please wait.");
                    txtIDCard.ResetText();
                }
                Thread.Sleep(5000);
                serialPort1.Write("{0}");
            }
            catch { }

        }
        #endregion
        private void picHistory_Click(object sender, EventArgs e)
        {
            frmHistory f = new frmHistory();
            f.Show();
        }

        private void picSetting_Click(object sender, EventArgs e)
        {
            cbbCom.Show();
            btnKetNoi.Show();
            btnNgatKN.Show();
            lbCOM.Show();
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            txtIDCard.Select();
            if (!serialPort1.IsOpen)
            {
                serialPort1.PortName = cbbCom.Text;
                serialPort1.Open();
            }

        }

        private void btnNgatKN_Click(object sender, EventArgs e)
        {
            txtIDCard.Select();
            serialPort1.Close();
        }
        private void picAddMember_Click(object sender, EventArgs e)
        {
            frmMembers f = new frmMembers();
            f.Show();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                lbCOM.Text = ("Chưa kết nối");
                lbCOM.ForeColor = Color.Red;
            }
            else if (serialPort1.IsOpen)
            {
                lbCOM.Text = ("Ðã kết nối");
                lbCOM.ForeColor = Color.Green;
            }
        }
        private bool isConnected = false;

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (!serialPort1.IsOpen && isConnected)
            {
                isConnected = false;

            }
            else if (serialPort1.IsOpen && !isConnected)
            {
                isConnected = true;

            }
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            //picCapture.Visible = true;
            //if (videoCapture != null) videoCapture.Dispose();
            //videoCapture = new Capture();
            //Application.Idle += ProcessFrame;
        }
        private void btnCameraOFF_Click(object sender, EventArgs e)
        {
            //videoCapture.Dispose();
            //picCapture.Visible = false ;
        }

        //private void ProcessFrame(object sender, EventArgs e)
        //{
        //    if (videoCapture != null && videoCapture.Ptr != IntPtr.Zero)
        //    {
        //        videoCapture.Retrieve(frame, 0);
        //        currentFrame = frame.ToImage<Bgr, Byte>().Resize(picCapture.Width, picCapture.Height, Inter.Cubic);

        //        //Step 2: Face Detection

        //        if (facesDetectionEnabled)
        //        {
        //            //Convert from Bgr to Gray Image
        //            Mat grayImage = new Mat();
        //            CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray);
        //            //Enhance the image to get better result
        //            CvInvoke.EqualizeHist(grayImage, grayImage);
        //            Rectangle[] faces = faceCasacdeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);
        //            //If faces detected
        //            if (faces.Length > 0)
        //            {
        //                foreach (var face in faces)
        //                {
        //                    //Draw square around each face 
        //                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2);
        //                }
        //            }

        //        }
        //                //Render the video capture into the Picture Box picCapture
        //                picCapture.Image = currentFrame.Bitmap;
        //    }

        //    //Dispose the Current Frame after processing it to reduce the memory consumption.
        //    if (currentFrame != null)
        //        currentFrame.Dispose();
        //}

        private void btnAddPerson_click(object sender, EventArgs e)
        {
            //btnAddPerson.Enabled = false;
            //EnableSaveImage = true;
        }

        private void btnDetect_Click(object sender, EventArgs e)
        {
            //facesDetectionEnabled = true;
            //TrainImagesFromDir();                                     
        }

        //private bool TrainImagesFromDir()
        //{
        //    int ImagesCount = 0;
        //    double Threshold = 2000;
        //    TrainedFaces.Clear();
        //    PersonsLabes.Clear();
        //    PersonsNames.Clear();
        //    try
        //    {
        //        string path = Directory.GetCurrentDirectory() + @"\TrainedImages";
        //        string[] files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);

        //        foreach (var file in files)
        //        {
        //            Image<Gray, byte> trainedImage = new Image<Gray, byte>(file).Resize(200, 200, Inter.Cubic);
        //            CvInvoke.EqualizeHist(trainedImage, trainedImage);
        //            TrainedFaces.Add(trainedImage);
        //            PersonsLabes.Add(ImagesCount);
        //            string name = file.Split('\\').Last().Split('_')[0];
        //            PersonsNames.Add(name);
        //            ImagesCount++;
        //            Debug.WriteLine(ImagesCount + ". " + name);

        //        }

        //        if (TrainedFaces.Count() > 0)
        //        {
        //            recognizer = new EigenFaceRecognizer(ImagesCount, Threshold);
        //            recognizer.Train(TrainedFaces.ToArray(), PersonsLabes.ToArray());

        //            isTrained = true;

        //            return true;
        //        }
        //        else
        //        {
        //            isTrained = false;
        //            return false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        isTrained = false;
        //        MessageBox.Show("Error in Train Images: " + ex.Message);
        //        return false;
        //    }
        //}


        #region code nhan dien am thanh
        private void talkingdetect()
        {
            try
            {
                DateTime today = DateTime.Today;
                DayOfWeek dayOfWeek = today.DayOfWeek;

                ss = new SpeechSynthesizer();
                sre = new SpeechRecognitionEngine();

                clist = new Choices();
                clist.Add(new string[] { "can you open door", "hello" });
                gr = new Grammar(new GrammarBuilder(clist));

                // Thêm sự kiện SpeechRecognized vào SpeechRecognitionEngine
                sre.SpeechRecognized += sre_SpeechRecognized;

                // Bắt đầu nhận dạng giọng nói
                sre.LoadGrammar(gr);
                sre.SetInputToDefaultAudioDevice();
                sre.RecognizeAsync(RecognizeMode.Multiple);

                isSpeechRecognitionEngineRunning = true;
            }
            catch { }

        }

        private void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string recognizedText = e.Result.Text.ToLower();
            try
            {
                // Kiểm tra nếu người dùng nói lệnh "open the door"
                if (recognizedText == "can you open door?")
                {
                    // Yêu cầu máy mở cửa
                    ss.SpeakAsync("Opening the door, please wait.");
                    // Thực hiện hành động mở cửa ở đây
                    //serialPort1.Write("{1}");
                }
                else if (recognizedText == "hello")
                {
                    ss.SpeakAsync("hello");
                }
                else
                {
                    ss.SpeakAsync("Sorry");
                }
            }
            catch { }

            Thread.Sleep(5000);
            //serialPort1.Write("{0}");
        }
        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isSpeechRecognitionEngineRunning)
            {
                sre.RecognizeAsyncStop();
                isSpeechRecognitionEngineRunning = false;
            }
        }
    }
}
