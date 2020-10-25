using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZJV.SurveyMaker.BL.Models;

namespace ZJV.SurveyMaker.Utils
{
    public partial class ucQuizzer : UserControl
    {
        Activation activation;
        Answer answer;
        Question question;
        public ucQuizzer()
        {
            InitializeComponent();
            Reload();
        }
        public ucQuizzer(Activation activation, Answer answer, Question question)
        {
            InitializeComponent();
            Reload();
        }

        private void Reload()
        {
            throw new NotImplementedException();
        }

        private void rbtnAnswer1_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnAnswer1.Checked==true)
            {
                
            }
        }
    }
}
