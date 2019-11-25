using System.Collections.Generic;
using Prism.Mvvm;

namespace TreeViewSample.Models
{
    public class TreeViewItemInfo : BindableBase
    {
        #region Fields
        private bool isExpanded;
        #endregion

        #region Properties
        public IEnumerable<TreeViewItemInfo> Children { get; set; }
        public string Name { get; set; }

        public bool IsExpanded
        {
            get => isExpanded;
            set => SetProperty(ref isExpanded, value);
        }

        public bool IsSelected { get; set; }
        #endregion
    }
}
