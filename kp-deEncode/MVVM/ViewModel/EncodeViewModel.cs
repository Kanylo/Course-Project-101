using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kp_deEncode.Core;
using Prism.Mvvm;
using System.Windows.Input;

namespace kp_deEncode.MVVM.ViewModel
{
    public class EncodeViewModel : BindableBase
    {
        private string _input;
        private string _output;

        public string Input
        {
            get { return _input; }
            set
            {
                SetProperty(ref _input, value);
                Output = Solving.EncodeToBase64(value);
            }
        }

        public string Output
        {
            get { return _output; }
            set { SetProperty(ref _output, value); }
        }

       
    }

}
