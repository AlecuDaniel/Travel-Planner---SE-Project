using Travel_Planner___SE_Project.Data;
using Travel_Planner___SE_Project.Data.Repositories;
using Travel_Planner___SE_Project.Services;
namespace Travel_Planner_Unit_Test
{
    [TestClass]
    public sealed class TravelPlannerTest
    {
        [TestMethod]
        public async Task GetDestinationList_All()
        {

            // Arrange
            var fakeRepo = new FakeDestinationRepository();
            var service = new DestinationService(fakeRepo);

            // Act
            var results = await service.GetAllAsync();

            // Assert
            var resultList = results.ToList();
            Assert.AreEqual(5, resultList.Count);
        }
    }
}
