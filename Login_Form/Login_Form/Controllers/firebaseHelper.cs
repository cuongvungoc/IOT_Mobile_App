using Firebase.Auth;
using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Login_Form.Models;
using System.Linq;
using System.Diagnostics;
using Firebase.Database.Query;

namespace Login_Form.Controllers
{
    class firebaseHelper
    {
        // Conect app with Firebase using API url
        public static FirebaseClient firebase = new FirebaseClient("AIzaSyAzUTYkFhecYELDf_01IWLg_8p4dz2DXVo");

        // Read all
        public static async Task<List<Users>> GetAllUser()
        {
            try
            {
                var userlist = (await firebase
                .Child("Users")
                .OnceAsync<Users>()).Select(item =>
                new Users
                {
                    Email = item.Object.Email,
                    Password = item.Object.Password
                }).ToList();
                return userlist;
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error:{e}");
                return null;
            }
        }

        // Read
        public static async Task<Users> GetUser(string email)
        {
            try
            {
                var allUsers = await GetAllUser();
                await firebase
                .Child("Users")
                .OnceAsync<User>();
                return allUsers.Where(a => a.Email == email).FirstOrDefault();
            }
            catch(Exception e)
            {
                Debug.WriteLine($"Error:{e}");
                return null;
            }
        }

        // Insert a user
        public static async Task<bool> AddUser(string email, string password)
        {
            try
            {
                await firebase
                .Child("Users")
                .PostAsync(new Users() { Email = email, Password = password });
                return true;
            }
            catch(Exception e)
            {
                Debug.WriteLine($"Error: {e}");
                return false;
            }
        }
    }
}
