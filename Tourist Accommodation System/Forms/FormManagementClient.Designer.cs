namespace Tourist_Accommodation_System
{
    partial class FormManagementClient
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
            button_addclient = new Button();
            button_editclient = new Button();
            button_removeclient = new Button();
            button_listclient = new Button();
            SuspendLayout();
            // 
            // button_addclient
            // 
            button_addclient.Location = new Point(340, 67);
            button_addclient.Name = "button_addclient";
            button_addclient.Size = new Size(170, 74);
            button_addclient.TabIndex = 1;
            button_addclient.Text = "ADD CLIENT";
            button_addclient.UseVisualStyleBackColor = true;
            button_addclient.Click += button_addclient_Click;
            // 
            // button_editclient
            // 
            button_editclient.Location = new Point(340, 168);
            button_editclient.Name = "button_editclient";
            button_editclient.Size = new Size(170, 74);
            button_editclient.TabIndex = 2;
            button_editclient.Text = "EDIT CLIENT";
            button_editclient.UseVisualStyleBackColor = true;
            button_editclient.Click += button_editclient_Click;
            // 
            // button_removeclient
            // 
            button_removeclient.Location = new Point(340, 264);
            button_removeclient.Name = "button_removeclient";
            button_removeclient.Size = new Size(170, 69);
            button_removeclient.TabIndex = 3;
            button_removeclient.Text = "REMOVE CLIENT";
            button_removeclient.UseVisualStyleBackColor = true;
            button_removeclient.Click += button_removeclient_Click;
            // 
            // button_listclient
            // 
            button_listclient.Location = new Point(340, 369);
            button_listclient.Name = "button_listclient";
            button_listclient.Size = new Size(170, 69);
            button_listclient.TabIndex = 4;
            button_listclient.Text = "LIST CLIENT";
            button_listclient.UseVisualStyleBackColor = true;
            button_listclient.Click += button_listclient_Click;
            // 
            // FormManagementClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button_listclient);
            Controls.Add(button_removeclient);
            Controls.Add(button_editclient);
            Controls.Add(button_addclient);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormManagementClient";
            Text = "CLIENT MENU";
            Load += FormManagementClient_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button_addclient;
        private Button button_editclient;
        private Button button_removeclient;
        private Button button_listclient;
    }
}