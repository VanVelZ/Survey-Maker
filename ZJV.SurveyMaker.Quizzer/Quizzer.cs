using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using ZJV.SurveyMaker.BL;
using ZJV.SurveyMaker.Utils;
using ZJV.SurveyMaker.BL.Models;

namespace ZJV.SurveyMaker.Quizzer
{
    public partial class Quizzer : Form
    {
        List<Answer> answers;
        List<Question> questions;
        Question question;
        List<Activation> activations;
        //I swear I know how to spell response. For whatever reason, using http breaks the variable if it's named "response"
        Response respons;
        public Quizzer()
        {
            InitializeComponent();
        }
        private void Quizzer_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void Reload()
        {
            //Declare api
            HttpClient client = InitializeClient();
            HttpResponseMessage httpResponse;
            string result;
            dynamic items;

            //Fill activation list
            httpResponse = client.GetAsync("Activation").Result;
            result = httpResponse.Content.ReadAsStringAsync().Result;
            activations = JsonConvert.DeserializeObject<List<Activation>>(result);

            //Add code for custom control
        }

        private static HttpClient InitializeClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44377/api/");
            return client;
        }
        private void txtActivationCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (question != null)
            {

                respons = new Response();

                if (rbtnAnswer1.Checked) respons.AnswerId = question.Answers[0].Id;
                else if (rbtnAnswer2.Checked) respons.AnswerId = question.Answers[1].Id;
                else if (rbtnAnswer3.Checked) respons.AnswerId = question.Answers[2].Id;

                respons.QuestionId = question.Id;
                respons.ResponseDate = DateTime.Now;

                HttpClient client = InitializeClient();
                string serializedResponse = JsonConvert.SerializeObject(respons);
                var content = new StringContent(serializedResponse);
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                HttpResponseMessage response = client.PostAsync("Response", content).Result;
                btnClear_Click(sender, e);
                lblQuestionInfo.Text = "Thank you for submitting";

            }
            else
            {
                System.Windows.MessageBox.Show("Please use the activation code to start a survey");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblQuestionInfo.Text = string.Empty;
            lblAnswer1.Text = string.Empty;
            lblAnswer2.Text = string.Empty;
            lblAnswer3.Text = string.Empty;

        }

        private void txtActivationCode_Leave(object sender, EventArgs e)
        {
            Reload();
            Activation activation = activations.FirstOrDefault(a => a.ActivationCode == txtActivationCode.Text);
            if (activation != null)
            {
                if (activation.EndDate > DateTime.Now)
                {
                    //Declare api
                    HttpClient client = InitializeClient();
                    HttpResponseMessage httpResponse;
                    string result;
                    dynamic items;

                    //Fill question
                    httpResponse = client.GetAsync("Question").Result;
                    result = httpResponse.Content.ReadAsStringAsync().Result;
                    questions = JsonConvert.DeserializeObject<List<Question>>(result);
                    question = questions.FirstOrDefault(q => q.Id == activation.QuestionId);
                    lblQuestionInfo.Text = question.Text;
                    lblAnswer1.Text = question.Answers[0].Text;
                    lblAnswer2.Text = question.Answers[1].Text;
                    lblAnswer3.Text = question.Answers[2].Text;
                }
                else
                {
                    btnClear_Click(sender, e);
                    lblQuestionInfo.Text = "This survey is over";
                }
            }
            else
            {
                btnClear_Click(sender, e);
                lblQuestionInfo.Text = "Question not found";
            }
        }

        private void txtActivationCode_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtActivationCode_Leave(sender, e);
            }
        }
    }
}
