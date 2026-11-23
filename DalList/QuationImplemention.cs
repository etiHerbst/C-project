using DO;
using DalApi;
using Tools;
using System.Reflection;

namespace Dal;

internal class QuationImplemention : IQuestion
{
    public int Create(Question item)
    {
        Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The question {item.QuestionId} entered to create question function {DateTime.Now}"
                    );

        try
        {
            Question question = item with { QuestionId = DataSource.Config.InitialQuestion };
            DataSource.quastions.Add( question );
            Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The question {item.QuestionId} successfully created question function {DateTime.Now}"
                    );
            return question.QuestionId;

        }
        catch (Exception)
        {

            throw new NotImplementedException();
            Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The question {item.QuestionId} failed to create question function {DateTime.Now}"
                    );
        }
    }

    public void Delete(int id)
    {
        Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The question {id} entered to delete question function {DateTime.Now}"
                    );
        var question = DataSource.quastions.FirstOrDefault(a => a.QuestionId == id);
        if (question != null)
        {
            DataSource.quastions.Remove(question);
            Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The question {id} successfully deleted question function {DateTime.Now}"
                    );
            return;
        }
        throw new KeyNotFoundException($"This question didnt found");
        Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The question {id} failed to delete question function {DateTime.Now}"
                    );
    }

    public Question? Read(int id)
    {
        Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The question {id} entered to read question function {DateTime.Now}"
                    );
        var question = DataSource.quastions.FirstOrDefault(a => a.QuestionId == id);
        if (question != null)
        {
            Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The question {id} successfully read question function {DateTime.Now}"
                    );
            return question;
        }
        throw new KeyNotFoundException($"This question didnt found");
        Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The question {id} failed to read question function {DateTime.Now}"
                    );
    }

    public List<(Question,bool IsFilter)> ReadAll()
    {
        Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The question entered to read all question function {DateTime.Now}"
                    );
        Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The question successfully read all question function {DateTime.Now}"
                    );
        return [ ..DataSource.quastions];
    }

    public void Update(Question item)
    {
       
        Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The question {item.QuestionId} entered to update question function {DateTime.Now}"
                    );
        var question = DataSource.quastions.FirstOrDefault(a => a.QuestionId == item.QuestionId);
        if ( question != null ) {
            DataSource.quastions.Remove(question);
            DataSource.quastions.Add(item);
            Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The question {item.QuestionId} successfully updated question function {DateTime.Now}"
                    );
        }
        else
            throw new KeyNotFoundException($"This question didnt found");
        Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The question {item.QuestionId} failed to update question function {DateTime.Now}"
                    );
    }
}
