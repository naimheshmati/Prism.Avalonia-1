using System;
using Avalonia;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prism.IocContainer.Avalonia.Tests.Support;
using Prism.Logging;

namespace Prism.Unity.Wpf.Tests
{
    [TestClass]
    public class UnityBootstrapperNullLoggerFixture : BootstrapperFixtureBase
    {
        [TestMethod]
        public void NullLoggerThrows()
        {
            var bootstrapper = new NullLoggerBootstrapper();

            AssertExceptionThrownOnRun(bootstrapper, typeof(InvalidOperationException), "ILoggerFacade");
        }

        internal class NullLoggerBootstrapper : UnityBootstrapper
        {
            protected override ILoggerFacade CreateLogger()
            {
                return null;
            }

            protected override IAvaloniaObject CreateShell()
            {
                throw new NotImplementedException();
            }

            protected override void InitializeShell()
            {
                throw new NotImplementedException();
            }
        }
    }
}