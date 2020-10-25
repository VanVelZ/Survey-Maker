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
    public enum Mode
    {
        Question, Answer
    }
    public partial class EditAttribute : Window
    {
        Mode mode;
        List<Question> questions;
        List<Answer> answers;

        public EditAttribute(Mode mode)
        {
            InitializeComponent();
            this.mode = mode;
            string title = mode.ToString() + "s";
            lblEnter.Content = "Manage " + title;
            Title = title;
            Reload();
        }

        private void Reload()
        {
            try
            {
                txtAttribute.Text = string.Empty;
                cboAttribute.ItemsSource = null;
                switch (mode)
                {
                    case Mode.Answer:
                        answers = AnswerManager.Load();
                        cboAttribute.ItemsSource = answers;
                        break;
                    case Mode.Question:
                        questions = QuestionManager.Load();
                        cboAttribute.ItemsSource = questions;
                        break;
                }

                cboAttribute.DisplayMemberPath = "Text";
                cboAttribute.SelectedValuePath = "Id";
            }


            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (mode)
                {
                    case Mode.Answer:
                        AnswerManager.Insert(new Answer { Text = txtAttribute.Text });
                        break;
                    case Mode.Question:
                        QuestionManager.Insert(new Question { Text = txtAttribute.Text });
                        break;
                }

                Reload();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (mode)
                {
                    case Mode.Answer:
                        answers[cboAttribute.SelectedIndex].Text = txtAttribute.Text;
                        AnswerManager.Update(answers[cboAttribute.SelectedIndex]);
                        break;
                    case Mode.Question:
                        answers[cboAttribute.SelectedIndex].Text = txtAttribute.Text;
                        QuestionManager.Update(questions[cboAttribute.SelectedIndex]);
                        break;
                }
                Reload();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (mode)
                {
                    case Mode.Answer:
                        AnswerManager.Delete(answers[cboAttribute.SelectedIndex].Id);
                        break;
                    case Mode.Question:
                        QuestionManager.Delete(questions[cboAttribute.SelectedIndex].Id);
                        break;
                }
                Reload();

            }
            catch (Exception)
            {
                MessageBox.Show("This is required for an existing question. Unpair to delete");
            }

        }

        private void cboAttribute_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (cboAttribute.SelectedIndex > -1)
                {
                    switch (mode)
                    {
                        case Mode.Answer:
                            txtAttribute.Text = answers[cboAttribute.SelectedIndex].Text;
                            break;
                        case Mode.Question:
                            txtAttribute.Text = questions[cboAttribute.SelectedIndex].Text;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
