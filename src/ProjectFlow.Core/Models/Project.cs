using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFlow.Core.Models
{
    public abstract class Project
    {
        /// <summary>
        /// The primary key for the project entity.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The name of the project.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// A description of the project.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// The URL of the project's GitHub repository.
        /// </summary>
        public string GitHubUrl { get; set; } = string.Empty;

        // Other relevant project properties
    }
}
