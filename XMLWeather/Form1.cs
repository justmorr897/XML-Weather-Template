using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        //list to hold day objects
        public static List<Day> days = new List<Day>();
        public static List<string> countryNames = new List<string>();
        public static List<string> countryShortcuts = new List<string>();

        public static string city = "Stratford";
        public static string country = "CA";

        public static string oldCity = "Stratford";
        public static string oldCountry = "CA";

        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();

            if (days[0].weatherNumber.StartsWith("2"))
            {
                this.Icon = Properties.Resources.thunderstormIcon;
            }
            else if (days[0].weatherNumber.StartsWith("3"))
            {
                this.Icon = Properties.Resources.RainingIcon;
            }
            else if (days[0].weatherNumber.StartsWith("5"))
            {
                this.Icon = Properties.Resources.PrecipitationIcon;
            }
            else if (days[0].weatherNumber.StartsWith("6"))
            {
                this.Icon = Properties.Resources.snowIcon;
            }
            else if (days[0].weatherNumber.StartsWith("8") && (days[0].weatherNumber.EndsWith("0") || days[0].weatherNumber.EndsWith("1")))
            {
                this.Icon = Properties.Resources.sunnyIcon;
            }
            else if (days[0].weatherNumber.StartsWith("8") && (days[0].weatherNumber.EndsWith("3") || days[0].weatherNumber.EndsWith("4") || days[0].weatherNumber.EndsWith("2")))
            {
                this.Icon = Properties.Resources.cloudySunnyIcon;
            }
            else if(DateTime.Now.Hour > 8)
            {
                this.Icon = Properties.Resources.nightIcon;
            }

            string country;
            string code;


            XmlReader reader = XmlReader.Create("https://gist.githubusercontent.com/nathanhornby/4727009/raw/86eea19828e19455fe4082a989521f32f7006e9a/XML%2520Country%2520List");

            while (reader.Read())
            {
                for(int i = 0; i < 237; i++)
                {
                    reader.ReadToFollowing("country");
                    code = reader.GetAttribute("code");
                    country = reader.ReadElementContentAsString().ToLower();

                    if(code != null)
                    {
                        countryShortcuts.Add(code);
                    }
                    if (country != null)
                    {
                        countryNames.Add(country);
                    }
                }

                reader.Close();
             
            }

            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        public static void ExtractForecast()
        {
            XmlReader reader;
            try
            {
                reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/forecast/daily?q={city},{country}&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");
            }
            catch 
            {
                reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/forecast/daily?q={oldCity},{oldCountry}&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");
            }

            int timeshift = 0;

            reader.ReadToFollowing("timezone");
            string timeshiftS = reader.ReadString();

            if (timeshiftS != "")
            {
                timeshift = int.Parse(timeshiftS);
            }

            while (reader.Read())
            {
                Day day = new Day();

                //fill day object with required data
                reader.ReadToFollowing("time");
                day.date = Convert.ToDateTime(reader.GetAttribute("day")).ToString("MMMM dd, yyy");
                day.dayOfWeek = Convert.ToDateTime(reader.GetAttribute("day")).ToString("dddd");

                reader.ReadToFollowing("sun");
                day.sunrise = reader.GetAttribute("rise");
                day.sunset = reader.GetAttribute("set");

                int hours;

                if (day.sunrise != null)
                {
                    int riseIndex = day.sunrise.IndexOf("T");
                    day.sunrise = day.sunrise.Substring(riseIndex + 1, day.sunrise.Length - riseIndex - 1);

                    int seconds = (60 * 60 * int.Parse(day.sunrise.Substring(0, 2))) +
                        (60 * int.Parse(day.sunrise.Substring(3, 2))) +
                        (int.Parse(day.sunrise.Substring(6, 2)));

                    if (seconds + timeshift < 0)
                    {
                        seconds = 86400 + seconds + timeshift;
                    }
                    else if (seconds + timeshift > 86400)
                    {
                        seconds = seconds + timeshift - 86400;
                    }
                    else
                    {
                        seconds = seconds + timeshift;
                    }

                    TimeSpan timespan = TimeSpan.FromSeconds(seconds);
                    day.sunrise = timespan.ToString();

                    if (day.sunrise.StartsWith("0"))
                    {
                        day.sunrise = day.sunrise.Substring(1, day.sunrise.Length - 4);
                    }
                    else
                    {
                        day.sunrise = day.sunrise.Substring(0, day.sunrise.Length - 3);
                    }

                    if (day.sunrise[1].ToString() != ":")
                    {
                        hours = int.Parse(day.sunrise.Substring(0, 2));

                        if (hours > 12)
                        {
                            hours = hours - 12;
                        }

                        day.sunrise = hours.ToString() + day.sunrise.Substring(2);
                    }
                }

                if (day.sunset != null)
                {
                    int setIndex = day.sunset.IndexOf("T");
                    day.sunset = day.sunset.Substring(setIndex + 1, day.sunset.Length - setIndex - 1);

                    int seconds = (60 * 60 * int.Parse(day.sunset.Substring(0, 2))) +
                        (60 * int.Parse(day.sunset.Substring(3, 2))) +
                        (int.Parse(day.sunset.Substring(6, 2)));

                    if (seconds + timeshift < 0)
                    {
                        seconds = 86400 + seconds + timeshift;
                    }
                    else if (seconds + timeshift > 86400)
                    {
                        seconds = seconds + timeshift - 86400;
                    }
                    else
                    {
                        seconds = seconds + timeshift;
                    }

                    TimeSpan timespan = TimeSpan.FromSeconds(seconds);
                    day.sunset = timespan.ToString();

                    if (day.sunset.StartsWith("0"))
                    {
                        day.sunset = day.sunset.Substring(1, day.sunset.Length - 4);
                    }
                    else
                    {
                        day.sunset = day.sunset.Substring(0, day.sunset.Length - 3);
                    }

                    if (day.sunset[1].ToString() != ":")
                    {
                        hours = int.Parse(day.sunset.Substring(0, 2));

                        if (hours > 12)
                        {
                            hours = hours - 12;
                        }

                        day.sunset = hours.ToString() + day.sunset.Substring(2);
                    }
                }

                reader.ReadToFollowing("symbol");
                day.weatherNumber = reader.GetAttribute("number");
                day.weatherName = reader.GetAttribute("name");

                reader.ReadToFollowing("precipitation");
                day.precipitation = reader.GetAttribute("probability");

                if(day.precipitation != null)
                {
                    if (day.precipitation.StartsWith("1"))
                    {
                        day.precipitation = "100";
                    }
                    else if (day.precipitation == "0")
                    {

                    }
                    else
                    {
                        day.precipitation = (Convert.ToDecimal(day.precipitation) * 100).ToString();
                        day.precipitation = day.precipitation.Substring(0, 2);
                    }
                }

                reader.ReadToFollowing("windDirection");
                day.windDirection = reader.GetAttribute("name");

                reader.ReadToFollowing("windSpeed");
                day.windSpeed = reader.GetAttribute("mps");

                reader.ReadToFollowing("temperature");
                day.tempLow = reader.GetAttribute("min");
                day.tempHigh = reader.GetAttribute("max");

                reader.ReadToFollowing("pressure");
                day.pressure = reader.GetAttribute("value") + " " + reader.GetAttribute("unit");

                reader.ReadToFollowing("humidity");
                day.humidity = reader.GetAttribute("value") + reader.GetAttribute("unit");

                reader.ReadToFollowing("clouds");
                day.cloudsValue = reader.GetAttribute("value");
                day.cloudsPercent = reader.GetAttribute("all");

                //If day object not null add to the days list
                if (day.date != null)
                {
                    days.Add(day);
                }
            }

            reader.Close();
        }

        public static void ExtractCurrent()
        {
            XmlReader reader;
            try
            {
                CurrentScreen.hasFailed = false;

                // current info is not included in forecast file so we need to use this file to get it
                reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/weather?q={city},{country}&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");
                reader.ReadToFollowing("city");
                days[0].location = reader.GetAttribute("name") + ", " + country;


                reader.ReadToFollowing("temperature");
                days[0].currentTemp = reader.GetAttribute("value");

                oldCity = city;
                oldCountry = country;
            }
            catch
            {
                CurrentScreen.hasFailed = true;

                reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/weather?q={oldCity},{oldCountry}&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");
                reader.ReadToFollowing("city");
                days[0].location = reader.GetAttribute("name") + ", " + oldCountry;

                reader.ReadToFollowing("temperature");
                days[0].currentTemp = reader.GetAttribute("value");
            }
        }
    }
}
