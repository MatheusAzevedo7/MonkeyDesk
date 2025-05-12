namespace Prototipo_Suport
{
    partial class telaPrincipal
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnAndamento = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAberto = new System.Windows.Forms.Button();
            this.vScrollBar3 = new System.Windows.Forms.VScrollBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnFechado = new System.Windows.Forms.Button();
            this.btnResolvido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNovoChamado = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnBuscarChamado = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAndamento
            // 
            this.btnAndamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAndamento.FlatAppearance.BorderSize = 0;
            this.btnAndamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAndamento.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAndamento.ForeColor = System.Drawing.Color.White;
            this.btnAndamento.Location = new System.Drawing.Point(306, 43);
            this.btnAndamento.Name = "btnAndamento";
            this.btnAndamento.Size = new System.Drawing.Size(91, 23);
            this.btnAndamento.TabIndex = 3;
            this.btnAndamento.Text = "Andamento";
            this.btnAndamento.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(403, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Pendente";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnAberto
            // 
            this.btnAberto.BackColor = System.Drawing.Color.Lime;
            this.btnAberto.FlatAppearance.BorderSize = 0;
            this.btnAberto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAberto.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAberto.ForeColor = System.Drawing.Color.White;
            this.btnAberto.Location = new System.Drawing.Point(228, 43);
            this.btnAberto.Name = "btnAberto";
            this.btnAberto.Size = new System.Drawing.Size(75, 23);
            this.btnAberto.TabIndex = 2;
            this.btnAberto.Text = "Aberto";
            this.btnAberto.UseVisualStyleBackColor = false;
            // 
            // vScrollBar3
            // 
            this.vScrollBar3.Location = new System.Drawing.Point(1044, 0);
            this.vScrollBar3.Name = "vScrollBar3";
            this.vScrollBar3.Size = new System.Drawing.Size(20, 542);
            this.vScrollBar3.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.chart1);
            this.panel3.Controls.Add(this.vScrollBar3);
            this.panel3.Location = new System.Drawing.Point(226, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1064, 591);
            this.panel3.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(204, 33);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // btnFechado
            // 
            this.btnFechado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechado.FlatAppearance.BorderSize = 0;
            this.btnFechado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechado.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechado.ForeColor = System.Drawing.Color.White;
            this.btnFechado.Location = new System.Drawing.Point(565, 43);
            this.btnFechado.Name = "btnFechado";
            this.btnFechado.Size = new System.Drawing.Size(75, 23);
            this.btnFechado.TabIndex = 5;
            this.btnFechado.Text = "Fechados";
            this.btnFechado.UseVisualStyleBackColor = false;
            // 
            // btnResolvido
            // 
            this.btnResolvido.BackColor = System.Drawing.Color.Cyan;
            this.btnResolvido.FlatAppearance.BorderSize = 0;
            this.btnResolvido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResolvido.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResolvido.ForeColor = System.Drawing.Color.White;
            this.btnResolvido.Location = new System.Drawing.Point(484, 43);
            this.btnResolvido.Name = "btnResolvido";
            this.btnResolvido.Size = new System.Drawing.Size(75, 23);
            this.btnResolvido.TabIndex = 6;
            this.btnResolvido.Text = "Resolvido";
            this.btnResolvido.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chamados";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Prototipo_Suport.Properties.Resources.MONKEYDESK;
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnNovoChamado
            // 
            this.btnNovoChamado.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNovoChamado.FlatAppearance.BorderSize = 0;
            this.btnNovoChamado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoChamado.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoChamado.ForeColor = System.Drawing.Color.White;
            this.btnNovoChamado.Location = new System.Drawing.Point(46, 230);
            this.btnNovoChamado.Name = "btnNovoChamado";
            this.btnNovoChamado.Size = new System.Drawing.Size(123, 39);
            this.btnNovoChamado.TabIndex = 8;
            this.btnNovoChamado.Text = "Novo chamado";
            this.btnNovoChamado.UseVisualStyleBackColor = false;
            this.btnNovoChamado.Click += new System.EventHandler(this.btnNovoChamado_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(46, 291);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(123, 39);
            this.btnDashboard.TabIndex = 9;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnBuscarChamado
            // 
            this.btnBuscarChamado.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBuscarChamado.FlatAppearance.BorderSize = 0;
            this.btnBuscarChamado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarChamado.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarChamado.ForeColor = System.Drawing.Color.White;
            this.btnBuscarChamado.Location = new System.Drawing.Point(46, 354);
            this.btnBuscarChamado.Name = "btnBuscarChamado";
            this.btnBuscarChamado.Size = new System.Drawing.Size(123, 39);
            this.btnBuscarChamado.TabIndex = 10;
            this.btnBuscarChamado.Text = "Buscar chamado";
            this.btnBuscarChamado.UseVisualStyleBackColor = false;
            // 
            // telaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(134)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(1290, 654);
            this.Controls.Add(this.btnBuscarChamado);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.btnNovoChamado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnResolvido);
            this.Controls.Add(this.btnFechado);
            this.Controls.Add(this.btnAberto);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAndamento);
            this.Controls.Add(this.panel3);
            this.Name = "telaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAndamento;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAberto;
        private System.Windows.Forms.VScrollBar vScrollBar3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFechado;
        private System.Windows.Forms.Button btnResolvido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovoChamado;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnBuscarChamado;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

