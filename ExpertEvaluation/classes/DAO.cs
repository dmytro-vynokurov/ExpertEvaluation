using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace ExpertEvaluation.classes
{
    static class Dao
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

        public static IEnumerable<Question> GetQuestions()
        {
            var collection = GetCollection<Question>("questions");
            var cursor = collection.FindAllAs<Question>();
            var result = new List<Question>(cursor);
            return result;
        }

        public static Question GetQuestionById(int id)
        {
            var collection = GetCollection<Question>("questions");
            var query = Query<Question>.EQ(e => e.QuestionNumber, id);
            var result = collection.FindOneAs<Question>(query);
            return result;  
        }

        public static int MaxQuestionNumber()
        {
            var collection = GetCollection<Sequence>("sequences");
            var selectQuery = Query<Sequence>.EQ(s => s.Name, "questions");
            var questionSequence = collection.FindOneAs<Sequence>(selectQuery);
            var maxQuestionNumber = questionSequence.Value;
            questionSequence.Value += 1;
            collection.Save(questionSequence);
            return maxQuestionNumber;
        }

        public static void SaveQuestion(Question question)
        {
            var collection = GetCollection<Question>("questions");
            collection.Save(question);
        }

        public static void DeleteQuestion(int questionNumber)
        {
            var collection = GetCollection<Question>("questions");
            var query = Query<Question>.EQ(e => e.QuestionNumber, questionNumber);
            collection.Remove(query);

        }

        public static IEnumerable<User> GetUsers()
        {
            var collection = GetCollection<User>("users");
            var cursor = collection.FindAllAs<User>();
            var result = new List<User>(cursor);
            return result;
        }

        public static void SaveUser(User user)
        {
            var collection = GetCollection<User>("users");
            collection.Save(user);
        }

        public static User GetUserById(ObjectId id)
        {
            var collection = GetCollection<User>("users");
            var query = Query<User>.EQ(e => e.Id, id);
            var result = collection.FindOneAs<User>(query);
            return result;
        }

        public static void DeleteUser(ObjectId userId)
        {
            var collection = GetCollection<User>("users");
            var query = Query<User>.EQ(u => u.Id, userId);
            collection.Remove(query);
        }



    }
}
