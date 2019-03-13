using System.Collections.Generic;
namespace studentExercises
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public string CohortName { get; set; }

        //The collection of exercises that the student is currently working on

        public List<Exercise> ExerciseList { get; set; }

        public Student(string firstName, string lastName, string slackHandle)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            ExerciseList = new List<Exercise>();
        }
    }
}