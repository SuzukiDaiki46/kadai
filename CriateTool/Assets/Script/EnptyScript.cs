using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnptyScript : MonoBehaviour
{
    public GameObject cube;

    public void OutputLog()
    {
        cube.gameObject.SetActive(false);
    }
}
