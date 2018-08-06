using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;

namespace SignaturePadUsingXamarinForms
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void SaveBtn_Clicked(object sender, EventArgs e)
        {
            Stream image = await MainSignaturePad.GetImageStreamAsync(SignaturePad.Forms.SignatureImageFormat.Jpeg);
        }

        private void ClearBtn_Clicked(object sender, EventArgs e)
        {
            MainSignaturePad.Clear();
        }
    }
}

