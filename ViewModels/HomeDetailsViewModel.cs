using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodFIghtAdmin.Models;

namespace FoodFIghtAdmin.ViewModels
{
    public class HomeDetailsViewModel
    {
        public IQueryable<User> Users { get; set; }
        public IQueryable<Restaurant> Restaurants { get; set; }
        public IQueryable<MatchSession> MatchSessions { get; set; }

        public int UCount { get; set; }
        public int RCount { get; set; }
        public int MsCount { get; set; }

        public HomeDetailsViewModel(IQueryable<User> users, IQueryable<Restaurant> restaurants, IQueryable<MatchSession> matchSessions)
        {
            Users = users;
            Restaurants = restaurants;
            MatchSessions = matchSessions;

            UCount = Users.Count();
            RCount = Restaurants.Count();
            MsCount = MatchSessions.Count();
        }

    }
}
