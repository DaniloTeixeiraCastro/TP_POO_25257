namespace Tourist_Accommodation_System
{
    partial class Forms1

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forms1));
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button_CLIENT = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(365, 27);
            label1.Name = "label1";
            label1.Size = new Size(370, 31);
            label1.TabIndex = 0;
            label1.Text = "ACCOMODATION MANAGEMENT";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 539);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 148);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 263);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button_CLIENT
            // 
            button_CLIENT.Location = new Point(370, 148);
            button_CLIENT.Margin = new Padding(3, 4, 3, 4);
            button_CLIENT.Name = "button_CLIENT";
            button_CLIENT.Size = new Size(86, 31);
            button_CLIENT.TabIndex = 7;
            button_CLIENT.Text = "CLIENT";
            button_CLIENT.UseVisualStyleBackColor = true;
            button_CLIENT.Click += button_client_Click;
            // 
            // Forms1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 547);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(button_CLIENT);
            Name = "Forms1";
            Text = "Form1";
            Load += Forms1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button_CLIENT;
    }
}
