using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using System.Windows.Input;
using VoshodWEB.Models;
using Octane.Xamarin.Forms.VideoPlayer;
using VoshodWEB.Services;
namespace VoshodWEB.ViewModels
{
    public sealed class MusicViewModel:INotifyPropertyChanged
    {
        private readonly MusicModel _model;
        private TimeSpan _duration = TimeSpan.FromSeconds(1);
        public string Title { get { return _model.Title; } set { } }
        public VideoSource Source
        {
            get
            {
                var prop = RestAPI._apiIP + _model.Source;
                return _model.FromNetwork ? VideoSource.FromUri(prop) : VideoSource.FromFile(_model.Source);
            }
            set
            {
                
            }
        }
        public TimeSpan Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                if (Duration.Seconds == 1)
                {
                    _duration = value;
                    OnPropertyChanged();
                }
            }
        }
        public ICommand PlayAndPauseCommand { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public MusicViewModel(MusicModel model)
        {
            _model = model;
            PlayAndPauseCommand = new Command((obj) =>
            {
                if((obj as VideoPlayer).State == Octane.Xamarin.Forms.VideoPlayer.Constants.PlayerState.Playing)
                {
                    (obj as VideoPlayer).Pause();
                }
                else
                {
                    (obj as VideoPlayer).Play();
                }
            }, (obj) => obj is VideoPlayer);
        }
        public MusicModel ToModel()
        {
            return _model;
        }
        public void OnPropertyChanged([CallerMemberName]string name = default)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
