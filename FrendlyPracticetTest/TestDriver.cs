using Codeer.Friendly.Dynamic;
using Codeer.Friendly.Windows.Grasp;
using Ong.Friendly.FormsStandardControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrendlyPracticetTest
{
    class TestDriver
    {
        public WindowControl WindowControl { get; }
        public FormsButton RegisterButton { get; }
        public FormsTextBox NameTextBox { get; }
        public FormsTextBox NameKanaTextBos { get;  }

        public TestDriver(WindowControl windowControl)
        {
            this.WindowControl = windowControl;
            this.RegisterButton = new FormsButton(windowControl.Dynamic().btnRegister);
            this.NameTextBox = new FormsTextBox(windowControl.Dynamic().txtName);
            this.NameKanaTextBos = new FormsTextBox(windowControl.Dynamic().txtNameKana);
        }
    }
}
