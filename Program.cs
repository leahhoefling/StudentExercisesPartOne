using System;
using System.Collections.Generic;

namespace studentExercises
{

    class Program
    {
        static void Main(string[] args)
        {
            // Create 4, or more, exercises.
            Exercise Dictionaries = new Exercise("Dictionaries", "C#");
            Exercise Hashsets = new Exercise("Hashsets", "C#");
            Exercise Arrays = new Exercise("Arrays", "Javascript");
            Exercise Lists = new Exercise("Lists", "Ruby");


            // Create 3, or more, cohorts.
            Cohort Cohort29 = new Cohort("Cohort 29");
            Cohort Cohort30 = new Cohort("Cohort 30");
            Cohort Cohort31 = new Cohort("Cohort 31");

            // Create 4, or more, students and assign them to one of the cohorts.
            Student Alison = new Student("Alison", "Collins", "@alison");
            Cohort29.StudentList.Add(Alison);
            Student Ash = new Student("Ash", "Praksh", "@ashwin");
            Cohort30.StudentList.Add(Ash);
            Student Asia = new Student("Asia", "Carter", "@asia");
            Cohort31.StudentList.Add(Asia);
            Student Brittany = new Student("Brittany", "Ramos", "@brittany");
            Cohort29.StudentList.Add(Brittany);

            // Create 3, or more, instructors and assign them to one of the cohorts.

            Instructor Andy = new Instructor("Andy", "Collins", "askingalot", Cohort29);
            Cohort29.InstructorList.Add(Andy);

            Instructor Leah = new Instructor("Leah", "Hoefling", "leahhoefling", Cohort30);
            Cohort30.InstructorList.Add(Leah);

            Instructor Jisie = new Instructor("Jisie", "David", "jisie", Cohort31);
            Cohort31.InstructorList.Add(Jisie);

            // Have each instructor assign 2 exercises to each of the students.
            Jisie.AssignExercise(Asia, Dictionaries);
            Jisie.AssignExercise(Asia, Hashsets);
            Andy.AssignExercise(Brittany, Lists);
            Andy.AssignExercise(Brittany, Lists);
            Andy.AssignExercise(Alison, Arrays);
            Andy.AssignExercise(Alison, Hashsets);
            Leah.AssignExercise(Ash, Hashsets);
            Leah.AssignExercise(Ash, Lists);
        }
    }
}
