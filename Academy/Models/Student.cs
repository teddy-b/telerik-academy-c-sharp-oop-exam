using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Utils.Contracts;
using Academy.Models.Enums;

namespace Academy.Models
{
    public class Student : IStudent
    {
        private string username;
        private Track track;

        public Student(string username, Track track)
        {
            this.Username = username;
            this.Track = track;

            this.CourseResults = new List<ICourseResult>();
        }

        public IList<ICourseResult> CourseResults { get; set; }

        public Track Track
        {
            get
            {
                return this.track;
            }

            set
            {
                if (!(value.Equals(Track.Frontend) || value.Equals(Track.Dev) || value.Equals(Track.None)))
                {
                    throw new ArgumentException("The provided track is not valid!");
                }

                this.track = value;
            }
        }

        public string Username
        {
            get
            {
                return this.username;
            }

            set
            {
                if (value.Length < 3 || value.Length > 16)
                {
                    throw new ArgumentException("User's username should be between 3 and 16 symbols long!");
                }

                this.username = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("* Student:");
            sb.AppendLine($" - Username: {this.username}");
            sb.AppendLine($" - Track: {this.track}");
            sb.AppendLine($" - Course results:");

            if (this.CourseResults.Count == 0)
            {
                sb.AppendLine("  * User has no course results!");
            }
            else
            {
                foreach (var courseResult in this.CourseResults) {
                    sb.AppendLine(courseResult.ToString());
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
