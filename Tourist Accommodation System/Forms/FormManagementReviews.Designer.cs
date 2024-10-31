namespace Tourist_Accommodation_System.Forms
{
    partial class FormManagementReviews
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
            button_addreview = new Button();
            button_editreview = new Button();
            button_removereview = new Button();
            button_listreview = new Button();
            SuspendLayout();
            // 
            // button_addreview
            // 
            button_addreview.Location = new Point(250, 41);
            button_addreview.Name = "button_addreview";
            button_addreview.Size = new Size(212, 54);
            button_addreview.TabIndex = 0;
            button_addreview.Text = "ADD REVIEW";
            button_addreview.UseVisualStyleBackColor = true;
            button_addreview.Click += button_addreview_Click;
            // 
            // button_editreview
            // 
            button_editreview.Location = new Point(254, 114);
            button_editreview.Name = "button_editreview";
            button_editreview.Size = new Size(204, 47);
            button_editreview.TabIndex = 1;
            button_editreview.Text = "EDIT REVIEW";
            button_editreview.UseVisualStyleBackColor = true;
            // 
            // button_removereview
            // 
            button_removereview.Location = new Point(255, 185);
            button_removereview.Name = "button_removereview";
            button_removereview.Size = new Size(202, 50);
            button_removereview.TabIndex = 2;
            button_removereview.Text = "REMOVE REVIEW";
            button_removereview.UseVisualStyleBackColor = true;
            button_removereview.Click += button_removereview_Click;
            // 
            // button_listreview
            // 
            button_listreview.Location = new Point(260, 262);
            button_listreview.Name = "button_listreview";
            button_listreview.Size = new Size(196, 64);
            button_listreview.TabIndex = 3;
            button_listreview.Text = "LIST REVIEW";
            button_listreview.UseVisualStyleBackColor = true;
            button_listreview.Click += button_listreview_Click;
            // 
            // FormManagementReviews
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_listreview);
            Controls.Add(button_removereview);
            Controls.Add(button_editreview);
            Controls.Add(button_addreview);
            Name = "FormManagementReviews";
            Text = "FormManagementReviews";
            ResumeLayout(false);
        }

        #endregion

        private Button button_addreview;
        private Button button_editreview;
        private Button button_removereview;
        private Button button_listreview;
    }
}