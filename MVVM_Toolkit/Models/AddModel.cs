using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Drawing;

namespace MVVM_Toolkit.Models
{
    public partial class AddModel : ObservableObject
    {
       
        //计算结果显示
        [ObservableProperty]
        private string? resultText;
       
        public int AddValue1 { get; set; } = 0;
        public int AddValue2 { get; set; } = 0;

        [ObservableProperty]
        private int addValue3 = 0;

        //输入文本
        [ObservableProperty]
        private string? inputText;

        //输入文本
        [ObservableProperty]
        public bool isPush = true;

    }
}
