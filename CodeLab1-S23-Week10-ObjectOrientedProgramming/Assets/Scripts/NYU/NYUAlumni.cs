using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYUAlumni : NYUStudent
{
    public int graduationDate = 0;

    public NYUAlumni(
        string name, string netId,
        float gpa, int credits, int graduationDate) : 
        base(name, netId, gpa, credits)
    {
        this.graduationDate = graduationDate;
        type = "NYU Alumnus";
    }
    public override string ShowRecord()
    {
        return base.ShowRecord() + "\nGraduated in: " +graduationDate; 
    }
}


