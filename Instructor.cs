using System.Collections.Generic;
using System;
namespace studentExercises
{
    public class Instructor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort CohortName { get; set; }
        public void AssignExercise(Student student, Exercise exercise)
        {

            student.ExerciseList.Add(exercise);
            Console.WriteLine($"Instructor {FirstName} assigned the exercise, {exercise.ExerciseName}, to {student.FirstName}");

        }

        public Instructor(string firstName, string lastName, string slackHandle, Cohort cohortName)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            CohortName = cohortName;
        }
    }

}