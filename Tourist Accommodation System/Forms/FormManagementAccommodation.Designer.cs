namespace Tourist_Accommodation_System
{
    partial class FormManagementAccommodation
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
            button_addaccommodation = new Button();
            button_editaccommodation = new Button();
            button_removeaccommodation = new Button();
            button_listaccommodation = new Button();
            SuspendLayout();
            // 
            // button_addaccommodation
            // 
            button_addaccommodation.Location = new Point(243, 75);
            button_addaccommodation.Name = "button_addaccommodation";
            button_addaccommodation.Size = new Size(277, 51);
            button_addaccommodation.TabIndex = 0;
            button_addaccommodation.Text = "ADD ACCOMMODATION";
            button_addaccommodation.UseVisualStyleBackColor = true;
            button_addaccommodation.Click += button_addaccommodation_Click;
            // 
            // button_editaccommodation
            // 
            button_editaccommodation.Location = new Point(243, 164);
            button_editaccommodation.Name = "button_editaccommodation";
            button_editaccommodation.Size = new Size(277, 51);
            button_editaccommodation.TabIndex = 1;
            button_editaccommodation.Text = "EDIT ACCOMMODATION";
            button_editaccommodation.UseVisualStyleBackColor = true;
            // 
            // button_removeaccommodation
            // 
            button_removeaccommodation.Location = new Point(243, 249);
            button_removeaccommodation.Name = "button_removeaccommodation";
            button_removeaccommodation.Size = new Size(277, 45);
            button_removeaccommodation.TabIndex = 2;
            button_removeaccommodation.Text = "REMOVE ACCOMMODATION";
            button_removeaccommodation.UseVisualStyleBackColor = true;
            button_removeaccommodation.Click += button_removeaccommodation_Click;
            // 
            // button_listaccommodation
            // 
            button_listaccommodation.Location = new Point(243, 329);
            button_listaccommodation.Name = "button_listaccommodation";
            button_listaccommodation.Size = new Size(277, 45);
            button_listaccommodation.TabIndex = 3;
            button_listaccommodation.Text = "LIST ACCOMMODATION";
            button_listaccommodation.UseVisualStyleBackColor = true;
            button_listaccommodation.Click += button_listaccommodation_Click;
            // 
            // FormManagementAccommodation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_listaccommodation);
            Controls.Add(button_removeaccommodation);
            Controls.Add(button_editaccommodation);
            Controls.Add(button_addaccommodation);
            Name = "FormManagementAccommodation";
            Text = "FormManagementAccommodation";
            ResumeLayout(false);
        }

        #endregion

        private Button button_addaccommodation;
        private Button button_editaccommodation;
        private Button button_removeaccommodation;
        private Button button_listaccommodation;
    }
}