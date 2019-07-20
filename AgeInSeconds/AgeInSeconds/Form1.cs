using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeInSeconds
{
    
    public partial class AgerForm : Form
    {
        private void InitCustom()
        {
            this.Age.MaxDate = DateTime.Now;
        }

        public AgerForm()
        {
            InitializeComponent();
            InitCustom();
        }

        private void AgerForm_Load(object sender, EventArgs e)
        {

        }

        private void Age_ValueChanged(object sender, EventArgs e)
        {
            int Years = DateTime.Now.Year - Age.Value.Year;
            int Months = DateTime.Now.Month - Age.Value.Month;
            int Days = DateTime.Now.Day - Age.Value.Day;

            int output = ConvertDateToSeconds.ConvertYear(Years) + ConvertDateToSeconds.ConvertMonth(Months) + ConvertDateToSeconds.ConvertDay(Days);
            Seconds.Text = output.ToString();
        }
    }

    class ConvertDateToSeconds
    {
        public static int ConvertMinute(int Minute)
        {
            return Minute * 60;
        }

        public static int ConvertHour(int Hour)
        {
            return ConvertMinute(60) * Hour;
        }

        public static int ConvertDay(int Day)
        {
            return ConvertHour(24) * Day;
        }

        public static int ConvertWeek(int Week)
        {
            return ConvertDay(7) * Week;
        }

        public static int ConvertMonth(int Month)
        {
            return (ConvertWeek(4) + ConvertDay(2)) * Month;
        }

        public static int ConvertYear(int Year)
        {
            return ConvertMonth(12) * Year;
        }
    }
}
