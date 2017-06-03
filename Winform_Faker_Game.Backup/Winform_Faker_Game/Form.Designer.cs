namespace Winform_Faker_Game
{
    partial class Form
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.dubbleBufferedPanel1 = new Winform_Faker_Game.DubbleBufferedPanel();
            this.EnemyBox2 = new System.Windows.Forms.PictureBox();
            this.EnemyBox1 = new System.Windows.Forms.PictureBox();
            this.mainchareBox = new System.Windows.Forms.PictureBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.EnemyBox3 = new System.Windows.Forms.PictureBox();
            this.EnemyBox4 = new System.Windows.Forms.PictureBox();
            this.EnemyBox5 = new System.Windows.Forms.PictureBox();
            this.EnemyBox6 = new System.Windows.Forms.PictureBox();
            this.EnemyBox7 = new System.Windows.Forms.PictureBox();
            this.EnemyBox8 = new System.Windows.Forms.PictureBox();
            this.dubbleBufferedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainchareBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // dubbleBufferedPanel1
            // 
            this.dubbleBufferedPanel1.Controls.Add(this.EnemyBox8);
            this.dubbleBufferedPanel1.Controls.Add(this.EnemyBox7);
            this.dubbleBufferedPanel1.Controls.Add(this.EnemyBox6);
            this.dubbleBufferedPanel1.Controls.Add(this.EnemyBox5);
            this.dubbleBufferedPanel1.Controls.Add(this.EnemyBox4);
            this.dubbleBufferedPanel1.Controls.Add(this.EnemyBox3);
            this.dubbleBufferedPanel1.Controls.Add(this.EnemyBox2);
            this.dubbleBufferedPanel1.Controls.Add(this.EnemyBox1);
            this.dubbleBufferedPanel1.Controls.Add(this.mainchareBox);
            this.dubbleBufferedPanel1.Location = new System.Drawing.Point(1, 1);
            this.dubbleBufferedPanel1.Name = "dubbleBufferedPanel1";
            this.dubbleBufferedPanel1.Size = new System.Drawing.Size(580, 557);
            this.dubbleBufferedPanel1.TabIndex = 2;
            this.dubbleBufferedPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.dubbleBufferedPanel1_Paint);
            // 
            // EnemyBox2
            // 
            this.EnemyBox2.BackColor = System.Drawing.Color.Transparent;
            this.EnemyBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EnemyBox2.Location = new System.Drawing.Point(408, 401);
            this.EnemyBox2.Name = "EnemyBox2";
            this.EnemyBox2.Size = new System.Drawing.Size(30, 35);
            this.EnemyBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyBox2.TabIndex = 6;
            this.EnemyBox2.TabStop = false;
            // 
            // EnemyBox1
            // 
            this.EnemyBox1.BackColor = System.Drawing.Color.Transparent;
            this.EnemyBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EnemyBox1.Location = new System.Drawing.Point(480, 205);
            this.EnemyBox1.Name = "EnemyBox1";
            this.EnemyBox1.Size = new System.Drawing.Size(40, 40);
            this.EnemyBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyBox1.TabIndex = 5;
            this.EnemyBox1.TabStop = false;
            // 
            // mainchareBox
            // 
            this.mainchareBox.BackColor = System.Drawing.Color.Transparent;
            this.mainchareBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainchareBox.Image = global::Winform_Faker_Game.Properties.Resources.main_char;
            this.mainchareBox.Location = new System.Drawing.Point(270, 244);
            this.mainchareBox.Name = "mainchareBox";
            this.mainchareBox.Size = new System.Drawing.Size(20, 33);
            this.mainchareBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainchareBox.TabIndex = 3;
            this.mainchareBox.TabStop = false;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "zero.png");
            this.imageList.Images.SetKeyName(1, "Nau.png");
            this.imageList.Images.SetKeyName(2, "BardL.png");
            this.imageList.Images.SetKeyName(3, "CalR.png");
            this.imageList.Images.SetKeyName(4, "GarenR.png");
            this.imageList.Images.SetKeyName(5, "UdryR.png");
            this.imageList.Images.SetKeyName(6, "NauR.png");
            this.imageList.Images.SetKeyName(7, "GarenL.png");
            this.imageList.Images.SetKeyName(8, "UdryL.png");
            this.imageList.Images.SetKeyName(9, "BardR.png");
            this.imageList.Images.SetKeyName(10, "CalL.png");
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // EnemyBox3
            // 
            this.EnemyBox3.BackColor = System.Drawing.Color.Transparent;
            this.EnemyBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EnemyBox3.Location = new System.Drawing.Point(176, 438);
            this.EnemyBox3.Name = "EnemyBox3";
            this.EnemyBox3.Size = new System.Drawing.Size(30, 40);
            this.EnemyBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyBox3.TabIndex = 7;
            this.EnemyBox3.TabStop = false;
            // 
            // EnemyBox4
            // 
            this.EnemyBox4.BackColor = System.Drawing.Color.Transparent;
            this.EnemyBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EnemyBox4.Location = new System.Drawing.Point(106, 344);
            this.EnemyBox4.Name = "EnemyBox4";
            this.EnemyBox4.Size = new System.Drawing.Size(30, 30);
            this.EnemyBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyBox4.TabIndex = 8;
            this.EnemyBox4.TabStop = false;
            // 
            // EnemyBox5
            // 
            this.EnemyBox5.BackColor = System.Drawing.Color.Transparent;
            this.EnemyBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EnemyBox5.Location = new System.Drawing.Point(83, 215);
            this.EnemyBox5.Name = "EnemyBox5";
            this.EnemyBox5.Size = new System.Drawing.Size(35, 35);
            this.EnemyBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyBox5.TabIndex = 9;
            this.EnemyBox5.TabStop = false;
            // 
            // EnemyBox6
            // 
            this.EnemyBox6.BackColor = System.Drawing.Color.Transparent;
            this.EnemyBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EnemyBox6.Location = new System.Drawing.Point(121, 100);
            this.EnemyBox6.Name = "EnemyBox6";
            this.EnemyBox6.Size = new System.Drawing.Size(40, 40);
            this.EnemyBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyBox6.TabIndex = 10;
            this.EnemyBox6.TabStop = false;
            // 
            // EnemyBox7
            // 
            this.EnemyBox7.BackColor = System.Drawing.Color.Transparent;
            this.EnemyBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EnemyBox7.Location = new System.Drawing.Point(260, 77);
            this.EnemyBox7.Name = "EnemyBox7";
            this.EnemyBox7.Size = new System.Drawing.Size(30, 30);
            this.EnemyBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyBox7.TabIndex = 11;
            this.EnemyBox7.TabStop = false;
            // 
            // EnemyBox8
            // 
            this.EnemyBox8.BackColor = System.Drawing.Color.Transparent;
            this.EnemyBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EnemyBox8.Location = new System.Drawing.Point(403, 115);
            this.EnemyBox8.Name = "EnemyBox8";
            this.EnemyBox8.Size = new System.Drawing.Size(35, 35);
            this.EnemyBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyBox8.TabIndex = 12;
            this.EnemyBox8.TabStop = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 557);
            this.Controls.Add(this.dubbleBufferedPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form";
            this.Text = "Faker Game";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form_PreviewKeyDown);
            this.dubbleBufferedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainchareBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DubbleBufferedPanel dubbleBufferedPanel1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.PictureBox mainchareBox;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox EnemyBox1;
        private System.Windows.Forms.PictureBox EnemyBox2;
        private System.Windows.Forms.PictureBox EnemyBox8;
        private System.Windows.Forms.PictureBox EnemyBox7;
        private System.Windows.Forms.PictureBox EnemyBox6;
        private System.Windows.Forms.PictureBox EnemyBox5;
        private System.Windows.Forms.PictureBox EnemyBox4;
        private System.Windows.Forms.PictureBox EnemyBox3;
    }
}

