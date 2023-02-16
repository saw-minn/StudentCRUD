namespace StudentCRUD.Models
{
    public class User
    {
        private int id;
        private string password;
        private string username;

        public int GetId()
        {
            return id;
        }

        public void SetId(int value)
        {
            id = value;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public List<Student> Students { get; set; }
    }
}
