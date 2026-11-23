using DalApi;
using DO;
using System.Reflection;
using Tools;

namespace Dal;

internal class StudentImplementation : IStudent
{
    public int Create(Student item)
    {
        Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The student {item.StudentId} entered to update student function {DateTime.Now}"
                    );
        foreach (var i in DataSource.Students)
        {
            if (i.StudentId == item.StudentId)
                throw new Exception("this Id already exists");
            Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The student {item.StudentId} failed to create student function {DateTime.Now}"
                    );
        }
        DataSource.Students.Add(item);
        Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The student {item.StudentId} successfully created student function {DateTime.Now}"
                    );
        return item.StudentId;
    }

    public void Delete(int id)
    {
        Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The student {id} entered to delete student function {DateTime.Now}"
                    );
        var student = DataSource.Students.FirstOrDefault(a => a.StudentId == id);
        if (student != null)
        {
            DataSource.Students.Remove(student);

            Tools.LogManager.logWriter(
                                    projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                                    funcName: MethodBase.GetCurrentMethod().Name,
                                    message: $"The student {id} successfully deleted student function {DateTime.Now}"
                                );
            return;
        }
        throw new KeyNotFoundException($"This student didnt found");
        Tools.LogManager.logWriter(
                         projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                         funcName: MethodBase.GetCurrentMethod().Name,
                         message: $"The student {id} failed to delete student function {DateTime.Now}"
                     );

    }

    public Student? Read(int id)
    {
        Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The student {id} entered to read student function {DateTime.Now}"
                    );
        Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The student {id} successfully read student function {DateTime.Now}"
                    );
        return DataSource.Students.FirstOrDefault(a => a.StudentId == id);


    }

    public List<> ReadAll(Student s, bool Is)
    {
        Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The student entered to read all student function {DateTime.Now}"
                    );
        Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The student successfully read all student function {DateTime.Now}"
                    );

        var students = DataSource.Students.Select(s => new Student
        {
            StudentId = s.StudentId,
            FirstName = s.FirstName,
            LastName = s.LastName,
            Password = s.Password,
            Email = s.Email,
            PhoneNumber = s.PhoneNumber
        }).where(s => s.s).toList();
        return [.. DataSource.Students];
    }

    public void Update(Student item)
    {
        Tools.LogManager.logWriter(
                                projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                                funcName: MethodBase.GetCurrentMethod().Name,
                                message: $"The student {item.StudentId} entered to update student function {DateTime.Now}"
                            );
        var student = DataSource.Students.FirstOrDefault(a => a.StudentId == item.StudentId);
        if (student != null)
        {

            DataSource.Students.Remove(student);
            DataSource.Students.Add(item);
            Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The student {item.StudentId} successfully updated student function {DateTime.Now}"
                    );
        }
        else throw new KeyNotFoundException($"This student didnt found");
        Tools.LogManager.logWriter(
                        projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                        funcName: MethodBase.GetCurrentMethod().Name,
                        message: $"The student {item.StudentId} failed to update student function {DateTime.Now}"
                    );

    }
}
