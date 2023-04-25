using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYUAdjunct : NYUFaculty
{
    public bool adjunctFaculty = false;

    public NYUAdjunct(string name, string netId, float salary, bool tenure, bool adjunctFaculty) : base(name, netId,
        salary, tenure)
    {
        this.adjunctFaculty = adjunctFaculty; 
    }

    public override string ShowRecord()
    {
        return base.ShowRecord()
        + "\nAdjunct:" + adjunctFaculty; 
    }
}
