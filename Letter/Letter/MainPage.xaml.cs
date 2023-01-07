using Letter.Controllers;
using Letter.Models;
using Letter.Services;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Letter
{
    public partial class MainPage : ContentPage
    {
        public static readonly LetterService _lettersService = new LetterService();
        public static readonly Grammar _grammar = new Grammar();
        public static readonly VersionService _version = new VersionService();

        public MainPage()
        {
            InitializeComponent();
        }

        int count_exit = 0;
        int lesson_number = 0;
        void Button_Clicked(object sender, System.EventArgs e)
        {
            String abstrato, lesson;
            do {
                lesson_number++;    
                lesson = "lesson " + lesson_number;
                abstrato = _grammar.GetSentenceSimple(lesson);
            } while (abstrato == null);
            count_exit++;
            ((Button)sender).Text = $"You clicked " + lesson + ", sentence simple: " + abstrato;
            List<Aula> aula = _lettersService.GetAll();
            if (count_exit >= aula.Count) {
                count_exit = 0;
                lesson_number = 0;
            }
        }
    }

}
