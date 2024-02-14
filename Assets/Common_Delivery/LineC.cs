using System;

[System.Serializable]
public struct LineC
{
    #region FIELDS
    public Vector3C origin;
    public Vector3C direction;
    #endregion

    #region PROPIERTIES
    #endregion

    #region CONSTRUCTORS
    public LineC(Vector3C origin, Vector3C direction)
    {
        this.origin = origin;
        this.direction = direction;
    }
    #endregion

    #region OPERATORS
    #endregion

    #region METHODS

    public Vector3C NearestPointToPoint(Vector3C point)
    {
        Vector3C AP = new Vector3C(point.x - origin.x, point.y - origin.y, point.z - origin.z);
        float t = (Vector3C.Dot(AP, direction)) / direction.magnitude * direction.magnitude;

        Vector3C nearestPoint = new Vector3C(origin.x + t * direction.x, origin.y + t * direction.y, origin.z + t * direction.z);

        return nearestPoint;
    }

    public Vector3C NearestPointToLine(LineC lineB)
    {
        Vector3C originDiff = new Vector3C(lineB.origin.x - this.origin.x, lineB.origin.y - this.origin.y, lineB.origin.z - this.origin.z);

        float t = Vector3C.Dot(originDiff, this.direction) / Vector3C.Dot(this.direction, this.direction);

        Vector3C nearestPointA = new Vector3C(this.origin.x + t * this.direction.x, this.origin.y + t * this.direction.y, this.origin.z + t * this.direction.z);

        return nearestPointA;
    }
    #endregion

    #region FUNCTIONS
    #endregion

}