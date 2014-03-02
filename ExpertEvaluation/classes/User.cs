using MongoDB.Bson;

namespace ExpertEvaluation.classes
{
    internal enum UserType
    {
        Admin, Expert
    }

    class User
    {
        public User(string name, string login, string password, double estimate, Answer[] answers)
        {
            Name = name;
            Login = login;
            Password = password;
            Estimate = estimate;
            Answers = answers;
        }

        public ObjectId Id { get; set; }

        public string Name { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public UserType Type { get; set; }

        public double Estimate { get; set; }

        public Answer[] Answers { get; set; }

        public override string ToString()
        {
            return Login;
        }
    }
}
