using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest
{
    [TestFixture(Platform.Android)]
    public class Tests
    {
        IApp app;
        Platform platform;
        private IAuthScreen Auth;

        public Tests(Platform platform)
        {
            this.platform = platform;
            Auth = new AndroidAuthScreen();
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        [Category("Tap")]
        [TestCase("textA")]
        [TestCase("textB")]
        [TestCase("textOp")]
        [TestCase("textRes")]
        [TestCase("btnRes")]
        public void AppButton(string id)
        {
            app.Tap(id);
        }
    }
}

