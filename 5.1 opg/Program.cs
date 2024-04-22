using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace Threads
{
    class Program
    {
        #region Exercise 1 Function
        //Exercise 1 Function
        /*static void printThreadHello()
        {
           for (int i = 0; i < 11; i++)
            {
                if (i < 10)
                {
                    Console.WriteLine($"Hello #{i} {Thread.CurrentThread.Name}");
                }
                else if (i == 10)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} Terminates");
                }
            }
        }*/
        #endregion

        #region Exercise 2 Variable and functions
        /*static int Shared = 0;

        static void Increment()
        {
            Shared++;
            Thread.Sleep(1000);
        }

        static void Read()
        {
            Console.WriteLine($"Shared variable is: {Shared}");
            Thread.Sleep(1000);
        }*/
        #endregion

        #region Exercise 3 Vector
        private static Vector sharedVector = new Vector();

        public static void Writer(object id)
        {
            int writerId = (int)id;

            while (true)
            {
                int setValue = writerId;
                bool isConsistent = sharedVector.SetAndTest(setValue);

                if (!isConsistent)
                {
                    Console.WriteLine($"Error: Inconsistency detected by Writer {writerId}");
                }

                Thread.Sleep(100);
            }
        }

        #endregion

        static void Main(string[] args)
        {
            #region Exercise 1 Threads
            //Exercise 1 Threads
            /*Thread threadOne = new Thread(new ThreadStart(printThreadHello));
            Thread threadTwo = new Thread(new ThreadStart(printThreadHello));
            threadOne.Name = "Thread One";
            threadTwo.Name = "Thread Two";
            threadOne.Start();
            threadTwo.Start();
            */
            #endregion

            #region Exercise 2 Threads
            /*for (int i = 0; i < 10; i++)
            {
                Thread threadIncrementer = new Thread(new ThreadStart(Increment));
                Thread threadReader = new Thread(new ThreadStart(Read));
                threadIncrementer.Start();
                threadReader.Start();
            }*/
            #endregion

            #region Exercise 3 Vector Main
            int numWriters = 3;

            for (int i = 1; i <= numWriters; i++)
            {
                Thread writerThread = new Thread(new ParameterizedThreadStart(Writer));
                writerThread.Start(i);
            }

            while (true)
            {
                Thread.Sleep(100);
            }
            #endregion
        }


    }

}

/*Answer to exercise 3/4
 * Jeg ik sikker på om jeg skal fikse problemet så vælger at la være.
 * men alle de "inconsistensies" som threadsene støder på er ikke fordi der er noget galt med vector klassen men -
 * fordi at alle threadsene har ingen restriktioner, på den måde at de alle kan access shared data på samme tid(uden locks)
 * hvilket vil sige at mens en thread tester kan en anden thread lige ha set dataen så der kommer fejl, hvilket alle gør på samme tid -
 * det noget bøvl
 * kun med kun 1 eller 2 threads kørene kommer der ingen inconsistensies åbenbart, men 3 eller over kan de ikke finde ud af det.
*/