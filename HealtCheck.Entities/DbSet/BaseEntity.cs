using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealtCheck.Entities.DbSet
{
    public abstract class BaseEntity
    {
        public Guid Id
        {
            get
            {
                return Guid.NewGuid();
            }
        }
        // for hard delete
        public int Status
        {
            get
            {
                return 1;
            }
        }
        public DateTime AddedDate
        {
            get
            {
                return DateTime.UtcNow;
            }
        } 
        public DateTime UpdatedDate { get; set; }
    }
}