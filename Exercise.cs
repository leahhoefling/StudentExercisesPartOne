using System.Collections.Generic;
namespace studentExercises
{
    public class Exercise
    {
        public string ExerciseName { get; set; }
        public string ExerciseLanguage { get; set; }

        public Exercise(string exerciseName, string exerciseLanguage)
        {
            ExerciseName = exerciseName;
            ExerciseLanguage = exerciseLanguage;
        }
    }
}