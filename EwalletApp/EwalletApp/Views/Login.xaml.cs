﻿using EwalletApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EwalletApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        LoginVM _vM;
        public Login(LoginVM vM)
        {
            InitializeComponent();
            BindingContext = _vM = vM;
        }
    }
}