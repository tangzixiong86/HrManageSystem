using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrmSystem.Core.Enum
{
    /// <summary>
    /// 字段类型
    /// </summary>
    public enum FieldType
    {
        /// <summary>
        /// 常规
        /// </summary>
        Normal = 0,
        /// <summary>
        /// 图像
        /// </summary>
        Image = 1,
        /// <summary>
        /// 附件
        /// </summary>
        Attachment = 2,
        /// <summary>
        /// 列表
        /// </summary>
        List = 3,
        /// <summary>
        /// 系统资源
        /// </summary>
        Resource = 4,
    }
}
