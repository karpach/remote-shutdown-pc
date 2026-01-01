using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Karpach.RemoteShutdown.Controller.Helpers;
using Karpach.RemoteShutdown.Controller.Interfaces;
using Microsoft.AspNetCore.Http;
using Moq;
using Moq.AutoMock;
using NUnit.Framework;

namespace Karpach.RemoteShutdown.Controller.Tests
{
    [TestFixture]
    public class HostHelperTests
    {
        private AutoMocker _mocker;
        private HostHelper _hostHelper;

        [SetUp]
        public void Init()
        {
            _mocker = new AutoMocker();
            _hostHelper = _mocker.CreateInstance<HostHelper>();
            _hostHelper.DefaultCommand = TrayCommandType.Suspend;
        }

        [Test]  
        [TestCase("shutdown", TrayCommandType.Shutdown)]
        [TestCase("restart", TrayCommandType.Restart)]
        [TestCase("hibernate", TrayCommandType.Hibernate)]
        public async Task ProcessRequestAsync_Ignore_Secret(string commandText, TrayCommandType command)
        {
            // Arrange                        
            _mocker.GetMock<ITrayCommandHelper>().Setup(x => x.GetCommandType(commandText)).Returns(command);
            var queryCollection = new Mock<IQueryCollection>().Object;

            // Act
            await _hostHelper.ProcessRequestAsync($"/someCode/{commandText}", queryCollection).ConfigureAwait(false);

            // Assert
            _mocker.Verify<ITrayCommandHelper>(x => x.RunCommand(command), Times.Once);
        }                

        [Test]
        [TestCase("shutdown", TrayCommandType.Shutdown)]
        [TestCase("restart", TrayCommandType.Restart)]
        [TestCase("hibernate", TrayCommandType.Hibernate)]
        public async Task ProcessRequestAsync_No_Secret(string commandText, TrayCommandType command)
        {
            // Arrange            
            _mocker.GetMock<ITrayCommandHelper>().Setup(x => x.GetCommandType(commandText)).Returns(command);
            var queryCollection = new Mock<IQueryCollection>().Object;

            // Act
            await _hostHelper.ProcessRequestAsync($"/{commandText}", queryCollection).ConfigureAwait(false);

            // Assert
            _mocker.Verify<ITrayCommandHelper>(x => x.RunCommand(command), Times.Once);
        }

        [Test]        
        public async Task ProcessRequestAsync_No_Secret_Passed()
        {
            // Arrange            
            _hostHelper.SecretCode = "secret_code";
            string commandText = "hibernate";
            var queryCollection = new Mock<IQueryCollection>().Object;
            _mocker.GetMock<ITrayCommandHelper>().Setup(x => x.GetCommandType(commandText)).Returns(TrayCommandType.Hibernate);

            // Act
            await _hostHelper.ProcessRequestAsync($"/{commandText}", queryCollection).ConfigureAwait(false);

            // Assert
            _mocker.Verify<ITrayCommandHelper>(x => x.RunCommand(It.IsAny<TrayCommandType>()), Times.Never);
        }

        [Test]
        public async Task ProcessRequestAsync_Invalid_Command()
        {
            // Arrange            
            string commandText = "some_command";
            var queryCollection = new Mock<IQueryCollection>().Object;

            // Act
            await _hostHelper.ProcessRequestAsync($"/{commandText}", queryCollection).ConfigureAwait(false);

            // Assert
            _mocker.Verify<ITrayCommandHelper>(x => x.RunCommand(It.IsAny<TrayCommandType>()), Times.Never);
        }
    }
}

