using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class CyclicReference
    {
        string _name;
        public CyclicReference? cyclicRef = null;

        public CyclicReference(string name)
        {
            _name = name;
        }

        ~CyclicReference()
        {
            Console.WriteLine($"CyclicReference {_name} collected");
        }
    }
    class ClassWithDtor
    {
        private static int _objectCount = 0; // Tracks total objects created
        public int _id;                     // Unique ID for each object
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

        public static ClassWithDtor AllocateAndLoseRef()
        {
            // Create an array of ClassWithDtor objects
            ClassWithDtor[] objects = new ClassWithDtor[10];
            Console.WriteLine($"After allocating the array objectCount={_objectCount}");

            for (int i = 0; i < objects.Length; i++)
            {
                objects[i] = new ClassWithDtor();
                ClassWithDtor tmp = new ClassWithDtor();
            }

            ClassWithDtor theOneToKeep = objects[5];
            Console.WriteLine($"theOneToKeep: {theOneToKeep._id}");

            // Lose reference to the array
            objects = null;

            CyclicReference c1 = new CyclicReference("c1");
            CyclicReference c2 = new CyclicReference("c2");
            c1.cyclicRef = c2;
            c2.cyclicRef = c1;

            return theOneToKeep;
        }

        public static void F(out ClassWithDtor c)
        {
            c = new ClassWithDtor();
            c._id = 1000;
        }


        public static void G(ClassWithDtor? c)
        {
            c._id = 2000;
        }

        public static void TestGC()
        {
            ClassWithDtor? d = null;
            G(d);
            F(out d);
            Console.WriteLine($"d._id={d._id}");

            ClassWithDtor c = AllocateAndLoseRef();

            int[]? arr = { 1, 2, 3 };
            ref int j = ref arr[2];
            j++;
            Console.WriteLine($"arr={String.Join(",", arr)}");

            arr = null;

            // Force garbage collection
            GC.Collect();
            GC.WaitForPendingFinalizers();

            j++;

            System.Threading.Thread.Sleep(2000);
            Console.WriteLine($"Object count after WaitForPendingFinalizers: {ClassWithDtor._objectCount}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

