using System.Collections.Generic;
using System.Linq;

namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new List<UserInfo>();
        
        static Repository() 
        {
            _users.Add(new UserInfo() { Id = 1, Name = "Beyza", Email = "abc@info.com", Phone = "12345", WillAttend = true });
            _users.Add(new UserInfo() { Id = 2, Name = "Xxxxx", Email = "abcf@info.com", Phone = "144345", WillAttend = true });
            _users.Add(new UserInfo() { Id = 3, Name = "Yyyy", Email = "abcd@info.com", Phone = "153445", WillAttend = false });
            _users.Add(new UserInfo() { Id = 4, Name = "Zzzzz", Email = "abce@info.com", Phone = "214", WillAttend = false });
        }

        public static List<UserInfo> Users => _users;

        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }

        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}
