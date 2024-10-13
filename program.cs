using System.Runtime.CompilerServices;

namespace ardena
{
    internal class program
    {
        static void Main(string[] args)
        {
            
            user user = new user("ardena", "password");
            Console.WriteLine(user.verifylogin("ardena", "password"));
            user.updatePassword("pass");
                
            administrator admin = new administrator("reynold", "ardena", "password");
            Console.WriteLine(admin.verifylogin("ardena", "password")); 
            admin.updateAdminName("ardena");

        }
    }

    class user
    {
        private string user_id;
        protected string password;

        public user(string id, string pass)
        {
            this.user_id = id;
            this.password = pass;

        }

        public Boolean verifylogin(string id, string pass)
        {
            return this.user_id.Equals(id) && this.password.Equals(pass);

        }

        public void updatePassword(string newPassword)
        {
            this.password = newPassword;
        }
    }

    class administrator : user {
        private string admin_name;

        public administrator(string name , string id , string pass) : base(id, pass) 
        {
            this.admin_name = name;
        }

        public void updatePassword(string newPassword)
        {
            base.updatePassword(newPassword);

        }
        public void updateAdminName(string name)
        {
            this.admin_name = name;

        }
    }
}
