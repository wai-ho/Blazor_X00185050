using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using X00185050_CA3_Blazor.Models;

namespace X00185050_CA3_Blazor.Services
{
    public class WatchlistService
    {
        private List<int> watchlist = new();

        public void AddToWatchlist(int movieId)
        {
            if (!watchlist.Contains(movieId))
            {
                watchlist.Add(movieId);
            }
        }

        public void RemoveFromWatchlist(int movieId)
        {
            watchlist.Remove(movieId);
        }

        public List<int> GetWatchlist()
        {
            return watchlist;
        }
    }
}



