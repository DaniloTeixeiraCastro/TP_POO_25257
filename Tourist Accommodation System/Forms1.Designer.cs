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
            lblClient = new Label();
            lblAccommodation = new Label();
            lblReservation = new Label();
            lblReviews = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblChekcin = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(319, 20);
            label1.Name = "label1";
            label1.Size = new Size(308, 25);
            label1.TabIndex = 0;
            label1.Text = "ACCOMODATION MANAGEMENT";
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.Font = new Font("Segoe UI", 16F);
            lblClient.Location = new Point(319, 104);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(82, 30);
            lblClient.TabIndex = 1;
            lblClient.Text = "CLIENT";
            lblClient.Click += lblClient_Click;
            // 
            // lblAccommodation
            // 
            lblAccommodation.AutoSize = true;
            lblAccommodation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAccommodation.Location = new Point(319, 152);
            lblAccommodation.Name = "lblAccommodation";
            lblAccommodation.Size = new Size(148, 21);
            lblAccommodation.TabIndex = 2;
            lblAccommodation.Text = "ACCOMMODATION";
            lblAccommodation.Click += lblAccommodation_Click;
            // 
            // lblReservation
            // 
            lblReservation.AutoSize = true;
            lblReservation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReservation.Location = new Point(319, 196);
            lblReservation.Name = "lblReservation";
            lblReservation.Size = new Size(109, 21);
            lblReservation.TabIndex = 3;
            lblReservation.Text = "RESERVATION";
            lblReservation.Click += lblReservation_Click;
            // 
            // lblReviews
            // 
            lblReviews.AutoSize = true;
            lblReviews.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReviews.Location = new Point(319, 240);
            lblReviews.Name = "lblReviews";
            lblReviews.Size = new Size(74, 21);
            lblReviews.TabIndex = 4;
            lblReviews.Text = "REVIEWS";
            lblReviews.Click += lblReviews_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 404);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 78);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 257);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblChekcin
            // 
            lblChekcin.AutoSize = true;
            lblChekcin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChekcin.Location = new Point(319, 287);
            lblChekcin.Name = "lblChekcin";
            lblChekcin.Size = new Size(80, 21);
            lblChekcin.TabIndex = 6;
            lblChekcin.Text = "CHECK-IN";
            lblChekcin.Click += lblChekcin_Click;
            // 
            // button1
            // 
            button1.Location = new Point(324, 111);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Forms1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 410);
            Controls.Add(lblChekcin);
            Controls.Add(panel1);
            Controls.Add(lblReviews);
            Controls.Add(lblReservation);
            Controls.Add(lblAccommodation);
            Controls.Add(lblClient);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
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
        private Label lblClient;
        private Label lblAccommodation;
        private Label lblReservation;
        private Label lblReviews;
        private Panel panel1;
        private Label lblChekcin;
        private PictureBox pictureBox1;
        private Button button1;
    }
}
