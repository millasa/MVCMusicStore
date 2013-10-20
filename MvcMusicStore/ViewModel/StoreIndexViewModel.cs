using MvcMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.ViewModels
{
    public class StoreIndexViewModel
    {
        public int NumberOfGenres { get; set; }
        public Genre Genres { get; set; }
    }
}