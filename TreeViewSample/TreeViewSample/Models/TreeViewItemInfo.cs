using System;
using System.Collections.Generic;
using System.Text;
using Prism.Mvvm;

namespace TreeViewSample.Models
{
    public class TreeViewItemInfo
    {
        #region Properties
        public IEnumerable<TreeViewItemInfo> Children { get; set; }
        public string Name { get; set; }

        public bool IsExpanded { get; set; }

        public bool IsSelected { get; set; }
        #endregion
    }
}
