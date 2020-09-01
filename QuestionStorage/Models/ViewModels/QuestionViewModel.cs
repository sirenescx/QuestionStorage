using QuestionStorage.Models.Questions;

namespace QuestionStorage.Models.ViewModels
{
    public class QuestionViewModel 
    {
        public QuestionsInfo Question { get; set; }
        public QuestionAnswerVariants AnswerOption { get; set; }
    }
}