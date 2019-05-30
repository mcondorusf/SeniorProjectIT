using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace FloodDataAPITests
{
    [TestClass]
    public class FloodDataAPITests
    {
        [TestMethod]
        public async Task GET_RESPONSE()
        {
            //Arrange 
            var api = new FloodDataAPI.FloodDataAPI(); 

            //Act
            dynamic data = await api.GetResponse(); 

            //Assert
        }
    }
}
