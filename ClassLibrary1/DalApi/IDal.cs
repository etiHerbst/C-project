
namespace DalApi
{
    public interface IDal
    {
        IStudent Student { get; }
        ITest Test { get; }

        IQuestion Question { get; }

        IAnswer Answer { get; }
        IQuesForExminee QuesForExaminee { get; }

       
    }
}
