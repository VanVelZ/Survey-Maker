using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ZJV.SurveyMaker.BL;
using ZJV.SurveyMaker.BL.Models;

namespace ZJV.SurveyMaker.Utils
{
    /// <summary>
    /// Interaction logic for ucAnswer.xaml
    /// </summary>
    public partial class ucAnswer : UserControl
    {
        List<Answer> answers;
        Question question;
        public ucAnswer()
        {
            InitializeComponent();
            Reload();

        }
        public ucAnswer(Answer answer, Question question)
        {
            InitializeComponent();
            Reload();
            cboAnswers.SelectedValue = answer.Id;
            rdoIsCorrect.IsChecked = answer.IsCorrect;
            this.question = question;

        }
        public void Reload()
        {
            cboAnswers.ItemsSource = null;
            answers = AnswerManager.Load();
            cboAnswers.ItemsSource = answers;
            cboAnswers.DisplayMemberPath = "Text";
            cboAnswers.SelectedValuePath = "Id";
            cboAnswers.SelectedIndex = 0;
        }
        public Guid? AnswerId
        {
            get { return (Guid)cboAnswers?.SelectedValue; }
        }
        public string AttributeText
        {
            get { return cboAnswers?.Text; }
        }
        public bool? isChecked
        {
            get { return (bool)rdoIsCorrect?.IsChecked; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(cboAnswers.SelectedIndex > -1) QuestionAnswerManager.Delete(question.Id, answers[cboAnswers.SelectedIndex].Id);
            question.Answers.Remove(answers[cboAnswers.SelectedIndex]);
            Reload();
        }

        private void rdoIsCorrect_Checked(object sender, RoutedEventArgs e)
        {
            answers[cboAnswers.SelectedIndex].IsCorrect = true;
        }

        private void rdoIsCorrect_Unchecked(object sender, RoutedEventArgs e)
        {
            answers[cboAnswers.SelectedIndex].IsCorrect = false;
        }

        private void cboAnswers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
