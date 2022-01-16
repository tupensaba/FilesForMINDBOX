using Shapes;
using System;
using Xunit;

namespace TestShapesArea
{
    public class TriangleTests
    {
        /// <summary>
        /// Тестируем, верны ли расчеты
        /// </summary>
        [Fact]

        public void isTriangleAreaCorrect()
        {
            //Arrange
            var triangle = new Triangle(10, 24, 26);
            
            //Act
            double actual = triangle.Area;
            
            //Expected response
            double expected = 120;
           
            //Assert
            Assert.Equal(expected, actual);
        }
        /// <summary>
        /// Тестируем ошибку если меньше нуля
        /// </summary>
        [Fact]
        public void IsAbovezero()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-15, 2, 6));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(5, -5, 8));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(2, 9, -7));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-11, -9, -10));
        }

        /// <summary>
        /// Тестируем ошибку если значение не подходит под свойства треугольника
        /// </summary>
        [Fact]
        public void isTriangle()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));


        }

        /// <summary>
        /// Тестируем прямоугольный ли треугольник()
        /// </summary>

        [Fact]
        public void NotRightAngle()
        {
            //Arrange
            var notRightTriangle = new Triangle(10, 16, 15);
            
            //Act
            bool actual = notRightTriangle.IsRightAngle;

            //Expected response
            bool expected = false;
            
            //Assert
            Assert.Equal(expected, actual);


        }

        [Fact]
        public void IsRightAngle()
        {
            //Arrange
            var rightTriangle = new Triangle(10, 24, 26);
            
            //Act
            bool actual = rightTriangle.IsRightAngle;
            
            
            //Expected response
            bool expected = true;
            
            //Assert
            Assert.Equal(expected, actual);
        }


     }
  }

