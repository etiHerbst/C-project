using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO;

public record Question(
    int QuestionId,
    QuestionSubject Subject,
    string QuastionContent,
    int RightAns
)
{
    public Question() : this(0, default, string.Empty, 0) { }
}
