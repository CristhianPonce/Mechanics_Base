using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;

[System.Serializable]
public struct Vector3C
{
    #region FIELDS
    public float x;
    public float y;
    public float z;
    #endregion

    #region PROPIERTIES
    public float r { get => x; set => x = value; }
    public float g { get => y; set => y = value; }
    public float b { get => z; set => z = value; }
    public float magnitude { get { return (float)Math.Sqrt(x*x + y*y + z*z); } }
    public Vector3C normalized { get { return new Vector3C(x / magnitude, y / magnitude, z / magnitude); } }

    public static Vector3C zero { get { return new Vector3C(0, 0, 0); } }
    public static Vector3C one { get { return new Vector3C(1, 1, 1); } }
    public static Vector3C right { get { return new Vector3C(1, 0, 0); } }
    public static Vector3C up { get { return new Vector3C(0, 1, 0); } }
    public static Vector3C forward { get { return new Vector3C(0, 0, 1); } }

    public static Vector3C black { get { return new Vector3C(0, 0, 0); } }
    public static Vector3C white { get { return new Vector3C(1, 1, 1); } }
    public static Vector3C red { get { return new Vector3C(1, 0, 0); } }
    public static Vector3C green { get { return new Vector3C(0, 1, 0); } }
    public static Vector3C blue { get { return new Vector3C(0, 0, 1); } }
    #endregion

    #region CONSTRUCTORS
    public Vector3C(float x = 0, float y = 0, float z = 0)
    {
        this.x = x; this.y = y; this.z = z;
    }

    public Vector3C(Vector3C pointA, Vector3C pointB)
    {
        this = pointB - pointA;
    }
    #endregion

    #region OPERATORS
    public static Vector3C operator +(Vector3C a)
    {
        return a;
    }

    public static Vector3C operator -(Vector3C a)
    {
        a.x = -a.x;
        a.y = -a.y;
        a.z = -a.z;
        return a;
    }

    public static Vector3C operator+ (Vector3C a, Vector3C b)
    {
        return new Vector3C(a.x + b.x, a.y + b.y, a.z + b.z);
    }

    public static Vector3C operator- (Vector3C a, Vector3C b)
    {
        return new Vector3C(a.x - b.x, a.y - b.y, a.z - b.z);
    }

    public static Vector3C operator *(Vector3C a, Vector3C b)
    {
        return new Vector3C(a.x * b.x, a.y * b.y, a.z * b.z);
    }

    public static Vector3C operator /(Vector3C a, Vector3C b)
    {
        return new Vector3C(a.x / b.x, a.y / b.y, a.z / b.z);
    }

    public static Vector3C operator *(Vector3C a, float b)
    {
        return new Vector3C(a.x * b, a.y * b, a.z * b);
    }

    public static Vector3C operator /(Vector3C a, float b)
    {
        return new Vector3C(a.x / b, a.y / b, a.z / b);
    }
    #endregion

    #region METHODS
    public void Normalize()
    {
        this.x = this.x / magnitude;
        this.y = this.y / magnitude;
        this.z = this.z / magnitude;
    }

    public bool Equals(Vector3C other)
    {
        //Comprobar si funciona bien
        return (x == other.x) ? ((y == other.y) ? (z == other.z) : false) : false;
    }
    #endregion

    #region FUNCTIONS
    public static float Dot(Vector3C v1, Vector3C v2)
    {
        return (v1.x * v2.x + v1.y * v2.y + v1.z * v2.z);
    }
    public static Vector3C Cross(Vector3C v1, Vector3C v2)
    {
        return v1 * v2;
    }
    #endregion

}