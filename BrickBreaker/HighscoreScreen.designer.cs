namespace BrickBreaker.Screens
{
    partial class HighscoreScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.scoreTitle = new System.Windows.Forms.Label();
            this.top5Output = new System.Windows.Forms.Label();
            this.next5Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scoreTitle
            // 
            this.scoreTitle.BackColor = System.Drawing.Color.Transparent;
            this.scoreTitle.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.scoreTitle.Location = new System.Drawing.Point(198, 24);
            this.scoreTitle.Name = "scoreTitle";
            this.scoreTitle.Size = new System.Drawing.Size(404, 90);
            this.scoreTitle.TabIndex = 0;
            this.scoreTitle.Text = "High Scores";
            // 
            // top5Output
            // 
            this.top5Output.AutoSize = true;
            this.top5Output.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top5Output.Location = new System.Drawing.Point(172, 200);
            this.top5Output.Name = "top5Output";
            this.top5Output.Size = new System.Drawing.Size(150, 41);
            this.top5Output.TabIndex = 1;
            this.top5Output.Text = "label1";
            // 
            // next5Output
            // 
            this.next5Output.AutoSize = true;
            this.next5Output.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next5Output.Location = new System.Drawing.Point(487, 200);
            this.next5Output.Name = "next5Output";
            this.next5Output.Size = new System.Drawing.Size(150, 41);
            this.next5Output.TabIndex = 2;
            this.next5Output.Text = "label1";
            // 
            // HighscoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BrickBreaker.Properties.Resources.fadedBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.next5Output);
            this.Controls.Add(this.top5Output);
            this.Controls.Add(this.scoreTitle);
            this.Name = "HighscoreScreen";
            this.Size = new System.Drawing.Size(800, 550);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.HighscoreScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreTitle;
        private System.Windows.Forms.Label top5Output;
        private System.Windows.Forms.Label next5Output;
    }
}
