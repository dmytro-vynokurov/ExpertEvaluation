using System;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace ExpertEvaluation.classes
{
    class UserDao
    {

        private static MongoCollection GetCollection<T>(string collectionName)
        {
            var client = new MongoClient("mongodb://localhost");
            var server = client.GetServer();
            var database = server.GetDatabase("expert_evaluation");
            return database.GetCollection<T>(collectionName);
        }

        public User GetUserByLogin(string login)
        {
            Console.WriteLine(@"Getting user by login: "+login);
            var collection = GetCollection<User>("users");
            var query = Query<User>.EQ(e => e.Login, login);
            var result = collection.FindOneAs<User>(query);
            Console.WriteLine(@"User found: " + result);
            return result;
        }
    }
}
