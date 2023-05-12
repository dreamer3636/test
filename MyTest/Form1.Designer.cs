namespace MyTest
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtRes = new TextBox();
            label3 = new Label();
            btnStart = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 112);
            label1.Name = "label1";
            label1.Size = new Size(60, 24);
            label1.TabIndex = 0;
            label1.Text = "num1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(413, 112);
            label2.Name = "label2";
            label2.Size = new Size(60, 24);
            label2.TabIndex = 1;
            label2.Text = "num2";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(200, 109);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(150, 30);
            txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(538, 109);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(150, 30);
            txtNum2.TabIndex = 3;
            // 
            // txtRes
            // 
            txtRes.Location = new Point(413, 267);
            txtRes.Name = "txtRes";
            txtRes.Size = new Size(150, 30);
            txtRes.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(159, 270);
            label3.Name = "label3";
            label3.Size = new Size(100, 24);
            label3.TabIndex = 5;
            label3.Text = "相加的结果";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(619, 377);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(112, 34);
            btnStart.TabIndex = 6;
            btnStart.Text = "计算";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(834, 498);
            Controls.Add(btnStart);
            Controls.Add(label3);
            Controls.Add(txtRes);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtRes;
        private Label label3;
        private Button btnStart;
    }
}