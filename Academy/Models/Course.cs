using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    public class Course : ICourse
    {
        private string name;
        private int lecturesPerWeek;

        public Course(string name, int lecturesPerWeek, DateTime startingDate)
        {
            this.Name = name;
            this.LecturesPerWeek = lecturesPerWeek;
            this.StartingDate = startingDate;

            this.EndingDate = startingDate.AddDays(30);

            this.Lectures = new List<ILecture>();
            this.OnlineStudents = new List<IStudent>();
            this.OnsiteStudents = new List<IStudent>();
    }

        public DateTime EndingDate { get; set; }

        public IList<ILecture> Lectures { get; }

        public int LecturesPerWeek
        {
            get
            {
                return this.lecturesPerWeek;
            }

            set
            {
                if (value < 1 || value > 7)
                {
                    throw new ArgumentException("The number of lectures per week must be between 1 and 7!");
                }

                this.lecturesPerWeek = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length < 3 || value.Length > 45)
                {
                    throw new ArgumentException("The name of the course must be between 3 and 45 symbols!");
                }

                this.name = value;
            }
        }

        public IList<IStudent> OnlineStudents { get; }

        public IList<IStudent> OnsiteStudents { get; }

        public DateTime StartingDate { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("* Course:");
            sb.AppendLine($" - Name: {this.name}");
            sb.AppendLine($" - Lectures per week: {this.lecturesPerWeek}");
            sb.AppendLine($" - Starting date: {this.StartingDate}");
            sb.AppendLine($" - Ending date: {this.EndingDate}");
            sb.AppendLine($" - Onsite students: {this.OnsiteStudents.Count}");
            sb.AppendLine($" - Online students: {this.OnlineStudents.Count}");
            sb.AppendLine($" - Lectures:");

            if (this.Lectures.Count == 0)
            {
                sb.AppendLine("  * There are no lectures in this course!");
            }
            else
            {
                foreach (var lecture in this.Lectures)
                {
                    sb.AppendLine(lecture.ToString());
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
