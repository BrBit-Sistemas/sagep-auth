using Sagep.Application.Services;
using Sagep.Application.ViewModels;
using Sagep.Domain.Interfaces;
using Moq;
using AutoMapper;
using Xunit;
using System;

namespace Sagep.WebUI.Tests.Services
{
    public class EntityToTestServiceTests
    {
        private EntityToTestAppService entityToTestAppService;

        public EntityToTestServiceTests()
        {
            entityToTestAppService = new EntityToTestAppService(
                                            new Mock<IEntityToTestRepository>().Object,
                                            new Mock<IMapper>().Object);
        }   

        [Fact]
        public void Add_SendingValidId()
        {
            var exception = Assert.Throws<Exception>(() => entityToTestAppService.Add(new DetentoViewModel { Id = Guid.NewGuid() }));
            Assert.Equal("O GUID é vazio!", exception.Message);
        }
    }
}