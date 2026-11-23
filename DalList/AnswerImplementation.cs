using DO;
using DalApi;
using Tools;
using System.Reflection;

namespace Dal;

internal class AnswerImplementation : IAnswer
{
    
public int Create(Answer item)
    {
Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The answer {item.AnswerId} entered to create answer function {DateTime.Now}"
                    );
        Answer copyAnswer = item with { AnswerId = DataSource.Config.InitialAnswer };
        DataSource.answers.Add(copyAnswer);
        Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The answer {item.AnswerId} successfully created answer function {DateTime.Now}"
                    );
        return copyAnswer.AnswerId;


        throw new NotImplementedException();
        Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The answer {item.AnswerId} failed to create answer function {DateTime.Now}"
                    );
    }

    public void Delete(int id)
    {
        Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The answer {id} entered to delete answer function {DateTime.Now}"
                    );
        var answer = DataSource.answers.FirstOrDefault(a => a.AnswerId == id);
        if (answer != null)
        {
            DataSource.answers.Remove(answer);
            Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The answer {id} successfully deleted answer function {DateTime.Now}"
                    );
            return;
        }
        throw new KeyNotFoundException($"This answer didnt found");
        Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The answer {id} failed to delete answer function {DateTime.Now}"
                    );
    }

    public Answer? Read(int id)
    {
        Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The answer {id} entered to read answer function {DateTime.Now}"
                    );
        var answer = DataSource.answers.FirstOrDefault(a => a.AnswerId == id);
        if (answer != null)
        {
            Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The answer {id} successfully read answer function {DateTime.Now}"
                    );
            return answer;
        }
        throw new KeyNotFoundException($"This answer didnt found");
        Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The answer {id} failed to read answer function {DateTime.Now}"
                    );
    }

    public List<(Answer,bool isFilter)>ReadAll()
    {
        Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The answer entered to read all answer function {DateTime.Now}"
                    );
        Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The answer successfully read all answer function {DateTime.Now}"
                    );
        return DataSource.answers.ToList();
    }

    public void Update(Answer item)
    {
       Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The answer {item.AnswerId} entered to update answer function {DateTime.Now}"
                    );
        var answer = DataSource.answers.FirstOrDefault(a => a.AnswerId == item.AnswerId);
        if (answer != null)
        {
            DataSource.answers.Remove(answer);
            DataSource.answers.Add(item);
            Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The answer {item.AnswerId} successfully updated answer function {DateTime.Now}"
                    );
            return;
        }
        throw new KeyNotFoundException($"This answer didnt found");
        Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The answer {item.AnswerId} failed to update answer function {DateTime.Now}"
                    );

    }
}
