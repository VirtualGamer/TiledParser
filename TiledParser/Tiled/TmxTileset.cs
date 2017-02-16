using System.Xml.Serialization;

namespace AssetImporter.Tiled
{
    [XmlRootAttribute("tileset")]
    public class TmxTileset
    {
        [XmlAttribute("firstgid")]
        public int TileIdOffset;

        [XmlAttribute("name")]
        public string Name;

        [XmlAttribute("tilewidth")]
        public int TileWidth;

        [XmlAttribute("tileheight")]
        public int TileHeight;

        [XmlAttribute("tilecount")]
        public int TileCount;

        [XmlAttribute("columns")]
        public int Columns;

        [XmlElement("image")]
        public TmxImage Image;

        /// <summary>
        /// Constructs a new empty TmxTileset.
        /// </summary>
        public TmxTileset()
        {
        }

        /// <summary>
        /// Retrieves a compact string representation of the TmxTileset.
        /// </summary>
        /// <returns>a compact string representation of the TmxTileset.</returns>
        public override string ToString()
        {
            return "Tile ID Offset: " + this.TileIdOffset + ", Name: " + this.Name + ", Tile Width: " + this.TileWidth +
                   ", Tile Height: " + this.TileHeight + ", Tile Count: " + this.TileCount + ", Columns: " + this.Columns +
                   "\n" + this.Image;
        }
    }
}