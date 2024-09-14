

    static string[] GetQuestions(int questionsCount)
    {
        string[] questions = new string[questionsCount];
        questions[0] = "Сколько будет два плюс два умноженное на два?";
        questions[1] = "Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?";
        questions[2] = "На двух руках 10 пальцев. Сколько пальцев на 5 руках?";
        questions[3] = "Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?";
        questions[4] = "Пять свечей горело, две потухли. Сколько свечей осталось?";
        return questions;
    }
    int questionsCount = 5;
    string[] questions = GetQuestions(questionsCount); 

    static int[] GetAnswers(int questionsCount)
    {
        int[] answers = new int[questionsCount];
        answers[0] = 6;
        answers[1] = 9;
        answers[2] = 25;
        answers[3] = 60;
        answers[4] = 2;
        return answers;
    }
string lastAnswer;
string[] yesVariants = { "yes", "y", "true", "да", "еще бы", "только об этом и мечтаю" };
do
{
    bool lastAction;
    int[] answers = GetAnswers(questionsCount);
    Console.Write("участник, представьтесь ");
    string nameUser = Console.ReadLine();

    int countRightAnswers = 0;

    List<string> list = new List<string>();
    Random random = new Random();

    string[] stringQuestions = new string[questionsCount];
    int randomQuestionIndex;
    for (int i = 0; i < questionsCount; i++)
    {
        while (true)
        {
            randomQuestionIndex = random.Next(questionsCount);
            if (!list.Any(x => x.Equals(questions[randomQuestionIndex])))
            {
                list.Add(questions[randomQuestionIndex]);
                stringQuestions[i] = questions[randomQuestionIndex];
                break;
            }
        }
        Console.WriteLine("вопрос номер " + (i + 1));
        Console.WriteLine(stringQuestions[i]);

        int rightAnswers = answers[randomQuestionIndex];
        int userAnswer = Convert.ToInt32(Console.ReadLine());
        if (userAnswer == rightAnswers)
        {
            countRightAnswers++;
        }
    }
    Console.WriteLine("количество правильных ответов пользователя " + nameUser + " = " + GetDiagnosis(countRightAnswers));
    Console.WriteLine("Повторить тест? (Yes/No)"); 
    lastAnswer = Console.ReadLine();
} while (yesVariants.Contains(lastAnswer, StringComparer.OrdinalIgnoreCase));
    
       
    
    static int GetDiagnosis(int x)
    {
        switch (x)
        {
            case 0: Console.WriteLine("Ваш диагноз - идиот"); break;
            case 1: Console.WriteLine("Ваш диагноз - кретин"); break;
            case 2: Console.WriteLine("Ваш диагноз - дурак"); break;
            case 3: Console.WriteLine("Ваш диагноз - нормальный"); break;
            case 4: Console.WriteLine("Ваш диагноз - талант"); break;
            case 5: Console.WriteLine("Ваш диагноз - гений!!!"); break;
        }
        return x;
    }





