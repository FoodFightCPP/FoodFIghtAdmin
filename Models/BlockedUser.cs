using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FoodFIghtAdmin.Models
{
    [Index(nameof(BaseUserId), Name = "fkIdx_BlockedUsersBase_UserID")]
    [Index(nameof(BlockedUserId), Name = "fkIdx_BlockedUsersBlocked_UserID")]
    public partial class BlockedUser
    {
        [Key]
        [Column("BlockUserID")]
        public int BlockUserId { get; set; }
        [Column("BaseUserID")]
        public int BaseUserId { get; set; }
        [Column("BlockedUserID")]
        public int BlockedUserId { get; set; }

        [ForeignKey(nameof(BaseUserId))]
        [InverseProperty(nameof(User.BlockedUserBaseUsers))]
        public virtual User BaseUser { get; set; }
        [ForeignKey(nameof(BlockedUserId))]
        [InverseProperty(nameof(User.BlockedUserBlockedUserNavigations))]
        public virtual User BlockedUserNavigation { get; set; }
    }
}
