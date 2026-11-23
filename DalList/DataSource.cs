using DO;

namespace Dal
{
    static internal class DataSource
    {
        //רשימה המכילה את הפניות לכל ישות
        static internal List<Student?> Students = new List<Student?>();
        static internal List<Test?> Tests = new List<Test?>();
        static internal List<Question?> quastions = new List<Question?>();
        static internal List<Answer?> answers = new List<Answer?>();
        static internal List<QuesForExaminee?> questionExaminees = new List<QuesForExaminee?>();


        static internal class Config
        {
            //אתחול מספר ראשוני לכל ישות
            internal const int TestId = 100;
            internal const int StudentId = 1000;
            internal const int QuestionId = 1;
            internal const int AnswerId = 1;
            internal const int QuestionAnswerId = 1;

            //אתחול מספר רץ לכל ישות במספר הקבוע
            static private int initialTest = TestId;
            static private int initialStudent = StudentId;
            static private int initialQuestion = QuestionId;
            static private int initialAnswer = AnswerId;
            static internal int initialQuesForExaminee = 1;


            //פונקציות קידום למספרים רצים

            internal static int InitialTest
            {
                get
                {
                    return initialTest++;

                }
            }
            internal static int InitialStudent
            {
                get
                {
                    return initialStudent++;
                }
            }

            internal static int InitialQuestion
            {
                get
                {
                    return initialQuestion+=4;
                }

            }
            internal static int InitialQuesForExaminee
			{
                get
                {
                    return initialQuesForExaminee++;
                }
            }
            internal static int InitialAnswer
            {
                get
                {
                    return initialAnswer++;
                }
            }
        }
    }
}