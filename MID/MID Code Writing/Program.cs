using System;
using static System.Net.WebRequestMethods;

namespace MidCodeWriting_Course
{
    public class Course
    {
        internal string courseId;
        internal string title;
        internal string instructorName;
        internal double basePrice;

        public Course (string courseId, string title, string instructorName, double basePrice)
        {
            this.courseId = courseId;
            this.title = title;
            this.instructorName = instructorName;
            this.basePrice = basePrice;
        }

        public virtual double CalculateFinalPrice ()
        {
            return basePrice;
        }

        public bool IsPremiumCourse ()
        {
            return CalculateFinalPrice() > 5000;
        }

        public virtual void ShowCourseInfo ()
        {
            Console.WriteLine ("Course ID: " + courseId);
            Console.WriteLine ("Course Title: " + title);
            Console.WriteLine ("Instructor Name: " + instructorName);
            Console.WriteLine ("Base Price: " + basePrice);
            Console.WriteLine ("Final Price: " + (CalculateFinalPrice() + basePrice));

            if (IsPremiumCourse())
            {
                Console.WriteLine("Course Type: Premium");
            }
            else
            {
                Console.WriteLine("Course Type: Non Premium");
            }
        }
    }

    public class LiveCourse : Course
    {
        internal int maxStudents;
        internal int classWeek;

        public LiveCourse (string courseId, string title, string instructorName, double basePrice, int maxStudents, int classWeek) : base(courseId, title, instructorName, basePrice)
        {
            if (maxStudents <= 50)
            {
                this.maxStudents = maxStudents;
            }
            this.classWeek = classWeek;
        }

        public override double CalculateFinalPrice()
        {
            if (classWeek > 8)
            {
                return 0.2 * basePrice;
            }
            else
            {
                return basePrice;
            }
        }

        public override void ShowCourseInfo()
        {
            base.ShowCourseInfo();
            Console.WriteLine("Maximum Student: " + maxStudents);
            Console.WriteLine("Class Weeks: " + classWeek);
        }
    }

    public class RecordedCourse : Course
    {
        internal int totalVideoHour;
        internal bool lifeTimeAccess;

        public RecordedCourse (string courseId, string title, string instructorName, double basePrice, int totalVideoHour, bool lifeTimeAccess) : base(courseId, title, instructorName, basePrice)
        {
            this.totalVideoHour = totalVideoHour;
            this.lifeTimeAccess = lifeTimeAccess;
        }

        public override double CalculateFinalPrice()
        {
            if (totalVideoHour > 100)
            {
                return 0.1 * basePrice;
            }
            else
            {
                return basePrice;
            }
        }

        public override void ShowCourseInfo()
        {
            base.ShowCourseInfo();
            Console.WriteLine("Total Video Hour: " + totalVideoHour);
            Console.WriteLine("Life Time Accessibility: " + lifeTimeAccess);
        }
    }

    public class Program
    {
        internal static void Main(string[] args)
        {
            Course[] course = new Course[2];

            course[0] = new LiveCourse("00123", "C#", "Kazi Sadia Afroze", 1000, 30, 10);
            course[1] = new RecordedCourse("05123", "C++", "Nazia Alfaz", 300, 500, true);

            foreach (Course c in course)
            {
                c.ShowCourseInfo();
                Console.WriteLine();
            }
        }
    }
}