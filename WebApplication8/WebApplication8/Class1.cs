using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace WebApplication8
{
    public class WeekDay
    {
        public Label[] l_name = new Label[5];
        private string empty_str = " ";
        //public WeekDay() { for (int i = 0; i < 5; i++) { l_name[i] = new Label(); l_name[i].Text = Convert.ToString(i); } }
        public WeekDay() { for (int i = 0; i < 5; i++) { l_name[i] = new Label(); l_name[i].Text = empty_str; } }
        public WeekDay(string str)
        { 
            l_name[0] = new Label(); l_name[0].Text = "Diapers replacing";
            l_name[1] = new Label(); l_name[1].Text = "Tiptoeing";
            l_name[2] = new Label(); l_name[2].Text = "Hygiene";
            l_name[3] = new Label(); l_name[3].Text = " ";
            l_name[4] = new Label(); l_name[4].Text = " ";
        }

        public int AvailableLesson()
        {
            int av_less = -1;
            for (int i = 0; i < 5; i++)
            {
                if (l_name[i].Text == empty_str)
                {
                    av_less = i;
                    break;
                }
            }
            return av_less;
        }

        public int LastLesson()
        {
            int last_lesson = 0;
            for (int i = 4; i >= 0; i--)
            {
                if (l_name[i].Text != empty_str)
                {
                    last_lesson = i;
                    break;
                }
            }
            return last_lesson;
        }

        public void AppendLesson(string str1)
        {
            int i = 0;
            i = this.AvailableLesson();
            this.l_name[i].Text = str1;
        }

        public void DeleteLesson()
        {
            int i = 0;
            i = this.LastLesson();
            this.l_name[i].Text = empty_str;
        }
    }
}