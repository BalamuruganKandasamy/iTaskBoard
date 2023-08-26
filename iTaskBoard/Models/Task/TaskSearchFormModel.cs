using iTaskBoard.Data;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace iTaskBoard.Models.Task
{
    using static DataConstants;
    public class TaskSearchFormModel
    {
        [StringLength(MaxKeyword)]
        public string Keyword { get; init; }

        public IEnumerable<TaskViewModel> Tasks { get; set; } = new List<TaskViewModel>();
    }
}
