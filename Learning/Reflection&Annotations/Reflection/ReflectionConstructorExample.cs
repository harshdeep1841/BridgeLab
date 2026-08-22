namespace ConsoleAppLearning1.Learning.Reflection;

using System;
using System.Reflection;


class ReflectionConstructorExample
{
    static void ReflectionConstructern()
    {
        Type type = typeof(Student);

        ConstructorInfo constructor =
            type.GetConstructor(new Type[] { typeof(string) });

        Student student =
            (Student)constructor.Invoke(new object[] { "Emma" });

        student.Display();
    }
}