using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity_Exp_01.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumOfLesson { get; set; }
        public int Grade { get; set; }
        public string UserId { get; set; }

    }
}
