using System.Xml.Serialization;

namespace AssetImporter.Tiled
{
    [XmlRootAttribute("layer")]
    public class TmxLayer
    {
        [XmlAttribute("name")]
        public string Name = "";

        [XmlElement("data")]
        public TmxData Data;

        /// <summary>
        /// Constructs a new empty TmxLayer.
        /// </summary>
        public TmxLayer()
        {
        }

        /// <summary>
        /// Retrieves a compact string representation of the TmxLayer.
        /// </summary>
        /// <returns>a compact string representation of the TmxLayer.</returns>
        public override string ToString()
        {
            return "Name: " + this.Name + "\n" + this.Data;
        }
    }
}