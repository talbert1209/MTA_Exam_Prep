using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Proficiency_Assessment
{
    public delegate void SampleDelegate();

    public interface ISampleEvents
    {
        event SampleDelegate SampleEvent;
        void Invoke();
    }

    public class SampleClass: ISampleEvents
    {
        public event SampleDelegate SampleEvent;
        public void Invoke()
        {
            if (SampleEvent != null) SampleEvent();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SampleClass testSampleClass = new SampleClass();
            testSampleClass.SampleEvent += TestMethod1;
            testSampleClass.SampleEvent += TestMethod2;
            
            testSampleClass.Invoke();
        }

        public static void TestMethod1()
        {
            Console.WriteLine("This is TestMethod1 firing...");
        }

        public static void TestMethod2()
        {
            Console.WriteLine("This is TestMethod2 firing...");
        }
    }
}
