namespace SampleDownloadNaverMap
{
    partial class Form1
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
            this.ButtonDownload = new System.Windows.Forms.Button();
            this.LabelLatitude = new System.Windows.Forms.Label();
            this.LabelLongitude = new System.Windows.Forms.Label();
            this.LabelImageWidth = new System.Windows.Forms.Label();
            this.LabelImageHeight = new System.Windows.Forms.Label();
            this.LabelZoomLevel = new System.Windows.Forms.Label();
            this.TextBoxLatitude = new System.Windows.Forms.TextBox();
            this.TextBoxLongitude = new System.Windows.Forms.TextBox();
            this.TextBoxImageWidth = new System.Windows.Forms.TextBox();
            this.TextBoxImageHeight = new System.Windows.Forms.TextBox();
            this.TextBoxZoomLevel = new System.Windows.Forms.TextBox();
            this.TextBoxClientKey = new System.Windows.Forms.TextBox();
            this.TextBoxClientSecret = new System.Windows.Forms.TextBox();
            this.LabelClientKey = new System.Windows.Forms.Label();
            this.LabelClientSecret = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonDownload
            // 
            this.ButtonDownload.Location = new System.Drawing.Point(11, 227);
            this.ButtonDownload.Name = "ButtonDownload";
            this.ButtonDownload.Size = new System.Drawing.Size(253, 38);
            this.ButtonDownload.TabIndex = 0;
            this.ButtonDownload.Text = "Download";
            this.ButtonDownload.UseVisualStyleBackColor = true;
            this.ButtonDownload.Click += new System.EventHandler(this.ButtonDownload_Click);
            // 
            // LabelLatitude
            // 
            this.LabelLatitude.AutoSize = true;
            this.LabelLatitude.Location = new System.Drawing.Point(14, 78);
            this.LabelLatitude.Name = "LabelLatitude";
            this.LabelLatitude.Size = new System.Drawing.Size(49, 12);
            this.LabelLatitude.TabIndex = 1;
            this.LabelLatitude.Text = "Latitude";
            // 
            // LabelLongitude
            // 
            this.LabelLongitude.AutoSize = true;
            this.LabelLongitude.Location = new System.Drawing.Point(14, 108);
            this.LabelLongitude.Name = "LabelLongitude";
            this.LabelLongitude.Size = new System.Drawing.Size(60, 12);
            this.LabelLongitude.TabIndex = 2;
            this.LabelLongitude.Text = "Longitude";
            // 
            // LabelImageWidth
            // 
            this.LabelImageWidth.AutoSize = true;
            this.LabelImageWidth.Location = new System.Drawing.Point(14, 138);
            this.LabelImageWidth.Name = "LabelImageWidth";
            this.LabelImageWidth.Size = new System.Drawing.Size(74, 12);
            this.LabelImageWidth.TabIndex = 3;
            this.LabelImageWidth.Text = "Image Width";
            // 
            // LabelImageHeight
            // 
            this.LabelImageHeight.AutoSize = true;
            this.LabelImageHeight.Location = new System.Drawing.Point(14, 168);
            this.LabelImageHeight.Name = "LabelImageHeight";
            this.LabelImageHeight.Size = new System.Drawing.Size(79, 12);
            this.LabelImageHeight.TabIndex = 4;
            this.LabelImageHeight.Text = "Image Height";
            // 
            // LabelZoomLevel
            // 
            this.LabelZoomLevel.AutoSize = true;
            this.LabelZoomLevel.Location = new System.Drawing.Point(14, 198);
            this.LabelZoomLevel.Name = "LabelZoomLevel";
            this.LabelZoomLevel.Size = new System.Drawing.Size(72, 12);
            this.LabelZoomLevel.TabIndex = 5;
            this.LabelZoomLevel.Text = "Zoom Level";
            // 
            // TextBoxLatitude
            // 
            this.TextBoxLatitude.Location = new System.Drawing.Point(105, 75);
            this.TextBoxLatitude.Name = "TextBoxLatitude";
            this.TextBoxLatitude.Size = new System.Drawing.Size(157, 21);
            this.TextBoxLatitude.TabIndex = 6;
            // 
            // TextBoxLongitude
            // 
            this.TextBoxLongitude.Location = new System.Drawing.Point(105, 105);
            this.TextBoxLongitude.Name = "TextBoxLongitude";
            this.TextBoxLongitude.Size = new System.Drawing.Size(157, 21);
            this.TextBoxLongitude.TabIndex = 7;
            // 
            // TextBoxImageWidth
            // 
            this.TextBoxImageWidth.Location = new System.Drawing.Point(105, 135);
            this.TextBoxImageWidth.Name = "TextBoxImageWidth";
            this.TextBoxImageWidth.Size = new System.Drawing.Size(157, 21);
            this.TextBoxImageWidth.TabIndex = 8;
            // 
            // TextBoxImageHeight
            // 
            this.TextBoxImageHeight.Location = new System.Drawing.Point(105, 165);
            this.TextBoxImageHeight.Name = "TextBoxImageHeight";
            this.TextBoxImageHeight.Size = new System.Drawing.Size(157, 21);
            this.TextBoxImageHeight.TabIndex = 9;
            // 
            // TextBoxZoomLevel
            // 
            this.TextBoxZoomLevel.Location = new System.Drawing.Point(105, 195);
            this.TextBoxZoomLevel.Name = "TextBoxZoomLevel";
            this.TextBoxZoomLevel.Size = new System.Drawing.Size(157, 21);
            this.TextBoxZoomLevel.TabIndex = 10;
            // 
            // TextBoxClientKey
            // 
            this.TextBoxClientKey.Location = new System.Drawing.Point(105, 15);
            this.TextBoxClientKey.Name = "TextBoxClientKey";
            this.TextBoxClientKey.Size = new System.Drawing.Size(157, 21);
            this.TextBoxClientKey.TabIndex = 11;
            // 
            // TextBoxClientSecret
            // 
            this.TextBoxClientSecret.Location = new System.Drawing.Point(105, 45);
            this.TextBoxClientSecret.Name = "TextBoxClientSecret";
            this.TextBoxClientSecret.Size = new System.Drawing.Size(157, 21);
            this.TextBoxClientSecret.TabIndex = 12;
            // 
            // LabelClientKey
            // 
            this.LabelClientKey.AutoSize = true;
            this.LabelClientKey.Location = new System.Drawing.Point(14, 18);
            this.LabelClientKey.Name = "LabelClientKey";
            this.LabelClientKey.Size = new System.Drawing.Size(63, 12);
            this.LabelClientKey.TabIndex = 13;
            this.LabelClientKey.Text = "Client Key";
            // 
            // LabelClientSecret
            // 
            this.LabelClientSecret.AutoSize = true;
            this.LabelClientSecret.Location = new System.Drawing.Point(14, 48);
            this.LabelClientSecret.Name = "LabelClientSecret";
            this.LabelClientSecret.Size = new System.Drawing.Size(77, 12);
            this.LabelClientSecret.TabIndex = 14;
            this.LabelClientSecret.Text = "Client Secret";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 273);
            this.Controls.Add(this.LabelClientSecret);
            this.Controls.Add(this.LabelClientKey);
            this.Controls.Add(this.TextBoxClientSecret);
            this.Controls.Add(this.TextBoxClientKey);
            this.Controls.Add(this.TextBoxZoomLevel);
            this.Controls.Add(this.TextBoxImageHeight);
            this.Controls.Add(this.TextBoxImageWidth);
            this.Controls.Add(this.TextBoxLongitude);
            this.Controls.Add(this.TextBoxLatitude);
            this.Controls.Add(this.LabelZoomLevel);
            this.Controls.Add(this.LabelImageHeight);
            this.Controls.Add(this.LabelImageWidth);
            this.Controls.Add(this.LabelLongitude);
            this.Controls.Add(this.LabelLatitude);
            this.Controls.Add(this.ButtonDownload);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Sample: Download NaverMap";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonDownload;
        private System.Windows.Forms.Label LabelLatitude;
        private System.Windows.Forms.Label LabelLongitude;
        private System.Windows.Forms.Label LabelImageWidth;
        private System.Windows.Forms.Label LabelImageHeight;
        private System.Windows.Forms.Label LabelZoomLevel;
        private System.Windows.Forms.TextBox TextBoxLatitude;
        private System.Windows.Forms.TextBox TextBoxLongitude;
        private System.Windows.Forms.TextBox TextBoxImageWidth;
        private System.Windows.Forms.TextBox TextBoxImageHeight;
        private System.Windows.Forms.TextBox TextBoxZoomLevel;
        private System.Windows.Forms.TextBox TextBoxClientKey;
        private System.Windows.Forms.TextBox TextBoxClientSecret;
        private System.Windows.Forms.Label LabelClientKey;
        private System.Windows.Forms.Label LabelClientSecret;
    }
}

