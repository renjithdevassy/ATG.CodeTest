using Xunit;
using ATG.CodeTest;

namespace ATG.CodeTest.Test
{
    public class LotTest : IClassFixture<LotService>
    {
        private readonly LotService _lotService;
        [Fact]
        public void LotService_Test()
        {
            //Arrange
            Lot expected = new Lot() ;
            //Act
            var actual = _lotService.GetLot(1, true);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}