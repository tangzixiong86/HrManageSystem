using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrmSystem.Core.Domain.Form
{
    /// <summary>
    /// 代码类别
    /// </summary>
    public class CodeCategory : BaseEntity
    {
        private ICollection<CodeItem> _codeItems;
        /// <summary>
        /// 名称
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 是否停用
        /// </summary>
        public bool IsPause { get; set; }
        /// <summary>
        /// 是否系统类别
        /// </summary>
        public bool IsSystem { get; set; }
        /// <summary>
        /// 所属目录ID
        /// </summary>
        public int? CodeCategoryDirectoryId { get; set; }

        #region 导航属性
        /// <summary>
        /// 所属目录
        /// </summary>
        public virtual CodeCategoryDirectory CodeCategoryDirectory { get; set; }
        /// <summary>
        /// 属于该代码类别下的数据项集合
        /// </summary>
        public virtual ICollection<CodeItem> CodeItems
        {
            get { return _codeItems ?? (_codeItems = new List<CodeItem>()); }
            protected set { _codeItems = value; }
        }
        #endregion
    }
}
