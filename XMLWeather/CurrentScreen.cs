using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        Bitmap sunnyImage = new Bitmap(Properties.Resources.sunny);
        //Bitmap nightImage = new Bitmap(Properties.Resources.night);
        Bitmap mountainImage = new Bitmap(Properties.Resources.mountain);
        Bitmap lakeImage = new Bitmap(Properties.Resources.lake);
        Bitmap ThunderstormImage1 = new Bitmap(Properties.Resources.lightning1);
        Bitmap ThunderstormImage2 = new Bitmap(Properties.Resources.lightning2);
        Bitmap rainImage1 = new Bitmap(Properties.Resources.rain1);
        Bitmap rainImage2 = new Bitmap(Properties.Resources.rain2);
        Bitmap rainImage3 = new Bitmap(Properties.Resources.rain4);
        Bitmap rainImage4 = new Bitmap(Properties.Resources.rain5);
        Bitmap rainImage5 = new Bitmap(Properties.Resources.rain6);
        Bitmap snowImage = new Bitmap(Properties.Resources.snow);

        Bitmap sunnyIcon = new Bitmap(Properties.Resources.sunny_removebg_preview);
        Bitmap cloudySunnyIcon = new Bitmap(Properties.Resources.cloudySunny_removebg_preview);
        Bitmap nightIcon = new Bitmap(Properties.Resources.night);
        Bitmap snowIcon = new Bitmap(Properties.Resources.snow_removebg_preview);
        Bitmap windIcon = new Bitmap(Properties.Resources.wind);
        Bitmap rainIcon = new Bitmap(Properties.Resources.Raining_removebg_preview);
        Bitmap precipitationIcon = new Bitmap(Properties.Resources.Precipitation_removebg_preview);
        Bitmap thunderstormIcon = new Bitmap(Properties.Resources.thunderstorm_removebg_preview);

        Stopwatch stopwatch = new Stopwatch();

        public static int page = 0;
        int clickCounter = 0;

        public static bool hasFailed = false;

        public CurrentScreen()
        {
            InitializeComponent();

            int rgb = 50;
            boxLabel.BackColor = Color.FromArgb(200, rgb, rgb, rgb);
            outputLabel1.BackColor = Color.FromArgb(200, rgb, rgb, rgb);
            outputLabel2.BackColor = Color.FromArgb(200, rgb, rgb, rgb);
            outputTitleLabel1.BackColor = Color.FromArgb(200, rgb, rgb, rgb);
            outputTitleLabel2.BackColor = Color.FromArgb(200, rgb, rgb, rgb);
            titleLabel.BackColor = Color.FromArgb(200, rgb, rgb, rgb);
            longOutputLabel1.BackColor = Color.FromArgb(200, rgb, rgb, rgb);
            longOutputLabel2.BackColor = Color.FromArgb(200, rgb, rgb, rgb);
            weatherIconPictureBox.BackColor = Color.FromArgb(100, rgb / 2, rgb / 2, rgb / 2);

            countryComboBox.DropDownWidth *= 2;

            for (int i = 0; i < Form1.countryNames.Count; i++)
            {
                countryComboBox.Items.Add(Form1.countryNames[i]);
            }

            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            locationOutput.Text = Form1.days[0].location;

            dateOutput.Text = Form1.days[0].date;

            #region Current Temp
            double temp = Math.Round(Convert.ToDouble(Form1.days[0].currentTemp));

            if (temp > 20)
            {
                currentTempOutput.ForeColor = Color.Red;
            }
            else if (temp < 10)
            {
                currentTempOutput.ForeColor = Color.Blue;
            }
            else if (temp < 0)
            {
                currentTempOutput.ForeColor = Color.LightBlue;
            }
            else
            {
                currentTempOutput.ForeColor = Color.Yellow;
            }

            currentTempOutput.Text = $"{temp}°C";
            #endregion

            page = 0;
            Print();
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (page < 7)
            {
                page++;

            }

            Print();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (page > 0)
            {
                page--;
            }
            Print();
        }

        public void Print()
        {
            ClearLabels();

            if (Form1.days.Count > 0)
            {
                if (Form1.days[0].weatherNumber.StartsWith("2"))
                {
                    weatherIconPictureBox.BackgroundImage = thunderstormIcon;
                    this.BackgroundImage = ThunderstormImage2;
                }
                else if (Form1.days[0].weatherNumber.StartsWith("3"))
                {
                    weatherIconPictureBox.BackgroundImage = rainIcon;
                    this.BackgroundImage = rainImage4;
                }
                else if (Form1.days[0].weatherNumber.StartsWith("5"))
                {
                    weatherIconPictureBox.BackgroundImage = precipitationIcon;
                    this.BackgroundImage = rainImage4;

                    dateOutput.ForeColor = Color.Yellow;
                    locationOutput.ForeColor = Color.Black;
                    todayButton.ForeColor = Color.Black;
                    forecastButton.ForeColor = Color.Black;
                    underlineLabel.ForeColor = Color.Black;
                }
                else if (Form1.days[0].weatherNumber.StartsWith("6"))
                {
                    weatherIconPictureBox.BackgroundImage = snowIcon;
                    this.BackgroundImage = snowImage;
                }
                else if (Form1.days[0].weatherNumber.StartsWith("7"))
                {
                    weatherIconPictureBox.BackgroundImage = windIcon;
                    this.BackgroundImage = windIcon;
                }
                else if (Form1.days[0].weatherNumber.StartsWith("8") && (Form1.days[0].weatherNumber.EndsWith("0") || Form1.days[0].weatherNumber.EndsWith("1")))
                {
                    weatherIconPictureBox.BackgroundImage = sunnyIcon;
                    this.BackgroundImage = sunnyImage;
                }
                else if (Form1.days[0].weatherNumber.StartsWith("8") && (Form1.days[0].weatherNumber.EndsWith("3") || Form1.days[0].weatherNumber.EndsWith("4") || Form1.days[0].weatherNumber.EndsWith("2")))
                {
                    weatherIconPictureBox.BackgroundImage = cloudySunnyIcon;
                    this.BackgroundImage = lakeImage;

                    dateOutput.ForeColor = Color.White;
                    locationOutput.ForeColor = Color.White;
                    todayButton.ForeColor = Color.White;
                    forecastButton.ForeColor = Color.White;
                    underlineLabel.ForeColor = Color.White;
                }

                if (page == 0)
                {
                    longOutputLabel1.SendToBack();
                    longOutputLabel2.SendToBack();

                    titleLabel.Text = "Temperature";

                    #region Min and Max Temps
                    decimal tempLow = Math.Round(Convert.ToDecimal(Form1.days[0].tempLow), 0);
                    decimal tempHigh = Math.Round(Convert.ToDecimal(Form1.days[0].tempHigh), 0);

                    outputLabel1.Text = $"{tempLow}";
                    outputLabel2.Text = $"{tempHigh}";

                    Color lowTextColor = new Color();
                    Color highTextColor = new Color();

                    if (Convert.ToInt16(tempLow) > 30 && Convert.ToInt16(tempLow) <= 35)
                    {
                        lowTextColor = Color.FromArgb(255, 255, 0, 0);
                    }
                    else if (Convert.ToInt16(tempLow) > 20 && Convert.ToInt16(tempLow) <= 30)
                    {
                        lowTextColor = Color.FromArgb(255, 240, 5, 5);
                    }
                    else if (Convert.ToInt16(tempLow) > 10 && Convert.ToInt16(tempLow) <= 20)
                    {
                        lowTextColor = Color.FromArgb(255, 254, 240, 1);
                    }
                    else if (Convert.ToInt16(tempLow) >= 5 && Convert.ToInt16(tempLow) <= 10)
                    {
                        lowTextColor = Color.FromArgb(255, 101, 155, 223);
                    }
                    else if (Convert.ToInt16(tempLow) <= 5)
                    {
                        lowTextColor = Color.FromArgb(255, 150, 240, 255);
                    }

                    if (Convert.ToInt16(tempHigh) > 30 && Convert.ToInt16(tempHigh) <= 35)
                    {
                        highTextColor = Color.FromArgb(255, 255, 0, 0);
                    }
                    else if (Convert.ToInt16(tempHigh) > 20 && Convert.ToInt16(tempHigh) <= 30)
                    {
                        highTextColor = Color.FromArgb(255, 240, 5, 5);
                    }
                    else if (Convert.ToInt16(tempHigh) > 10 && Convert.ToInt16(tempHigh) <= 20)
                    {
                        highTextColor = Color.FromArgb(255, 254, 240, 1);
                    }
                    else if (Convert.ToInt16(tempHigh) >= 5 && Convert.ToInt16(tempHigh) <= 10)
                    {
                        highTextColor = Color.FromArgb(255, 101, 155, 223);
                    }
                    else if (Convert.ToInt16(tempHigh) <= 5)
                    {
                        highTextColor = Color.FromArgb(255, 150, 240, 255);
                    }

                    outputLabel1.ForeColor = lowTextColor;
                    outputLabel2.ForeColor = highTextColor;
                    outputTitleLabel1.Text = "Min";
                    outputTitleLabel2.Text = "Max";
                    #endregion
                }
                else if (page == 1)
                {
                    longOutputLabel1.BringToFront();
                    longOutputLabel2.BringToFront();
                    titleLabel.Text = "Weather";

                    longOutputLabel1.Font = new Font("Aquire", 11);
                    longOutputLabel1.Text = Form1.days[0].weatherName;
                }
                else if (page == 2)
                {
                    titleLabel.Text = "Wind";

                    weatherIconPictureBox.BackgroundImage = windIcon;

                    longOutputLabel1.Text = $"{Math.Round(Convert.ToDecimal(Form1.days[0].windSpeed))} m/s";
                    longOutputLabel2.Text = $"{Form1.days[0].windDirection}";
                }
                else if (page == 3)
                {
                    weatherIconPictureBox.BackgroundImage = sunnyIcon;

                    longOutputLabel1.Text = Form1.days[0].sunrise + " AM";
                    titleLabel.Text = "Sunrise";
                }
                else if (page == 4)
                {
                    weatherIconPictureBox.BackgroundImage = cloudySunnyIcon;

                    longOutputLabel1.Text = Form1.days[0].sunset + " PM";
                    titleLabel.Text = "Sunset";
                }
                else if (page == 5)
                {
                    weatherIconPictureBox.BackgroundImage = precipitationIcon;

                    titleLabel.Text = "Precipitation";
                    longOutputLabel1.Text = Form1.days[0].precipitation + "%";

                    progressBar.Visible = true;
                    progressBar.BringToFront();
                    progressBar.Value = Convert.ToInt16(Form1.days[0].precipitation);
                }
                else if (page == 6)
                {
                    weatherIconPictureBox.BackgroundImage = windIcon;

                    titleLabel.Text = "Pressure";
                    longOutputLabel1.Text = Form1.days[0].pressure;
                }
                else if (page == 7)
                {
                    weatherIconPictureBox.BackgroundImage = cloudySunnyIcon;

                    titleLabel.Text = "Clouds";

                    longOutputLabel1.Font = new Font("Aquire", 12);
                    longOutputLabel1.Text = Form1.days[0].cloudsValue;
                    longOutputLabel2.Text = Form1.days[0].cloudsPercent + "%";

                    progressBar.Visible = true;
                    progressBar.Location = new Point(progressBar.Location.X, 465);
                    progressBar.Value = Convert.ToInt16(Form1.days[0].cloudsPercent);
                }
            }
        }

        public void ClearLabels()
        {
            titleLabel.Text = "";
            outputTitleLabel1.Text = "";
            outputTitleLabel2.Text = "";
            outputLabel1.Text = "";
            outputLabel2.Text = "";
            longOutputLabel1.Text = "";
            longOutputLabel2.Text = "";
            progressBar.Visible = false;
            longOutputLabel1.Font = new Font("Aquire", 18);
            progressBar.Location = new Point(110, 440);
            longOutputLabel1.Location = new Point(longOutputLabel1.Location.X, 357);
        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            clickCounter++;
            if (clickCounter % 2 == 0)
            {
                locationOutput.Visible = true;
                cityComboBox.Visible = false;
                countryComboBox.Visible = false;
                cityComboBox.SendToBack();
                countryComboBox.SendToBack();
            }
            else
            {
                locationOutput.Visible = false;
                cityComboBox.Visible = true;
                countryComboBox.Visible = true;

                cityComboBox.BringToFront();
                countryComboBox.BringToFront();

                cityComboBox.Focus();
            }
        }
        private void searchCityComboBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && cityComboBox.Text != "")
            {
                countryComboBox.Focus();
                countryComboBox.Text = "";
            }
        }
        private void searchComboBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && countryComboBox.Text != "")
            {
                Form1.country = countryComboBox.Text.ToLower();
                Form1.city = cityComboBox.Text;

                int index;

                if (Form1.countryNames.Contains(Form1.country))
                {
                    index = Form1.countryNames.FindIndex(x => x.Equals(Form1.country));
                    Form1.country = Form1.countryShortcuts[index];
                }

                countryComboBox.Text = "";
                cityComboBox.Text = "";

                countryComboBox.Visible = false;
                cityComboBox.Visible = false;
                locationOutput.Visible = true;

                countryComboBox.SendToBack();
                cityComboBox.SendToBack();

                Form1.days.Clear();

                Form1.ExtractForecast();
                Form1.ExtractCurrent();
                DisplayCurrent();

                if (hasFailed)
                {
                    stopwatch.Restart();
                    stopwatch.Start();

                    locationOutput.ForeColor = Color.Red;
                    locationOutput.Text = "Search Failed";
                    Refresh();

                    while (stopwatch.ElapsedMilliseconds < 1000)
                    {

                    }

                    locationOutput.ForeColor = Color.White;
                    locationOutput.Text = Form1.days[0].location;
                }

                page = 0;
                Print();
            }
        }
        private void searchButton_MouseEnter(object sender, EventArgs e)
        {
            searchButton.BorderStyle = BorderStyle.FixedSingle;
        }
        private void searchButton_MouseLeave(object sender, EventArgs e)
        {
            searchButton.BorderStyle = BorderStyle.None;
        }

        private void countryComboBox_Enter(object sender, EventArgs e)
        {
            //countryComboBox.DroppedDown = true;
        }

        private void countryComboBox_TextChanged(object sender, EventArgs e)
        {
            countryComboBox.DroppedDown = true;
        }
    }
}
