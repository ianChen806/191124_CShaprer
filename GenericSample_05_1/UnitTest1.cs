namespace GenericSample_05_1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var intList = new IntList();
        intList.Add(1);
        int intItem = intList.Get(0);
        Assert.Equal(1, intItem);

        var classList = new MyClassList();
        classList.Add(new MyClass());
        MyClass classItem = classList.Get(0);
        Assert.NotNull(classItem);
    }
}
