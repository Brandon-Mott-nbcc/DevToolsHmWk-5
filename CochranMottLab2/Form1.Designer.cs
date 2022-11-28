namespace CochranMottLab2
{
    partial class Lab2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab2));
            this.Multiplier = new System.Windows.Forms.GroupBox();
            this.lblAnswerBox = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtBoxMulti = new System.Windows.Forms.TextBox();
            this.lblMulti = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtBoxNum = new System.Windows.Forms.TextBox();
            this.Information = new System.Windows.Forms.GroupBox();
            this.txtHobby = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.btnPicture = new System.Windows.Forms.Button();
            this.lblModel = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.Multiplier.SuspendLayout();
            this.Information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Multiplier
            // 
            this.Multiplier.Controls.Add(this.lblAnswerBox);
            this.Multiplier.Controls.Add(this.btnReset);
            this.Multiplier.Controls.Add(this.btnCalculate);
            this.Multiplier.Controls.Add(this.lblAnswer);
            this.Multiplier.Controls.Add(this.txtBoxMulti);
            this.Multiplier.Controls.Add(this.lblMulti);
            this.Multiplier.Controls.Add(this.lblNumber);
            this.Multiplier.Controls.Add(this.txtBoxNum);
            this.Multiplier.Location = new System.Drawing.Point(12, 12);
            this.Multiplier.Name = "Multiplier";
            this.Multiplier.Size = new System.Drawing.Size(260, 283);
            this.Multiplier.TabIndex = 0;
            this.Multiplier.TabStop = false;
            this.Multiplier.Text = "Multiplier";
            // 
            // lblAnswerBox
            // 
            this.lblAnswerBox.Location = new System.Drawing.Point(100, 160);
            this.lblAnswerBox.Name = "lblAnswerBox";
            this.lblAnswerBox.Size = new System.Drawing.Size(150, 30);
            this.lblAnswerBox.TabIndex = 8;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(140, 220);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 50);
            this.btnReset.TabIndex = 7;
            this.btnReset.Tag = "";
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(10, 220);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 50);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Tag = "";
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.Location = new System.Drawing.Point(10, 160);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(90, 40);
            this.lblAnswer.TabIndex = 4;
            this.lblAnswer.Text = "42";
            // 
            // txtBoxMulti
            // 
            this.txtBoxMulti.Location = new System.Drawing.Point(100, 100);
            this.txtBoxMulti.Name = "txtBoxMulti";
            this.txtBoxMulti.Size = new System.Drawing.Size(150, 30);
            this.txtBoxMulti.TabIndex = 3;
            // 
            // lblMulti
            // 
            this.lblMulti.Location = new System.Drawing.Point(10, 100);
            this.lblMulti.Name = "lblMulti";
            this.lblMulti.Size = new System.Drawing.Size(90, 40);
            this.lblMulti.TabIndex = 2;
            this.lblMulti.Text = "Multiplier:";
            // 
            // lblNumber
            // 
            this.lblNumber.Location = new System.Drawing.Point(10, 40);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(90, 40);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Number:";
            // 
            // txtBoxNum
            // 
            this.txtBoxNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxNum.Location = new System.Drawing.Point(100, 40);
            this.txtBoxNum.Name = "txtBoxNum";
            this.txtBoxNum.Size = new System.Drawing.Size(150, 30);
            this.txtBoxNum.TabIndex = 0;
            // 
            // Information
            // 
            this.Information.Controls.Add(this.txtHobby);
            this.Information.Controls.Add(this.btnExit);
            this.Information.Controls.Add(this.btnHide);
            this.Information.Controls.Add(this.btnData);
            this.Information.Controls.Add(this.btnPicture);
            this.Information.Controls.Add(this.lblModel);
            this.Information.Controls.Add(this.picBox);
            this.Information.Location = new System.Drawing.Point(278, 12);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(420, 283);
            this.Information.TabIndex = 1;
            this.Information.TabStop = false;
            this.Information.Text = "Information";
            // 
            // txtHobby
            // 
            this.txtHobby.Location = new System.Drawing.Point(0, 37);
            this.txtHobby.Name = "txtHobby";
            this.txtHobby.Size = new System.Drawing.Size(400, 180);
            this.txtHobby.TabIndex = 6;
            this.txtHobby.Text = resources.GetString("txtHobby.Text");
            this.txtHobby.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(316, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(220, 225);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(90, 40);
            this.btnHide.TabIndex = 4;
            this.btnHide.Text = "&Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(102, 225);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(90, 40);
            this.btnData.TabIndex = 3;
            this.btnData.Text = "&Data";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnPicture
            // 
            this.btnPicture.Location = new System.Drawing.Point(6, 226);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(90, 40);
            this.btnPicture.TabIndex = 2;
            this.btnPicture.Text = "&Picture";
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(170, 14);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(74, 23);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Models";
            this.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBox
            // 
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(6, 40);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(400, 180);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            this.picBox.Visible = false;
            // 
            // Lab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 314);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.Multiplier);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximumSize = new System.Drawing.Size(735, 370);
            this.MinimumSize = new System.Drawing.Size(735, 370);
            this.Name = "Lab2";
            this.Text = "Lab 2 by Brandon Cochran-Mott";
            this.Multiplier.ResumeLayout(false);
            this.Multiplier.PerformLayout();
            this.Information.ResumeLayout(false);
            this.Information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox Multiplier;
        private Label lblNumber;
        private TextBox txtBoxNum;
        private GroupBox Information;
        private Button btnCalculate;
        private Label lblAnswer;
        private TextBox txtBoxMulti;
        private Label lblMulti;
        private Button btnReset;
        private PictureBox picBox;
        private Label lblModel;
        private Button btnExit;
        private Button btnHide;
        private Button btnData;
        private Button btnPicture;
        private Label txtHobby;
        private Label lblAnswerBox;
    }
}