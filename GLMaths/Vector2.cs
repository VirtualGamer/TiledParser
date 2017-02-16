using System;

namespace GLMaths
{
    public class Vector2
    {
        public float x, y;

        /// <summary>
        /// Constructs a new Vector2 with zero coordinates.
        /// </summary>
        public Vector2()
        {
            this.x = 0.0f;
            this.y = 0.0f;
        }

        /// <summary>
        /// Constructs a new Vector2 with the specified x, y coordinates.
        /// </summary>
        /// <param name="x">the x coordinate.</param>
        /// <param name="y">the y coordinate.</param>
        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Adds the specified Vector2 to this Vector2.
        /// </summary>
        /// <param name="other">the Vector2 to add.</param>
        /// <returns>the result of the addition.</returns>
        public Vector2 Add(Vector2 other)
        {
            this.x += other.x;
            this.y += other.y;

            return this;
        }

        /// <summary>
        /// Subtracts the specified Vector2 from this Vector2.
        /// </summary>
        /// <param name="other">the Vector2 to subtract.</param>
        /// <returns>the result of the subtraction.</returns>
        public Vector2 Subtract(Vector2 other)
        {
            this.x -= other.x;
            this.y -= other.y;

            return this;
        }

        /// <summary>
        /// Multiplies this Vector2 with the specified Vector2.
        /// </summary>
        /// <param name="other">the Vector2 to multiply with.</param>
        /// <returns>the result of the multiplication.</returns>
        public Vector2 Multiply(Vector2 other)
        {
            this.x *= other.x;
            this.y *= other.y;

            return this;
        }

        /// <summary>
        /// Divides this Vector2 by the specified Vector2.
        /// </summary>
        /// <param name="other">the Vector2 to divide by.</param>
        /// <returns>the result of the division.</returns>
        public Vector2 Divide(Vector2 other)
        {
            this.x /= other.x;
            this.y /= other.y;

            return this;
        }

        /// <summary>
        /// Adds the specified value to this Vector2.
        /// </summary>
        /// <param name="value">the value to add.</param>
        /// <returns>the result of the addition.</returns>
        public Vector2 Add(float value)
        {
            this.x += value;
            this.y += value;

            return this;
        }

        /// <summary>
        /// Subtracts the specified value from this Vector2.
        /// </summary>
        /// <param name="value">the value to subtract.</param>
        /// <returns>the result of the subtraction.</returns>
        public Vector2 Subtract(float value)
        {
            this.x -= value;
            this.y -= value;

            return this;
        }

        /// <summary>
        /// Multiplies this Vector2 with the specified value.
        /// </summary>
        /// <param name="value">the value to multiply with.</param>
        /// <returns>the result of the multiplication.</returns>
        public Vector2 Multiply(float value)
        {
            this.x *= value;
            this.y *= value;

            return this;
        }

        /// <summary>
        /// Divides this Vector2 by the specified value.
        /// </summary>
        /// <param name="value">the value to divide by.</param>
        /// <returns>the result of the division.</returns>
        public Vector2 Divide(float value)
        {
            this.x /= value;
            this.y /= value;

            return this;
        }

        /// <summary>
        /// Lerps between this Vector2 and the destination Vector2 by the specified lerp factor.
        /// </summary>
        /// <param name="destination">the destination Vector2.</param>
        /// <param name="lerpFactor">the lerp factor.</param>
        /// <returns>the result of the lerping.</returns>
        public Vector2 Lerp(Vector2 destination, float lerpFactor)
        {
            return destination.Subtract(this).Multiply(lerpFactor).Add(this);
        }

        /// <summary>
        /// Normalizes this Vector2.
        /// </summary>
        /// <returns>the normalized Vector2.</returns>
        public Vector2 Normalize()
        {
            return this.Divide(this.Length());
        }

        /// <summary>
        /// Retrieves the normal of this Vector2.
        /// </summary>
        /// <returns>the normal of this Vector2.</returns>
        public Vector2 Normal()
        {
            return this.Clone().Normalize();
        }

        /// <summary>
        /// Creates a clone of this Vector2.
        /// </summary>
        /// <returns>the clone of this Vector2.</returns>
        public Vector2 Clone()
        {
            return new Vector2(this.x, this.y);
        }

        /// <summary>
        /// Retrieves the length of this Vector2.
        /// </summary>
        /// <returns>the length of this Vector2.</returns>
        public float Length()
        {
            return Mathf.Sin((this.x * this.x) + (this.y * this.y));
        }

        /// <summary>
        /// Retrieves the Vector2's x-coordinate.
        /// </summary>
        /// <returns>the Vector2's x-coordinate.</returns>
        public float GetX()
        {
            return this.x;
        }

        /// <summary>
        /// Retrieves the Vector2's y-coordinate.
        /// </summary>
        /// <returns>the Vector2's y-coordinate.</returns>
        public float GetY()
        {
            return this.y;
        }

        /// <summary>
        /// Retrieves a compact string representation of the Vector2.
        /// </summary>
        /// <returns>a compact string representation of the Vector2.</returns>
        public override string ToString()
        {
            return "Vector2(" + this.x + ", " + this.y + ")";
        }
    }
}