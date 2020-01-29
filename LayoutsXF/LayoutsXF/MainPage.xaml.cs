using LayoutsXF.Views.Absolute;
using LayoutsXF.Views.Grid;
using LayoutsXF.Views.Relative;
using LayoutsXF.Views.Scroll;
using LayoutsXF.Views.Stack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutsXF
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GoToStackPage(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new StackPage());
        }

        private void GoToScrollPage(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new ScrollPage());
        }

        private void GoToRelativePage(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new RelativePage());
        }

        private void GoToGridPage(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new GridPage());
        }

        private void GoToAbsolutePage(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new AbsolutePage());
        }
    }
}
