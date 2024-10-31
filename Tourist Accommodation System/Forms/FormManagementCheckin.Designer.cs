namespace Tourist_Accommodation_System.Forms
{
    partial class FormManagementCheckin
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
            button_addcheckin = new Button();
            button_editcheckin = new Button();
            button_removecheckin = new Button();
            button_listcheckin = new Button();
            SuspendLayout();
            // 
            // button_addcheckin
            // 
            button_addcheckin.Location = new Point(246, 55);
            button_addcheckin.Name = "button_addcheckin";
            button_addcheckin.Size = new Size(204, 40);
            button_addcheckin.TabIndex = 0;
            button_addcheckin.Text = "ADD CHECK-IN";
            button_addcheckin.UseVisualStyleBackColor = true;
            button_addcheckin.Click += button_addcheckin_Click;
            // 
            // button_editcheckin
            // 
            button_editcheckin.Location = new Point(246, 127);
            button_editcheckin.Name = "button_editcheckin";
            button_editcheckin.Size = new Size(200, 38);
            button_editcheckin.TabIndex = 1;
            button_editcheckin.Text = "EDIT CHECK-IN";
            button_editcheckin.UseVisualStyleBackColor = true;
            button_editcheckin.Click += button_editcheckin_Click;
            // 
            // button_removecheckin
            // 
            button_removecheckin.Location = new Point(248, 189);
            button_removecheckin.Name = "button_removecheckin";
            button_removecheckin.Size = new Size(198, 43);
            button_removecheckin.TabIndex = 2;
            button_removecheckin.Text = "REMOVE CHECK-IN";
            button_removecheckin.UseVisualStyleBackColor = true;
            // 
            // button_listcheckin
            // 
            button_listcheckin.Location = new Point(247, 254);
            button_listcheckin.Name = "button_listcheckin";
            button_listcheckin.Size = new Size(191, 52);
            button_listcheckin.TabIndex = 3;
            button_listcheckin.Text = "LIST CHECK-IN";
            button_listcheckin.UseVisualStyleBackColor = true;
            button_listcheckin.Click += button_listcheckin_Click;
            // 
            // FormManagementCheckin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_listcheckin);
            Controls.Add(button_removecheckin);
            Controls.Add(button_editcheckin);
            Controls.Add(button_addcheckin);
            Name = "FormManagementCheckin";
            Text = "FormManagementCheckin";
            ResumeLayout(false);
        }

        #endregion

        private Button button_addcheckin;
        private Button button_editcheckin;
        private Button button_removecheckin;
        private Button button_listcheckin;
    }
}