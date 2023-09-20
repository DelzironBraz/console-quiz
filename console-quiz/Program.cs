using System;

class QuizProgram
{
    public static void Main(string[] args)
    {
        //Questions
        string[] questions =
        {
            "What book holds the record for the fatest selling book in history?",
            "How old was Queen Elizabeth II when was first crowned the Ween of England?",
            "Which blood type is a universal donor?"
        };

        //Answers
        string[] answers =
        {
            "A. Haryy Potter \nB. The Hunger Games \nC. To Kill A Mocking",
            "A. 31 \nB. 24 \nC. 27",
            "A. O negative \nB. B positive \nC. AB",
        };

        //Correct Answers
        string[] correctAnswers = { "B", "C", "A" };
        int score = 0;

        Console.WriteLine("Welcome to some random Quiz App");
        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine("Question " + i+1);
            Console.WriteLine(questions[i]);
            Console.WriteLine(answers[i]);
            Console.Write("Please enter yout answer ('A', 'B' or 'C'): ");
            string playerAnswer = Console.ReadLine();

            // Validating Answers
            if(string.Equals(playerAnswer, correctAnswers[i], StringComparison.OrdinalIgnoreCase))
            {
                score++;
            }
        }

        Console.WriteLine("Quiz complete!");
        Console.WriteLine("Your score is: " + score + "/" + correctAnswers.Length); 
    }
}