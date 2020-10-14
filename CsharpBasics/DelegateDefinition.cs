using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpBasics
{
    // <access specifier> <access modifier> <return_type> delegate delegate_name(parameters)
    public delegate int NumericDelegate(int a, int b);
    public delegate DialogResult FormDialogResult();

    public class DialogResult
    {
        public string Result { get; set; }
    }
}
