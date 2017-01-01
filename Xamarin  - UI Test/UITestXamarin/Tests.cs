using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITestXamarin
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }
        [Test]
        public void TabContent()
        {
            app.Tap(c => c.Marked("Content View"));
            //app.WaitFor(c => c.Marked("BtnContent"), )
        }
        [Test]
        public void TabContent2()
        {
            app.Tap(c => c.Marked("Content View"));
            //app.WaitFor(c => c.Marked("BtnContent"), )
        }
    }
}

