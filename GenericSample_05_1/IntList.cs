using System.Collections;

namespace GenericSample_05_1;

public class IntList
{
    private ArrayList _arrayList = new ArrayList();

    public void Add(int i)
    {
        _arrayList.Add(i);
    }

    public int Get(int i)
    {
        return (int)_arrayList[i];
    }
}
