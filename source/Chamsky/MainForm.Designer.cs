namespace Chamsky
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnLoadData = new System.Windows.Forms.Button();
            this.txtFeedBack = new System.Windows.Forms.TextBox();
            this.btnTerming = new System.Windows.Forms.Button();
            this.btnFeaturing = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenText = new System.Windows.Forms.Button();
            this.rdbtnInformationGain = new System.Windows.Forms.RadioButton();
            this.rdbtnChiSquare = new System.Windows.Forms.RadioButton();
            this.btnOpenFeature = new System.Windows.Forms.Button();
            this.btnWeighting = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbtnRocchio = new System.Windows.Forms.RadioButton();
            this.rdbtnSVM = new System.Windows.Forms.RadioButton();
            this.rdbtnKNN = new System.Windows.Forms.RadioButton();
            this.rdbtnNaiveBayes = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rabtnBigram = new System.Windows.Forms.RadioButton();
            this.rdbtnUnigram = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(586, 22);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(79, 23);
            this.btnLoadData.TabIndex = 0;
            this.btnLoadData.Text = "Load/Start";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // txtFeedBack
            // 
            this.txtFeedBack.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeedBack.Location = new System.Drawing.Point(12, 22);
            this.txtFeedBack.Multiline = true;
            this.txtFeedBack.Name = "txtFeedBack";
            this.txtFeedBack.ReadOnly = true;
            this.txtFeedBack.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFeedBack.Size = new System.Drawing.Size(512, 332);
            this.txtFeedBack.TabIndex = 1;
            // 
            // btnTerming
            // 
            this.btnTerming.Location = new System.Drawing.Point(112, 47);
            this.btnTerming.Name = "btnTerming";
            this.btnTerming.Size = new System.Drawing.Size(41, 23);
            this.btnTerming.TabIndex = 2;
            this.btnTerming.Text = "Term";
            this.btnTerming.UseVisualStyleBackColor = true;
            this.btnTerming.Click += new System.EventHandler(this.btnTerming_Click);
            // 
            // btnFeaturing
            // 
            this.btnFeaturing.Location = new System.Drawing.Point(86, 47);
            this.btnFeaturing.Name = "btnFeaturing";
            this.btnFeaturing.Size = new System.Drawing.Size(50, 23);
            this.btnFeaturing.TabIndex = 3;
            this.btnFeaturing.Text = "Select";
            this.btnFeaturing.UseVisualStyleBackColor = true;
            this.btnFeaturing.Click += new System.EventHandler(this.btnFeaturing_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenText);
            this.groupBox1.Controls.Add(this.rdbtnInformationGain);
            this.groupBox1.Controls.Add(this.rdbtnChiSquare);
            this.groupBox1.Controls.Add(this.btnOpenFeature);
            this.groupBox1.Controls.Add(this.btnWeighting);
            this.groupBox1.Controls.Add(this.btnFeaturing);
            this.groupBox1.Location = new System.Drawing.Point(548, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Features";
            // 
            // btnOpenText
            // 
            this.btnOpenText.Location = new System.Drawing.Point(137, 71);
            this.btnOpenText.Name = "btnOpenText";
            this.btnOpenText.Size = new System.Drawing.Size(16, 23);
            this.btnOpenText.TabIndex = 9;
            this.btnOpenText.Text = "#";
            this.btnOpenText.UseVisualStyleBackColor = true;
            this.btnOpenText.Click += new System.EventHandler(this.btnOpenText_Click);
            // 
            // rdbtnInformationGain
            // 
            this.rdbtnInformationGain.AutoSize = true;
            this.rdbtnInformationGain.Location = new System.Drawing.Point(15, 42);
            this.rdbtnInformationGain.Name = "rdbtnInformationGain";
            this.rdbtnInformationGain.Size = new System.Drawing.Size(35, 16);
            this.rdbtnInformationGain.TabIndex = 7;
            this.rdbtnInformationGain.TabStop = true;
            this.rdbtnInformationGain.Text = "IG";
            this.rdbtnInformationGain.UseVisualStyleBackColor = true;
            // 
            // rdbtnChiSquare
            // 
            this.rdbtnChiSquare.AutoSize = true;
            this.rdbtnChiSquare.Location = new System.Drawing.Point(15, 20);
            this.rdbtnChiSquare.Name = "rdbtnChiSquare";
            this.rdbtnChiSquare.Size = new System.Drawing.Size(83, 16);
            this.rdbtnChiSquare.TabIndex = 6;
            this.rdbtnChiSquare.TabStop = true;
            this.rdbtnChiSquare.Text = "chi-suqare";
            this.rdbtnChiSquare.UseVisualStyleBackColor = true;
            // 
            // btnOpenFeature
            // 
            this.btnOpenFeature.Location = new System.Drawing.Point(137, 47);
            this.btnOpenFeature.Name = "btnOpenFeature";
            this.btnOpenFeature.Size = new System.Drawing.Size(16, 23);
            this.btnOpenFeature.TabIndex = 5;
            this.btnOpenFeature.Text = "*";
            this.btnOpenFeature.UseVisualStyleBackColor = true;
            this.btnOpenFeature.Click += new System.EventHandler(this.btnOpenFeature_Click);
            // 
            // btnWeighting
            // 
            this.btnWeighting.Location = new System.Drawing.Point(86, 71);
            this.btnWeighting.Name = "btnWeighting";
            this.btnWeighting.Size = new System.Drawing.Size(50, 23);
            this.btnWeighting.TabIndex = 4;
            this.btnWeighting.Text = "TF-IDF";
            this.btnWeighting.UseVisualStyleBackColor = true;
            this.btnWeighting.Click += new System.EventHandler(this.btnWeighting_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbtnRocchio);
            this.groupBox2.Controls.Add(this.rdbtnSVM);
            this.groupBox2.Controls.Add(this.rdbtnKNN);
            this.groupBox2.Controls.Add(this.rdbtnNaiveBayes);
            this.groupBox2.Location = new System.Drawing.Point(548, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 111);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Classifier";
            // 
            // rdbtnRocchio
            // 
            this.rdbtnRocchio.AutoSize = true;
            this.rdbtnRocchio.Location = new System.Drawing.Point(15, 20);
            this.rdbtnRocchio.Name = "rdbtnRocchio";
            this.rdbtnRocchio.Size = new System.Drawing.Size(65, 16);
            this.rdbtnRocchio.TabIndex = 11;
            this.rdbtnRocchio.TabStop = true;
            this.rdbtnRocchio.Text = "Rocchio";
            this.rdbtnRocchio.UseVisualStyleBackColor = true;
            // 
            // rdbtnSVM
            // 
            this.rdbtnSVM.AutoSize = true;
            this.rdbtnSVM.Location = new System.Drawing.Point(15, 86);
            this.rdbtnSVM.Name = "rdbtnSVM";
            this.rdbtnSVM.Size = new System.Drawing.Size(41, 16);
            this.rdbtnSVM.TabIndex = 10;
            this.rdbtnSVM.TabStop = true;
            this.rdbtnSVM.Text = "SVM";
            this.rdbtnSVM.UseVisualStyleBackColor = true;
            // 
            // rdbtnKNN
            // 
            this.rdbtnKNN.AutoSize = true;
            this.rdbtnKNN.Location = new System.Drawing.Point(15, 64);
            this.rdbtnKNN.Name = "rdbtnKNN";
            this.rdbtnKNN.Size = new System.Drawing.Size(41, 16);
            this.rdbtnKNN.TabIndex = 9;
            this.rdbtnKNN.TabStop = true;
            this.rdbtnKNN.Text = "kNN";
            this.rdbtnKNN.UseVisualStyleBackColor = true;
            // 
            // rdbtnNaiveBayes
            // 
            this.rdbtnNaiveBayes.AutoSize = true;
            this.rdbtnNaiveBayes.Location = new System.Drawing.Point(15, 42);
            this.rdbtnNaiveBayes.Name = "rdbtnNaiveBayes";
            this.rdbtnNaiveBayes.Size = new System.Drawing.Size(89, 16);
            this.rdbtnNaiveBayes.TabIndex = 8;
            this.rdbtnNaiveBayes.TabStop = true;
            this.rdbtnNaiveBayes.Text = "Naïve Bayes";
            this.rdbtnNaiveBayes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chamsky 0.1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rabtnBigram);
            this.groupBox3.Controls.Add(this.rdbtnUnigram);
            this.groupBox3.Controls.Add(this.btnTerming);
            this.groupBox3.Location = new System.Drawing.Point(548, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(159, 80);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Terms";
            // 
            // rabtnBigram
            // 
            this.rabtnBigram.AutoSize = true;
            this.rabtnBigram.Location = new System.Drawing.Point(15, 38);
            this.rabtnBigram.Name = "rabtnBigram";
            this.rabtnBigram.Size = new System.Drawing.Size(71, 16);
            this.rabtnBigram.TabIndex = 8;
            this.rabtnBigram.TabStop = true;
            this.rabtnBigram.Text = "1.5-gram";
            this.rabtnBigram.UseVisualStyleBackColor = true;
            // 
            // rdbtnUnigram
            // 
            this.rdbtnUnigram.AutoSize = true;
            this.rdbtnUnigram.Location = new System.Drawing.Point(15, 20);
            this.rdbtnUnigram.Name = "rdbtnUnigram";
            this.rdbtnUnigram.Size = new System.Drawing.Size(71, 16);
            this.rdbtnUnigram.TabIndex = 7;
            this.rdbtnUnigram.TabStop = true;
            this.rdbtnUnigram.Text = "1.0-gram";
            this.rdbtnUnigram.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(675, 360);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 407);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.txtFeedBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Chamsky";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.TextBox txtFeedBack;
        private System.Windows.Forms.Button btnTerming;
        private System.Windows.Forms.Button btnFeaturing;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnWeighting;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenFeature;
        private System.Windows.Forms.RadioButton rdbtnInformationGain;
        private System.Windows.Forms.RadioButton rdbtnChiSquare;
        private System.Windows.Forms.RadioButton rdbtnKNN;
        private System.Windows.Forms.RadioButton rdbtnNaiveBayes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rabtnBigram;
        private System.Windows.Forms.RadioButton rdbtnUnigram;
        private System.Windows.Forms.RadioButton rdbtnSVM;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rdbtnRocchio;
        private System.Windows.Forms.Button btnOpenText;
    }
}

