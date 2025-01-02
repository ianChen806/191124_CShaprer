using FluentAssertions;

namespace WhereExercise;

public class UnitTest1
{
    [Fact]
    public void filter_class_list()
    {
        var list = new List<MyClass>()
        {
            new MyClass() { Id = 1, Name = "test1" },
            new MyClass() { Id = 2, Name = "test2" },
            new MyClass() { Id = 3, Name = "test3" },
            new MyClass() { Id = 4, Name = "test4" },
        };

        // TODO
        List<MyClass> actual = default;

        // actual = list.CustomWhere(r => r.Id > 2);

        actual.Should().BeEquivalentTo(new List<MyClass>()
        {
            new MyClass() { Id = 3, Name = "test3" },
            new MyClass() { Id = 4, Name = "test4" }
        });
    }

    [Fact]
    public void filter_int_list()
    {
        var list = new List<int>()
        {
            1, 2, 3, 4
        };

        // TODO
        List<MyClass> actual = default;

        // actual = list.CustomWhere(r => r > 2);

        actual.Should().BeEquivalentTo(new List<int>()
        {
            3, 4
        });
    }
}

public class MyClass
{
    public int Id { get; set; }

    public string Name { get; set; }
}
