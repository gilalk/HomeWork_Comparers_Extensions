using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson5_HW_Comparers
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Student> students = new List<Student>();

            students.Add(new Student("Gil", "Alkobi", 100));
            students.Add(new Student("Raz", "Hajaj", 77));
            students.Add(new Student("Or", "Levi", 80));
            students.Add(new Student("Eli", "Cohen", 56));
            students.Add(new Student("Eli", "Cohen", 97));
            students.Add(new Student("Yakov", "Cohen", 60));

            students.Sort();
            students.Sort(new SortStudentsByLastName());
            students.Sort(new SortStudentsByGrade());


            List<TemperatureMeasurments> measurments = new List<TemperatureMeasurments>();

            measurments.Add(new TemperatureMeasurments("Yaffo", new DateTime(2021, 8, 10), 37.4, 70));
            measurments.Add(new TemperatureMeasurments("Jerusalem", new DateTime(2021, 8, 3), 29.34, 35.5));
            measurments.Add(new TemperatureMeasurments("Netanya", new DateTime(2021, 8, 12), 38, 70.2));
            measurments.Add(new TemperatureMeasurments("Acre", new DateTime(2021, 8, 23), 28.5, 66.8));
            measurments.Add(new TemperatureMeasurments("Gilgal", new DateTime(2021, 8, 10), 37.4, 70));
            measurments.Add(new TemperatureMeasurments("Jerusalem", new DateTime(2021, 8, 11), 28.7, 40));

            measurments.Sort();
            measurments.Sort(new SortMeasurmentsByCity());
            measurments.Sort(new SortMeasurmentsByCityOrDate());
            measurments.Sort(new SortMeasurmentsByTempOrCity());



            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
