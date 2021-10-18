using Moq;
using UnitTest_Mock.Controllers;
using UnitTest_Mock.Models;
using UnitTest_Mock.Services;
using Xunit;

namespace UnitTesting.UnitTest_Mock
{
    public class EmployeeTest
    {
        #region Property

        public Mock<IEmployeeService> mock = new Mock<IEmployeeService>();

        #endregion

        [Fact]
        public async void GetEmployeebyID()
        {
            mock.Setup(p => p.GetEmployeebyId(1)).ReturnsAsync("JK");
            EmployeeController emp = new EmployeeController(mock.Object);
            string result = await emp.GetEmployeeById(1);
            Assert.Equal("JK", result);
        }

        [Fact]
        public async void GetEmployeeDetails()
        {
            var employeeDTO = new Employee()
            {
                id = 1,
                name = "JK",
                desgination = "SDE"
            };

            mock.Setup(
                p => p.GetEmployeeDetails(1)).ReturnsAsync(employeeDTO);

            EmployeeController emp = new EmployeeController(mock.Object);
            var result = await emp.GetEmployeeDetails(1);

            Assert.True(employeeDTO.Equals(result));

        }
    }
}
