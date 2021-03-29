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
        public IQueryable<ConnectedUser> ConnectedUsers { get; set; }

        public IQueryable<MatchSessionViewModel> MatchSessionViewModels { get; set; }

        public int UCount { get; set; }
        public int RCount { get; set; }
        public int MsCount { get; set; }
        public int CuCount { get; set; }

        public HomeDetailsViewModel(IQueryable<User> users, IQueryable<Restaurant> restaurants, IQueryable<MatchSession> matchSessions, IQueryable<ConnectedUser> connectedUsers)
        {
            Users = users;
            Restaurants = restaurants;
            MatchSessions = matchSessions;
            ConnectedUsers = connectedUsers;
            //MatchSessionViewModels = matchSessions.Select()

            UCount = Users.Count();
            RCount = Restaurants.Count();
            MsCount = MatchSessions.Count();
            CuCount = ConnectedUsers.Count();
        }

        //private IQueryable<MatchSessionViewModel> GetMSVM(IQueryable<MatchSession> matchSessions, IQueryable<ConnectedUser> connectedUsers)
        //{

        //    List<Guid> connectedUserIds = new List<Guid>();
        //    foreach (var i in matchSessions)
        //    {
        //        connectedUserIds.Add(i.ConnectedUserId);
        //    }
        //    foreach (var i in connectedUsers)
        //    {
                
        //        MatchSessionViewModel matchSessionViewModel = new MatchSessionViewModel();
        //        foreach (var id in connectedUserIds)
        //        {
        //            if (i.ConnectedUserId==id)
        //            {
                        
        //            }
        //        }

        //    }

        //}
    }
}
