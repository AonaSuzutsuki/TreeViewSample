using System;
using System.Collections.Generic;
using System.Text;
using Prism.Mvvm;

namespace WpfApp1.Models
{
    public class TreeViewItemInfo : BindableBase
    {
        #region Fields
        private bool _isExpanded;
        private bool _isSelected;
        #endregion

        #region Properties
        public IEnumerable<TreeViewItemInfo> Children { get; set; }
        public string Name { get; set; }

        public bool IsExpanded
        {
            get => _isExpanded;
            set => SetProperty(ref _isExpanded, value);
        }

        public bool IsSelected
        {
            get => _isSelected;
            set => SetProperty(ref _isSelected, value);
        }
        #endregion
    }
}
