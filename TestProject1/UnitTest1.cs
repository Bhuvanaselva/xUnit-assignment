namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string nameFirst = "Bhuvana";
            string nameLast = "Selvaraj";
            string expected = "Selvaraj,Bhuvana";
            string actual = xUnit_assignment.Assignment5.MakeSignature(nameFirst, nameLast);
            Assert.Equal(expected, actual);

        }
    }
}