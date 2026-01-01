using System;
using Karpach.RemoteShutdown.Controller.Helpers;
using NUnit.Framework;

namespace Karpach.RemoteShutdown.Controller.Tests
{
    [TestFixture]
    public class TrayCommandTests
    {
        [Test, Explicit("Local test for commands")]
        public void TestTurnScreenOff()
        {
            // Arrange
            var commandHelper = new TrayCommandHelper();

            // Act
            commandHelper.RunCommand(TrayCommandType.TurnScreenOff);
        }
    }
}
 