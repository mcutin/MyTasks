namespace MyTasks
{
    partial class PlannerDay
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
            this.lblDay = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblNormal = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDay
            // 
            this.lblDay.BackColor = System.Drawing.Color.White;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(1, 1);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(78, 22);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "Day";
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHigh
            // 
            this.lblHigh.BackColor = System.Drawing.Color.White;
            this.lblHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHigh.ForeColor = System.Drawing.Color.Red;
            this.lblHigh.Location = new System.Drawing.Point(1, 23);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(78, 22);
            this.lblHigh.TabIndex = 1;
            this.lblHigh.Text = "High";
            this.lblHigh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNormal
            // 
            this.lblNormal.BackColor = System.Drawing.Color.White;
            this.lblNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNormal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblNormal.Location = new System.Drawing.Point(1, 45);
            this.lblNormal.Name = "lblNormal";
            this.lblNormal.Size = new System.Drawing.Size(78, 22);
            this.lblNormal.TabIndex = 2;
            this.lblNormal.Text = "Normal";
            this.lblNormal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLow
            // 
            this.lblLow.BackColor = System.Drawing.Color.White;
            this.lblLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLow.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblLow.Location = new System.Drawing.Point(1, 67);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(78, 22);
            this.lblLow.TabIndex = 3;
            this.lblLow.Text = "Low";
            this.lblLow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlannerDay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.lblLow);
            this.Controls.Add(this.lblNormal);
            this.Controls.Add(this.lblHigh);
            this.Controls.Add(this.lblDay);
            this.MaximumSize = new System.Drawing.Size(80, 90);
            this.MinimumSize = new System.Drawing.Size(80, 90);
            this.Name = "PlannerDay";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(80, 90);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Label lblNormal;
        private System.Windows.Forms.Label lblLow;
    }
}
