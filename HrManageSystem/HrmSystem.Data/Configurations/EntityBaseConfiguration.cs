using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HrmSystem.Core;

namespace HrmSystem.Data.Configurations
{
    public class EntityBaseConfiguration<T>: EntityTypeConfiguration<T> where T : BaseEntity
    {
        protected EntityBaseConfiguration()
        {
            PostInitialize();
        }

        /// <summary>
        /// Developers can override this method in custom partial classes
        /// in order to add some custom initialization code to constructors
        /// </summary>
        protected virtual void PostInitialize()
        {
            HasKey(e => e.Id);
        }
    }
}
