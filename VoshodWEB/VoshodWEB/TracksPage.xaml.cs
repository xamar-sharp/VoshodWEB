using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoshodWEB.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using VoshodWEB.Services;
using System.Windows.Input;
namespace VoshodWEB
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TracksPage : ContentPage
    {
        public ObservableCollection<MusicViewModel> Musics { get; set; }
        public ICommand GetTracksCommand { get; set; }
        public ICommand SearchTrackCommand { get; set; }
        public ICommand ItemSelectedCommand { get; set; }
        public TracksPage()
        {
            Musics = new ObservableCollection<MusicViewModel>(Array.Empty<MusicViewModel>().ToList());
            InitializeComponent();
            GetTracksCommand = new Command(async (obj) =>
            {
                (obj as RefreshView).IsRefreshing = true;
                Musics.Clear();
                var musics = await RestAPI.GetTracks();
                if (musics == Array.Empty<Models.MusicModel>())
                {
                    (obj as RefreshView).IsRefreshing = false;
                    await DisplayAlert(Resource.Title, Resource.Error, Resource.Cancel);
                }
                else
                {
                    foreach (var el in musics)
                    {
                        Musics.Add(new MusicViewModel(el));
                    }
                (obj as RefreshView).IsRefreshing = false;
                }
            });
            SearchTrackCommand = new Command(async (obj) =>
            {
                await Navigation.PushAsync(new MusicPage(RestAPI.GetTrack(obj as string)));
            });
            ItemSelectedCommand = new Command(async (obj) =>
            {
                await Navigation.PushAsync(new MusicPage((obj as MusicViewModel).ToModel()));
            });
            this.BindingContext = this;
        }
        protected override void OnAppearing()
        {
            GetTracksCommand.Execute(refresh);
        }
    }
}