namespace XMLWeather
{
    partial class ForecastScreen
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
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.outputLabel2 = new System.Windows.Forms.Label();
            this.outputTitleLabel2 = new System.Windows.Forms.Label();
            this.outputLabel1 = new System.Windows.Forms.Label();
            this.outputTitleLabel1 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.boxLabel = new System.Windows.Forms.Label();
            this.longOutputLabel2 = new System.Windows.Forms.Label();
            this.longOutputLabel1 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dayOfWeekLabel = new System.Windows.Forms.Label();
            this.outputLabel4 = new System.Windows.Forms.Label();
            this.weatherIconPictureBox = new System.Windows.Forms.PictureBox();
            this.rightArrow = new System.Windows.Forms.PictureBox();
            this.leftArrow = new System.Windows.Forms.PictureBox();
            this.searchButton = new System.Windows.Forms.PictureBox();
            this.locationOutput = new System.Windows.Forms.Label();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.topBackgroundLabel = new System.Windows.Forms.Label();
            this.bottomBackgroundLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            this.SuspendLayout();
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Aquire", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(212, 15);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(115, 41);
            this.forecastLabel.TabIndex = 62;
            this.forecastLabel.Text = "WEEK";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Aquire", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 41);
            this.label3.TabIndex = 61;
            this.label3.Text = "Today";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(129, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 27);
            this.label5.TabIndex = 63;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(190, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 42);
            this.label1.TabIndex = 70;
            this.label1.Text = "____________________________";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // outputLabel2
            // 
            this.outputLabel2.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel2.Font = new System.Drawing.Font("Aquire", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel2.ForeColor = System.Drawing.Color.White;
            this.outputLabel2.Location = new System.Drawing.Point(199, 237);
            this.outputLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLabel2.Name = "outputLabel2";
            this.outputLabel2.Size = new System.Drawing.Size(61, 50);
            this.outputLabel2.TabIndex = 78;
            this.outputLabel2.Text = "20";
            this.outputLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // outputTitleLabel2
            // 
            this.outputTitleLabel2.AutoSize = true;
            this.outputTitleLabel2.BackColor = System.Drawing.Color.Transparent;
            this.outputTitleLabel2.Font = new System.Drawing.Font("Aquire", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTitleLabel2.ForeColor = System.Drawing.Color.White;
            this.outputTitleLabel2.Location = new System.Drawing.Point(201, 288);
            this.outputTitleLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputTitleLabel2.Name = "outputTitleLabel2";
            this.outputTitleLabel2.Size = new System.Drawing.Size(63, 24);
            this.outputTitleLabel2.TabIndex = 77;
            this.outputTitleLabel2.Text = "max";
            // 
            // outputLabel1
            // 
            this.outputLabel1.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel1.Font = new System.Drawing.Font("Aquire", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel1.ForeColor = System.Drawing.Color.White;
            this.outputLabel1.Location = new System.Drawing.Point(104, 237);
            this.outputLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLabel1.Name = "outputLabel1";
            this.outputLabel1.Size = new System.Drawing.Size(72, 50);
            this.outputLabel1.TabIndex = 76;
            this.outputLabel1.Text = "10";
            this.outputLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // outputTitleLabel1
            // 
            this.outputTitleLabel1.AutoSize = true;
            this.outputTitleLabel1.BackColor = System.Drawing.Color.Transparent;
            this.outputTitleLabel1.Font = new System.Drawing.Font("Aquire", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTitleLabel1.ForeColor = System.Drawing.Color.White;
            this.outputTitleLabel1.Location = new System.Drawing.Point(111, 288);
            this.outputTitleLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputTitleLabel1.Name = "outputTitleLabel1";
            this.outputTitleLabel1.Size = new System.Drawing.Size(47, 24);
            this.outputTitleLabel1.TabIndex = 75;
            this.outputTitleLabel1.Text = "min";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Aquire", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(111, 187);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(157, 20);
            this.titleLabel.TabIndex = 74;
            this.titleLabel.Text = "temperature";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // boxLabel
            // 
            this.boxLabel.BackColor = System.Drawing.Color.Transparent;
            this.boxLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.boxLabel.Location = new System.Drawing.Point(88, 169);
            this.boxLabel.Name = "boxLabel";
            this.boxLabel.Size = new System.Drawing.Size(200, 326);
            this.boxLabel.TabIndex = 79;
            // 
            // longOutputLabel2
            // 
            this.longOutputLabel2.BackColor = System.Drawing.Color.Transparent;
            this.longOutputLabel2.Font = new System.Drawing.Font("Aquire", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longOutputLabel2.ForeColor = System.Drawing.Color.White;
            this.longOutputLabel2.Location = new System.Drawing.Point(104, 282);
            this.longOutputLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.longOutputLabel2.Name = "longOutputLabel2";
            this.longOutputLabel2.Size = new System.Drawing.Size(164, 50);
            this.longOutputLabel2.TabIndex = 81;
            this.longOutputLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // longOutputLabel1
            // 
            this.longOutputLabel1.BackColor = System.Drawing.Color.Transparent;
            this.longOutputLabel1.Font = new System.Drawing.Font("Aquire", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longOutputLabel1.ForeColor = System.Drawing.Color.White;
            this.longOutputLabel1.Location = new System.Drawing.Point(109, 232);
            this.longOutputLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.longOutputLabel1.Name = "longOutputLabel1";
            this.longOutputLabel1.Size = new System.Drawing.Size(164, 50);
            this.longOutputLabel1.TabIndex = 80;
            this.longOutputLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Aquire", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(7, 511);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(358, 36);
            this.dateLabel.TabIndex = 82;
            this.dateLabel.Text = "Date";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayOfWeekLabel
            // 
            this.dayOfWeekLabel.BackColor = System.Drawing.Color.Transparent;
            this.dayOfWeekLabel.Font = new System.Drawing.Font("Aquire", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayOfWeekLabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.dayOfWeekLabel.Location = new System.Drawing.Point(7, 547);
            this.dayOfWeekLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dayOfWeekLabel.Name = "dayOfWeekLabel";
            this.dayOfWeekLabel.Size = new System.Drawing.Size(358, 36);
            this.dayOfWeekLabel.TabIndex = 83;
            this.dayOfWeekLabel.Text = "Day Of Week";
            this.dayOfWeekLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputLabel4
            // 
            this.outputLabel4.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel4.Font = new System.Drawing.Font("Aquire", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel4.ForeColor = System.Drawing.Color.White;
            this.outputLabel4.Location = new System.Drawing.Point(107, 423);
            this.outputLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLabel4.Name = "outputLabel4";
            this.outputLabel4.Size = new System.Drawing.Size(164, 60);
            this.outputLabel4.TabIndex = 86;
            this.outputLabel4.Text = "weather";
            this.outputLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // weatherIconPictureBox
            // 
            this.weatherIconPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.weatherIconPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weatherIconPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weatherIconPictureBox.Location = new System.Drawing.Point(148, 331);
            this.weatherIconPictureBox.Name = "weatherIconPictureBox";
            this.weatherIconPictureBox.Size = new System.Drawing.Size(80, 80);
            this.weatherIconPictureBox.TabIndex = 87;
            this.weatherIconPictureBox.TabStop = false;
            // 
            // rightArrow
            // 
            this.rightArrow.BackColor = System.Drawing.Color.Transparent;
            this.rightArrow.BackgroundImage = global::XMLWeather.Properties.Resources.arrow2;
            this.rightArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rightArrow.Location = new System.Drawing.Point(299, 293);
            this.rightArrow.Name = "rightArrow";
            this.rightArrow.Size = new System.Drawing.Size(73, 69);
            this.rightArrow.TabIndex = 73;
            this.rightArrow.TabStop = false;
            this.rightArrow.Click += new System.EventHandler(this.rightArrow_Click);
            // 
            // leftArrow
            // 
            this.leftArrow.BackColor = System.Drawing.Color.Transparent;
            this.leftArrow.BackgroundImage = global::XMLWeather.Properties.Resources.arrow1;
            this.leftArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.leftArrow.Location = new System.Drawing.Point(3, 293);
            this.leftArrow.Name = "leftArrow";
            this.leftArrow.Size = new System.Drawing.Size(73, 69);
            this.leftArrow.TabIndex = 72;
            this.leftArrow.TabStop = false;
            this.leftArrow.Click += new System.EventHandler(this.leftArrow_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.BackgroundImage = global::XMLWeather.Properties.Resources.magnifying_removebg_preview;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.Location = new System.Drawing.Point(16, 106);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(32, 32);
            this.searchButton.TabIndex = 94;
            this.searchButton.TabStop = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            this.searchButton.MouseEnter += new System.EventHandler(this.searchButton_MouseEnter_1);
            this.searchButton.MouseLeave += new System.EventHandler(this.searchButton_MouseLeave_1);
            // 
            // locationOutput
            // 
            this.locationOutput.BackColor = System.Drawing.Color.Transparent;
            this.locationOutput.Font = new System.Drawing.Font("Aquire", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationOutput.ForeColor = System.Drawing.Color.White;
            this.locationOutput.Location = new System.Drawing.Point(7, 102);
            this.locationOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locationOutput.Name = "locationOutput";
            this.locationOutput.Size = new System.Drawing.Size(360, 48);
            this.locationOutput.TabIndex = 88;
            this.locationOutput.Text = "City";
            this.locationOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // countryComboBox
            // 
            this.countryComboBox.Font = new System.Drawing.Font("Aquire", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(205, 107);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(157, 32);
            this.countryComboBox.TabIndex = 93;
            this.countryComboBox.Text = "Country";
            this.countryComboBox.DropDown += new System.EventHandler(this.countryComboBox_DropDown);
            this.countryComboBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.countryComboBox_PreviewKeyDown);
            // 
            // cityComboBox
            // 
            this.cityComboBox.Font = new System.Drawing.Font("Aquire", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(55, 107);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(144, 32);
            this.cityComboBox.TabIndex = 92;
            this.cityComboBox.Text = "City";
            this.cityComboBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cityComboBox_PreviewKeyDown);
            // 
            // topBackgroundLabel
            // 
            this.topBackgroundLabel.BackColor = System.Drawing.Color.Black;
            this.topBackgroundLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.topBackgroundLabel.Location = new System.Drawing.Point(5, 85);
            this.topBackgroundLabel.Name = "topBackgroundLabel";
            this.topBackgroundLabel.Size = new System.Drawing.Size(365, 71);
            this.topBackgroundLabel.TabIndex = 95;
            // 
            // bottomBackgroundLabel
            // 
            this.bottomBackgroundLabel.BackColor = System.Drawing.Color.Black;
            this.bottomBackgroundLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bottomBackgroundLabel.Location = new System.Drawing.Point(5, 505);
            this.bottomBackgroundLabel.Name = "bottomBackgroundLabel";
            this.bottomBackgroundLabel.Size = new System.Drawing.Size(365, 88);
            this.bottomBackgroundLabel.TabIndex = 96;
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.locationOutput);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.weatherIconPictureBox);
            this.Controls.Add(this.outputLabel4);
            this.Controls.Add(this.dayOfWeekLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.outputLabel2);
            this.Controls.Add(this.outputTitleLabel2);
            this.Controls.Add(this.outputLabel1);
            this.Controls.Add(this.outputTitleLabel1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.rightArrow);
            this.Controls.Add(this.leftArrow);
            this.Controls.Add(this.boxLabel);
            this.Controls.Add(this.longOutputLabel2);
            this.Controls.Add(this.longOutputLabel1);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.topBackgroundLabel);
            this.Controls.Add(this.bottomBackgroundLabel);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(375, 615);
            ((System.ComponentModel.ISupportInitialize)(this.weatherIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outputLabel2;
        private System.Windows.Forms.Label outputTitleLabel2;
        private System.Windows.Forms.Label outputLabel1;
        private System.Windows.Forms.Label outputTitleLabel1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox rightArrow;
        private System.Windows.Forms.PictureBox leftArrow;
        private System.Windows.Forms.Label boxLabel;
        private System.Windows.Forms.Label longOutputLabel2;
        private System.Windows.Forms.Label longOutputLabel1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label dayOfWeekLabel;
        private System.Windows.Forms.Label outputLabel4;
        private System.Windows.Forms.PictureBox weatherIconPictureBox;
        private System.Windows.Forms.PictureBox searchButton;
        private System.Windows.Forms.Label locationOutput;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.Label topBackgroundLabel;
        private System.Windows.Forms.Label bottomBackgroundLabel;
    }
}
