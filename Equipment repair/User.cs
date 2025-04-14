using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Equipment_repair.User;

namespace Equipment_repair
{
    public class User
    {
        private static User instance;
        private User() { }

        public static User Instance
        {
            get
            {
                if (instance == null)
                    instance = new User();
                
                return instance;
            }
        }

        public Post post { set; get; }

        public void setPost(string key_text)
        {
            switch (key_text)
            {
                case "Engineer":
                    post = Post.Engineer;
                    break;
                case "Manager":
                    post = Post.Manager;
                    break;
                default:
                    break;
            }
        }

        public enum Post
        {
            Engineer,
            Manager,
            None
        }
    }
}
