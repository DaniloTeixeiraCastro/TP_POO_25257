﻿namespace Tourist_Accommodation_System
{
    partial class UserControlAccommodation
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            button_listaccommodation = new Button();
            button_removeaccommodation = new Button();
            button_editaccommodation = new Button();
            button_addaccommodation = new Button();
            SuspendLayout();
            // 
            // button_listaccommodation
            // 
            button_listaccommodation.Location = new Point(197, 347);
            button_listaccommodation.Name = "button_listaccommodation";
            button_listaccommodation.Size = new Size(277, 45);
            button_listaccommodation.TabIndex = 7;
            button_listaccommodation.Text = "LIST ACCOMMODATION";
            button_listaccommodation.UseVisualStyleBackColor = true;
            button_listaccommodation.Click += button_listaccommodation_Click;
            // 
            // button_removeaccommodation
            // 
            button_removeaccommodation.Location = new Point(197, 267);
            button_removeaccommodation.Name = "button_removeaccommodation";
            button_removeaccommodation.Size = new Size(277, 45);
            button_removeaccommodation.TabIndex = 6;
            button_removeaccommodation.Text = "REMOVE ACCOMMODATION";
            button_removeaccommodation.UseVisualStyleBackColor = true;
            button_removeaccommodation.Click += button_removeaccommodation_Click;
            // 
            // button_editaccommodation
            // 
            button_editaccommodation.Location = new Point(197, 182);
            button_editaccommodation.Name = "button_editaccommodation";
            button_editaccommodation.Size = new Size(277, 51);
            button_editaccommodation.TabIndex = 5;
            button_editaccommodation.Text = "EDIT ACCOMMODATION";
            button_editaccommodation.UseVisualStyleBackColor = true;
            button_editaccommodation.Click += button_editaccommodation_Click;
            // 
            // button_addaccommodation
            // 
            button_addaccommodation.Location = new Point(197, 93);
            button_addaccommodation.Name = "button_addaccommodation";
            button_addaccommodation.Size = new Size(277, 51);
            button_addaccommodation.TabIndex = 4;
            button_addaccommodation.Text = "ADD ACCOMMODATION";
            button_addaccommodation.UseVisualStyleBackColor = true;
            button_addaccommodation.Click += button_addaccommodation_Click;
            // 
            // UserControlAccommodation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_listaccommodation);
            Controls.Add(button_removeaccommodation);
            Controls.Add(button_editaccommodation);
            Controls.Add(button_addaccommodation);
            Name = "UserControlAccommodation";
            Size = new Size(670, 485);
            ResumeLayout(false);
        }

        #endregion

        private Button button_listaccommodation;
        private Button button_removeaccommodation;
        private Button button_editaccommodation;
        private Button button_addaccommodation;
    }
}
