using System;


public interface ITask
{
    string TaskName { get; set; }
    string Discriptiom { get; set; }
    DateTime TimeRegestration { get; }   
}
