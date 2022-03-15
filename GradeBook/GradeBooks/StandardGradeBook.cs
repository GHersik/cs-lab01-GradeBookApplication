using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool isweight) : base(name,isweight)
        {
            Type = Enums.GradeBookType.Standard;
        }
    }
}
