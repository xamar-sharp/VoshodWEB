using System;
using System.Collections.Generic;
using System.Text;

namespace VoshodWEB.Models
{
    public sealed class MusicModel
    {
        public string Title { get; set; }
        public string Source { get; set; }
        public bool FromNetwork { get => true; }
    }
}
