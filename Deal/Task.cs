﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task : ITask
{
    public string TaskName { get; set; }
    public string Discriptiom { get; set; }
    public DateTime TimeRegestration => DateTime.Now;
 
    public Task(string name,string discript)
    {
        TaskName = name;
        Discriptiom = discript;
    }
  
}
