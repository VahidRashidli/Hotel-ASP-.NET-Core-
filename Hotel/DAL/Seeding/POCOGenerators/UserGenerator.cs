﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel.Constants.POCOConstants;
using Hotel.Models;
using Microsoft.AspNetCore.Identity;

namespace Hotel.DAL.Seeding.POCOGenerators
{
    public static class UserGenerator
    { // Adding 4 users for better demonstration: Admin, HotelUser1, HotelUser2,HotelUser3
        public static async Task GenerateDefaultUsersAsnyc(this UserManager<User> userManager)
        {
            User adminUser = new User()
            {
                UserName = DefaultUserConstants.AdminUserName,
                Email = DefaultUserConstants.AdminEmail
            };
            await userManager.CreateAsync(adminUser, DefaultUserConstants.AdminPassword);
            await userManager.AddToRoleAsync(adminUser, DefaultRoleConstants.Admin);
            User hotelUser = new User()
            {
                UserName = DefaultUserConstants.HotelUserName,
                Email = DefaultUserConstants.HotelEmail
            };
            await userManager.CreateAsync(hotelUser, DefaultUserConstants.HotelPassword);
            await userManager.AddToRoleAsync(hotelUser, DefaultRoleConstants.Hotel);
            User hotelUserA = new User()
            {
                UserName = DefaultUserConstants.HotelUserNameA,
                Email = DefaultUserConstants.HotelEmailA,
                Image = DefaultUserConstants.HotelUserAImage
            };
            await userManager.CreateAsync(hotelUserA, DefaultUserConstants.HotelPasswordA);
            await userManager.AddToRoleAsync(hotelUserA, DefaultRoleConstants.Hotel);

            User hotelUserB = new User()
            {
                UserName = DefaultUserConstants.HotelUserNameB,
                Email = DefaultUserConstants.HotelEmailB,
                Image = DefaultUserConstants.HotelUserBImage
            };
            await userManager.CreateAsync(hotelUserB, DefaultUserConstants.HotelPasswordB);
            await userManager.AddToRoleAsync(hotelUserB, DefaultRoleConstants.Hotel);
        }
    }
}
