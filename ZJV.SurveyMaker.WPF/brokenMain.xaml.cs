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

namespace ZJV.SurveyMaker.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class brokenMain : Window
    {
        List<Question> questions;
        Question question;
        List<ucAnswer> answers;

        public brokenMain()
        {
            InitializeComponent();
            Reload();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

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
        private void DrawScreen()
        {

        }
    }
}
