using Shapes;
using System;
using Xunit;

namespace TestShapesArea
{
    public class CircleTests
    {
        /// <summary>
        /// Тестируем, верны ли расчеты
        /// </summary>

        [Fact]
        
        public void IsCircleAreaCorrect()
        {
            //Arrange
            Circle circle = new Circle(5);
            
           
            //Act
           double actual = circle.Area;

           // Expected response 
           double expected = 78.53981633974483;
           
            
            //Assert
            Assert.Equal(expected, actual ) ;
        }

        /// <summary>
        /// Тестируем неверные значения
        /// </summary>
        [Fact]
        public void NotValidInputs ()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
            Assert.Throws<ArgumentException>(() => new Circle(-13));
        }
    }
}
