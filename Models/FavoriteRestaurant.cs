using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FoodFIghtAdmin.Models
{
    [Table("FavoriteRestaurant")]
    [Index(nameof(RestaurantId), Name = "fkIdx_FavoriteRestaurant_RestaurantID")]
    [Index(nameof(UserId), Name = "fkIdx_FavoriteRestaurant_UserID")]
    public partial class FavoriteRestaurant
    {
        [Key]
        [Column("FavoriteRestaurantID")]
        public int FavoriteRestaurantId { get; set; }
        [Required]
        [Column("RestaurantID")]
        
        public int RestaurantId { get; set; }
        [Column("UserID")]
        public int UserId { get; set; }

        [ForeignKey(nameof(RestaurantId))]
        [InverseProperty("FavoriteRestaurants")]
        public virtual Restaurant Restaurant { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("FavoriteRestaurants")]
        public virtual User User { get; set; }
    }
}
