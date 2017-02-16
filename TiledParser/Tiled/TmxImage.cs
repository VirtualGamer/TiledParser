using System.Xml.Serialization;

namespace AssetImporter.Tiled
{
    [XmlRootAttribute("image")]
    public class TmxImage
    {
        [XmlAttribute("source")]
        public string Filepath = "";

        [XmlAttribute("width")]
        public int Width = 0;

        [XmlAttribute("height")]
        public int Height = 0;

        /// <summary>
        /// Constructs a new empty TmxImage.
        /// </summary>
        public TmxImage()
        {
        }

        /// <summary>
        /// Retrieves a compact string representation of the TmxTileset.
        /// </summary>
        /// <returns>a compact string representation of the TmxTileset.</returns>
        public override string ToString()
        {
            return "Filepath: " + this.Filepath + ", Width: " + this.Width + ", Height: " + this.Height;
        }
    }
}