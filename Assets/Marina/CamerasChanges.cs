using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerasChanges : MonoBehaviour
{
    public Camera[] cameras;
    public int index = 0;
    public int n;
    private void Start()
    {
        cameras = transform.GetComponentsInChildren<Camera>();
        n = cameras.Length;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) index++;
        if (index >= n) index = 0;
        for(int i=0;i< n; i++)
        {
            cameras[i].gameObject.SetActive(false);
        }
        cameras[index].gameObject.SetActive(true);
    }
}
