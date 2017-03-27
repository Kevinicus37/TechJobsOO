using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechJobs.Models;

namespace TechJobs.ViewModels
{
    public class BaseViewModel
    {
        // View title
        public string Title { get; set; } = "";

        // All columns, for display
        public List<JobFieldType> Columns { get; set; }

        // Column to view or search
        public JobFieldType Column { get; set; }



        public BaseViewModel()
        {
            Columns = new List<JobFieldType>();

            foreach (JobFieldType enumVal in Enum.GetValues(typeof(JobFieldType)))
            {
                Columns.Add(enumVal);
            }
        }
    }
}
