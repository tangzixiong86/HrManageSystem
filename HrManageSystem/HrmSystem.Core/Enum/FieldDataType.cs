using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrmSystem.Core.Enum
{
    /// <summary>
    /// 字段数据类型
    /// </summary>
    public enum  FieldDataType
    {
        /// <summary>
        /// 字符型
        /// </summary>
        StringValue = 0,
			/// <summary>
		/// 整数型
		/// </summary>
		IntValue = 1,
			/// <summary>
		/// 小数型
		/// </summary>
		DecimalValue = 2,
			/// <summary>
		/// 布尔型
		/// </summary>
		BoolValue = 3,
			/// <summary>
		/// 日期型
		/// </summary>
		DateValue = 4,
			/// <summary>
		/// 大文本类型
		/// </summary>
		TextValue = 5,
    }
}
