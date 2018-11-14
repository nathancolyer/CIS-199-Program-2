namespace Program_2
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
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.freshBtn = new System.Windows.Forms.RadioButton();
            this.seniorBtn = new System.Windows.Forms.RadioButton();
            this.juniorBtn = new System.Windows.Forms.RadioButton();
            this.sophBtn = new System.Windows.Forms.RadioButton();
            this.nameLbl = new System.Windows.Forms.Label();
            this.regDateLbl = new System.Windows.Forms.Label();
            this.dateDisplayLbl = new System.Windows.Forms.Label();
            this.goBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(83, 18);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(135, 20);
            this.nameTxtBox.TabIndex = 0;
            // 
            // freshBtn
            // 
            this.freshBtn.AutoSize = true;
            this.freshBtn.Location = new System.Drawing.Point(36, 63);
            this.freshBtn.Name = "freshBtn";
            this.freshBtn.Size = new System.Drawing.Size(71, 17);
            this.freshBtn.TabIndex = 1;
            this.freshBtn.TabStop = true;
            this.freshBtn.Text = "Freshman";
            this.freshBtn.UseVisualStyleBackColor = true;
            // 
            // seniorBtn
            // 
            this.seniorBtn.AutoSize = true;
            this.seniorBtn.Location = new System.Drawing.Point(163, 97);
            this.seniorBtn.Name = "seniorBtn";
            this.seniorBtn.Size = new System.Drawing.Size(55, 17);
            this.seniorBtn.TabIndex = 2;
            this.seniorBtn.TabStop = true;
            this.seniorBtn.Text = "Senior";
            this.seniorBtn.UseVisualStyleBackColor = true;
            // 
            // juniorBtn
            // 
            this.juniorBtn.AutoSize = true;
            this.juniorBtn.Location = new System.Drawing.Point(36, 97);
            this.juniorBtn.Name = "juniorBtn";
            this.juniorBtn.Size = new System.Drawing.Size(53, 17);
            this.juniorBtn.TabIndex = 3;
            this.juniorBtn.TabStop = true;
            this.juniorBtn.Text = "Junior";
            this.juniorBtn.UseVisualStyleBackColor = true;
            // 
            // sophBtn
            // 
            this.sophBtn.AutoSize = true;
            this.sophBtn.Location = new System.Drawing.Point(163, 63);
            this.sophBtn.Name = "sophBtn";
            this.sophBtn.Size = new System.Drawing.Size(79, 17);
            this.sophBtn.TabIndex = 4;
            this.sophBtn.TabStop = true;
            this.sophBtn.Text = "Sophomore";
            this.sophBtn.UseVisualStyleBackColor = true;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(12, 21);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(61, 13);
            this.nameLbl.TabIndex = 5;
            this.nameLbl.Text = "Last Name:";
            // 
            // regDateLbl
            // 
            this.regDateLbl.AutoSize = true;
            this.regDateLbl.Location = new System.Drawing.Point(9, 164);
            this.regDateLbl.Name = "regDateLbl";
            this.regDateLbl.Size = new System.Drawing.Size(92, 13);
            this.regDateLbl.TabIndex = 6;
            this.regDateLbl.Text = "Registration Date:";
            // 
            // dateDisplayLbl
            // 
            this.dateDisplayLbl.AutoSize = true;
            this.dateDisplayLbl.Location = new System.Drawing.Point(107, 164);
            this.dateDisplayLbl.Name = "dateDisplayLbl";
            this.dateDisplayLbl.Size = new System.Drawing.Size(0, 13);
            this.dateDisplayLbl.TabIndex = 7;
            // 
            // goBtn
            // 
            this.goBtn.Location = new System.Drawing.Point(105, 128);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(75, 23);
            this.goBtn.TabIndex = 8;
            this.goBtn.Text = "Go!";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.goBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 201);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.dateDisplayLbl);
            this.Controls.Add(this.regDateLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.sophBtn);
            this.Controls.Add(this.juniorBtn);
            this.Controls.Add(this.seniorBtn);
            this.Controls.Add(this.freshBtn);
            this.Controls.Add(this.nameTxtBox);
            this.Name = "Form1";
            this.Text = "Program2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.RadioButton freshBtn;
        private System.Windows.Forms.RadioButton seniorBtn;
        private System.Windows.Forms.RadioButton juniorBtn;
        private System.Windows.Forms.RadioButton sophBtn;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label regDateLbl;
        private System.Windows.Forms.Label dateDisplayLbl;
        private System.Windows.Forms.Button goBtn;
    }
}

