using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Utils
{
    public class VideoResource : LectureResource, ILectureResouce
    {
        private DateTime uploadedOn;

        public VideoResource(string name, string url, DateTime uploadedOn) : base(name, url)
        {
            this.uploadedOn = uploadedOn;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("    * Resource:");
            sb.AppendLine($"     - Name: {this.Name}");
            sb.AppendLine($"     - Url: {this.Url}");
            sb.AppendLine("     - Type: Video");
            sb.AppendLine($"     - Due date: {this.uploadedOn}");

            return sb.ToString().TrimEnd();
        }
    }
}
