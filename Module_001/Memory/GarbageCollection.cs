using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class ClassWithDtor
    {
        private static int _objectCount = 0; // Tracks total objects created
        private int _id;                     // Unique ID for each object
        // private double[] arr;

        public ClassWithDtor()
        {
            _id = ++_objectCount;            // Increment static counter and assign ID
            // arr = new double[5000];
            Console.WriteLine($"Object {_id} created");
        }

        ~ClassWithDtor()
        {
            Console.WriteLine($"Finalize called for object {_id}");
            _objectCount--;
            // GC.ReRegisterForFinalize(this);
        }

        public static void AllocateAndLoseRef()
        {
            // Create an array of ClassWithDtor objects
            ClassWithDtor[] objects = new ClassWithDtor[10];
            for (int i = 0; i < objects.Length; i++)
            {
                objects[i] = new ClassWithDtor();
                ClassWithDtor tmp = new ClassWithDtor();
            }

            // Lose reference to the array
            objects = null;
        }

        public static void TestGC()
        {
            AllocateAndLoseRef();

            // Force garbage collection
            GC.Collect();
            GC.WaitForPendingFinalizers();

            System.Threading.Thread.Sleep(2000);
            Console.WriteLine($"Object count after WaitForPendingFinalizers: {ClassWithDtor._objectCount}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

