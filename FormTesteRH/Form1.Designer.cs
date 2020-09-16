namespace FormTesteRH
{
    partial class Form1
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
            this.dateInput = new System.Windows.Forms.DateTimePicker();
            this.bEnviar = new System.Windows.Forms.Button();
            this.textOut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateInput
            // 
            this.dateInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateInput.Location = new System.Drawing.Point(26, 47);
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(282, 25);
            this.dateInput.TabIndex = 0;
            // 
            // bEnviar
            // 
            this.bEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bEnviar.Cursor = System.Windows.Forms.Cursors.Default;
            this.bEnviar.Location = new System.Drawing.Point(342, 46);
            this.bEnviar.Name = "bEnviar";
            this.bEnviar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bEnviar.Size = new System.Drawing.Size(148, 23);
            this.bEnviar.TabIndex = 1;
            this.bEnviar.Text = "Enviar";
            this.bEnviar.UseVisualStyleBackColor = true;
            this.bEnviar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EnviarData);
            // 
            // textOut
            // 
            this.textOut.Location = new System.Drawing.Point(26, 101);
            this.textOut.Multiline = true;
            this.textOut.Name = "textOut";
            this.textOut.Size = new System.Drawing.Size(463, 51);
            this.textOut.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(514, 164);
            this.Controls.Add(this.textOut);
            this.Controls.Add(this.bEnviar);
            this.Controls.Add(this.dateInput);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Consultar 5º Util";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateInput;
        private System.Windows.Forms.Button bEnviar;
        private System.Windows.Forms.TextBox textOut;
    }
}

