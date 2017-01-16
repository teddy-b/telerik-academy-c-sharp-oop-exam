using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Utils
{
    class Lecture : ILecture
    {
        private string name;

        public Lecture(string name, DateTime date, ITrainer trainer)
        {
            this.Name = name;
            this.Date = date;
            this.Trainer = trainer;

            this.Resouces = new List<ILectureResouce>();
        }

        public DateTime Date { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length < 5 || value.Length > 30)
                {
                    throw new ArgumentException("Lecture's name should be between 5 and 30 symbols long!");
                }

                this.name = value;
            }
        }

        public IList<ILectureResouce> Resouces { get; }

        public ITrainer Trainer { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("  * Lecture:");
            sb.AppendLine($"   - Name: {this.name}");
            sb.AppendLine($"   - Date: {this.Date}");
            sb.AppendLine($"   - Trainer username: {this.Trainer.Username}");
            sb.AppendLine($"   - Resources:");

            if (this.Resouces.Count == 0)
            {
                sb.AppendLine("    * There are no resources in this lecture.");
            }
            // else
            // {
            //     foreach (var resouce in this.Resouces)
            //     {
            //         sb.AppendLine(resouce.ToString());
            //     }
            // }

            return sb.ToString().TrimEnd();
        }
    }
}
