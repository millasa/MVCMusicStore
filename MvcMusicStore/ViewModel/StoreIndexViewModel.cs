using MvcMusicStore.Models;

namespace MvcMusicStore.ViewModels
{
    public class StoreIndexViewModel
    {
        public int NumberOfGenres { get; set; }
        public Genre Genres { get; set; }
    }
}