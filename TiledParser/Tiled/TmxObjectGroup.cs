using System;
using System.Xml.Serialization;

namespace AssetImporter.Tiled
{
    [XmlRootAttribute("objectgroup")]
    public class TmxObjectGroup
    {
        [XmlAttribute("color")]
        public string Color = "";

        [XmlAttribute("name")]
        public string Name = "";

        [XmlElement("object")]
        public TmxObject[] Object;

        /// <summary>
        /// Constructs a new empty TmxObjectGroup.
        /// </summary>
        public TmxObjectGroup()
        {
        }

        /// <summary>
        /// Retrieves the TmxColor from the Color string.
        /// </summary>
        /// <returns>the TmxColor from the Color string.</returns>
        public TmxColor GetColor()
        {
            return new TmxColor(this.Color);
        }

        /// <summary>
        /// Retrieves a compact string representation of the TmxObjectGroup.
        /// </summary>
        /// <returns>a compact string representation of the TmxObjectGroup.</returns>
        public override string ToString()
        {
            string result = "Name: " + this.Name + ", Color: " + this.GetColor() + "\n{\n";
            if (Object.Length > 1)
            {
                for (int objectIndex = 0; objectIndex < this.Object.Length; objectIndex++)
                {
                    result += "\t" + this.Object[objectIndex];
                    if (objectIndex < this.Object.Length - 1)
                    {
                        result += ",\n";
                    }
                }
            }
            else if (Object.Length == 1)
            {
                result += this.Object[0];
            }
            else
            {
                Console.Error.WriteLine("Couldn\'t find any layers.");
                Environment.Exit(1);
            }
            return result + "\n}";
        }
    }
}