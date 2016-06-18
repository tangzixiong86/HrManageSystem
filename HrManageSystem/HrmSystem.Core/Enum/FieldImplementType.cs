using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrmSystem.Core.Enum
{
    /// <summary>
    /// 字段实现类型
    /// </summary>
    public enum FieldImplementType
    {
        /// <summary>
        /// 物理字段
        /// </summary>
        PhysicalField = 0,
        /// <summary>
        /// 逻辑字段
        /// </summary>
        LogicalField = 1,
        /// <summary>
        /// 虚拟字段
        /// </summary>
        VirtualField = 2,
    }
}
