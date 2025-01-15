using SOLID.OCP.After;

namespace SOLID.OCP
{
    class Program
    {
        public static void Main(string[] args)
        {
            var quiz = new After.Quiz(QuestionBank.Generate());
            quiz.Print();
        }
    }
}