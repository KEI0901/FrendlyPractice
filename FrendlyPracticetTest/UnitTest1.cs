using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Codeer.Friendly;
using Codeer.Friendly.Dynamic;
using Codeer.Friendly.Windows;
using Codeer.Friendly.Windows.Grasp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FrendlyPracticetTest
{
    [TestClass]
    public class UnitTest1
    {
        private WindowsAppFriend _app;
        private TestDriver _testDriver;

        [TestInitialize]
        public void Initialize()
        {
            var process = Process.Start("FrendlyPractice.exe");
            this._app = new WindowsAppFriend(process);
            var windowsControl = new WindowControl(this._app.Type<Application>().OpenForms[0]);
            this._testDriver = new TestDriver(windowsControl);
        }

        [TestMethod]
        public void TestMethod1()
        {
            this._testDriver.NameTextBox.EmulateChangeText("テスト 太郎");
            this._testDriver.NameKanaTextBos.EmulateChangeText("テスト タロウ");
            this._testDriver.RegisterButton.EmulateClick();

            using (var reader = new StreamReader("user.csv"))
            {
                var text = reader.ReadLine();
                var texts = text.Split(',');
                Assert.AreEqual(texts[0], "テスト 太郎");
                Assert.AreEqual(texts[1], "テスト タロウ");
            }


        }

        [TestCleanup]
        public void CleanUp()
        {
            this._app.Dispose();
        }

    }
}
