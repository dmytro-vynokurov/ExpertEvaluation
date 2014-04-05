using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace ExpertEvaluation.classes
{
    class Sequence
    {
        public ObjectId Id { get; set; }
        public int Value { get; set; }
        public string Name { get; set; }
    }
}
