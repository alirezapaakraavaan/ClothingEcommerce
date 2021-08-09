using _0_Framework.Domain;
using AccountManagement.Domain.RoleAgg;

namespace AccountManagement.Domain.AccountAgg
{
    public class Account : EntityBase
    {
        public string Fullname { get; private set; }
        public string Username { get; private set; }
        public string City { get; private set; }
        public string Address { get; private set; }
        public string Password { get; private set; }
        public string RePassword { get; private set; }
        public long RoleId { get; private set; }
        public string Mobile { get; private set; }
        public string ProfilePhoto { get; private set; }
        public Role Role { get; private set; }

        public Account(string fullname, string username, string city, string address, string password,
            string rePassword, long roleId, string mobile, string profilePhoto)
        {
            Fullname = fullname;
            Username = username;
            City = city;
            Address = address;
            Password = password;
            RePassword = rePassword;
            RoleId = roleId;

            if (roleId == 0)
                RoleId = 2;

            Mobile = mobile;
            ProfilePhoto = profilePhoto;
        }

        public void Edit(string fullname, string username, long roleId, string mobile,
            string profilePhoto)
        {
            Fullname = fullname;
            Username = username;
            RoleId = roleId;
            Mobile = mobile;
            if (!string.IsNullOrWhiteSpace(profilePhoto))
                ProfilePhoto = profilePhoto;
        }

        public void ChangePassword(string password)
        {
            Password = password;
        }

        public void ChangeAddress(string address)
        {
            Address = address;
        }
    }
}