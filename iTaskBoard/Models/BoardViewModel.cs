using System.Collections.Generic;

using iTaskBoard.Models.Task;

namespace iTaskBoard.Models
{
    public class BoardViewModel
    {
        public int Id { get; init; }

        public string Name { get; init; }

        public IEnumerable<TaskViewModel> Tasks { get; set; } = new List<TaskViewModel>();
    }
}
