using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace ExpertEvaluation.classes
{
    class Dao
    {

        private static MongoCollection GetCollection<T>(string collectionName)
        {
            var client = new MongoClient("mongodb://localhost");
            var server = client.GetServer();
            var database = server.GetDatabase("expert_evaluation");
            return database.GetCollection<T>(collectionName);
        }

        public static User GetUserByLogin(string login)
        {
            var collection = GetCollection<User>("users");
            var query = Query<User>.EQ(e => e.Login, login);
            var result = collection.FindOneAs<User>(query);
            return result;
        }

        public static List<Question> GetQuestions()
        {
            var collection = GetCollection<Question>("questions");
            var cursor = collection.FindAllAs<Question>();
            var result = new List<Question>(cursor);
            return result;
        }

        public static Question GetQuestionByID(int id)
        {
            var collection = GetCollection<Question>("questions");
            var query = Query<Question>.EQ(e => e.QuestionNumber, id);
            var result = collection.FindOneAs<Question>(query);
            return result;  
        }



    }
}
