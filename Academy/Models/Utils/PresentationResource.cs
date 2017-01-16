using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Utils.Contracts;
using Academy.Models.Contracts;

namespace Academy.Models.Utils
{
    public class PresentationResource : LectureResource, ILectureResource
    {
        public PresentationResource(string name, string url) : base(name, url)
        {

        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("    * Resource:");
            sb.AppendLine($"     - Name: {this.Name}");
            sb.AppendLine($"     - Url: {this.Url}");
            sb.AppendLine("     - Type: Presentation");

            return sb.ToString().TrimEnd();
        }
    }
}
