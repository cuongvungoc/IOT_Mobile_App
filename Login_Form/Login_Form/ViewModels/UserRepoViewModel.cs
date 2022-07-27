using Firebase.Database;
using Login_Form.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Form.ViewModels
{
    class UserRepoViewModel
    {
        FirebaseClient firebaseClient = new FirebaseClient("https://xamariniot-default-rtdb.firebaseio.com/");

        public async Task<List<DeviceModel>> GetAllDevice()
        {
            return (await firebaseClient.Child(nameof(DeviceModel)).OnceAsync<DeviceModel>()).Select(item => new DeviceModel
            {
                Name = item.Object.Name,
                Status = item.Object.Status,
                Id = item.Key
            }).ToList();
        }
        public async Task<bool> SaveDevice(DeviceModel device)
        {
            var data = await firebaseClient.Child(nameof(DeviceModel)).PostAsync(JsonConvert.SerializeObject(device));
            if (!string.IsNullOrEmpty(data.Key))
            {
                return true;
            }
            return false;
        }
        public async Task<bool> Save(Users user)
        {
            var data = await firebaseClient.Child(nameof(Users)).PostAsync(JsonConvert.SerializeObject(user));
            if (!string.IsNullOrEmpty(data.Key))
            {
                return true;
            }
            return false;
        }

        public async Task<List<Users>> GetAll()
        {
            return (await firebaseClient.Child(nameof(Users)).OnceAsync<Users>()).Select(item => new Users
            {
                Email = item.Object.Email,
                Password = item.Object.Password,
                Id = item.Key
            }).ToList();
        }

        public async Task<Users> GetById(string id)
        {
            return (await firebaseClient.Child(nameof(Users) + "/" + id).OnceSingleAsync<Users>());
        }
    }
}
