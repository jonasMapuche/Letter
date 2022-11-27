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

        int count = 0;
        void Button_Clicked(object sender, System.EventArgs e)
        {
            count++;
            String abstrato = _grammar.GetSentenceSimple("lesson " + count);
            ((Button)sender).Text = $"You clicked {count} lesson, sentence simple: " + abstrato;
            List<Aula> aula = _lettersService.GetAll();
            if (count >= aula.Count) count = 0;
        }
    }

}
