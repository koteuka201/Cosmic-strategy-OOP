namespace CosmStarategy
{
    partial class Planitarium
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Planitarium));
            this.buttonTayplin = new System.Windows.Forms.Button();
            this.buttonAndromeda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTayplin
            // 
            this.buttonTayplin.BackgroundImage = global::CosmStarategy.Resource1.vega2;
            this.buttonTayplin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTayplin.Location = new System.Drawing.Point(138, 206);
            this.buttonTayplin.Name = "buttonTayplin";
            this.buttonTayplin.Size = new System.Drawing.Size(180, 180);
            this.buttonTayplin.TabIndex = 0;
            this.buttonTayplin.Text = "Tayplin";
            this.buttonTayplin.UseVisualStyleBackColor = true;
            this.buttonTayplin.Click += new System.EventHandler(this.buttonTayplin_Click);
            // 
            // buttonAndromeda
            // 
            this.buttonAndromeda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAndromeda.BackgroundImage")));
            this.buttonAndromeda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAndromeda.Location = new System.Drawing.Point(589, 45);
            this.buttonAndromeda.Name = "buttonAndromeda";
            this.buttonAndromeda.Size = new System.Drawing.Size(180, 180);
            this.buttonAndromeda.TabIndex = 1;
            this.buttonAndromeda.Text = "Andromeda";
            this.buttonAndromeda.UseVisualStyleBackColor = true;
            this.buttonAndromeda.Click += new System.EventHandler(this.buttonAndromeda_Click);
            // 
            // Planitarium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CosmStarategy.Resource1.plan;
            this.ClientSize = new System.Drawing.Size(1008, 647);
            this.Controls.Add(this.buttonAndromeda);
            this.Controls.Add(this.buttonTayplin);
            this.Name = "Planitarium";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTayplin;
        private System.Windows.Forms.Button buttonAndromeda;
    }
}