using Moq;
using Parsis.Authentication.Implement.Manager;
using Xunit;

namespace Parsis.Authentication.Test.Implement
{
    public class AccessManagerTest
    {
        [Fact]
        public async void Should_Is_Match_Predicate() 
        {
            var mock = new Mock<AccessService>() 
            {
                    CallBase = true
            };

            //mock.Setup(item => item.IsMatch("")).Returns(() => new System.Threading.Tasks.Task<bool>(() => true));

            var result = await mock.Object.IsMatch("Action:SystemManagement:User:Add:**");

            Assert.True(result);
        }

        [Fact]
        public async void Should_Is_Not_Match_Predicate() 
        {
        
        }

    }
}
