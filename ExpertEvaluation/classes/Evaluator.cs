using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpertEvaluation.classes
{
    class Evaluator
    {
        private User _expert;
        private readonly Answer[] _answers;

        public Evaluator(User expert)
        {
            if (expert.Type != UserType.Expert) 
                throw new ArgumentException("We can evaluate Experts only");
            _expert = expert;
            _answers = expert.Answers;
        }

        public double Evaluate()
        {
            var tMatrices = GetTMatrices();
            return GetAggregatedEvaluation(tMatrices);
        }

        private List<TMatrix> GetTMatrices()
        {
            var result = GetTMatricesForNonBooleanQuestions();
            var booleanTMatrix = GetTMatrixForBooleanQuestions();
            result.Add(booleanTMatrix);

            return result;

        }

        private List<TMatrix> GetTMatricesForNonBooleanQuestions()
        {
            var otherAnswers =
                (List<Answer>)_answers.Where(answer => answer.QuestionType != QuestionType.BooleanQuestion);
            throw new NotImplementedException();
        }

        private TMatrix GetTMatrixForBooleanQuestions()
        {
            var boolAnswers =
                (List<Answer>)_answers.Where(answer => answer.QuestionType == QuestionType.BooleanQuestion);
            throw new NotImplementedException();
        }

        private double GetAggregatedEvaluation(List<TMatrix> tMatrices)
        {
            throw new NotImplementedException();
        }

    }
}
