using System;
using System.Security.Cryptography.X509Certificates;

namespace PomoTimer
{
    internal class Timesec
    {
        public void TimeCount()
        {

            try
            {
                Console.Write("Enter a WorkTime duration in mins: ");
                int workDuration = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a RestTime duration in mins: ");
                int restDuration = Convert.ToInt32(Console.ReadLine());



                bool session = true;
                while (session)
                {

                    if (workDuration >= 1 && restDuration >= 1)
                    {
                        int work_time_in_min = workDuration * 60;

                        CountDown(1);


                        Console.WriteLine("time start:");

                        for (int i = work_time_in_min; i >= 0; i--)
                        {
                            Console.WriteLine("Counting down work Time... {0} Second(s)", i);
                            CountDown(1);
                            Console.Clear();
                        }
                        Console.WriteLine("your work duration has ended\n");
                        Console.WriteLine("your rest time starts now");
                        int rest_time = restDuration * 60;
                        CountDown(1);
                        Console.WriteLine("time start:");
                        for (int r = rest_time; r >= 0; r--)
                        {
                            Console.WriteLine("Counting down Rest Time... {0} Second(s)", r);
                            CountDown(1);

                            Console.Clear();
                        }

                        break;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                TimeCount();
            }

            Console.WriteLine("Rest time completed:");
            Console.WriteLine("To Continue type 1, to end type 2");

            try {
                if (int.TryParse(Console.ReadLine(), out int select))
                {
                    switch (select)
                    {
                        case 1:
                            TimeCount();
                            break;
                        case 2:
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("you entered invalid number!");
                    // TimeCount();
                }

            } catch (FormatException ex)
            { 
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("contine executing other program if any");
          

            
        }

        static void CountDown(int delayInSeconds)
        {
            DateTime initialTime = DateTime.UtcNow;
            for (; ; )
            {
                if ((DateTime.UtcNow - initialTime).TotalSeconds >= delayInSeconds)
                {
                    break;
                }
            }
        }


    }
}
