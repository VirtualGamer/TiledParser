using System.Xml.Serialization;

namespace AssetImporter.Tiled
{
    [XmlRootAttribute("data")]
    public class TmxData
    {
        [XmlAttribute("encoding")]
        public string Encoding;

        [XmlText]
        public string innerXML;

        /// <summary>
        /// Constructs a new empty TmxData.
        /// </summary>
        public TmxData()
        {
        }

        /// <summary>
        /// Retrieves a compact string representation of the TmxData.
        /// </summary>
        /// <returns>a compact string representation of the TmxData.</returns>
        public override string ToString()
        {
            string result = "Encoding: " + this.Encoding + "\n{";
            string[] splitArray = this.innerXML.Split('\n');
            foreach (string line in splitArray)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    result += "\n\t" + line.Replace("\n", "");
                }
            }
            result += "\n}";
            return result;
        }
    }
}