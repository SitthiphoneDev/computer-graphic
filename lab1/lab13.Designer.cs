namespace computer_graphic
{
    partial class lab13
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
            btncomplement = new Button();
            btnInterSect = new Button();
            bitUnion = new Button();
            btnExclude = new Button();
            Xor = new Button();
            SuspendLayout();
            // 
            // btncomplement
            // 
            btncomplement.Location = new Point(662, 41);
            btncomplement.Name = "btncomplement";
            btncomplement.Size = new Size(111, 46);
            btncomplement.TabIndex = 0;
            btncomplement.Text = "Complement";
            btncomplement.UseVisualStyleBackColor = true;
            btncomplement.Click += btncomplement_Click;
            // 
            // btnInterSect
            // 
            btnInterSect.Location = new Point(662, 93);
            btnInterSect.Name = "btnInterSect";
            btnInterSect.Size = new Size(111, 46);
            btnInterSect.TabIndex = 1;
            btnInterSect.Text = "Inter Sect";
            btnInterSect.UseVisualStyleBackColor = true;
            btnInterSect.Click += btnInterSect_Click;
            // 
            // bitUnion
            // 
            bitUnion.Location = new Point(662, 145);
            bitUnion.Name = "bitUnion";
            bitUnion.Size = new Size(111, 46);
            bitUnion.TabIndex = 2;
            bitUnion.Text = "Union";
            bitUnion.UseVisualStyleBackColor = true;
            bitUnion.Click += bitUnion_Click;
            // 
            // btnExclude
            // 
            btnExclude.Location = new Point(662, 197);
            btnExclude.Name = "btnExclude";
            btnExclude.Size = new Size(111, 46);
            btnExclude.TabIndex = 3;
            btnExclude.Text = "Exclude";
            btnExclude.UseVisualStyleBackColor = true;
            btnExclude.Click += btnExclude_Click;
            // 
            // Xor
            // 
            Xor.Location = new Point(662, 249);
            Xor.Name = "Xor";
            Xor.Size = new Size(111, 46);
            Xor.TabIndex = 4;
            Xor.Text = "Xor";
            Xor.UseVisualStyleBackColor = true;
            Xor.Click += Xor_Click;
            // 
            // lab13
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Xor);
            Controls.Add(btnExclude);
            Controls.Add(bitUnion);
            Controls.Add(btnInterSect);
            Controls.Add(btncomplement);
            Name = "lab13";
            Text = "lab13";
            ResumeLayout(false);
        }

        #endregion

        private Button btncomplement;
        private Button btnInterSect;
        private Button bitUnion;
        private Button btnExclude;
        private Button Xor;
    }
}