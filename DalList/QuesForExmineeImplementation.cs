using DO;
using DalApi;
using System.Reflection;
using Tools;

namespace Dal;

internal class QuesForExmineeImplementation : IQuesForExminee
{
    public int Create(QuesForExaminee item)
    {
        Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The question for examinee {item.QuestionId} entered to create question for examinee function {DateTime.Now}"
                    );
        try
        {
            int Id = DataSource.Config.initialQuesForExaminee;
            QuesForExaminee quesForExaminee = item with { QuestionId = Id };
            DataSource.questionExaminees.Add(quesForExaminee);
            Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The question for examinee {item.QuestionId} successfully created question for examinee function {DateTime.Now}"
                    );
            return Id;
        }
        catch
        {
            throw new NotImplementedException();
            Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The question for examinee {item.QuestionId} failed to create question for examinee function {DateTime.Now}"
                    );

        }

    }
    public void Delete(int id)
    {
        Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The question for examinee {id} entered to delete question for examinee function {DateTime.Now}"
                    );
        var quesForExaminee = DataSource.questionExaminees.FirstOrDefault(a => a.QuestionId == id);
        if(quesForExaminee != null)
            {
            DataSource.questionExaminees.Remove(quesForExaminee);
            Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The question for examinee {id} successfully deleted question for examinee function {DateTime.Now}"
                    );
        }
        else
            throw new NotImplementedException("$");
        Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The question for examinee {id} failed to delete question for examinee function {DateTime.Now}"
                    );
    }

    public QuesForExaminee? Read(int id)
    {
       Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The question for examinee {id} entered to read question for examinee function {DateTime.Now}"
                    );
        var quesForExaminee = DataSource.questionExaminees.FirstOrDefault(a => a.QuestionId == id);
        if(quesForExaminee != null)
        {
            Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The question for examinee {id} successfully read question for examinee function {DateTime.Now}"
                    );
            return quesForExaminee;
        }
        else
            throw new NotImplementedException($"This question for examinee with id {id} not found");
    }

    public List<QuesForExaminee> ReadAll()
    {
      Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The question for examinee entered to read all question for examinee function {DateTime.Now}"
                    );
        Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The question for examinee successfully read all question for examinee function {DateTime.Now}"
                    );
        return DataSource.questionExaminees.ToList();
    }

    public void Update(QuesForExaminee item)
    {
       Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The question for examinee {item.QuestionId} entered to update question for examinee function {DateTime.Now}"
                    );
        var quesForExaminee = DataSource.questionExaminees.FirstOrDefault(a => a.QuestionId == item.QuestionId);
        if(quesForExaminee != null)
        {
            DataSource.questionExaminees.Remove(quesForExaminee);
            DataSource.questionExaminees.Add(item);
            Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The question for examinee {item.QuestionId} successfully updated question for examinee function {DateTime.Now}"
                    );
        }
        else
            throw new NotImplementedException($"This question for examinee with id {item.QuestionId} not found");
    }
}
