using MongoDB.Bson;

namespace ExpertEvaluation.classes
{
    public enum UserType
    {
        Admin, Expert
    }

    public class User
    {
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
