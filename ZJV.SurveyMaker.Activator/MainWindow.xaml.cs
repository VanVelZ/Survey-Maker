using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using ZJV.SurveyMaker.BL.Models;

namespace ZJV.SurveyMaker.Activator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Question> questions;
        Question question;
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private static HttpClient InitializeClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44377/api/");
            return client;
        }

        private void Reload()
        {
            ClearFields();
            HttpClient client = InitializeClient();
            HttpResponseMessage response;
            string result;
            dynamic items;

            //call the api
            response = client.GetAsync("Question").Result;
            result = response.Content.ReadAsStringAsync().Result;
            items = (JArray)JsonConvert.DeserializeObject(result);
            questions = items.ToObject<List<Question>>();

            cboQuestion.ItemsSource = null;
            cboQuestion.ItemsSource = questions;
            cboQuestion.DisplayMemberPath = "Text";
            cboQuestion.SelectedValuePath = "Id";

        }
        public void ClearFields()
        {
            txtCode.Text = string.Empty;
            dateStart.SelectedDate = DateTime.Now;
            dateEnd.SelectedDate = DateTime.Now;
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Reload();
        }

        private void cboQuestion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ClearFields();
            if (cboQuestion.SelectedIndex > -1)
            {
                question = questions[cboQuestion.SelectedIndex];
                if (question.Activator != null)
                {
                    dateStart.SelectedDate = question.Activator.StartDate;
                    dateEnd.SelectedDate = question.Activator.EndDate;
                    txtCode.Text = question.Activator.ActivationCode;
                }
                else
                {
                    dateStart.SelectedDate = DateTime.Now;
                }
            }
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (question.Activator == null)
                {
                    question.Activator = new Activation();
                    question.Activator.StartDate = dateStart.SelectedDate.Value;
                    question.Activator.EndDate = dateEnd.SelectedDate.Value;
                    question.Activator.ActivationCode = txtCode.Text;
                    question.Activator.QuestionId = question.Id;

                    HttpClient client = InitializeClient();
                    string serializedActivation = JsonConvert.SerializeObject(question.Activator);
                    var content = new StringContent(serializedActivation);
                    content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    HttpResponseMessage response = client.PostAsync("Activation", content).Result;

                    Reload();
                }
                else
                {
                    btnUpdate_Click(sender, e);
                }
            
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            question.Activator.StartDate = dateStart.SelectedDate.Value;
            question.Activator.EndDate = dateEnd.SelectedDate.Value;
            question.Activator.ActivationCode = txtCode.Text;

            HttpClient client = InitializeClient();
            string serializedActivation = JsonConvert.SerializeObject(question.Activator);
            var content = new StringContent(serializedActivation);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = client.PostAsync("Activation/" + question.Activator.Id, content).Result;
            Reload();


        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            HttpClient client = InitializeClient();
            HttpResponseMessage response = client.DeleteAsync("Activation/" + question.Activator.Id).Result;
            Reload();

        }
    }
}
