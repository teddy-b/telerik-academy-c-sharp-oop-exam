using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Utils
{
    public class HomeworkResource : LectureResource, ILectureResouce
    {
        private DateTime dueDate;

        public HomeworkResource(string name, string url, DateTime dueDate) : base(name, url)
        {
            this.dueDate = dueDate;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("    * Resource:");
            sb.AppendLine($"     - Name: {this.Name}");
            sb.AppendLine($"     - Url: {this.Url}");
            sb.AppendLine("     - Type: Homework");
            sb.AppendLine($"     - Due date: {this.dueDate}");

            return sb.ToString().TrimEnd();
        }
    }
}
