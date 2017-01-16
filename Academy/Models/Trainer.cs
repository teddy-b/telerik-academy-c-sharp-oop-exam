using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    public class Trainer : ITrainer
    {
        private string username;

        public Trainer(string username, string technologies)
        {
            this.Username = username;

            this.Technologies = new List<string>();

            string[] technologiesToAdd = technologies.Split(new char[] { ',' }, StringSplitOptions.None);

            foreach (string technology in technologiesToAdd)
            {
                this.Technologies.Add(technology);
            }
        }

        public IList<string> Technologies { get; set; }

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

            sb.AppendLine("* Trainer:");
            sb.AppendLine($" - Username: {this.username}");
            sb.Append($" - Technologies:");

            for (int i = 0; i < this.Technologies.Count - 1; i++)
            {
                sb.Append($" {this.Technologies[i]};");
            }

            sb.Append($" {this.Technologies[this.Technologies.Count - 1]}");

            return sb.ToString().TrimEnd();
        }
    }
}
