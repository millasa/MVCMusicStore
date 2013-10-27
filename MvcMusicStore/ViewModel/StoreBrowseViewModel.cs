using System.Collections.Generic;
using MvcMusicStore.Models;

namespace MvcMusicStore.ViewModel
{
    public class StoreBrowseViewModel
    {
        public Genre Genre { get; set; } 
        public List<Album> Albums { get; set; }
    }
}