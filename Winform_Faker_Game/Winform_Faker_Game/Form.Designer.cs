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
            this.dubbleBufferedPanel1 = new Winform_Faker_Game.DubbleBufferedPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dubbleBufferedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dubbleBufferedPanel1
            // 
            this.dubbleBufferedPanel1.Controls.Add(this.pictureBox2);
            this.dubbleBufferedPanel1.Location = new System.Drawing.Point(1, 1);
            this.dubbleBufferedPanel1.Name = "dubbleBufferedPanel1";
            this.dubbleBufferedPanel1.Size = new System.Drawing.Size(581, 557);
            this.dubbleBufferedPanel1.TabIndex = 2;
            this.dubbleBufferedPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.dubbleBufferedPanel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::Winform_Faker_Game.Properties.Resources.main_char;
            this.pictureBox2.Location = new System.Drawing.Point(259, 231);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private DubbleBufferedPanel dubbleBufferedPanel1;
    }
}

