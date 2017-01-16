using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Utils.Contracts;
using Academy.Models.Contracts;

namespace Academy.Models.Utils
{
    public class DemoResource : LectureResource, ILectureResource
    {
        public DemoResource(string name, string url) : base(name, url)
        {

        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("    * Resource:");
            sb.AppendLine($"     - Name: {this.Name}");
            sb.AppendLine($"     - Url: {this.Url}");
            sb.AppendLine("     - Type: Demo");

            return sb.ToString().TrimEnd();
        }
    }
}
