using calucaltor;

namespace calculatorTest
{






    public class CalculatorTest
    {


        [Theory]
        [InlineData("+")]
        [InlineData("-")]
        [InlineData("*")]
        [InlineData("/")]
        public void Test_CheckOperator(string oprator)
        {
            bool result = TestFunctions.CheckOperator(oprator);

            Assert.True(result);
        }


        [Theory]
        [InlineData("f")]
        [InlineData("%")]
        public void Test_ChackWrongOperator(string oprator)
        {
            bool result = TestFunctions.CheckOperator(oprator);

            Assert.False(result); ;
        }





        [Theory]
        [InlineData("777", "3",new double[] {777,3})]
        [InlineData("65.56", "23.33", new double[] { 65.56, 23.33 })]
        [InlineData("2.5553", "0", new double[] { 2.5553, 0 })]
        public void Test_ConvertNumbersTrue(string number1,string number2, double[] expected)
        {
            double[] result = TestFunctions.ConvertNumbers(number1, number2);

            Assert.Equal(expected, result);
        }



        [Theory]
        [InlineData("f2", "25")]
        [InlineData("33", "3d")]
        [InlineData(" ", "5.333333")]
        public void Test_ConvertNumberFalse(string number1,string number2)
        {

            Assert.Throws<ArgumentException>(() => TestFunctions.ConvertNumbers(number1,number2));
        }




        [Theory]
        [InlineData(4, 2, 6)]
        [InlineData(5.2, 6.3, 11.5)]
        public void Test_Addition(double num1, double num2, double expected)
        {
            double result = TestFunctions.Addition(num1, num2);

            Assert.Equal(expected, result);
        }




        [Theory]
        [InlineData(25,3,22)]
        [InlineData(33.5,45,-11.5)]
        [InlineData(5.5,0,5.5)]
        public void Test_Substraction(double num1,double num2,double expected)
        {
            double result = TestFunctions.Subtraction(num1,num2);

            Assert.Equal(expected, result);
        }



        [Theory]
        [InlineData(3,5,15)]
        [InlineData(55.4,33.33,1846.482)]
        public static void Test_Multiplication(double num1,double num2,double expected)
        {
            double result = TestFunctions.Multiplication(num1, num2);

            Assert.Equal(expected, result);
        }




        [Theory]
        [InlineData(55,4,13.75)]
        [InlineData(15,-3,-5)]
        [InlineData(33,0,double.MaxValue)]
        public static void Test_Division(double num1,double num2,double expected)
        {
            if (num2 == 0)
            {
                Assert.Throws<ArgumentException>(() => TestFunctions.Division(num1, num2));
            }
            else
            {

                double result = TestFunctions.Division(num1, num2);

                Assert.Equal(expected, result);

            }
        }






    }
}