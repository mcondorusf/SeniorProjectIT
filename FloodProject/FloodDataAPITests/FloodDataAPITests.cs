using FloodDataAPI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FloodDataAPITests
{
    [TestClass]
    public class FloodDataAPITests
    {
        [TestMethod]
        public async Task Get_Flood_Data_By_Coordinates()
        {
            //Arrange 
            var api = new FloodDataAPI.FloodDataAPI(); 

            //Act
            dynamic data = await api.Get_Flood_Data_By_Coordinates(27.950575, -82.457176);

            //Assert
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public async Task Get_Flood_Data_By_Address()
        {
            //Arrange 
            var api = new FloodDataAPI.FloodDataAPI();

            //Act
            dynamic data = await api.Get_Flood_Data_By_Address("4202 E Fowler Ave, Tampa, FL 33620");

            //Assert
            Assert.IsNotNull(data);

        }

        [TestMethod]
        public async Task Build_Flood_Model_From_Data()
        {
            //Arrange 
            var api = new FloodDataAPI.FloodDataAPI();
            var converter = new FloodDataAPI.BuildFloodResultsModel();

            //Act
            dynamic data = await api.Get_Flood_Data_By_Coordinates(27.950575, -82.457176);
            FloodDataResultModel flood_info = converter.Convert_Flood_API_Data_To_Flood_Model(data); 

            //Assert
            Assert.IsNotNull(flood_info.FloodZone);
        }
    }
}
