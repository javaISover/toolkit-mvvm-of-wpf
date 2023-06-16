using CommunityToolkit.Mvvm.Input;
using MVVM_Toolkit.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Toolkit.ViewModels
{
    public partial class AddViewModel
    {

        public AddModel addModel { get; set; }

        public AddViewModel()
        {
            addModel = new AddModel();
        }
        

        [RelayCommand]
        private void AddMethod()
        {
            addModel.AddValue3 = addModel.AddValue1 + addModel.AddValue2;

            addModel.ResultText = "算出结果为：" + addModel.AddValue3;

            if(addModel.isPush)
            {
                addModel.isPush = false;
               
            }
            else
            {
                addModel.isPush = true;
            }
            
        }

    }
}
