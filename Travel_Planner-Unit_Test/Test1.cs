using Travel_Planner___SE_Project.Data;
using Travel_Planner___SE_Project.Data.Repositories;
using Travel_Planner___SE_Project.Services;
namespace Travel_Planner_Unit_Test
{
    [TestClass]
    public sealed class TravvelPlannerTest
    {
        [TestMethod]
        public async Task GetDestinationList_By_Search_Name()
        {

            // Arrange
            var fakeRepo = new FakeDestinationRepository();
            var service = new DestinationService(fakeRepo);

            // Act
            var results = await service.SearchAsync("par");

            // Assert
            var resultList = results.ToList();
            Assert.AreEqual(2, resultList.Count);
            Assert.IsTrue(resultList.Any(d => d.Name == "Paris"));
            Assert.IsTrue(resultList.Any(d => d.Name == "Parioli"));
        }
    }
}
