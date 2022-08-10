namespace AlarmClock
{
    partial class frmForm2
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
            this.lbl_HorarioDeInicio = new System.Windows.Forms.Label();
            this.box_Horas = new System.Windows.Forms.NumericUpDown();
            this.box_Minutos = new System.Windows.Forms.NumericUpDown();
            this.lbl_Horas = new System.Windows.Forms.Label();
            this.lbl_Minutos = new System.Windows.Forms.Label();
            this.btn_Iniciar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.box_Horas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_Minutos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_HorarioDeInicio
            // 
            this.lbl_HorarioDeInicio.AutoSize = true;
            this.lbl_HorarioDeInicio.Font = new System.Drawing.Font("Calibri", 12.25F);
            this.lbl_HorarioDeInicio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_HorarioDeInicio.Location = new System.Drawing.Point(39, 54);
            this.lbl_HorarioDeInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_HorarioDeInicio.Name = "lbl_HorarioDeInicio";
            this.lbl_HorarioDeInicio.Size = new System.Drawing.Size(125, 21);
            this.lbl_HorarioDeInicio.TabIndex = 0;
            this.lbl_HorarioDeInicio.Text = "Horário de Início";
            // 
            // box_Horas
            // 
            this.box_Horas.BackColor = System.Drawing.SystemColors.Control;
            this.box_Horas.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_Horas.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.box_Horas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.box_Horas.InterceptArrowKeys = false;
            this.box_Horas.Location = new System.Drawing.Point(105, 39);
            this.box_Horas.Margin = new System.Windows.Forms.Padding(2);
            this.box_Horas.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.box_Horas.Name = "box_Horas";
            this.box_Horas.Size = new System.Drawing.Size(67, 31);
            this.box_Horas.TabIndex = 1;
            this.box_Horas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.box_Horas.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // box_Minutos
            // 
            this.box_Minutos.BackColor = System.Drawing.SystemColors.Control;
            this.box_Minutos.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_Minutos.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.box_Minutos.Location = new System.Drawing.Point(256, 39);
            this.box_Minutos.Margin = new System.Windows.Forms.Padding(2);
            this.box_Minutos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.box_Minutos.Name = "box_Minutos";
            this.box_Minutos.Size = new System.Drawing.Size(67, 31);
            this.box_Minutos.TabIndex = 2;
            this.box_Minutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Horas
            // 
            this.lbl_Horas.AutoSize = true;
            this.lbl_Horas.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Horas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Horas.Location = new System.Drawing.Point(183, 49);
            this.lbl_Horas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Horas.Name = "lbl_Horas";
            this.lbl_Horas.Size = new System.Drawing.Size(40, 15);
            this.lbl_Horas.TabIndex = 3;
            this.lbl_Horas.Text = "Horas";
            // 
            // lbl_Minutos
            // 
            this.lbl_Minutos.AutoSize = true;
            this.lbl_Minutos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Minutos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Minutos.Location = new System.Drawing.Point(335, 49);
            this.lbl_Minutos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Minutos.Name = "lbl_Minutos";
            this.lbl_Minutos.Size = new System.Drawing.Size(53, 15);
            this.lbl_Minutos.TabIndex = 4;
            this.lbl_Minutos.Text = "Minutos";
            // 
            // btn_Iniciar
            // 
            this.btn_Iniciar.BackColor = System.Drawing.Color.Green;
            this.btn_Iniciar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btn_Iniciar.FlatAppearance.BorderSize = 0;
            this.btn_Iniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btn_Iniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Iniciar.Font = new System.Drawing.Font("Calibri Light", 14.75F);
            this.btn_Iniciar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Iniciar.Location = new System.Drawing.Point(43, 217);
            this.btn_Iniciar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Iniciar.Name = "btn_Iniciar";
            this.btn_Iniciar.Size = new System.Drawing.Size(474, 79);
            this.btn_Iniciar.TabIndex = 5;
            this.btn_Iniciar.Text = "Iniciar";
            this.btn_Iniciar.UseVisualStyleBackColor = false;
            this.btn_Iniciar.Click += new System.EventHandler(this.btn_Iniciar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Minutos);
            this.groupBox1.Controls.Add(this.lbl_Horas);
            this.groupBox1.Controls.Add(this.box_Minutos);
            this.groupBox1.Controls.Add(this.box_Horas);
            this.groupBox1.Location = new System.Drawing.Point(43, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(474, 105);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // frmForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(99)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(564, 371);
            this.Controls.Add(this.btn_Iniciar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_HorarioDeInicio);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmForm2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm Clock";
            this.Load += new System.EventHandler(this.Alarm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.box_Horas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_Minutos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_HorarioDeInicio;
        private System.Windows.Forms.NumericUpDown box_Horas;
        private System.Windows.Forms.NumericUpDown box_Minutos;
        private System.Windows.Forms.Label lbl_Horas;
        private System.Windows.Forms.Label lbl_Minutos;
        private System.Windows.Forms.Button btn_Iniciar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

