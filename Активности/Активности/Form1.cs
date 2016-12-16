using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Активности
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Timer Timer1 = new Timer();
            Timer1.Interval = 1000;
            Timer1.Tick += new EventHandler(Timer1_Tick);
            Timer1.Enabled = true;
            _Init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Update();
        }

        private void _Init()
        {
            if (Properties.Settings.Default._FrUch == true)
                _FrUch.ForeColor = Color.Green;
            if (Properties.Settings.Default._FrSever == true)
                _FrSever.ForeColor = Color.Green;
            if (Properties.Settings.Default._FrBamb == true)
                _FrBamb.ForeColor = Color.Green;
            if (Properties.Settings.Default._FrSulan == true)
                _FrSulan.ForeColor = Color.Green;
            if (Properties.Settings.Default._FrKril == true)
                _FrKril.ForeColor = Color.Green;
            if (Properties.Settings.Default._FrGrib == true)
                _FrGrib.ForeColor = Color.Green;
            if (Properties.Settings.Default._FrFalm == true)
                _FrFalm.ForeColor = Color.Green;
            if (Properties.Settings.Default._FrMedv == true)
                _FrMedv.ForeColor = Color.Green;
            if (Properties.Settings.Default._FrVarv == true)
                _FrVarv.ForeColor = Color.Green;
            if (Properties.Settings.Default._ObGuild10 == true)
                _ObGuild10.ForeColor = Color.Green;
        }

        private void _Update()
        {
            _FrUch.ForeColor = Color.Red;
            Properties.Settings.Default._FrUch = false;
            _FrSever.ForeColor = Color.Red;
            Properties.Settings.Default._FrSever = false;
            _FrBamb.ForeColor = Color.Red;
            Properties.Settings.Default._FrBamb = false;
            _FrSulan.ForeColor = Color.Red;
            Properties.Settings.Default._FrSulan = false;
            _FrKril.ForeColor = Color.Red;
            Properties.Settings.Default._FrKril = false;
            _FrGrib.ForeColor = Color.Red;
            Properties.Settings.Default._FrGrib = false;
            _FrFalm.ForeColor = Color.Red;
            Properties.Settings.Default._FrFalm = false;
            _FrMedv.ForeColor = Color.Red;
            Properties.Settings.Default._FrMedv = false;
            _FrVarv.ForeColor = Color.Red;
            Properties.Settings.Default._FrVarv = false;
            _ObGuild10.ForeColor = Color.Red;
            Properties.Settings.Default._ObGuild10 = false;

            Properties.Settings.Default.Save();
        }

        private void Timer1_Tick(object Sender, EventArgs e)
        {
            TimeZoneInfo moscowTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Russian Standard Time");
            DateTime moscowDateTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, moscowTimeZone);
            if (moscowDateTime.TimeOfDay.Minutes > 10)
            {
                label2.Text = Convert.ToString(moscowDateTime.TimeOfDay.Hours) + ":" + Convert.ToString(moscowDateTime.TimeOfDay.Minutes);
            }
            else if ((moscowDateTime.TimeOfDay.Minutes > 0) && (moscowDateTime.TimeOfDay.Minutes < 10))
            {
                label2.Text = Convert.ToString(moscowDateTime.TimeOfDay.Hours) + ":0" + Convert.ToString(moscowDateTime.TimeOfDay.Minutes);
            }
            else
            {
                label2.Text = Convert.ToString(moscowDateTime.TimeOfDay.Hours) + ":00";
            }

            if ((moscowDateTime.TimeOfDay.Hours == 2) && (moscowDateTime.TimeOfDay.Minutes == 12) && (moscowDateTime.TimeOfDay.Seconds == 0))
            {
                MessageBox.Show("Все ежедневные квесты обновились!");
                _Update();
            }
        }

        private void _ObGuild10_Click(object sender, EventArgs e)
        {
            if (_ObGuild10.ForeColor == Color.Red)
            {
                _ObGuild10.ForeColor = Color.Green;
                Properties.Settings.Default._ObGuild10 = true;
            }
            else
            {
                _ObGuild10.ForeColor = Color.Red;
                Properties.Settings.Default._ObGuild10 = false;
            }
            Properties.Settings.Default.Save();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void _FrUch_Click(object sender, EventArgs e)
        {
            if (_FrUch.ForeColor == Color.Red)
            {
                _FrUch.ForeColor = Color.Green;
                Properties.Settings.Default._FrUch = true;
            }
            else
            {
                _FrUch.ForeColor = Color.Red;
                Properties.Settings.Default._FrUch = false;
            }
            Properties.Settings.Default.Save();
        }

        private void _FrSever_Click(object sender, EventArgs e)
        {
            if (_FrSever.ForeColor == Color.Red)
            {
                _FrSever.ForeColor = Color.Green;
                Properties.Settings.Default._FrSever = true;
            }
            else
            {
                _FrSever.ForeColor = Color.Red;
                Properties.Settings.Default._FrSever = false;
            }
            Properties.Settings.Default.Save();
        }

        private void _FrBamb_Click(object sender, EventArgs e)
        {
            if (_FrBamb.ForeColor == Color.Red)
            {
                _FrBamb.ForeColor = Color.Green;
                Properties.Settings.Default._FrBamb = true;
            }
            else
            {
                _FrBamb.ForeColor = Color.Red;
                Properties.Settings.Default._FrBamb = false;
            }
            Properties.Settings.Default.Save();
        }

        private void _FrSulan_Click(object sender, EventArgs e)
        {
            if (_FrSulan.ForeColor == Color.Red)
            {
                _FrSulan.ForeColor = Color.Green;
                Properties.Settings.Default._FrSulan = true;
            }
            else
            {
                _FrSulan.ForeColor = Color.Red;
                Properties.Settings.Default._FrSulan = false;
            }
            Properties.Settings.Default.Save();
        }

        private void _FrKril_Click(object sender, EventArgs e)
        {
            if (_FrKril.ForeColor == Color.Red)
            {
                _FrKril.ForeColor = Color.Green;
                Properties.Settings.Default._FrKril = true;
            }
            else
            {
                _FrKril.ForeColor = Color.Red;
                Properties.Settings.Default._FrKril = false;
            }
            Properties.Settings.Default.Save();
        }

        private void _FrGrib_Click(object sender, EventArgs e)
        {
            if (_FrGrib.ForeColor == Color.Red)
            {
                _FrGrib.ForeColor = Color.Green;
                Properties.Settings.Default._FrGrib = true;
            }
            else
            {
                _FrGrib.ForeColor = Color.Red;
                Properties.Settings.Default._FrGrib = false;
            }
            Properties.Settings.Default.Save();
        }

        private void _FrFalm_Click(object sender, EventArgs e)
        {
            if (_FrFalm.ForeColor == Color.Red)
            {
                _FrFalm.ForeColor = Color.Green;
                Properties.Settings.Default._FrFalm = true;
            }
            else
            {
                _FrFalm.ForeColor = Color.Red;
                Properties.Settings.Default._FrFalm = false;
            }
            Properties.Settings.Default.Save();
        }

        private void _FrMedv_Click(object sender, EventArgs e)
        {
            if (_FrMedv.ForeColor == Color.Red)
            {
                _FrMedv.ForeColor = Color.Green;
                Properties.Settings.Default._FrMedv = true;
            }
            else
            {
                _FrMedv.ForeColor = Color.Red;
                Properties.Settings.Default._FrMedv = false;
            }
            Properties.Settings.Default.Save();
        }

        private void _FrVarv_Click(object sender, EventArgs e)
        {
            if (_FrVarv.ForeColor == Color.Red)
            {
                _FrVarv.ForeColor = Color.Green;
                Properties.Settings.Default._FrVarv = true;
            }
            else
            {
                _FrVarv.ForeColor = Color.Red;
                Properties.Settings.Default._FrVarv = false;
            }
            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
