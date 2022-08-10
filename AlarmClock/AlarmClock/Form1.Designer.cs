namespace AlarmClock
{
    partial class frmForm1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSim = new System.Windows.Forms.Button();
            this.btnNao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "E ai mano, já bateu a merda do ponto?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSim
            // 
            this.btnSim.Location = new System.Drawing.Point(61, 116);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(144, 54);
            this.btnSim.TabIndex = 1;
            this.btnSim.Text = "SIM";
            this.btnSim.UseVisualStyleBackColor = true;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // btnNao
            // 
            this.btnNao.Location = new System.Drawing.Point(278, 116);
            this.btnNao.Name = "btnNao";
            this.btnNao.Size = new System.Drawing.Size(144, 54);
            this.btnNao.TabIndex = 2;
            this.btnNao.Text = "NÃO";
            this.btnNao.UseVisualStyleBackColor = true;
            this.btnNao.Click += new System.EventHandler(this.btnNao_Click);
            // 
            // frmForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 255);
            this.Controls.Add(this.btnNao);
            this.Controls.Add(this.btnSim);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmForm1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm Clock";
            this.Load += new System.EventHandler(this.frmForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.Button btnNao;
    }
}