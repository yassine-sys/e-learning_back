using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    class Subscription
    {

        [Key]
        public int SubscriptionID { get; set; }

        public DateTime Date { get; set; }

        public string userId { get; set; }

        public string CourseID { get; set; }
        public string CourseProgress { get; set; }
    }
}
