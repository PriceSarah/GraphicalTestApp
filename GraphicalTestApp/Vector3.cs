using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Vector3
    {
        public float x;
        public float y;
        public float z;

        public Vector3()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        public Vector3(float newX, float newY, float newZ)
        {
            x = newX;
            y = newY;
            z = newZ;
        }

        public override string ToString()
        {
            return "{ " + x + ", " + y + ", " + z + " }";
        }


        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        }

        public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z + rhs.z);
        }

        public static Vector3 operator *(Vector3 vector, float scaler)
        {
            return new Vector3(vector.x * scaler, vector.y * scaler, vector.z * scaler);
        }

        public static Vector3 operator *(float scaler, Vector3 vector)
        {
            return new Vector3(scaler * vector.x, scaler * vector.y, scaler * vector.z);
        }

        public static Vector3 operator /(Vector3 vector, float scaler)
        {
            return new Vector3(vector.x / scaler, vector.y / scaler, vector.z / scaler);
        }

        public static Vector3 operator /(float scaler, Vector3 vector)
        {
            return new Vector3(scaler / vector.x, scaler / vector.y, scaler / vector.z);
        }

        public float Dot(Vector3 rhs)
        {
            return x * rhs.x + y * rhs.y + z * rhs.z;
        }

        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }

        public float MagnitudeSqr()
        {
            return (x * x + y * y + z * z);
        }

        public float Distance(Vector3 other)
        {
            float diffX = x - other.x;
            float diffY = y - other.y;
            float diffZ = z - other.z;

            return (float)Math.Sqrt(diffX * diffX + diffY * diffY + diffZ * diffZ);

        }

        public float DistanceSqr(Vector3 other)
        {
            float diffX = x - other.x;
            float diffY = y - other.y;
            float diffZ = z - other.z;

            return (diffX * diffX + diffY * diffY + diffZ * diffZ);

        }

        public void Normalize()
        {
            float m = Magnitude();
            this.x /= m;
            this.y /= m;
            this.z /= m;
        }

        public Vector3 GetNormalised()
        {
            return (this / Magnitude());
        }

        public float Angle(Vector3 other)
        {
            Vector3 a = GetNormalised();
            Vector3 b = other.GetNormalised();
            return (float)Math.Acos(a.x * b.x + a.y * b.y + a.z * b.z);
        }

        public Vector3 Cross(Vector3 rhs)
        {
            return new Vector3(
            y * rhs.z - z * rhs.y,
            z * rhs.x - x * rhs.z,
            x * rhs.y - y * rhs.x);
        }

        public static Vector3 Min(Vector3 a, Vector3 b)
        {
            return new Vector3(Math.Min(a.x, b.x), Math.Min(a.y, b.y), Math.Min(a.z, b.z));
        }

        public static Vector3 Max(Vector3 a, Vector3 b)
        {
            return new Vector3(Math.Max(a.x, b.x), Math.Max(a.y, b.y), Math.Max(a.z, b.z));
        }

        public static Vector3 Clamp(Vector3 t, Vector3 a, Vector3 b)
        {
            return Max(a, Min(b, t));
        }
    }
}
