using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using VoshodWEB.ViewModels;
using VoshodWEB.Models;
using VoshodWEB.Dependencies;
namespace VoshodWEB
{
    public partial class MusicPage : ContentPage
    {
        public MusicViewModel ViewModel { get; set; }
        private readonly IPlatformInfo _platformInfo;
        public MusicPage(MusicModel model)
        {
            InitializeComponent();
            _platformInfo = DependencyService.Get<IPlatformInfo>();
            this.BindingContext = ViewModel = new MusicViewModel(model);
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
#pragma warning disable
            Device.OpenUri(new Uri($"https://yandex.ru/search/?lr=210&text={(sender as Label).Text.Replace(" ", "_")}&clid=1"));
        }

        private void videoPlayer_Playing(object sender, Octane.Xamarin.Forms.VideoPlayer.Events.VideoPlayerEventArgs e)
        {
            ViewModel.Duration = e.Duration;
            VisualStateManager.GoToState(frame, "Loaded");
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            if (videoPlayer.State == Octane.Xamarin.Forms.VideoPlayer.Constants.PlayerState.Playing)
            {
                (sender as ImageButton).Source = ImageSource.FromResource("VoshodWEB.Images.play.png");
            }
            else
            {
                (sender as ImageButton).Source = ImageSource.FromResource("VoshodWEB.Images.pause.png");
            }
        }

        private void TextView_Touched(object sender, EventArgs e)
        {
            view.Text = _platformInfo.GetData();
        }
    }
}
