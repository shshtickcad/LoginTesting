using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TickToolCloud.Entities.Entity;

namespace logInTesting.Controllers
{
    public class UserController
    {
        private readonly HttpClient _client;

        public UserController(HttpClient client)
        {
            _client = client;
        }

        internal async Task<User> AddUser(User user)
        {
            string httpContent = JsonConvert.SerializeObject(user);
            byte[] buffer = Encoding.UTF8.GetBytes(httpContent);

            ByteArrayContent byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = await _client.PostAsync("api/user/", byteContent);

            if (response.IsSuccessStatusCode)
            {
                XtraMessageBox.Show(user.FirstName + " registered successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Server failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new User();
        }

        internal async Task<User> DeleteUser(string usrName)
        {
            string httpContent = JsonConvert.SerializeObject(usrName);
            byte[] buffer = Encoding.UTF8.GetBytes(httpContent);

            ByteArrayContent byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = await _client.PostAsync("api/user/Delete/" + usrName, byteContent);

            if (response.IsSuccessStatusCode)
            {
                XtraMessageBox.Show("Deleted Successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Server failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return new User();
        }

        internal async Task<bool> checkUsers(LoginModel login)
        {
            string httpContent = JsonConvert.SerializeObject(login);
            byte[] buffer = Encoding.UTF8.GetBytes(httpContent);

            ByteArrayContent byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage respond = await _client.PostAsync("api/user/check", byteContent);

            if (!respond.IsSuccessStatusCode)
            {
                return false;
            }
            return true;
        }

        internal async Task<bool> checkEmail(string email)
        {
            HttpResponseMessage respond = await _client.GetAsync("api/user/emcheck/" + email);

            if (!respond.IsSuccessStatusCode)
            {
                return false;
            }
            return true;
        }


        internal async Task<string> loggedAs()
        {
            HttpResponseMessage respond = _client.GetAsync("api/loggedAs").Result;

            if (!respond.IsSuccessStatusCode)
            {
                XtraMessageBox.Show("Server failed to give a successfull response.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
            else
            {
                var json = await respond.Content.ReadAsStringAsync();
                string result = JsonConvert.DeserializeObject<string>(json);
                return result;
            }
        }
    }
}
