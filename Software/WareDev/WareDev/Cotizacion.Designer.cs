namespace WareDev
{
    partial class Cotizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cotizacion));
            this.PDFcot = new AxAcroPDFLib.AxAcroPDF();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PDFcot)).BeginInit();
            this.SuspendLayout();
            // 
            // PDFcot
            // 
            this.PDFcot.Enabled = true;
            this.PDFcot.Location = new System.Drawing.Point(35, 42);
            this.PDFcot.Name = "PDFcot";
            this.PDFcot.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PDFcot.OcxState")));
            this.PDFcot.Size = new System.Drawing.Size(502, 514);
            this.PDFcot.TabIndex = 0;
            this.PDFcot.Enter += new System.EventHandler(this.PDFcot_Enter);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(574, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 56);
            this.button1.TabIndex = 47;
            this.button1.Text = "Export To PDF";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(574, 434);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 56);
            this.button2.TabIndex = 48;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.UseWaitCursor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(574, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 56);
            this.button3.TabIndex = 49;
            this.button3.Text = "Open ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.UseWaitCursor = true;
            // 
            // Cotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(733, 600);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PDFcot);
            this.Name = "Cotizacion";
            this.Text = "Cotizacion";
            ((System.ComponentModel.ISupportInitialize)(this.PDFcot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public AxAcroPDFLib.AxAcroPDF PDFcot;
        private System.Windows.Forms.Button button3;
    }
}