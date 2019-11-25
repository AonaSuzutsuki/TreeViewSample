using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Prism.Mvvm;

namespace TreeViewSample.Models
{
    public class MainWindowModel : BindableBase
    {
        #region Fields

        private IEnumerable<TreeViewItemInfo> _savedItemInfos;
        private ObservableCollection<TreeViewItemInfo> _items;
        #endregion

        #region Properties
        public ObservableCollection<TreeViewItemInfo> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }
        #endregion

        public MainWindowModel()
        {
            Items = new ObservableCollection<TreeViewItemInfo>
            {
                new TreeViewItemInfo
                {
                    Name = "Item1"
                },
                new TreeViewItemInfo
                {
                    Name = "Item2",
                    Children = new TreeViewItemInfo[]
                    {
                        new TreeViewItemInfo
                        {
                            Name = "SubItem1"
                        },
                        new TreeViewItemInfo
                        {
                            Name = "SubItem2",
                            Children = new TreeViewItemInfo[]
                            {
                                new TreeViewItemInfo
                                {
                                    Name = "SubSubItem1"
                                }
                            }
                        }
                    }
                },
                new TreeViewItemInfo
                {
                    Name = "Item3"
                }
            };
        }

        public void Clear()
        {
            _savedItemInfos = new List<TreeViewItemInfo>(Items);
            Items.Clear();
        }

        public void DrawItems()
        {
            foreach (var item in _savedItemInfos)
            {
               Items.Add(item); 
            }
        }

        public void OpenItem()
        {
            Items[1].IsExpanded = true;
        }
    }
}
