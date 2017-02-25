namespace RadioSimulator
{
    partial class RadioForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioFilesListBox = new System.Windows.Forms.ListBox();
            this.AddFilesButton = new System.Windows.Forms.Button();
            this.StartSimulationButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.PreviousStationButton = new System.Windows.Forms.Button();
            this.NextStationButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioFilesListBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 337);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estações";
            // 
            // RadioFilesListBox
            // 
            this.RadioFilesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioFilesListBox.FormattingEnabled = true;
            this.RadioFilesListBox.Location = new System.Drawing.Point(7, 20);
            this.RadioFilesListBox.Name = "RadioFilesListBox";
            this.RadioFilesListBox.Size = new System.Drawing.Size(312, 303);
            this.RadioFilesListBox.TabIndex = 0;
            // 
            // AddFilesButton
            // 
            this.AddFilesButton.Location = new System.Drawing.Point(374, 33);
            this.AddFilesButton.Name = "AddFilesButton";
            this.AddFilesButton.Size = new System.Drawing.Size(280, 35);
            this.AddFilesButton.TabIndex = 1;
            this.AddFilesButton.Text = "Adicionar Arquivos";
            this.AddFilesButton.UseVisualStyleBackColor = true;
            this.AddFilesButton.Click += new System.EventHandler(this.AddFilesButton_Click);
            // 
            // StartSimulationButton
            // 
            this.StartSimulationButton.Location = new System.Drawing.Point(374, 75);
            this.StartSimulationButton.Name = "StartSimulationButton";
            this.StartSimulationButton.Size = new System.Drawing.Size(280, 37);
            this.StartSimulationButton.TabIndex = 2;
            this.StartSimulationButton.Text = "Começar Simulação";
            this.StartSimulationButton.UseVisualStyleBackColor = true;
            this.StartSimulationButton.Click += new System.EventHandler(this.StartSimulationButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(374, 119);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(62, 52);
            this.PlayButton.TabIndex = 3;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(443, 119);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(59, 52);
            this.PauseButton.TabIndex = 4;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            // 
            // PreviousStationButton
            // 
            this.PreviousStationButton.Location = new System.Drawing.Point(509, 119);
            this.PreviousStationButton.Name = "PreviousStationButton";
            this.PreviousStationButton.Size = new System.Drawing.Size(62, 52);
            this.PreviousStationButton.TabIndex = 5;
            this.PreviousStationButton.Text = "<";
            this.PreviousStationButton.UseVisualStyleBackColor = true;
            // 
            // NextStationButton
            // 
            this.NextStationButton.Location = new System.Drawing.Point(578, 119);
            this.NextStationButton.Name = "NextStationButton";
            this.NextStationButton.Size = new System.Drawing.Size(76, 52);
            this.NextStationButton.TabIndex = 6;
            this.NextStationButton.Text = ">";
            this.NextStationButton.UseVisualStyleBackColor = true;
            // 
            // RadioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 362);
            this.Controls.Add(this.NextStationButton);
            this.Controls.Add(this.PreviousStationButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.StartSimulationButton);
            this.Controls.Add(this.AddFilesButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "RadioForm";
            this.Text = "Radio Simulator";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox RadioFilesListBox;
        private System.Windows.Forms.Button AddFilesButton;
        private System.Windows.Forms.Button StartSimulationButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button PreviousStationButton;
        private System.Windows.Forms.Button NextStationButton;
    }
}

