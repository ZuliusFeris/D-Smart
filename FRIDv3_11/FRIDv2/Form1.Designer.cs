
namespace FRIDv2
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
            this.txtIDCard = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbCOM = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbVao = new System.Windows.Forms.Label();
            this.txtTimeVao = new System.Windows.Forms.TextBox();
            this.txtUserVao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbRa = new System.Windows.Forms.Label();
            this.txtTimeRa = new System.Windows.Forms.TextBox();
            this.txtUserRa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCameraOFF = new System.Windows.Forms.Button();
            this.txtAddPerson = new System.Windows.Forms.TextBox();
            this.btnDetect = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnCamera = new System.Windows.Forms.Button();
            this.picDetect = new System.Windows.Forms.PictureBox();
            this.cbbCom = new System.Windows.Forms.ComboBox();
            this.btnKetNoi = new System.Windows.Forms.Button();
            this.btnNgatKN = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picSetting = new System.Windows.Forms.PictureBox();
            this.picHistory = new System.Windows.Forms.PictureBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.picCapture = new System.Windows.Forms.PictureBox();
            this.picAddMember = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDetect)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddMember)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIDCard
            // 
            this.txtIDCard.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIDCard.Location = new System.Drawing.Point(12, 298);
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.Size = new System.Drawing.Size(238, 22);
            this.txtIDCard.TabIndex = 0;
            this.txtIDCard.UseSystemPasswordChar = true;
            this.txtIDCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDCard_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID CARD";
            // 
            // lbCOM
            // 
            this.lbCOM.AutoSize = true;
            this.lbCOM.Location = new System.Drawing.Point(72, 148);
            this.lbCOM.Name = "lbCOM";
            this.lbCOM.Size = new System.Drawing.Size(0, 20);
            this.lbCOM.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.lbVao);
            this.groupBox1.Controls.Add(this.txtTimeVao);
            this.groupBox1.Controls.Add(this.txtUserVao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 226);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vào";
            // 
            // lbVao
            // 
            this.lbVao.AutoSize = true;
            this.lbVao.Location = new System.Drawing.Point(102, 182);
            this.lbVao.Name = "lbVao";
            this.lbVao.Size = new System.Drawing.Size(0, 20);
            this.lbVao.TabIndex = 4;
            // 
            // txtTimeVao
            // 
            this.txtTimeVao.Location = new System.Drawing.Point(23, 145);
            this.txtTimeVao.Name = "txtTimeVao";
            this.txtTimeVao.Size = new System.Drawing.Size(193, 27);
            this.txtTimeVao.TabIndex = 3;
            // 
            // txtUserVao
            // 
            this.txtUserVao.Location = new System.Drawing.Point(23, 75);
            this.txtUserVao.Name = "txtUserVao";
            this.txtUserVao.Size = new System.Drawing.Size(193, 27);
            this.txtUserVao.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "User";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.lbRa);
            this.groupBox2.Controls.Add(this.txtTimeRa);
            this.groupBox2.Controls.Add(this.txtUserRa);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 241);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ra";
            // 
            // lbRa
            // 
            this.lbRa.AutoSize = true;
            this.lbRa.Location = new System.Drawing.Point(102, 204);
            this.lbRa.Name = "lbRa";
            this.lbRa.Size = new System.Drawing.Size(0, 20);
            this.lbRa.TabIndex = 4;
            // 
            // txtTimeRa
            // 
            this.txtTimeRa.Location = new System.Drawing.Point(23, 158);
            this.txtTimeRa.Name = "txtTimeRa";
            this.txtTimeRa.Size = new System.Drawing.Size(196, 27);
            this.txtTimeRa.TabIndex = 3;
            // 
            // txtUserRa
            // 
            this.txtUserRa.Location = new System.Drawing.Point(23, 68);
            this.txtUserRa.Name = "txtUserRa";
            this.txtUserRa.Size = new System.Drawing.Size(193, 27);
            this.txtUserRa.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "User";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox3.Controls.Add(this.btnCameraOFF);
            this.groupBox3.Controls.Add(this.txtAddPerson);
            this.groupBox3.Controls.Add(this.btnDetect);
            this.groupBox3.Controls.Add(this.btnAddPerson);
            this.groupBox3.Controls.Add(this.btnCamera);
            this.groupBox3.Controls.Add(this.picDetect);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(711, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 376);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Capture";
            // 
            // btnCameraOFF
            // 
            this.btnCameraOFF.Location = new System.Drawing.Point(130, 26);
            this.btnCameraOFF.Name = "btnCameraOFF";
            this.btnCameraOFF.Size = new System.Drawing.Size(105, 43);
            this.btnCameraOFF.TabIndex = 9;
            this.btnCameraOFF.Text = "OFF";
            this.btnCameraOFF.UseVisualStyleBackColor = true;
            this.btnCameraOFF.Click += new System.EventHandler(this.btnCameraOFF_Click);
            // 
            // txtAddPerson
            // 
            this.txtAddPerson.Location = new System.Drawing.Point(73, 212);
            this.txtAddPerson.Name = "txtAddPerson";
            this.txtAddPerson.Size = new System.Drawing.Size(108, 27);
            this.txtAddPerson.TabIndex = 8;
            // 
            // btnDetect
            // 
            this.btnDetect.Location = new System.Drawing.Point(73, 302);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(108, 33);
            this.btnDetect.TabIndex = 7;
            this.btnDetect.Text = "Detect";
            this.btnDetect.UseVisualStyleBackColor = true;
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(61, 249);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(131, 38);
            this.btnAddPerson.TabIndex = 6;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_click);
            // 
            // btnCamera
            // 
            this.btnCamera.Location = new System.Drawing.Point(15, 26);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(105, 43);
            this.btnCamera.TabIndex = 5;
            this.btnCamera.Text = "ON";
            this.btnCamera.UseVisualStyleBackColor = true;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // picDetect
            // 
            this.picDetect.Location = new System.Drawing.Point(61, 79);
            this.picDetect.Name = "picDetect";
            this.picDetect.Size = new System.Drawing.Size(131, 127);
            this.picDetect.TabIndex = 2;
            this.picDetect.TabStop = false;
            // 
            // cbbCom
            // 
            this.cbbCom.FormattingEnabled = true;
            this.cbbCom.Location = new System.Drawing.Point(60, 49);
            this.cbbCom.Name = "cbbCom";
            this.cbbCom.Size = new System.Drawing.Size(121, 28);
            this.cbbCom.TabIndex = 9;
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.Location = new System.Drawing.Point(0, 89);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(105, 44);
            this.btnKetNoi.TabIndex = 10;
            this.btnKetNoi.Text = "Kết nối";
            this.btnKetNoi.UseVisualStyleBackColor = true;
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // btnNgatKN
            // 
            this.btnNgatKN.Location = new System.Drawing.Point(111, 89);
            this.btnNgatKN.Name = "btnNgatKN";
            this.btnNgatKN.Size = new System.Drawing.Size(130, 44);
            this.btnNgatKN.TabIndex = 11;
            this.btnNgatKN.Text = "Ngắt kết nối";
            this.btnNgatKN.UseVisualStyleBackColor = true;
            this.btnNgatKN.Click += new System.EventHandler(this.btnNgatKN_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox4.Controls.Add(this.cbbCom);
            this.groupBox4.Controls.Add(this.btnNgatKN);
            this.groupBox4.Controls.Add(this.btnKetNoi);
            this.groupBox4.Controls.Add(this.lbCOM);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(711, 378);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 173);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cổng COM";
            // 
            // picLogo
            // 
            this.picLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picLogo.BackgroundImage = global::FRIDv2.Properties.Resources.DLA;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogo.Location = new System.Drawing.Point(423, 23);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(109, 97);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogo.TabIndex = 11;
            this.picLogo.TabStop = false;
            // 
            // picSetting
            // 
            this.picSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picSetting.BackgroundImage = global::FRIDv2.Properties.Resources.icons8_automatic_50;
            this.picSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSetting.Location = new System.Drawing.Point(244, 596);
            this.picSetting.Name = "picSetting";
            this.picSetting.Size = new System.Drawing.Size(100, 70);
            this.picSetting.TabIndex = 10;
            this.picSetting.TabStop = false;
            this.picSetting.Click += new System.EventHandler(this.picSetting_Click);
            // 
            // picHistory
            // 
            this.picHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picHistory.BackgroundImage = global::FRIDv2.Properties.Resources.icons8_order_history_50;
            this.picHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHistory.Location = new System.Drawing.Point(128, 595);
            this.picHistory.Name = "picHistory";
            this.picHistory.Size = new System.Drawing.Size(100, 71);
            this.picHistory.TabIndex = 9;
            this.picHistory.TabStop = false;
            this.picHistory.Click += new System.EventHandler(this.picHistory_Click);
            // 
            // picHome
            // 
            this.picHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picHome.BackgroundImage = global::FRIDv2.Properties.Resources.icons8_home_page_50;
            this.picHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHome.Location = new System.Drawing.Point(12, 595);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(100, 70);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHome.TabIndex = 8;
            this.picHome.TabStop = false;
            // 
            // picCapture
            // 
            this.picCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCapture.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.picCapture.Location = new System.Drawing.Point(256, 168);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(449, 418);
            this.picCapture.TabIndex = 1;
            this.picCapture.TabStop = false;
            // 
            // picAddMember
            // 
            this.picAddMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picAddMember.Image = global::FRIDv2.Properties.Resources.icons8_add_50;
            this.picAddMember.Location = new System.Drawing.Point(359, 596);
            this.picAddMember.Name = "picAddMember";
            this.picAddMember.Size = new System.Drawing.Size(95, 70);
            this.picAddMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAddMember.TabIndex = 15;
            this.picAddMember.TabStop = false;
            this.picAddMember.Click += new System.EventHandler(this.picAddMember_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::FRIDv2.Properties.Resources.backg;
            this.ClientSize = new System.Drawing.Size(972, 685);
            this.Controls.Add(this.picAddMember);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.picSetting);
            this.Controls.Add(this.picHistory);
            this.Controls.Add(this.picHome);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picCapture);
            this.Controls.Add(this.txtIDCard);
            this.Name = "Form1";
            this.Text = "Khóa Cửa Thông Minh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDetect)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDCard;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.PictureBox picCapture;
        private System.Windows.Forms.PictureBox picDetect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCOM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimeVao;
        private System.Windows.Forms.TextBox txtUserVao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTimeRa;
        private System.Windows.Forms.TextBox txtUserRa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAddPerson;
        private System.Windows.Forms.Button btnDetect;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnCamera;
        private System.Windows.Forms.ComboBox cbbCom;
        private System.Windows.Forms.Button btnKetNoi;
        private System.Windows.Forms.Button btnNgatKN;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.PictureBox picHistory;
        private System.Windows.Forms.PictureBox picSetting;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbVao;
        private System.Windows.Forms.Label lbRa;
        private System.Windows.Forms.PictureBox picAddMember;
        private System.Windows.Forms.Button btnCameraOFF;
    }
}

