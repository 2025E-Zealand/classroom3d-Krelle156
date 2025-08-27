using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class ClassRoom
    {
        public string RoomName { get; private set; }
        public List<Student> Students { get; private set; }
        public DateTime SemesterStart { get; private set; }

        public ClassRoom(string name, DateTime startDate)
        {
            RoomName = name;
            SemesterStart = startDate;

            Students = new List<Student>();
        }

        public override string ToString()
        {
            return $"Classroom: {RoomName}, stated in {SemesterStart}. Current number of students: {Students.Count}";
        }
    }
}
