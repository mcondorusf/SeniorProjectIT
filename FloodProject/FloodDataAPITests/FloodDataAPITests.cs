using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}
