namespace SampleProject.Tests;

public class UnitTest1
{
    [Fact]
    public void TestAddition()
    {
        int result = 2 + 2;
        Assert.Equal(4, result);
		int result2 = 5 - 4;
        Assert.Equal(1, result); 
    }
}
