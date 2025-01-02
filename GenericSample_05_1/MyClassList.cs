using System.Collections;

namespace GenericSample_05_1;

public class MyClassList
{
    private ArrayList _arrayList = new ArrayList();

    public void Add(MyClass myClass)
    {
        _arrayList.Add(myClass);
    }

    public MyClass Get(int i)
    {
        return (MyClass)_arrayList[i];
    }
}
