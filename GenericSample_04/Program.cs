using System.Collections;

namespace GenericSample_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayList = new ArrayList();
            
            arrayList.Add(1);
            arrayList.Add("1");
            arrayList.Add(new object());
            arrayList.Add(new MyClass());
        }
    }

    internal class MyClass
    {
    }
}