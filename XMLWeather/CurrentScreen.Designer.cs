namespace XMLWeather
{
    partial class CurrentScreen
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
            this.locationOutput = new System.Windows.Forms.Label();
            this.currentTempOutput = new System.Windows.Forms.Label();
            this.todayButton = new System.Windows.Forms.Label();
            this.forecastButton = new System.Windows.Forms.Label();
            this.dateOutput = new System.Windows.Forms.Label();
            this.underlineLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.outputTitleLabel2 = new System.Windows.Forms.Label();
            this.outputTitleLabel1 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.outputLabel1 = new System.Windows.Forms.Label();
            this.outputLabel2 = new System.Windows.Forms.Label();
            this.boxLabel = new System.Windows.Forms.Label();
            this.longOutputLabel1 = new System.Windows.Forms.Label();
            this.longOutputLabel2 = new System.Windows.Forms.Label();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.weatherIconPictureBox = new System.Windows.Forms.PictureBox();
            this.searchButton = new System.Windows.Forms.PictureBox();
            this.rightArrowButton = new System.Windows.Forms.PictureBox();
            this.leftArrowButton = new System.Windows.Forms.PictureBox();
            this.eventLog1 = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightArrowButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArrowButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // locationOutput
            // 
            this.locationOutput.BackColor = System.Drawing.Color.Transparent;
            this.locationOutput.Font = new System.Drawing.Font("Aquire", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationOutput.ForeColor = System.Drawing.Color.White;
            this.locationOutput.Location = new System.Drawing.Point(0, 80);
            this.locationOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locationOutput.Name = "locationOutput";
            this.locationOutput.Size = new System.Drawing.Size(371, 35);
            this.locationOutput.TabIndex = 22;
            this.locationOutput.Text = "City";
            this.locationOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentTempOutput
            // 
            this.currentTempOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentTempOutput.Font = new System.Drawing.Font("Aquire", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTempOutput.ForeColor = System.Drawing.Color.White;
            this.currentTempOutput.Location = new System.Drawing.Point(4, 123);
            this.currentTempOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentTempOutput.Name = "currentTempOutput";
            this.currentTempOutput.Size = new System.Drawing.Size(371, 73);
            this.currentTempOutput.TabIndex = 28;
            this.currentTempOutput.Text = "TEMP";
            this.currentTempOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // todayButton
            // 
            this.todayButton.BackColor = System.Drawing.Color.Transparent;
            this.todayButton.Font = new System.Drawing.Font("Aquire", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayButton.ForeColor = System.Drawing.Color.White;
            this.todayButton.Location = new System.Drawing.Point(32, 15);
            this.todayButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.todayButton.Name = "todayButton";
            this.todayButton.Size = new System.Drawing.Size(124, 43);
            this.todayButton.TabIndex = 40;
            this.todayButton.Text = "Today";
            // 
            // forecastButton
            // 
            this.forecastButton.BackColor = System.Drawing.Color.Transparent;
            this.forecastButton.Font = new System.Drawing.Font("Aquire", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastButton.ForeColor = System.Drawing.Color.White;
            this.forecastButton.Location = new System.Drawing.Point(212, 15);
            this.forecastButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastButton.Name = "forecastButton";
            this.forecastButton.Size = new System.Drawing.Size(124, 43);
            this.forecastButton.TabIndex = 41;
            this.forecastButton.Text = "Week";
            this.forecastButton.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // dateOutput
            // 
            this.dateOutput.BackColor = System.Drawing.Color.Transparent;
            this.dateOutput.Font = new System.Drawing.Font("Aquire", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOutput.ForeColor = System.Drawing.Color.White;
            this.dateOutput.Location = new System.Drawing.Point(1, 523);
            this.dateOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateOutput.Name = "dateOutput";
            this.dateOutput.Size = new System.Drawing.Size(371, 92);
            this.dateOutput.TabIndex = 48;
            this.dateOutput.Text = "April 13, 2023";
            this.dateOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // underlineLabel
            // 
            this.underlineLabel.BackColor = System.Drawing.Color.Transparent;
            this.underlineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineLabel.ForeColor = System.Drawing.Color.White;
            this.underlineLabel.Location = new System.Drawing.Point(6, 31);
            this.underlineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.underlineLabel.Name = "underlineLabel";
            this.underlineLabel.Size = new System.Drawing.Size(172, 42);
            this.underlineLabel.TabIndex = 42;
            this.underlineLabel.Text = "____________________________";
            this.underlineLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-22, -22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // outputTitleLabel2
            // 
            this.outputTitleLabel2.AutoSize = true;
            this.outputTitleLabel2.BackColor = System.Drawing.Color.Transparent;
            this.outputTitleLabel2.Font = new System.Drawing.Font("Aquire", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTitleLabel2.ForeColor = System.Drawing.Color.White;
            this.outputTitleLabel2.Location = new System.Drawing.Point(205, 428);
            this.outputTitleLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputTitleLabel2.Name = "outputTitleLabel2";
            this.outputTitleLabel2.Size = new System.Drawing.Size(63, 24);
            this.outputTitleLabel2.TabIndex = 67;
            this.outputTitleLabel2.Text = "max";
            // 
            // outputTitleLabel1
            // 
            this.outputTitleLabel1.AutoSize = true;
            this.outputTitleLabel1.BackColor = System.Drawing.Color.Transparent;
            this.outputTitleLabel1.Font = new System.Drawing.Font("Aquire", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTitleLabel1.ForeColor = System.Drawing.Color.White;
            this.outputTitleLabel1.Location = new System.Drawing.Point(113, 428);
            this.outputTitleLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputTitleLabel1.Name = "outputTitleLabel1";
            this.outputTitleLabel1.Size = new System.Drawing.Size(47, 24);
            this.outputTitleLabel1.TabIndex = 65;
            this.outputTitleLabel1.Text = "min";
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Aquire", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(95, 326);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(190, 28);
            this.titleLabel.TabIndex = 64;
            this.titleLabel.Text = "temperature";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // outputLabel1
            // 
            this.outputLabel1.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel1.Font = new System.Drawing.Font("Aquire", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel1.ForeColor = System.Drawing.Color.White;
            this.outputLabel1.Location = new System.Drawing.Point(99, 376);
            this.outputLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLabel1.Name = "outputLabel1";
            this.outputLabel1.Size = new System.Drawing.Size(79, 50);
            this.outputLabel1.TabIndex = 66;
            this.outputLabel1.Text = "10";
            this.outputLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // outputLabel2
            // 
            this.outputLabel2.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel2.Font = new System.Drawing.Font("Aquire", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel2.ForeColor = System.Drawing.Color.White;
            this.outputLabel2.Location = new System.Drawing.Point(188, 376);
            this.outputLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLabel2.Name = "outputLabel2";
            this.outputLabel2.Size = new System.Drawing.Size(89, 50);
            this.outputLabel2.TabIndex = 68;
            this.outputLabel2.Text = "20";
            this.outputLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // boxLabel
            // 
            this.boxLabel.BackColor = System.Drawing.Color.Transparent;
            this.boxLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.boxLabel.Location = new System.Drawing.Point(90, 222);
            this.boxLabel.Name = "boxLabel";
            this.boxLabel.Size = new System.Drawing.Size(200, 281);
            this.boxLabel.TabIndex = 69;
            // 
            // longOutputLabel1
            // 
            this.longOutputLabel1.BackColor = System.Drawing.Color.Transparent;
            this.longOutputLabel1.Font = new System.Drawing.Font("Aquire", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longOutputLabel1.ForeColor = System.Drawing.Color.Yellow;
            this.longOutputLabel1.Location = new System.Drawing.Point(95, 367);
            this.longOutputLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.longOutputLabel1.Name = "longOutputLabel1";
            this.longOutputLabel1.Size = new System.Drawing.Size(190, 50);
            this.longOutputLabel1.TabIndex = 70;
            this.longOutputLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // longOutputLabel2
            // 
            this.longOutputLabel2.BackColor = System.Drawing.Color.Transparent;
            this.longOutputLabel2.Font = new System.Drawing.Font("Aquire", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longOutputLabel2.ForeColor = System.Drawing.Color.White;
            this.longOutputLabel2.Location = new System.Drawing.Point(95, 412);
            this.longOutputLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.longOutputLabel2.Name = "longOutputLabel2";
            this.longOutputLabel2.Size = new System.Drawing.Size(190, 50);
            this.longOutputLabel2.TabIndex = 71;
            this.longOutputLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cityComboBox
            // 
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(50, 80);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(134, 32);
            this.cityComboBox.TabIndex = 74;
            this.cityComboBox.Text = "City";
            this.cityComboBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.searchCityComboBox_PreviewKeyDown);
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.LavenderBlush;
            this.progressBar.Location = new System.Drawing.Point(108, 465);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(160, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 77;
            this.progressBar.Value = 23;
            this.progressBar.Visible = false;
            // 
            // countryComboBox
            // 
            this.countryComboBox.Font = new System.Drawing.Font("Aquire", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(194, 80);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(164, 30);
            this.countryComboBox.TabIndex = 80;
            this.countryComboBox.Text = "Country";
            this.countryComboBox.Visible = false;
            this.countryComboBox.TextChanged += new System.EventHandler(this.countryComboBox_TextChanged);
            this.countryComboBox.Enter += new System.EventHandler(this.countryComboBox_Enter);
            this.countryComboBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.searchComboBox_PreviewKeyDown);
            // 
            // weatherIconPictureBox
            // 
            this.weatherIconPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.weatherIconPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weatherIconPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weatherIconPictureBox.Location = new System.Drawing.Point(147, 232);
            this.weatherIconPictureBox.Name = "weatherIconPictureBox";
            this.weatherIconPictureBox.Size = new System.Drawing.Size(80, 80);
            this.weatherIconPictureBox.TabIndex = 83;
            this.weatherIconPictureBox.TabStop = false;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.BackgroundImage = global::XMLWeather.Properties.Resources.magnifying_removebg_preview;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.Location = new System.Drawing.Point(10, 85);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(32, 32);
            this.searchButton.TabIndex = 82;
            this.searchButton.TabStop = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click_1);
            this.searchButton.MouseEnter += new System.EventHandler(this.searchButton_MouseEnter);
            this.searchButton.MouseLeave += new System.EventHandler(this.searchButton_MouseLeave);
            // 
            // rightArrowButton
            // 
            this.rightArrowButton.BackColor = System.Drawing.Color.Transparent;
            this.rightArrowButton.BackgroundImage = global::XMLWeather.Properties.Resources.arrow2;
            this.rightArrowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rightArrowButton.Location = new System.Drawing.Point(300, 339);
            this.rightArrowButton.Name = "rightArrowButton";
            this.rightArrowButton.Size = new System.Drawing.Size(73, 69);
            this.rightArrowButton.TabIndex = 55;
            this.rightArrowButton.TabStop = false;
            this.rightArrowButton.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // leftArrowButton
            // 
            this.leftArrowButton.BackColor = System.Drawing.Color.Transparent;
            this.leftArrowButton.BackgroundImage = global::XMLWeather.Properties.Resources.arrow1;
            this.leftArrowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.leftArrowButton.Location = new System.Drawing.Point(8, 339);
            this.leftArrowButton.Name = "leftArrowButton";
            this.leftArrowButton.Size = new System.Drawing.Size(73, 69);
            this.leftArrowButton.TabIndex = 54;
            this.leftArrowButton.TabStop = false;
            this.leftArrowButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.weatherIconPictureBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.outputLabel2);
            this.Controls.Add(this.outputTitleLabel2);
            this.Controls.Add(this.outputLabel1);
            this.Controls.Add(this.outputTitleLabel1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.rightArrowButton);
            this.Controls.Add(this.leftArrowButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.todayButton);
            this.Controls.Add(this.dateOutput);
            this.Controls.Add(this.forecastButton);
            this.Controls.Add(this.locationOutput);
            this.Controls.Add(this.currentTempOutput);
            this.Controls.Add(this.underlineLabel);
            this.Controls.Add(this.boxLabel);
            this.Controls.Add(this.longOutputLabel2);
            this.Controls.Add(this.longOutputLabel1);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.cityComboBox);
            this.Font = new System.Drawing.Font("Aquire", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(375, 615);
            ((System.ComponentModel.ISupportInitialize)(this.weatherIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightArrowButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArrowButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label locationOutput;
        private System.Windows.Forms.Label currentTempOutput;
        private System.Windows.Forms.Label todayButton;
        private System.Windows.Forms.Label forecastButton;
        private System.Windows.Forms.Label dateOutput;
        private System.Windows.Forms.Label underlineLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox leftArrowButton;
        private System.Windows.Forms.PictureBox rightArrowButton;
        private System.Windows.Forms.Label outputTitleLabel2;
        private System.Windows.Forms.Label outputTitleLabel1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label outputLabel1;
        private System.Windows.Forms.Label outputLabel2;
        private System.Windows.Forms.Label boxLabel;
        private System.Windows.Forms.Label longOutputLabel1;
        private System.Windows.Forms.Label longOutputLabel2;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.PictureBox searchButton;
        private System.Windows.Forms.PictureBox weatherIconPictureBox;
        private System.Diagnostics.EventLog eventLog1;
    }
}
