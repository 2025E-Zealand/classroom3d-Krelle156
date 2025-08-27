namespace ClassRoomNet60;
public class Program
{
    private static void Main(string[] args)
    {
        ClassRoom testRoom = new ClassRoom("Nurgle", new DateTime(2025, 01, 11));

        testRoom.Students.Add(new Student("Bob1", 1, 1));
        testRoom.Students.Add(new Student("Bob2", 12, 12));
        testRoom.Students.Add(new Student("Bob3", 7, 30));
        testRoom.Students.Add(new Student("Bob4", 1, 1));
        testRoom.Students.Add(new Student("Bob5", 12, 24));
        testRoom.Students.Add(new Student("Bob6", 1, 1));
        testRoom.Students.Add(new Student("Bob7", 1, 1));

        Console.WriteLine(testRoom);

        foreach(Student student in testRoom.Students)
        {
            Console.WriteLine(student);
        }

    }
}