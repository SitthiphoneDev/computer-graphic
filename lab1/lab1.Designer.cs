namespace lab1
{
    partial class lab_1
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
            btndelete = new Button();
            btndraw = new Button();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            btncolor = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btndelete
            // 
            btndelete.Location = new Point(589, 34);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(166, 62);
            btndelete.TabIndex = 0;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btndraw
            // 
            btndraw.Location = new Point(589, 112);
            btndraw.Name = "btndraw";
            btndraw.Size = new Size(166, 62);
            btndraw.TabIndex = 1;
            btndraw.Text = "Draw";
            btndraw.UseVisualStyleBackColor = true;
            btndraw.Click += btndraw_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(592, 200);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(166, 27);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(520, 202);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 3;
            label1.Text = "Pen Size:";
            // 
            // btncolor
            // 
            btncolor.Location = new Point(608, 261);
            btncolor.Name = "btncolor";
            btncolor.Size = new Size(147, 80);
            btncolor.TabIndex = 4;
            btncolor.UseVisualStyleBackColor = true;
            btncolor.Click += btncolor_Click;
            // 
            // lab_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btncolor);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(btndraw);
            Controls.Add(btndelete);
            Name = "lab_1";
            Text = "Lab1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btndelete;
        private Button btndraw;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Button btncolor;
    }
}