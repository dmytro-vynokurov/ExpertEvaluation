﻿using System;
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

        public User GetUserByLogin(string login)
        {
            var collection = GetCollection<User>("users");
            var query = Query<User>.EQ(e => e.Login, login);
            var result = collection.FindOneAs<User>(query);
            return result;
        }

//        public Question[] GetQuestions()
//        {
//            var collection = GetCollection<Question>("questions");
////            var query = Query<Question>.;
//            var result = collection.FindAllAs<Question>();
//            return result.Aggregate(); 
//        }
    }
}