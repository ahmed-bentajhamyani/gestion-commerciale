namespace gestionCommerciale.Forms
{
    partial class page_principale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(page_principale));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.client = new System.Windows.Forms.Button();
            this.pnlafficher = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.client);
            this.panel1.Location = new System.Drawing.Point(-1, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 152);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(813, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 91);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.BackgroundImage = global::gestionCommerciale.Properties.Resources.place_order;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(638, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 91);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.BackgroundImage = global::gestionCommerciale.Properties.Resources._1181198_product_hunt_producthunt_icon;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(455, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 95);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // client
            // 
            this.client.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.client.BackgroundImage = global::gestionCommerciale.Properties.Resources.groupe;
            this.client.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.client.Cursor = System.Windows.Forms.Cursors.Hand;
            this.client.ForeColor = System.Drawing.Color.FloralWhite;
            this.client.Location = new System.Drawing.Point(273, 33);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(91, 95);
            this.client.TabIndex = 0;
            this.client.UseVisualStyleBackColor = false;
            this.client.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlafficher
            // 
            this.pnlafficher.Location = new System.Drawing.Point(12, 159);
            this.pnlafficher.Name = "pnlafficher";
            this.pnlafficher.Size = new System.Drawing.Size(1128, 525);
            this.pnlafficher.TabIndex = 2;
            // 
            // page_principale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 696);
            this.Controls.Add(this.pnlafficher);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "page_principale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "page_principale";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button client;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel pnlafficher;
    }
}