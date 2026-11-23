
using DalApi;
using DO;
namespace Dal;

public class DalList : IDal
{
    public IStudent Student => new StudentImplementation();

    public ITest Test => new TestImplementation();

    public IQuestion Question => new QuationImplemention();

    public IAnswer Answer => new AnswerImplementation();

    public QuesForExaminee QuestionExaminee => new QuesForExmineeImplementation();



