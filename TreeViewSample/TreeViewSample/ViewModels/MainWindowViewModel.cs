using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Prism.Commands;
using Reactive.Bindings;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    public class MainWindowViewModel
    {
        #region Fields
        private readonly MainWindowModel model;
        #endregion

        #region Properties
        public ReadOnlyReactiveCollection<TreeViewItemInfo> TreeViewItems { get; set; }
        #endregion

        #region Event Properties
        public ICommand ClearBtClicked { get; set; }
        public ICommand DrawBtClicked { get; set; }
        #endregion

        public MainWindowViewModel(MainWindowModel model)
        {
            this.model = model;
            TreeViewItems = model.Items.ToReadOnlyReactiveCollection(item => item);

            ClearBtClicked = new DelegateCommand(ClearBt_Clicked);
            DrawBtClicked = new DelegateCommand(DrawBt_Clicked);
        }

        #region Event Methods

        public void ClearBt_Clicked()
        {
            model.Clear();
        }
        public void DrawBt_Clicked()
        {
            model.DrawItems();
        }
        #endregion
    }
}
