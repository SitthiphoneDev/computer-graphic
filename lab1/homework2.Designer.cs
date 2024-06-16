namespace computer_graphic
{
    partial class homework2
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
            pictureBox1 = new PictureBox();
            btnexit = new Button();
            btnsave = new Button();
            btntranslate = new Button();
            btnRotate = new Button();
            groupBox1 = new GroupBox();
            txtY = new TextBox();
            label3 = new Label();
            btnScale = new Button();
            txtX = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtangle = new TextBox();
            label2 = new Label();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1219, 639);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(1305, 494);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(131, 43);
            btnexit.TabIndex = 4;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(1307, 433);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(131, 43);
            btnsave.TabIndex = 3;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btntranslate
            // 
            btntranslate.Location = new Point(1283, 300);
            btntranslate.Name = "btntranslate";
            btntranslate.Size = new Size(168, 43);
            btntranslate.TabIndex = 6;
            btntranslate.Text = "Translate";
            btntranslate.UseVisualStyleBackColor = true;
            btntranslate.Click += btntranslate_Click;
            // 
            // btnRotate
            // 
            btnRotate.Location = new Point(13, 65);
            btnRotate.Name = "btnRotate";
            btnRotate.Size = new Size(133, 40);
            btnRotate.TabIndex = 7;
            btnRotate.Text = "Rotate";
            btnRotate.UseVisualStyleBackColor = true;
            btnRotate.Click += btnRotate_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtY);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnScale);
            groupBox1.Controls.Add(txtX);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1283, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(168, 151);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Scale";
            // 
            // txtY
            // 
            txtY.Location = new Point(49, 59);
            txtY.Name = "txtY";
            txtY.Size = new Size(77, 27);
            txtY.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 62);
            label3.Name = "label3";
            label3.Size = new Size(20, 20);
            label3.TabIndex = 10;
            label3.Text = "Y:";
            // 
            // btnScale
            // 
            btnScale.Location = new Point(22, 102);
            btnScale.Name = "btnScale";
            btnScale.Size = new Size(133, 43);
            btnScale.TabIndex = 7;
            btnScale.Text = "Scale";
            btnScale.UseVisualStyleBackColor = true;
            btnScale.Click += btnScale_Click;
            // 
            // txtX
            // 
            txtX.Location = new Point(49, 26);
            txtX.Name = "txtX";
            txtX.Size = new Size(77, 27);
            txtX.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 29);
            label1.Name = "label1";
            label1.Size = new Size(21, 20);
            label1.TabIndex = 8;
            label1.Text = "X:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtangle);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnRotate);
            groupBox2.Location = new Point(1283, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(168, 115);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Rotate";
            // 
            // txtangle
            // 
            txtangle.Location = new Point(79, 26);
            txtangle.Name = "txtangle";
            txtangle.Size = new Size(67, 27);
            txtangle.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 29);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 8;
            label2.Text = "Angle:";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(1283, 360);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(174, 43);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += button1_Click_1;
            // 
            // homework2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 663);
            Controls.Add(btnReset);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btntranslate);
            Controls.Add(pictureBox1);
            Controls.Add(btnexit);
            Controls.Add(btnsave);
            Name = "homework2";
            Text = "homework2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnexit;
        private Button btnsave;
        private Button btntranslate;
        private Button btnRotate;
        private GroupBox groupBox1;
        private TextBox txtX;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtangle;
        private Label label2;
        private Button btnScale;
        private TextBox txtY;
        private Label label3;
        private Button btnReset;
    }
}