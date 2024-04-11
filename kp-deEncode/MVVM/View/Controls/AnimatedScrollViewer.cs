using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using kp_deEncode.MVVM.ViewModel;

namespace kp_deEncode.MVVM.View.Controls
{
    public class AnimatedScrollViewer : ScrollViewer
    {
        protected override void OnScrollChanged(ScrollChangedEventArgs e)
        {
            base.OnScrollChanged(e);

            if (e.VerticalChange > 0)
            {
                // Assuming the DataContext is your MainViewModel
                ((MainViewModel)DataContext).ScrollDown();
            }
        }
    }

}
