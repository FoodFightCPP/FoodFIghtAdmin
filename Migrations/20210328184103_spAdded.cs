using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodFIghtAdmin.Migrations
{
    public partial class spAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    RestaurantID = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    State = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Lat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Lng = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OpenNow = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Website = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Rating = table.Column<double>(type: "float", nullable: true),
                    ZipCode = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.RestaurantID);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    SettingsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Enabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.SettingsID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Lat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Lng = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Facebook = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Twitter = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Instagram = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Website = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ProfilePicture = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Street = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    State = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ZipCode = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    Salt = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "BlockedRestaurant",
                columns: table => new
                {
                    BlockedRestaurantID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RestaurantID = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlockedRestaurant", x => x.BlockedRestaurantID);
                    table.ForeignKey(
                        name: "FK_BlockedRestaurants_RestaurantID",
                        column: x => x.RestaurantID,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlockedRestaurants_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BlockedUsers",
                columns: table => new
                {
                    BlockUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BaseUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BlockedUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlockedUsers", x => x.BlockUserID);
                    table.ForeignKey(
                        name: "FK_BlockedUsersBase_UserID",
                        column: x => x.BaseUserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlockedUsersID_UserID",
                        column: x => x.BlockedUserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConnectedUsers",
                columns: table => new
                {
                    ConnectedUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BaseUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FriendUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConnectedUsers", x => x.ConnectedUserID);
                    table.ForeignKey(
                        name: "FK_ConnectedUsersBase_UserID",
                        column: x => x.BaseUserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConnectedUsersFriend_UserID",
                        column: x => x.FriendUserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteRestaurant",
                columns: table => new
                {
                    FavoriteRestaurantID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RestaurantID = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteRestaurant", x => x.FavoriteRestaurantID);
                    table.ForeignKey(
                        name: "FK_FavoriteRestaurant_RestaurantID",
                        column: x => x.RestaurantID,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FavoriteRestaurant_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserSettings",
                columns: table => new
                {
                    UserSettingsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SettingsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSettings", x => x.UserSettingsID);
                    table.ForeignKey(
                        name: "FK_UserSettings_SettingsID",
                        column: x => x.SettingsID,
                        principalTable: "Settings",
                        principalColumn: "SettingsID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserSettings_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MatchSession",
                columns: table => new
                {
                    MatchSessionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConnectedUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Lat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Lng = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchSession", x => x.MatchSessionID);
                    table.ForeignKey(
                        name: "FK_MatchSession_ConnectedID",
                        column: x => x.ConnectedUserID,
                        principalTable: "ConnectedUsers",
                        principalColumn: "ConnectedUserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SwipeList",
                columns: table => new
                {
                    SwipeListID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RestaurantID = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MatchSessionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SwipeList", x => x.SwipeListID);
                    table.ForeignKey(
                        name: "FK_SwipeList_MatchSessionId",
                        column: x => x.MatchSessionID,
                        principalTable: "MatchSession",
                        principalColumn: "MatchSessionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SwipeList_RestaurantID",
                        column: x => x.RestaurantID,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AcceptedRestaurant",
                columns: table => new
                {
                    AcceptedRestaurantID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SwipeListID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcceptedRestaurant", x => x.AcceptedRestaurantID);
                    table.ForeignKey(
                        name: "FK_AcceptedRestaurant_SwipeListID",
                        column: x => x.SwipeListID,
                        principalTable: "SwipeList",
                        principalColumn: "SwipeListID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RejectedRestaurant",
                columns: table => new
                {
                    RejectedRestaurantID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    SwipeListID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RejectedRestaurant", x => x.RejectedRestaurantID);
                    table.ForeignKey(
                        name: "FK_RejectedRestaurant_SwipeListID",
                        column: x => x.SwipeListID,
                        principalTable: "SwipeList",
                        principalColumn: "SwipeListID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MatchedRestaurant",
                columns: table => new
                {
                    MatchRestaurantID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateTIme = table.Column<DateTime>(type: "datetime", nullable: false),
                    AcceptedRestaurantID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchedRestaurant", x => x.MatchRestaurantID);
                    table.ForeignKey(
                        name: "FK_MatchedRestaurant_AcceptedRestaurantID",
                        column: x => x.AcceptedRestaurantID,
                        principalTable: "AcceptedRestaurant",
                        principalColumn: "AcceptedRestaurantID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "fkIdx_AcceptedRestaurant_SwipeListID",
                table: "AcceptedRestaurant",
                column: "SwipeListID");

            migrationBuilder.CreateIndex(
                name: "fkIdx_BlockedRestaurants_RestaurantID",
                table: "BlockedRestaurant",
                column: "RestaurantID");

            migrationBuilder.CreateIndex(
                name: "fkIdx_BlockedRestaurants_UserID",
                table: "BlockedRestaurant",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "fkIdx_BlockedUsersBase_UserID",
                table: "BlockedUsers",
                column: "BaseUserID");

            migrationBuilder.CreateIndex(
                name: "fkIdx_BlockedUsersBlocked_UserID",
                table: "BlockedUsers",
                column: "BlockedUserID");

            migrationBuilder.CreateIndex(
                name: "fkIdx_ConnectedUsersBase_UserID",
                table: "ConnectedUsers",
                column: "BaseUserID");

            migrationBuilder.CreateIndex(
                name: "fkIdx_ConnectedUsersBlocked_UserID",
                table: "ConnectedUsers",
                column: "FriendUserID");

            migrationBuilder.CreateIndex(
                name: "fkIdx_FavoriteRestaurant_RestaurantID",
                table: "FavoriteRestaurant",
                column: "RestaurantID");

            migrationBuilder.CreateIndex(
                name: "fkIdx_FavoriteRestaurant_UserID",
                table: "FavoriteRestaurant",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "fkIdx_MatchedRestaurant_AcceptedRestaurantID",
                table: "MatchedRestaurant",
                column: "AcceptedRestaurantID");

            migrationBuilder.CreateIndex(
                name: "fkIdx_MatchSession_ConnectedUserID",
                table: "MatchSession",
                column: "ConnectedUserID");

            migrationBuilder.CreateIndex(
                name: "fkIdx_SwipeList_MatchSessionID",
                table: "MatchSession",
                column: "MatchSessionID");

            migrationBuilder.CreateIndex(
                name: "fkIdx_RejectedRestaurant_SwipeListID",
                table: "RejectedRestaurant",
                column: "SwipeListID");

            migrationBuilder.CreateIndex(
                name: "fkIdx_SwipeList_RestaurantID",
                table: "Restaurants",
                column: "RestaurantID");

            migrationBuilder.CreateIndex(
                name: "IX_SwipeList_MatchSessionID",
                table: "SwipeList",
                column: "MatchSessionID");

            migrationBuilder.CreateIndex(
                name: "IX_SwipeList_RestaurantID",
                table: "SwipeList",
                column: "RestaurantID");

            migrationBuilder.CreateIndex(
                name: "fkIdx_UserSettings_SettingsID",
                table: "UserSettings",
                column: "SettingsID");

            migrationBuilder.CreateIndex(
                name: "fkIdx_UserSettings_UserID",
                table: "UserSettings",
                column: "UserID");

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlockedRestaurant");

            migrationBuilder.DropTable(
                name: "BlockedUsers");

            migrationBuilder.DropTable(
                name: "FavoriteRestaurant");

            migrationBuilder.DropTable(
                name: "MatchedRestaurant");

            migrationBuilder.DropTable(
                name: "RejectedRestaurant");

            migrationBuilder.DropTable(
                name: "UserSettings");

            migrationBuilder.DropTable(
                name: "AcceptedRestaurant");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "SwipeList");

            migrationBuilder.DropTable(
                name: "MatchSession");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "ConnectedUsers");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
