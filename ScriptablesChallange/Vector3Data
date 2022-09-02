using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//the idea behind this script is to use it to make objects face a certain direction. I fiddled around with it for a long time, but couldn't get things to work.
[CreateAssetMenu]
public class Vector3Data : ScriptableObject
{
    public Vector3 value;

    public void SetValueFromTransform(Vector3 obj)
    {
        value = obj;
    }

    public void SetValueFromPosition(Transform obj)
    {
        value = obj.position;
    }

    public void SetValueFromRotation(Transform obj)
    {
        value = obj.eulerAngles;
    }
}
//gets rotation data}
