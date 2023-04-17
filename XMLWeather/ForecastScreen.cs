using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        Bitmap sunnyImage = new Bitmap(Properties.Resources.sunny);
        Bitmap nightImage = new Bitmap(Properties.Resources.night);
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
        Bitmap cloudyNightIcon = new Bitmap(Properties.Resources.cloudyNight_removebg_preview);
        Bitmap snowIcon = new Bitmap(Properties.Resources.snow_removebg_preview);
        Bitmap windIcon = new Bitmap(Properties.Resources.wind);
        Bitmap rainIcon = new Bitmap(Properties.Resources.Raining_removebg_preview);
        Bitmap precipitationIcon = new Bitmap(Properties.Resources.Precipitation_removebg_preview);
        Bitmap thunderstormIcon = new Bitmap(Properties.Resources.thunderstorm_removebg_preview);

        int index = 0;
        int clickCounter = 0;


        public ForecastScreen()
        {
            InitializeComponent();

            int rgb = 50;
            boxLabel.BackColor = Color.FromArgb(200, rgb, rgb, rgb);
            outputLabel1.BackColor = Color.FromArgb(200, rgb, rgb, rgb);
            outputLabel2.BackColor = Color.FromArgb(200, rgb, rgb, rgb);
            outputLabel4.BackColor = Color.FromArgb(200, rgb, rgb, rgb);
            outputTitleLabel1.BackColor = Color.FromArgb(200, rgb, rgb, rgb);
            outputTitleLabel2.BackColor = Color.FromArgb(200, rgb, rgb, rgb);
            titleLabel.BackColor = Color.FromArgb(200, rgb, rgb, rgb);
            weatherIconPictureBox.BackColor = Color.FromArgb(100, rgb / 2, rgb / 2, rgb / 3);
            topBackgroundLabel.BackColor = Color.FromArgb(200, rgb, rgb, rgb);
            bottomBackgroundLabel.BackColor = Color.FromArgb(200, rgb, rgb, rgb);
            searchButton.BackColor = Color.FromArgb(100, rgb / 2, rgb / 2, rgb / 3);
            locationOutput.BackColor = Color.FromArgb(200, rgb, rgb, rgb);
            dayOfWeekLabel.BackColor = Color.FromArgb(200, rgb, rgb, rgb);
            dateLabel.BackColor = Color.FromArgb(200, rgb, rgb, rgb);

            displayForecast();
        }
        public void displayForecast()
        {
            Print(0);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void rightArrow_Click(object sender, EventArgs e)
        {
            if (index < 6)
            {
                index++;
                Print(index);
            }
        }

        private void leftArrow_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                Print(index);
            }
        }

        public void Print(int _index)
        {
            locationOutput.Text = Form1.days[0].location;

            outputLabel4.Text = Form1.days[_index].weatherName;

            if (Form1.days[_index].weatherNumber.StartsWith("2"))
            {
                weatherIconPictureBox.BackgroundImage = thunderstormIcon;
                this.BackgroundImage = ThunderstormImage2;
            }
            else if (Form1.days[_index].weatherNumber.StartsWith("3"))
            {
                weatherIconPictureBox.BackgroundImage = rainIcon;
                this.BackgroundImage = rainImage4;
            }
            else if (Form1.days[_index].weatherNumber.StartsWith("5"))
            {
                weatherIconPictureBox.BackgroundImage = precipitationIcon;
                this.BackgroundImage = rainImage4;
            }
            else if (Form1.days[_index].weatherNumber.StartsWith("6"))
            {
                weatherIconPictureBox.BackgroundImage = snowIcon;
                this.BackgroundImage = snowImage;
            }
            else if (Form1.days[_index].weatherNumber.StartsWith("7"))
            {
                weatherIconPictureBox.BackgroundImage = windIcon;
                this.BackgroundImage = windIcon;
            }
            else if (Form1.days[_index].weatherNumber.StartsWith("8") && (Form1.days[0].weatherNumber.EndsWith("0") || Form1.days[0].weatherNumber.EndsWith("1")))
            {
                weatherIconPictureBox.BackgroundImage = sunnyIcon;
                this.BackgroundImage = sunnyImage;
            }
            else if (Form1.days[_index].weatherNumber.StartsWith("8") && (Form1.days[0].weatherNumber.EndsWith("3") || Form1.days[0].weatherNumber.EndsWith("4") || Form1.days[0].weatherNumber.EndsWith("2")))
            {
                weatherIconPictureBox.BackgroundImage = cloudySunnyIcon;
                this.BackgroundImage = lakeImage;
            }

            dateLabel.Text = Form1.days[_index].date;
            dayOfWeekLabel.Text = Form1.days[_index].dayOfWeek;

            #region High and Low Temps
            decimal tempLow = Math.Round(Convert.ToDecimal(Form1.days[_index].tempLow), 0);
            decimal tempHigh = Math.Round(Convert.ToDecimal(Form1.days[_index].tempHigh), 0);

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
            #endregion
        }

        private void cityComboBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && cityComboBox.Text != "")
            {
                countryComboBox.Focus();
            }
        }

        private void countryComboBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && countryComboBox.Text != "")
            {
                Form1.oldCity = Form1.city;
                Form1.oldCountry = Form1.country;

                Form1.country = countryComboBox.Text.ToUpper();
                Form1.city = cityComboBox.Text;

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

                Print(0);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
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

        private void searchButton_MouseEnter_1(object sender, EventArgs e)
        {
            searchButton.BorderStyle = BorderStyle.FixedSingle;
        }

        private void searchButton_MouseLeave_1(object sender, EventArgs e)
        {
            searchButton.BorderStyle = BorderStyle.None;
        }

        private void countryComboBox_DropDown(object sender, EventArgs e)
        {
            //for(int i = 0; i < Form1.countryNames.Count; i++)
            //{

            //}
        }
    }
}
