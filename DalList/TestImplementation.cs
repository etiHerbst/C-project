using DO;
using DalApi;
using Tools;
using System.Reflection;

namespace Dal;

internal class TestImplementation : ITest
{

    public int Create(Test item)
    {
        Tools.LogManager.logWriter(
                           projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                           funcName: MethodBase.GetCurrentMethod().Name,
                           message: $"The test {item.TestId} entered to create test function {DateTime.Now}"
                       );
        try
        {

            int Id = DataSource.Config.InitialTest;

            Test copyTest = item with { TestId = Id };
            
           DataSource.Tests.Add(copyTest);
            Tools.LogManager.logWriter(
                           projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                           funcName: MethodBase.GetCurrentMethod().Name,
                           message: $"The test {item.TestId} successfully created test function {DateTime.Now}"
                       );
            return Id;
        } 
        catch {
            
            throw new NotImplementedException();
            Tools.LogManager.logWriter(
                           projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                           funcName: MethodBase.GetCurrentMethod().Name,
                           message: $"The test {item.TestId} failed to create test function {DateTime.Now}"
                       );
        }
    }

    public void Delete(int id)
    {
        Tools.LogManager.logWriter(
                           projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                           funcName: MethodBase.GetCurrentMethod().Name,
                           message: $"The test {id} entered to delete test function {DateTime.Now}"
                       );
        var test = DataSource.Tests.FirstOrDefault(a => a.TestId == id);
        if (test != null)
        {
            DataSource.Tests.Remove(test);
            Tools.LogManager.logWriter(
                           projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                           funcName: MethodBase.GetCurrentMethod().Name,
                           message: $"The test {id} successfully deleted test function {DateTime.Now}"
                       );
        }
        else throw new KeyNotFoundException($"This test didnt found");
        Tools.LogManager.logWriter(
                           projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                           funcName: MethodBase.GetCurrentMethod().Name,
                           message: $"The test {id} failed to delete test function {DateTime.Now}"
                       );
    }

    public Test? Read(int id)
    {
        Tools.LogManager.logWriter(
                           projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                           funcName: MethodBase.GetCurrentMethod().Name,
                           message: $"The test {id} entered to read test function {DateTime.Now}"
                       );
        Tools.LogManager.logWriter(
                           projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                           funcName: MethodBase.GetCurrentMethod().Name,
                           message: $"The test {id} successfully read test function {DateTime.Now}"
                       );
        return DataSource.Tests.FirstOrDefault(a => a.TestId == id);
    }

    public List<Test> ReadAll()
    {
        Tools.LogManager.logWriter(
                           projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                           funcName: MethodBase.GetCurrentMethod().Name,
                           message: $"The test entered to read all test function {DateTime.Now}"
                       );
        Tools.LogManager.logWriter(
                           projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                           funcName: MethodBase.GetCurrentMethod().Name,
                           message: $"The test successfully read all test function {DateTime.Now}"
                       );
        return [ ..DataSource.Tests];
    }

    public void Update(Test item)
    {
        Tools.LogManager.logWriter(
                           projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                           funcName: MethodBase.GetCurrentMethod().Name,
                           message: $"The test {item.TestId} entered to update test function {DateTime.Now}"
                       );
        var test = DataSource.Tests.FirstOrDefault(a => a.TestId == item.TestId);
        if (test != null)
        {
            DataSource.Tests.Remove(test);
            DataSource.Tests.Add(item);
            Tools.LogManager.logWriter(
                           projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                           funcName: MethodBase.GetCurrentMethod().Name,
                           message: $"The test {item.TestId} successfully updated test function {DateTime.Now}"
                       );
        }
        else throw new KeyNotFoundException($"This test didnt found");
        Tools.LogManager.logWriter(
                           projectName: MethodBase.GetCurrentMethod().DeclaringType.FullName,
                           funcName: MethodBase.GetCurrentMethod().Name,
                           message: $"The test {item.TestId} failed to update test function {DateTime.Now}"
                       );
    }
}
