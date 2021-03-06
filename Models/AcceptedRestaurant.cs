using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FoodFIghtAdmin.Models
{
    [Table("AcceptedRestaurant")]
    [Index(nameof(SwipeListId), Name = "fkIdx_AcceptedRestaurant_SwipeListID")]
    public partial class AcceptedRestaurant
    {
        public AcceptedRestaurant()
        {
            MatchedRestaurants = new HashSet<MatchedRestaurant>();
        }

        [Key]
        [Column("AcceptedRestaurantID")]
        public int AcceptedRestaurantId { get; set; }
        [Column("SwipeListID")]
        public int SwipeListId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateTime { get; set; }
        [Required]
        [Column("UserID")]
        
        public int UserId { get; set; }

        [ForeignKey(nameof(SwipeListId))]
        [InverseProperty("AcceptedRestaurants")]
        public virtual SwipeList SwipeList { get; set; }
        [InverseProperty(nameof(MatchedRestaurant.AcceptedRestaurant))]
        public virtual ICollection<MatchedRestaurant> MatchedRestaurants { get; set; }
    }
}
