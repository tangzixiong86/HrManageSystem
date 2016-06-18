using HrmSystem.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrmSystem.Core.Domain.Form
{
    /// <summary>
    /// 字段
    /// </summary>
    public class Field
    {
        /// <summary>
        /// 字段代码
        /// </summary>
        public string FieldCode { get; set; }
        /// <summary>
        /// 字段名称
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 字段实现类型
        /// </summary>
        public FieldImplementType ImplementType { get; set; }
        /// <summary>
        /// 字段数据类型
        /// </summary>
        public FieldDataType DataType { get; set; }
        /// <summary>
        /// 字段类型
        /// </summary>
        public FieldType FieldType { get; set; }
       
        /// <summary>
        /// 字段长度
        /// </summary>
        public int FieldSize { get; set; }
        /// <summary>
        /// 小数位数
        /// </summary>
        public int DotNum { get; set; }
        /// <summary>
        /// 是否允许多值
        /// </summary>
        public bool IsMuliInput { get; set; }
        /// <summary>
        /// 是否建立索引
        /// </summary>
        public bool IsIndex { get; set; }
        /// <summary>
        /// 默认值
        /// </summary>
        public string DefaultValue { get; set; }
        /// <summary>
        /// 格式字符串
        /// </summary>
        public string FormatString { get; set; }
        /// <summary>
        /// 是否系统属性
        /// </summary>
        public bool IsSystem { get; set; }
        /// <summary>
        /// 字段绑定的代码类别ID
        /// </summary>
        public int? CodeCategoryId { get; set; }
        //todo:增加对资源的引用

        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime? UpdateDate { get; set; }

        #region 导航属性
        /// <summary>
        /// 字段绑定的代码类别
        /// </summary>
        public CodeCategory CodeCategory { get; set; }
        #endregion

    }
}
