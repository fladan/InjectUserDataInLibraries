using InjectUserDataInLibraries.Models.Abstract;
using Microsoft.AspNet.Identity;
using System.Web;

namespace InjectUserDataInLibraries.Security
{
    public class UserData : IUserData
    {
        private readonly string _userName;
        private readonly string _userId;

        public UserData()
        {
            _userName = HttpContext.Current.User.Identity.GetUserName();
            _userId = HttpContext.Current.User.Identity.GetUserId();
        }

        public string UserName { get { return _userName; } }

        public string UserId { get { return _userId; } }
    }
}