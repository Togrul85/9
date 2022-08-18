using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class Student
    {
        string _Fullname;
        string _GroupNo;
        string _Age;
    }
    public string Fullname
    {
        get { return _fullname; }
        set { if (CheckFullname(value)) _fullname = value; }
    }
    public string GroupNo
    {
        get { return _groupNo; }
        set { if (CheckGroupNo(value)) _groupNo = value; }
    }

}
