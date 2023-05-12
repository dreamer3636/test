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
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 93);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "num1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 93);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "num2";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(164, 91);
            txtNum1.Margin = new Padding(2, 2, 2, 2);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(123, 27);
            txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(440, 91);
            txtNum2.Margin = new Padding(2, 2, 2, 2);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(123, 27);
            txtNum2.TabIndex = 3;
            // 
            // txtRes
            // 
            txtRes.Location = new Point(338, 222);
            txtRes.Margin = new Padding(2, 2, 2, 2);
            txtRes.Name = "txtRes";
            txtRes.Size = new Size(123, 27);
            txtRes.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 225);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 5;
            label3.Text = "相加的结果";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(506, 314);
            btnStart.Margin = new Padding(2, 2, 2, 2);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(92, 28);
            btnStart.TabIndex = 6;
            btnStart.Text = "计算";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(139, 331);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 7;
            label4.Text = "test";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(682, 415);
            Controls.Add(label4);
            Controls.Add(btnStart);
            Controls.Add(label3);
            Controls.Add(txtRes);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
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
        private Label label4;
    }
}