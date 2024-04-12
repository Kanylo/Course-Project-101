using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using kp_deEncode.Core;
using Prism.Mvvm;

namespace kp_deEncode.MVVM.ViewModel
{
    public class DecodeViewModel : BindableBase
    {
        private string _input;
        private string _output;

        public string Input
        {
            get { return _input; }
            set
            {
                SetProperty(ref _input, value);
                Output = Solving.DecodeFromBase64(value);
            }
        }

        public string Output
        {
            get { return _output; }
            set { SetProperty(ref _output, value); }
        }
    }
    
}
