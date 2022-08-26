
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health
{
    private int _value;
    public int ChangeHealth {
        get { return _value; }
        set
        {
            _value += value;
        }
    }

}
