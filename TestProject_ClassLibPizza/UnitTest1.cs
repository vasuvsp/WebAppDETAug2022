using WebAppDETAug2022.Models;
using WebAppDETAug2022.Services;

namespace TestProject_ClassLibPizza
{
    public class UnitTest1
    {
        
            [Fact]
            public void TestGetAllPizzas()
            {
                int expected = 2;
                int actual = PizzaService.GetAll().Count;
                Assert.Equal(expected, actual);

            }
            [Fact]
            public void Test_AddPizza()
            {
                Pizza p = new Pizza { Name = "Veg", Size = PizzaSize.Medium, IsGlutenFree = true };

                PizzaService.Add(p);

                Pizza verify = PizzaService.Get(3);
                Assert.Equal(3, PizzaService.GetAll().Count());
                Assert.NotNull(verify.Id);
            }

        }
    }
