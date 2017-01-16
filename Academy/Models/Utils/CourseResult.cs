using Academy.Models.Utils.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;
using Academy.Models.Enums;

namespace Academy.Models.Utils
{
    class CourseResult : ICourseResult
    {
        private float examPoints;
        private float coursePoints;
        private Grade grade;

        public CourseResult(ICourse course, float examPoints, float coursePoints)
        {
            this.Course = course;
            this.ExamPoints = examPoints;
            this.CoursePoints = coursePoints;

            if (this.ExamPoints >= 65 || this.CoursePoints >= 75)
            {
                this.grade = Grade.Excellent;
            }
            else if (this.ExamPoints >= 30 || this.ExamPoints > 60 || this.CoursePoints >= 45 || this.CoursePoints > 75)
            {
                this.grade = Grade.Passed;
            }
            else
            {
                this.grade = Grade.Failed;
            }
        }

        public ICourse Course { get; }

        public float CoursePoints
        {
            get
            {
                return this.coursePoints;
            }

            set
            {
                if (value < 0 || value > 125)
                {
                    throw new ArgumentException("Course result's course points should be between 0 and 125!");
                }

                this.coursePoints = value;
            }
        }

        public float ExamPoints
        {
            get
            {
                return this.examPoints;
            }

            set
            {
                if (value < 0 || value > 1000)
                {
                    throw new ArgumentException("Course result's exam points should be between 0 and 1000!");
                }

                this.examPoints = value;
            }
        }

        public Grade Grade { get; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            
            sb.AppendLine($"  * {this.Course.Name}: Points - {this.CoursePoints}, Grade - {this.Grade}");
            
            return sb.ToString().TrimEnd();
        }
    }
}
