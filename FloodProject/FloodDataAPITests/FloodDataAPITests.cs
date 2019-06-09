using FloodDataAPI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace FloodDataAPITests
{
    [TestClass]
    public class FloodDataAPITests
    {
        [TestMethod]
        public async Task Build_Flood_Model_From_Data()
        {
            //Arrange 
            FloodDataResults flood_data = new FloodDataResults();

            //Act
            FloodDataResultModel data = await flood_data.Get_Flood_Data_Model_By_Coordiantes(27.950575, -82.457176);

            //Assert
            Assert.IsNotNull(data);

            Assert.IsTrue(!string.IsNullOrWhiteSpace(data.FloodZone));

            Assert.IsNotNull(data.SpecialFloodHazardArea); 
        }

        [TestMethod]
        public async Task Get_Flood_Data_Map()
        {
            //Arrange 
            FloodDataAPI.FloodDataAPI flood_data = new FloodDataAPI.FloodDataAPI();

            //Act
            dynamic data = await flood_data.Get_Flood_Map_By_Coordinates(28.09707, -82.40533); //This has a bfe list

            //Assert
            Assert.IsNotNull(data);
        }
    }
}
