using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorgenGry
{
    public class CourseRepository
    {
        private List<Course> courses = new List<Course>();

        public void AddCourse(Course c)
        {
            courses.Add(c);
        }
        public Course GetCourse(string name)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].Name == name)
                {
                    return courses[i];
                }
            }
            return null;
        }
        public double GetTotalValue()
        {
            double DidriksLomme = 0;
            for (int i = 0; i < courses.Count; i++)
            {
                DidriksLomme += Utility.GetValueOfCourse(courses[i]);
            }
            return DidriksLomme;
        }

    }
}
