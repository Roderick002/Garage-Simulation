namespace Garage_Data_Structure_Activity_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LbGarage = new System.Windows.Forms.ListBox();
            this.BtnDepart = new System.Windows.Forms.Button();
            this.TbPlateNumber = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnGS1 = new System.Windows.Forms.Button();
            this.BtnGS2 = new System.Windows.Forms.Button();
            this.BtnGS3 = new System.Windows.Forms.Button();
            this.BtnGS4 = new System.Windows.Forms.Button();
            this.BtnGS5 = new System.Windows.Forms.Button();
            this.BtnGS6 = new System.Windows.Forms.Button();
            this.BtnGS7 = new System.Windows.Forms.Button();
            this.BtnGS8 = new System.Windows.Forms.Button();
            this.BtnGS9 = new System.Windows.Forms.Button();
            this.BtnGS10 = new System.Windows.Forms.Button();
            this.BtnRecentDeparted = new System.Windows.Forms.Button();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblRecentlyDeparted = new System.Windows.Forms.Label();
            this.LblAvailableSpace = new System.Windows.Forms.Label();
            this.LblPlateNo = new System.Windows.Forms.Label();
            this.LblGarageSpace = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbGarage
            // 
            this.LbGarage.FormattingEnabled = true;
            this.LbGarage.ItemHeight = 18;
            this.LbGarage.Location = new System.Drawing.Point(44, 63);
            this.LbGarage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LbGarage.Name = "LbGarage";
            this.LbGarage.Size = new System.Drawing.Size(180, 184);
            this.LbGarage.TabIndex = 0;
            this.LbGarage.Visible = false;
            // 
            // BtnDepart
            // 
            this.BtnDepart.Location = new System.Drawing.Point(397, 435);
            this.BtnDepart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnDepart.Name = "BtnDepart";
            this.BtnDepart.Size = new System.Drawing.Size(130, 40);
            this.BtnDepart.TabIndex = 1;
            this.BtnDepart.Text = "Depart";
            this.BtnDepart.UseVisualStyleBackColor = true;
            this.BtnDepart.Click += new System.EventHandler(this.button1_Click);
            // 
            // TbPlateNumber
            // 
            this.TbPlateNumber.Location = new System.Drawing.Point(48, 449);
            this.TbPlateNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TbPlateNumber.Name = "TbPlateNumber";
            this.TbPlateNumber.Size = new System.Drawing.Size(186, 26);
            this.TbPlateNumber.TabIndex = 2;
            this.TbPlateNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbPlateNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnGS1);
            this.panel1.Controls.Add(this.BtnGS2);
            this.panel1.Controls.Add(this.BtnGS3);
            this.panel1.Controls.Add(this.BtnGS4);
            this.panel1.Controls.Add(this.BtnGS5);
            this.panel1.Controls.Add(this.BtnGS6);
            this.panel1.Controls.Add(this.BtnGS7);
            this.panel1.Controls.Add(this.BtnGS8);
            this.panel1.Controls.Add(this.BtnGS9);
            this.panel1.Controls.Add(this.BtnGS10);
            this.panel1.Controls.Add(this.LbGarage);
            this.panel1.Location = new System.Drawing.Point(17, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 372);
            this.panel1.TabIndex = 3;
            // 
            // BtnGS1
            // 
            this.BtnGS1.Location = new System.Drawing.Point(29, 318);
            this.BtnGS1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnGS1.Name = "BtnGS1";
            this.BtnGS1.Size = new System.Drawing.Size(216, 27);
            this.BtnGS1.TabIndex = 9;
            this.BtnGS1.Text = "Garage Space 1";
            this.BtnGS1.UseVisualStyleBackColor = true;
            // 
            // BtnGS2
            // 
            this.BtnGS2.Location = new System.Drawing.Point(29, 286);
            this.BtnGS2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnGS2.Name = "BtnGS2";
            this.BtnGS2.Size = new System.Drawing.Size(216, 27);
            this.BtnGS2.TabIndex = 8;
            this.BtnGS2.Text = "Garage Space 2";
            this.BtnGS2.UseVisualStyleBackColor = true;
            // 
            // BtnGS3
            // 
            this.BtnGS3.Location = new System.Drawing.Point(29, 253);
            this.BtnGS3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnGS3.Name = "BtnGS3";
            this.BtnGS3.Size = new System.Drawing.Size(216, 27);
            this.BtnGS3.TabIndex = 7;
            this.BtnGS3.Text = "Garage Space 3";
            this.BtnGS3.UseVisualStyleBackColor = true;
            // 
            // BtnGS4
            // 
            this.BtnGS4.Location = new System.Drawing.Point(29, 220);
            this.BtnGS4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnGS4.Name = "BtnGS4";
            this.BtnGS4.Size = new System.Drawing.Size(216, 27);
            this.BtnGS4.TabIndex = 6;
            this.BtnGS4.Text = "Garage Space 4";
            this.BtnGS4.UseVisualStyleBackColor = true;
            // 
            // BtnGS5
            // 
            this.BtnGS5.Location = new System.Drawing.Point(29, 188);
            this.BtnGS5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnGS5.Name = "BtnGS5";
            this.BtnGS5.Size = new System.Drawing.Size(216, 27);
            this.BtnGS5.TabIndex = 5;
            this.BtnGS5.Text = "Garage Space 5";
            this.BtnGS5.UseVisualStyleBackColor = true;
            // 
            // BtnGS6
            // 
            this.BtnGS6.Location = new System.Drawing.Point(29, 156);
            this.BtnGS6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnGS6.Name = "BtnGS6";
            this.BtnGS6.Size = new System.Drawing.Size(216, 27);
            this.BtnGS6.TabIndex = 4;
            this.BtnGS6.Text = "Garage Space 6";
            this.BtnGS6.UseVisualStyleBackColor = true;
            // 
            // BtnGS7
            // 
            this.BtnGS7.Location = new System.Drawing.Point(29, 124);
            this.BtnGS7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnGS7.Name = "BtnGS7";
            this.BtnGS7.Size = new System.Drawing.Size(216, 27);
            this.BtnGS7.TabIndex = 3;
            this.BtnGS7.Text = "Garage Space 7";
            this.BtnGS7.UseVisualStyleBackColor = true;
            // 
            // BtnGS8
            // 
            this.BtnGS8.Location = new System.Drawing.Point(29, 91);
            this.BtnGS8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnGS8.Name = "BtnGS8";
            this.BtnGS8.Size = new System.Drawing.Size(216, 27);
            this.BtnGS8.TabIndex = 2;
            this.BtnGS8.Text = "Garage Space 8";
            this.BtnGS8.UseVisualStyleBackColor = true;
            // 
            // BtnGS9
            // 
            this.BtnGS9.Location = new System.Drawing.Point(29, 59);
            this.BtnGS9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnGS9.Name = "BtnGS9";
            this.BtnGS9.Size = new System.Drawing.Size(216, 27);
            this.BtnGS9.TabIndex = 1;
            this.BtnGS9.Text = "Garage Space 9";
            this.BtnGS9.UseVisualStyleBackColor = true;
            // 
            // BtnGS10
            // 
            this.BtnGS10.Location = new System.Drawing.Point(29, 26);
            this.BtnGS10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnGS10.Name = "BtnGS10";
            this.BtnGS10.Size = new System.Drawing.Size(216, 27);
            this.BtnGS10.TabIndex = 0;
            this.BtnGS10.Text = "Garage Space 10";
            this.BtnGS10.UseVisualStyleBackColor = true;
            // 
            // BtnRecentDeparted
            // 
            this.BtnRecentDeparted.Location = new System.Drawing.Point(317, 337);
            this.BtnRecentDeparted.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnRecentDeparted.Name = "BtnRecentDeparted";
            this.BtnRecentDeparted.Size = new System.Drawing.Size(216, 27);
            this.BtnRecentDeparted.TabIndex = 10;
            this.BtnRecentDeparted.UseVisualStyleBackColor = true;
            this.BtnRecentDeparted.Click += new System.EventHandler(this.BtnRecentDeparted_Click);
            // 
            // BtnEnter
            // 
            this.BtnEnter.Location = new System.Drawing.Point(259, 435);
            this.BtnEnter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(130, 40);
            this.BtnEnter.TabIndex = 11;
            this.BtnEnter.Text = "Enter Garage";
            this.BtnEnter.UseVisualStyleBackColor = true;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Snap ITC", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LblTitle.Location = new System.Drawing.Point(304, 37);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(255, 114);
            this.LblTitle.TabIndex = 12;
            this.LblTitle.Text = "RRY \r\nGARAGE";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblRecentlyDeparted
            // 
            this.LblRecentlyDeparted.AutoSize = true;
            this.LblRecentlyDeparted.Font = new System.Drawing.Font("Calisto MT", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LblRecentlyDeparted.Location = new System.Drawing.Point(357, 306);
            this.LblRecentlyDeparted.Name = "LblRecentlyDeparted";
            this.LblRecentlyDeparted.Size = new System.Drawing.Size(148, 22);
            this.LblRecentlyDeparted.TabIndex = 13;
            this.LblRecentlyDeparted.Text = "Recently Departed:";
            this.LblRecentlyDeparted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblAvailableSpace
            // 
            this.LblAvailableSpace.AutoSize = true;
            this.LblAvailableSpace.Font = new System.Drawing.Font("Calisto MT", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LblAvailableSpace.Location = new System.Drawing.Point(366, 180);
            this.LblAvailableSpace.Name = "LblAvailableSpace";
            this.LblAvailableSpace.Size = new System.Drawing.Size(129, 22);
            this.LblAvailableSpace.TabIndex = 14;
            this.LblAvailableSpace.Text = "Available Space:";
            this.LblAvailableSpace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPlateNo
            // 
            this.LblPlateNo.AutoSize = true;
            this.LblPlateNo.Font = new System.Drawing.Font("Calisto MT", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LblPlateNo.Location = new System.Drawing.Point(78, 420);
            this.LblPlateNo.Name = "LblPlateNo";
            this.LblPlateNo.Size = new System.Drawing.Size(131, 22);
            this.LblPlateNo.TabIndex = 15;
            this.LblPlateNo.Text = "Enter Plate No#:";
            this.LblPlateNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblGarageSpace
            // 
            this.LblGarageSpace.AutoSize = true;
            this.LblGarageSpace.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblGarageSpace.Location = new System.Drawing.Point(376, 210);
            this.LblGarageSpace.Name = "LblGarageSpace";
            this.LblGarageSpace.Size = new System.Drawing.Size(102, 69);
            this.LblGarageSpace.TabIndex = 16;
            this.LblGarageSpace.Text = "10";
            this.LblGarageSpace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 491);
            this.Controls.Add(this.LblGarageSpace);
            this.Controls.Add(this.LblPlateNo);
            this.Controls.Add(this.LblAvailableSpace);
            this.Controls.Add(this.LblRecentlyDeparted);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.BtnRecentDeparted);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TbPlateNumber);
            this.Controls.Add(this.BtnDepart);
            this.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Garage (Stack Algorithm)";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox LbGarage;
        private Button BtnDepart;
        private TextBox TbPlateNumber;
        private Panel panel1;
        private Button BtnGS1;
        private Button BtnGS2;
        private Button BtnGS3;
        private Button BtnGS4;
        private Button BtnGS5;
        private Button BtnGS6;
        private Button BtnGS7;
        private Button BtnGS8;
        private Button BtnGS9;
        private Button BtnGS10;
        private Button BtnRecentDeparted;
        private Button BtnEnter;
        private System.Windows.Forms.Timer Timer;
        private Label LblTitle;
        private Label LblRecentlyDeparted;
        private Label LblAvailableSpace;
        private Label LblPlateNo;
        private Label LblGarageSpace;
    }
}