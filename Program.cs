using System.Collections;

class Student
{
    int StudentId;
    string StudentName = "";

    public void SetStudent(int id, string name)
    {
        StudentId = id;
        StudentName = name;
    }

    public String GetStudentName()
    {
        return StudentName;
    }

    public int GetStudentId()
    {
        return StudentId;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int intNum = 1;
        double doubleNum = 1.33;
        bool status = true;
        string str = "test string";
        Console.WriteLine($"intNum={intNum}, doubleNum={doubleNum}, bool={status}, str={str}");
        //也可寫作Console.WriteLine("{0}同學在{1}上課", name, school);

        int[] intArr = new int[3];
        intArr[0] = 1;
        intArr[1] = 2;
        intArr[2] = 3;
        for (int i = 0; i < intArr.Length; i++)
        {
            Console.WriteLine($"intArr[{i}]={intArr[i]}");
        }

        Student studentOne = new Student();
        studentOne.SetStudent(1, "Howard");
        Console.WriteLine(
            $"studentOne id = {studentOne.GetStudentId()}, name = {studentOne.GetStudentName()}"
        );

        ArrayList arrlist = new ArrayList();
        arrlist.Add(1);
        arrlist.Add("test");
        arrlist.Add(false);
        for (int i = 0; i < arrlist.Count; i++)
        {
            Console.WriteLine($"arrlist[{i}]={arrlist[i]}");
        }
        Console.WriteLine($"arrlist contains \"test\": {arrlist.Contains("test")}");
        arrlist.RemoveAt(2);
        for (int i = 0; i < arrlist.Count; i++)
        {
            Console.WriteLine($"arrlist[{i}]={arrlist[i]}");
        }

        Stack st = new Stack();
        st.Push("1");
        st.Push("2");
        st.Push("3");
        foreach (Object obj in st)
        {
            Console.WriteLine($"stack {obj}");
        }
        st.Pop();
        foreach (Object obj in st)
        {
            Console.WriteLine($"after pop, stack {obj}");
        }

        Queue q = new Queue();
        q.Enqueue(1);
        q.Enqueue(2);
        q.Enqueue(3);
        foreach (Object obj in q)
        {
            Console.WriteLine($"queue {obj}");
        }
        q.Dequeue();
        foreach (Object obj in q)
        {
            Console.WriteLine($"after dequeue, queue {obj}");
        }

        // Hashtable & Dictionary兩者都用來儲存鍵值對。對於二者的區別，最明顯的就是Dictionary針對的是泛型，
        // 而HashTable是非泛型，鍵值對均為object型別，類似於list與arraylist的關係
        // https://www.796t.com/content/1549274781.html
        Hashtable ht = new Hashtable();
        ht.Add("001", ".Net");
        ht.Add("002", "C#");
        ht.Add("003", "ASP.Net");
        foreach (String k in ht.Keys)
        {
            Console.WriteLine($"Hashtable key={k}, value={ht[k]}");
        }

        Dictionary<string, string> d = new Dictionary<string, string>();
        d.Add("001", ".Net");
        d.Add("002", "C#");
        d.Add("003", "ASP.Net");
        foreach (String k in d.Keys)
        {
            Console.WriteLine($"Dictionary key={k}, value={ht[k]}");
        }
    }
}
