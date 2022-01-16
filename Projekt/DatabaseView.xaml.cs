﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Net.Http;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Newtonsoft.Json;



namespace Projekt
{
    /// <summary>
    /// Interaction logic for DatabaseView.xaml
    /// </summary>
    public partial class DatabaseView : Window
    {
        static string url = "";
        static HttpClient client = new HttpClient();
        static List<string> listam = new List<string>();
        static Szinek szinek = new Szinek();
        public DatabaseView()
        {

            InitializeComponent();
            


        }

        private async Task Kvizlistazas(string url)

        {
            //FORMÁZOTT JSON

            /*
            string valasz = await client.GetStringAsync(url);
            var adat = JsonConvert.DeserializeObject(valasz);
            var formazott = JsonConvert.SerializeObject(adat, Formatting.Indented);
            listam.Add(formazott);
            lista.Items.Add(listam[0]);
            */
            lista.Items.Clear();
            string valasz = await client.GetStringAsync(url);
            List<Quiz> quiz = JsonConvert.DeserializeObject<List<Quiz>>(valasz);
            foreach (var item in quiz)
            {
                lista.Items.Add(item);
            }
            


            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            //string valasz = await client.GetStringAsync(url);
            //valasz.Trim();
            //lista.Text = valasz[0].ToString();
            //listam.Add(valasz);
            //lista.Text = listam[0];
            //List<Quiz> quiz = JsonConvert.DeserializeObject<List<Quiz>>(valasz);
           
            /*foreach (Quiz item in quiz)
            {
                lista.Text = $"{item.Id}\t${item.Header}\t{item.Active}\t{item.Description}\t{item.SecondsPerQuiz}\n";
            }

            /*client.DefaultRequestHeaders.Add("charset", "utf8");
            string answer = await client.GetStringAsync(url);
            listaz.Text = answer[0].ToString();
            lista.Add(answer);
            listaz.Text = lista[0];
            */





        }


        private async Task Kerdeslistazas(string url)

        {
            lista.Items.Clear();
            string valasz = await client.GetStringAsync(url);
            List<Question> question = JsonConvert.DeserializeObject<List<Question>>(valasz);
            foreach (var item in question)
            {
                lista.Items.Add(item);
            }

            //FORMÁZOTT JSON
            /*
            string valasz = await client.GetStringAsync(url);
            var adat = JsonConvert.DeserializeObject(valasz);
            var formazott = JsonConvert.SerializeObject(adat, Formatting.Indented);
            listam.Add(formazott);
            lista.Items.Add(listam[0]);
            */


            // List<Question> questionLista = JsonConvert.DeserializeObject<List<Question>>(valasz);
            //lista.Items.Add(questionLista.Count);
            //lista.ItemsSource = JsonConvert.DeserializeObject<List<Question>>(valasz);
            /*foreach (var item in lista.ItemsSource)
            {
                lista.Items.Add(item);
            }
            /*var questionList = JsonConvert.DeserializeObject<IList<Question>>(valasz);
            foreach (var question in questionList)
            {
                lista.Text = $"{question.Id}\t{question.QuizId}\t{question.Content}\t{question.Point}";
            }
            */
            //valasz.Trim()
            //lista.Items.Add(valasz[0].ToString());
            //listam.Add(valasz);
            //lista.Items.Add(listam[0]);

            /*string valasz = await client.GetStringAsync(url);
            foreach (var kerdes in data.Adatok)
            {
                lista.Items.Add(kerdes);
            }
            */








        }

        private async Task Valaszlistazas(string url)

        {
            lista.Items.Clear();
            string valasz = await client.GetStringAsync(url);
            List<Answer> answer = JsonConvert.DeserializeObject<List<Answer>>(valasz);
            foreach (var item in answer)
            {
                lista.Items.Add(item);
            }

            //Formázott json
            /*string valasz = await client.GetStringAsync(url);
            var adat = JsonConvert.DeserializeObject(valasz);
            var formazott = JsonConvert.SerializeObject(adat, Formatting.Indented);
            listam.Add(formazott);
            lista.Items.Add(listam[0]);
            */




            //listam.Clear();
            //string valasz = await client.GetStringAsync(url);
            //valasz.Trim();
            //lista.Text = valasz[0].ToString();
            //listam.Add(valasz);
            //lista.Text = listam[0];
            /* string valasz = await client.GetStringAsync(url);
            ApiAnswer<Answer> data = JsonConvert.DeserializeObject<ApiAnswer<Answer>>(valasz);
            foreach (var valasza in data.Adatok)
            {
                lista.Items.Add(valasza);
            }
            */








        }

        private void QuizClick(object sender, RoutedEventArgs e)
        {
            Kvizlistazas("http://quizion.hu/api/quizes");
        }

        private void QuestionClick(object sender, RoutedEventArgs e)
        {
            Kerdeslistazas("http://quizion.hu/api/questions");
        }

        private void AnswerClick(object sender, RoutedEventArgs e)
        {
            Valaszlistazas("http://quizion.hu/api/answers");
        }

        private void AdminClick(object sender, RoutedEventArgs e)
        {

        }


    }
}
