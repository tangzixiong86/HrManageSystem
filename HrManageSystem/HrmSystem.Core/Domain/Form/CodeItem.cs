using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrmSystem.Core.Domain.Form
{
    /// <summary>
    /// 代码数据项
    /// </summary>
    public class CodeItem
    {
        private ICollection<CodeItem> _subItems;
        /// <summary>
        /// 选项值
        /// </summary>
        public string ItemValue { get; set; }
        /// <summary>
        /// 选项文本
        /// </summary>
        public string ItemText { get; set; }
        /// <summary>
        /// 排序号
        /// </summary>
        public int ListOrder { get; set; }
        /// <summary>
        /// 是否停用
        /// </summary>
        public bool IsPause { get; set; }
        /// <summary>
        /// 父级数据项ID
        /// </summary>
        public int? ParentItemId { get; set; }
        /// <summary>
        /// 所属代码类别ID
        /// </summary>
        public int CodeCategoryId { get; set; }
        #region 导航属性
        /// <summary>
        /// 父级数据项
        /// </summary>
        public virtual CodeItem ParentItem { get; set; }
        /// <summary>
        /// 子数据项集合
        /// </summary>
        public virtual ICollection<CodeItem> SubItems
        {
            get { return _subItems ?? (_subItems = new List<CodeItem>()); }
            protected set { _subItems = value; }
        }
        /// <summary>
        /// 所属代码类别
        /// </summary>
        public virtual CodeCategory CodeCategory { get; set; }
        #endregion
    }
}
