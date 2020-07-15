using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _150720
{
    class Program
    {
        class MyTime
        {
            private long m_ticks; //UNIX

            public MyTime(long ticks)
            {
                this.m_ticks = ticks;
            }

            private string GetFormat()
            {
                return $"{m_ticks} ==";
            }

            public string GetTime()
            {
                // will use ticks to find out time in MY ZONE!!
                return "20:15:09 " + GetFormat();
            }
        }

        static Random r = new Random();
        class Person
        {
            // step 1: hide the member , field
            private float m_age;
            private int atm_secret_code = 12345;
            private float m_height;
            private int m_random_number;
            private string m_id;

            /// <summary>
            /// default getter
            /// </summary>
            /// <returns></returns>
            public int GetRandomNumber()
            {
                return m_random_number;
            }

            /// <summary>
            /// default Setter
            /// </summary>
            /// <param name="new_number"></param>
            public void SetRandomNumber(int new_number)
            {
                this.m_random_number = new_number;
            }


            // function - show the height
            /// <summary>
            /// Getter - functions which gives us the value of a specific (i.e. private) member
            /// Getter for m_age
            /// </summary>
            /// <returns></returns>
            public float GetAge()
            {
                return m_age;
            }

            /// <summary>
            /// Setter - functions which modify the value of a specific (i.e. private) member
            /// and supervising the new value
            /// </summary>
            /// <param name="new_age"></param>
            public void SetAge(float new_age)
            {
                if (new_age >= 0)
                    m_age = new_age;
            }

            // function - show the height
            /// <summary>
            /// Getter - functions which gives us the value of a specific (i.e. private) member
            /// Getter for m_age
            /// </summary>
            /// <returns></returns>
            public float GetHeight()
            {
                return m_height;
            }

            /// <summary>
            /// Setter - functions which modify the value of a specific (i.e. private) member
            /// and supervising the new value
            /// </summary>
            /// <param name="new_age"></param>
            public void SetHeight(float new_height)
            {
                if (new_height >= 0.3)
                    m_age = new_height;
            }

            public string GetId()
            {
                return this.m_id;
            }

            // dont want to be changed from outside the class code
            private void SetId(string new_id)
            {
                if (new_id.Length > 0)
                    this.m_id = new_id;
            }

            public Person(float age, float height, string id)
            {
                this.m_age = age;
                this.m_height = height;
                this.m_id = id;
                atm_secret_code = r.Next(1999, 9999 + 1);
            }

            private void DriveMyCar(string dest)
            {
                Console.WriteLine($"Driving my car to {dest}");
            }

            public void GoToMisradHapnim()
            {
                DriveMyCar("misrad hapnim");
                m_id = r.Next(112753172, 18276381).ToString();// wrong
                this.SetId(r.Next(112753172, 18276381).ToString()); // good
            }

            public override string ToString()
            {
                return $"{base.ToString()} {m_age} {m_id}";
            }

            public void GoToATM()
            {
                Console.WriteLine($"using my secret number");
            }
        }
        
        static void Main(string[] args)
        {
            MyTime mt = new MyTime(12897312);

            Person p = new Person(20, 1.8f, "1827817263");
            Console.WriteLine(p);
            Console.WriteLine(p.GetId()); // watch only. cannot modify the id from outside the class code
            p.GoToMisradHapnim();

            // encapsulation

            // access modifiers
            // properties

            // 1) maybe the age should be validated before modification?
            // 2) maybe i dont want the age to be modified from outside the class code
            //    maybe i want to all view only
            //p.m_age = -2; // private
            p.SetAge(-2);
            p.SetAge(20);
            Console.WriteLine(p.GetAge());
            // maybe i dont want access to this data at all ... ?
            //Console.WriteLine(p.atm_secret_code);

            // private member cannot be accessed from outside the class code AT ALL!!!!
        }
    }
}
