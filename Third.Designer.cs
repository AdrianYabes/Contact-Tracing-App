
namespace Contact_Tracing_App
{
    partial class Third
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Third));
            this.HumanDisplayOfInformation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HumanDisplayOfInformation
            // 
            this.HumanDisplayOfInformation.BackColor = System.Drawing.Color.Black;
            this.HumanDisplayOfInformation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HumanDisplayOfInformation.Location = new System.Drawing.Point(13, 13);
            this.HumanDisplayOfInformation.Multiline = true;
            this.HumanDisplayOfInformation.Name = "HumanDisplayOfInformation";
            this.HumanDisplayOfInformation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HumanDisplayOfInformation.Size = new System.Drawing.Size(469, 425);
            this.HumanDisplayOfInformation.TabIndex = 0;
            this.HumanDisplayOfInformation.TextChanged += new System.EventHandler(this.HumanDisplayOfInformation_TextChanged);
            // 
            // Third
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.HumanDisplayOfInformation);
            this.MaximizeBox = false;
            this.Name = "Third";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COVID Contact Tracing App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HumanDisplayOfInformation;
    }
}