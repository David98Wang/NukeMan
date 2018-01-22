using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitBlock : MonoBehaviour{

    public double Width = 5, Height =5;
    enum BackgroundType
    {
        Picture = 0,
        SolidColor = 1
    };

    public UnitBlock(float PositionX, float PositionY,float PositionZ)
    {
        SetX(PositionX);
        SetY(PositionY);
        SetZ(PositionZ);
    }

    public void Start()
    {
        
    }
    #region Private Function
    private void SetX(float newX)
    {
        Vector3 temp = this.transform.position;
        temp.x = newX;
        this.transform.position = temp;
    }
    private void SetY(float newY)
    {
        Vector3 temp = this.transform.position;
        temp.y = newY;
        this.transform.position = temp;
    }
    private void SetZ(float newZ)
    {
        Vector3 temp = this.transform.position;
        temp.z = newZ;
        this.transform.position = temp;
    }
    #endregion
}
