using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExamplesProject
{
    class Class
    {
        public int Id { get; set; }
        public string Subject {get; set;}
        public int Section { get; set; }
        public int InstructorId { get; set; }

        public Class(int Id, string subject, int section, int instructorId)
        {
            this.Id = Id;
            this.Subject = subject;
            this.Section = section;
            this.InstructorId = instructorId;
        }
    }
}
