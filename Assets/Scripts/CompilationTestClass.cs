using SomeNamespace;
using UnityEngine;

namespace SomeNamespace
{
    public delegate CompilationTestClass RootDelegate(int test, CompilationTestClass test1);
    
    public class CompilationTestClass : MonoBehaviour
    {
        public class NestedClass
        {
            public string Test { get; set; }
        }
        
        public delegate CompilationTestClass NestedDelegate(int test, CompilationTestClass test1);
        
        private CompilationTestClass _selfReference;
        public RootDelegate _rootDelegate;
        public NestedDelegate _nestedDelegate;
        public NestedClass _NestedClass;
        
        // Start is called before the first frame update
        void Start()
        {
#pragma warning disable CS8321
            string LocalMethod()
#pragma warning restore CS8321
            {
                int d = default;
                return d.ToString();
            }
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        
        public enum NestedEnum
        {
            Value1,
            Value2
        }
    }

    public class AnotherCompilationTestClass : MonoBehaviour
    {
         
    }
    
    public enum OuterEnum
    {
        Value11,
        Value21
    }

    public struct StructInNamespace
    {
        public string Test { get; set; }
        public CompilationTestClass CompilationTestClass { get; set; }
    }
    
    public struct TestStructWithMethods {
 
        public void Deconstruct(out TestStructWithMethods t, out string dataToSend) {
            // blinkedThrough = this.blinkedThrough;
            // dataToSend = this.dataToSend;
            dataToSend = "test";
            t = new();
        }
    }
}

public struct StructNoNamespace
{
    public string Test { get; set; }
    public RootDelegate _rootDelegate;
    public StructInNamespace StructInNamespace { get; set; }
}