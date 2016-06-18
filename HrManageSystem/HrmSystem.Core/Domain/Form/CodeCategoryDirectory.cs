using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrmSystem.Core.Domain.Form
{
    /// <summary>
    /// 代码类别目录
    /// </summary>
    public class CodeCategoryDirectory:BaseEntity
    {
        private ICollection<CodeCategoryDirectory> _subDirs;
        private ICollection<CodeCategory> _codeCategories;
        /// <summary>
        /// 目录名称
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 父目录ID
        /// </summary>
        public int? ParentDirId { get; set; }

        #region 导航属性
        /// <summary>
        /// 父目录
        /// </summary>
        public virtual CodeCategoryDirectory ParentDir { get; set; }
        /// <summary>
        /// 子目录集合
        /// </summary>
        public virtual ICollection<CodeCategoryDirectory> SubDirs
        {
            get { return _subDirs ?? (_subDirs= new List<CodeCategoryDirectory>());}
            protected set { _subDirs = value; }
        }
        /// <summary>
        /// 属于该目录下的代码类别集合
        /// </summary>
        public virtual ICollection<CodeCategory> CodeCategories
        {
            get { return _codeCategories ?? (_codeCategories = new List<CodeCategory>()); }
            protected set { _codeCategories = value; }
        }
        #endregion
    }
}
