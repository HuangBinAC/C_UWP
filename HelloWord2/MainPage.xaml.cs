﻿using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HelloWord2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Crash(object sender, RoutedEventArgs e)
        {  
           throw new System.Exception("This is a test crash");  
        }

        private void Button_NewCrash(object sender, RoutedEventArgs e)
        {
            throw new System.Exception("a NewCrash");
        }


        private void Button_Analytics(object sender, RoutedEventArgs e)
        {
            Analytics.TrackEvent("Video clicked", new Dictionary<string, string> {
                { "Category", "Music" },
                { "FileName", "favorite.avi"},
                { "Game", "Call of Duty"},
                { "CarBrand", "Lexus"}
            });
        }

        private void Button_NewEvent(object sender, RoutedEventArgs e)
        {
            Analytics.TrackEvent("this is a new event", new Dictionary<string, string> {
                { "吉尔伽美什", "杂修" },
                { "拉美西斯二世", "哈哈哈哈哈"},
                { "基督山伯爵", "一起虎啊虎"}              
            });
        }
    }
}
