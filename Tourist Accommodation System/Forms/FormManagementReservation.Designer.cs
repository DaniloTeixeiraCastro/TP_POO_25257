namespace Tourist_Accommodation_System.Forms
{
    partial class FormManagementReservation
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
            button_addreservation = new Button();
            button_editreservation = new Button();
            button_removereservation = new Button();
            button_listreservation = new Button();
            SuspendLayout();
            // 
            // button_addreservation
            // 
            button_addreservation.Location = new Point(257, 51);
            button_addreservation.Name = "button_addreservation";
            button_addreservation.Size = new Size(227, 53);
            button_addreservation.TabIndex = 0;
            button_addreservation.Text = "ADD RESERVATION";
            button_addreservation.UseVisualStyleBackColor = true;
            button_addreservation.Click += button_addreservation_Click;
            // 
            // button_editreservation
            // 
            button_editreservation.Location = new Point(257, 124);
            button_editreservation.Name = "button_editreservation";
            button_editreservation.Size = new Size(227, 53);
            button_editreservation.TabIndex = 1;
            button_editreservation.Text = "EDIT RESERVATION";
            button_editreservation.UseVisualStyleBackColor = true;
            button_editreservation.Click += button_editreservation_Click;
            // 
            // button_removereservation
            // 
            button_removereservation.Location = new Point(257, 205);
            button_removereservation.Name = "button_removereservation";
            button_removereservation.Size = new Size(227, 51);
            button_removereservation.TabIndex = 2;
            button_removereservation.Text = "REMOVE RESERVATION";
            button_removereservation.UseVisualStyleBackColor = true;
            button_removereservation.Click += button_removereservation_Click;
            // 
            // button_listreservation
            // 
            button_listreservation.Location = new Point(257, 291);
            button_listreservation.Name = "button_listreservation";
            button_listreservation.Size = new Size(227, 54);
            button_listreservation.TabIndex = 3;
            button_listreservation.Text = "LIST RESERVATION";
            button_listreservation.UseVisualStyleBackColor = true;
            button_listreservation.Click += button_listreservation_Click;
            // 
            // FormManagementReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_listreservation);
            Controls.Add(button_removereservation);
            Controls.Add(button_editreservation);
            Controls.Add(button_addreservation);
            Name = "FormManagementReservation";
            Text = "FormManagementReservation";
            ResumeLayout(false);
        }

        #endregion

        private Button button_addreservation;
        private Button button_editreservation;
        private Button button_removereservation;
        private Button button_listreservation;
    }
}