using SelfieWookie.Api.Controllers;

namespace TestWebApi
{
    public class SelfiesControllerUnitTest
    {
        #region Public methods
        [Fact]
        public void ShouldReturnListOfSelfies()
        {
            //ARRANGE
            var controller = new SelfiesController();

            //ACT
            var result = controller.TestAMoi();

            //ASSERT
            Assert.NotNull(result);
            Assert.True(result.GetEnumerator().MoveNext());

        }
        #endregion
    }
}