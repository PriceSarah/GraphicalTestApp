using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Vector4
    {
        public float x;
        public float y;
        public float z;
        public float w;

        public Vector4()
        {
            x = 0;
            y = 0;
            z = 0;
            w = 0;
        }

        public Vector4(float newX, float newY, float newZ, float newW)
        {
            x = newX;
            y = newY;
            z = newZ;
            w = newW;
        }

        public override string ToString()
        {
            return "{ " + x + ", " + y + ", " + z + ", " + w + " }";
        }

        public static Vector4 operator +(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        }

        public static Vector4 operator -(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        }

        public static Vector4 operator *(Vector4 vector, float scaler)
        {
            return new Vector4(vector.x * scaler, vector.y * scaler, vector.z * scaler, vector.w * scaler);
        }

        public static Vector4 operator *(float scaler, Vector4 vector)
        {
            return new Vector4(scaler * vector.x, scaler * vector.y, scaler * vector.z, scaler * vector.w);
        }

        public static Vector4 operator /(Vector4 vector, float scaler)
        {
            return new Vector4(vector.x / scaler, vector.y / scaler, vector.z / scaler, vector.w / scaler);
        }

        public static Vector4 operator /(float scaler, Vector4 vector)
        {
            return new Vector4(scaler / vector.x, scaler / vector.y, scaler / vector.z, scaler / vector.w);
        }

        public float Dot(Vector4 rhs)
        {
            return x * rhs.x + y * rhs.y + z * rhs.z + w * rhs.w;
        }

        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z + w * w);
        }

        public float MagnitudeSqr()
        {
            return (x * x + y * y + z * z + w * w);
        }

        public float Distance(Vector4 other)
        {
            float diffX = x - other.x;
            float diffY = y - other.y;
            float diffZ = z - other.z;
            float diffW = w - other.w;

            return (float)Math.Sqrt(diffX * diffX + diffY * diffY + diffZ * diffZ + diffW * diffW);

        }

        public float DistanceSqr(Vector4 other)
        {
            float diffX = x - other.x;
            float diffY = y - other.y;
            float diffZ = z - other.z;
            float diffW = w - other.w;

            return (diffX * diffX + diffY * diffY + diffZ * diffZ + diffW * diffW);

        }

        public void Normalize()
        {
            float m = Magnitude();
            this.x /= m;
            this.y /= m;
            this.z /= m;
            this.w /= w;
        }

        public Vector4 GetNormalised()
        {
            return (this / Magnitude());
        }

        public float Angle(Vector4 other)
        {
            Vector4 a = GetNormalised();
            Vector4 b = other.GetNormalised();
            return (float)Math.Acos(a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w);
        }
        public Vector4 Cross(Vector4 rhs)
        {
            return new Vector4(
            y * rhs.z - z * rhs.y,
            z * rhs.x - x * rhs.z,
            x * rhs.y - y * rhs.x,
            0);
        }
    }
}
