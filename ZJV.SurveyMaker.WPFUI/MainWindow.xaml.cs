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
using ZJV.SurveyMaker.Utils;

namespace ZJV.SurveyMaker.WPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Question> questions;
        Question question;
        List<ucAnswer> answers = new List<ucAnswer>();

        public MainWindow()
        {
            InitializeComponent();
            Reload();
        }

        private void Reload()
        {
            cboQuestions.ItemsSource = null;
            questions = QuestionManager.Load();
            cboQuestions.ItemsSource = questions;

            cboQuestions.DisplayMemberPath = "Text";
            cboQuestions.SelectedValuePath = "Id";
            cboQuestions.SelectedIndex = 0;
        }

        private void cboQuestions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cboQuestions.SelectedIndex > -1)question = questions[cboQuestions.SelectedIndex];
            DrawScreen();
        }
        public void DrawScreen()
        {
            if (answers.Count > 0) answers.ForEach(a=> grdAnswers.Children.Remove(a));
            answers.Clear();
            question.Answers.ForEach(a => answers.Add(new ucAnswer(a, question)));
            double left = -50;
            double top = -100;

            while(answers.Count < 3)
            {
                answers.Add(new ucAnswer());
            }
            foreach(ucAnswer answer in answers)
            {
                answer.Margin = new Thickness(left, top, 0, 0);
                grdAnswers.Children.Add(answer);
                top += 50;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            QuestionAnswerManager.Delete(question.Id);
            answers.ForEach(a => {
                if(a.AnswerId != null)QuestionAnswerManager.Insert(question.Id, (Guid)a.AnswerId, (bool)a.isChecked);
            });
            Reload();
        }

        private void btnNewQuestion_Click(object sender, RoutedEventArgs e)
        {
            EditAttribute editAttribute = new EditAttribute(Mode.Question);
            editAttribute.ShowDialog();
            Reload();
        }

        private void btnNewAnswer_Click(object sender, RoutedEventArgs e)
        {
            EditAttribute editAttribute = new EditAttribute(Mode.Answer);
            editAttribute.ShowDialog();
            Reload();

        }
    }
}
