using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodFIghtAdmin.Models;

namespace FoodFIghtAdmin.ViewModels
{
    public class MatchSessionViewModel
    {
        
        public DateTime DateTime { get; set; }
        public User BaseUserEmail { get; set; }
        public User FriendUserEmail { get; set; }

        public MatchSessionViewModel()
        {
            
        }
    }
}
