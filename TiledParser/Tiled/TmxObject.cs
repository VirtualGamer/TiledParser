using System.Xml.Serialization;
using GLMaths;

namespace AssetImporter.Tiled
{
    [XmlRootAttribute("object")]
    public class TmxObject
    {
        [XmlAttribute("id")]
        public int Id = 0;

        [XmlAttribute("name")]
        public string Name = "";

        [XmlAttribute("x")]
        public float X = 0.0f;

        [XmlAttribute("y")]
        public float Y = 0.0f;

        [XmlAttribute("width")]
        public float Width = 0.0f;

        [XmlAttribute("height")]
        public float Height = 0.0f;

        [XmlAttribute("rotation")]
        public float Rotation = 0.0f;

        /// <summary>
        /// Constructs a new empty TmxObject.
        /// </summary>
        public TmxObject()
        {
        }

        /// <summary>
        /// Retrieves the 2 dimensional TmxObject's position.
        /// </summary>
        /// <returns>the 2 dimensional TmxObject's position.</returns>
        public Vector2 GetPosition()
        {
            return new Vector2(this.X, this.Y);
        }

        /// <summary>
        /// Retrieves the 2 dimensional TmxObject's size.
        /// </summary>
        /// <returns>the 2 dimensional TmxObject's size.</returns>
        public Vector2 GetSize()
        {
            return new Vector2(this.Width, this.Height);
        }

        /// <summary>
        /// Retrieves a compact string representation of the TmxObject.
        /// </summary>
        /// <returns>a compact string representation of the TmxObject.</returns>
        public override string ToString()
        {
            return "ID: " + this.Id + ", Name: " + this.Name + ", Position: " + this.GetPosition() + ", Size: " +
                   this.GetSize() + ", Rotation: " + this.Rotation;
        }
    }
}