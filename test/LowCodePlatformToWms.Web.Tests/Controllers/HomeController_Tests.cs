using System.Threading.Tasks;
using LowCodePlatformToWms.Models.TokenAuth;
using LowCodePlatformToWms.Web.Controllers;
using Shouldly;
using Xunit;

namespace LowCodePlatformToWms.Web.Tests.Controllers
{
    public class HomeController_Tests: LowCodePlatformToWmsWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}