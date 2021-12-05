using System;

namespace Task10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            st.Greet();

            st.SetAge(22);
            st.ShowAge();
            st.Study();
            Teacher teach = new Teacher();
            teach.Greet();
            teach.Explain();
            teach.SetAge(38);
            teach.ShowAge();

        }
    }
}
