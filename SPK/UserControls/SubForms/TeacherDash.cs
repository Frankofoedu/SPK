﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPK.UserControls.Panels;

namespace SPK.UserControls.SubForms
{
    public partial class TeacherDash : UserControl
    {
        private Image _ProfilePic { get; set; } //= Properties.Resources.command;
        private string _School { get; set; } = "SCHOOL NAME";
        private string _Session { get; set; } = "Third Term - 2017/2018 Session";
        string _userType = "";


        public Image ProfilePic
        {
            get { return _ProfilePic; }
            set
            {
                _ProfilePic = value;
                NotifyPropertyChanged("ProfilePic");
            }
        }

        public string School
        {
            get { return _School; }
            set
            {
                _School = value;
                NotifyPropertyChanged("School");
            }
        }

        public string Session
        {
            get { return _Session; }
            set
            {
                _Session = value;
                NotifyPropertyChanged("Session");
            }
        }
        
        private void NotifyPropertyChanged(string Property)
        {
            switch (Property)
            {
                case "ProfilePic":
                    picSchoolLogo.Image = _ProfilePic;
                    break;

                case "School":
                    lblSchool.Text = _School;
                    break;

                case "Session":
                    lblTermNSession.Text = _Session;
                    break;

                default:
                    break;
            }
        }

        public TeacherDash()
        {
            InitializeComponent();
        }

        private void panProfileCover_MouseHover(object sender, EventArgs e)
        {
            var pan = (ExtendedPanel)sender;
            var ctrl = pan.Parent;
            ctrl.ForeColor = Color.FromArgb(0, 125, 113);
        }

        private void panProfileCover_MouseLeave(object sender, EventArgs e)
        {
            var pan = (ExtendedPanel)sender;
            var ctrl = pan.Parent;
            ctrl.ForeColor = Color.FromArgb(0, 150, 136);
        }

        private void showUserControl(Control ctrl)
        {
            Parent.Controls.Add(ctrl);
            Dispose();
        }

        private void panProfileCover_Click(object sender, EventArgs e)
        {
            showUserControl(new TeacherProfile());
        }

        private void panStudentCover_Click(object sender, EventArgs e)
        {
            showUserControl(new uploadBehaviouralAnalysis());
        }

        private void panClassCover_Click(object sender, EventArgs e)
        {
            showUserControl(new ViewAttendance());
        }

        private void panViewStudent_Click(object sender, EventArgs e)
        {
            showUserControl(new ViewRegisteredStudent());
        }

        private void PanSubjectCover_Click(object sender, EventArgs e)
        {
            showUserControl(new RegisterSubject());
        }

        private void panResultCover_Click(object sender, EventArgs e)
        {
            showUserControl(new EnterStudentResult());
        }
    }
}
