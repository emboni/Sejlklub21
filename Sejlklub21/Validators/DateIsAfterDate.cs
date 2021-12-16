using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sejlklub21.Validators
{
    /// <summary>
    /// Validates that a DateTime is after another DateTime, Now by default
    /// </summary>
    public class DateIsAfterDate : ValidationAttribute
    {
        public DateTime MustBeAfter { get; set; }

        
        public DateIsAfterDate()
        {
            this.MustBeAfter = DateTime.Now;
        }

        public override bool IsValid(object value)
        {
            return MustBeAfter.CompareTo(value) < 0;
        }
    }
}
