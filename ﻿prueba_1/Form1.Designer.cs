namespace _﻿prueba_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserInputPass = new System.Windows.Forms.TextBox();
            this.UserInputName = new System.Windows.Forms.TextBox();
            this.counter = new System.Windows.Forms.Label();
            this.ValidateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserInputPass
            // 
            this.UserInputPass.Location = new System.Drawing.Point(556, 169);
            this.UserInputPass.Name = "UserInputPass";
            this.UserInputPass.Size = new System.Drawing.Size(203, 22);
            this.UserInputPass.TabIndex = 0;
            // 
            // UserInputName
            // 
            this.UserInputName.Location = new System.Drawing.Point(68, 169);
            this.UserInputName.Name = "UserInputName";
            this.UserInputName.Size = new System.Drawing.Size(203, 22);
            this.UserInputName.TabIndex = 0;
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.Location = new System.Drawing.Point(377, 60);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(44, 16);
            this.counter.TabIndex = 1;
            this.counter.Text = "label1";
            this.counter.Click += new System.EventHandler(this.Counter_Click);
            // 
            // ValidateButton
            // 
            this.ValidateButton.Location = new System.Drawing.Point(305, 285);
            this.ValidateButton.Name = "ValidateButton";
            this.ValidateButton.Size = new System.Drawing.Size(230, 77);
            this.ValidateButton.TabIndex = 2;
            this.ValidateButton.Text = "button1";
            this.ValidateButton.UseVisualStyleBackColor = true;
            this.ValidateButton.Click += new System.EventHandler(this.ValidateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ValidateButton);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.UserInputName);
            this.Controls.Add(this.UserInputPass);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInputPass;
        private System.Windows.Forms.TextBox UserInputName;
        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.Button ValidateButton;
    }
}

