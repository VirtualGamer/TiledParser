using System;
using System.Xml.Serialization;

namespace AssetImporter.Tiled
{
    [XmlRootAttribute("map")]
    public class TmxMap
    {
        [XmlAttribute("orientation")]
        public string Orientation;

        [XmlAttribute("renderorder")]
        public string RenderOrder;

        [XmlAttribute("width")]
        public int Width = 0;

        [XmlAttribute("height")]
        public int Height = 0;

        [XmlAttribute("tilewidth")]
        public int TileWidth = 0;

        [XmlAttribute("tileheight")]
        public int TileHeight = 0;

        [XmlAttribute("backgroundcolor")]
        public string BackgroundColor;

        [XmlElement("tileset")]
        public TmxTileset[] Tileset;

        [XmlElement("layer")]
        public TmxLayer[] Layer;

        [XmlElement("objectgroup")]
        public TmxObjectGroup[] ObjectGroup;

        /// <summary>
        /// Constructs a new empty TmxMap.
        /// </summary>
        public TmxMap()
        {
        }

        public TmxColor GetBackgroundColor()
        {
            return (this.BackgroundColor == null ? null : new TmxColor(this.BackgroundColor));
        }

        public TmxOrientation GetOrientation()
        {
            switch (this.Orientation)
            {
                case "orthogonal":
                    return TmxOrientation.Orthogonal;
                case "isometric":
                    return TmxOrientation.Isometric;
                case "staggered":
                    return TmxOrientation.Staggered;
                case "hexagonal":
                    return TmxOrientation.Hexagonal;
                default:
                    return TmxOrientation.Unknown;
            }
        }

        public TmxRenderOrder GetRenderOrder()
        {
            switch (this.Orientation)
            {
                case "right-down":
                    return TmxRenderOrder.RightDown;
                case "right-up":
                    return TmxRenderOrder.RightUp;
                case "left-down":
                    return TmxRenderOrder.LeftDown;
                case "left-up":
                    return TmxRenderOrder.LeftUp;
                default:
                    return TmxRenderOrder.Unknown;
            }
        }

        /// <summary>
        /// Retrieves a compact string representation of the TmxMap.
        /// </summary>
        /// <returns>a compact string representation of the TmxMap.</returns>
        public override string ToString()
        {
            string result = "Width: " + this.Width + ", Height: " + this.Height + "\n";
            result += "Tile Width: " + this.TileWidth + ", Tile Height: " + this.TileHeight;
            result += (this.BackgroundColor != null ? ", Background Color: " + this.GetBackgroundColor() : "") + "\n";
            result += this.GetTilesetString();
            result += this.GetLayerString();
            result += this.GetObjectGroupString();
            return result;
        }

        /// <summary>
        /// Retrieves a compact string representation of the TmxTileset array.
        /// </summary>
        /// <returns>a compact string representation of the TmxTileset array.</returns>
        private string GetTilesetString()
        {
            string result = "";
            if (this.Tileset.Length > 1)
            {
                for (int tilesetIndex = 0; tilesetIndex < this.Tileset.Length; tilesetIndex++)
                {
                    result += this.Tileset[tilesetIndex];
                    if (tilesetIndex < this.Tileset.Length - 1)
                    {
                        result += ",\n";
                    }
                }
            }
            else if (this.Tileset.Length == 1)
            {
                result += this.Tileset[0];
            }
            else
            {
                Console.Error.WriteLine("Couldn\'t find any tilesets.");
                Environment.Exit(1);
            }
            return result + "\n";
        }

        /// <summary>
        /// Retrieves a compact string representation of the TmxLayer array.
        /// </summary>
        /// <returns>a compact string representation of the TmxLayer array.</returns>
        private string GetLayerString()
        {
            string result = "";
            if (this.Layer.Length > 1)
            {
                for (int layerIndex = 0; layerIndex < this.Layer.Length; layerIndex++)
                {
                    result += this.Layer[layerIndex];
                    if (layerIndex < this.Layer.Length - 1)
                    {
                        result += ",\n";
                    }
                }
            }
            else if (this.Layer.Length == 1)
            {
                result += this.Layer[0];
            }
            else
            {
                Console.Error.WriteLine("Couldn\'t find any layers.");
                Environment.Exit(1);
            }
            return result + "\n";
        }

        /// <summary>
        /// Retrieves a compact string representation of the TmxObjectGroup array.
        /// </summary>
        /// <returns>a compact string representation of the TmxObjectGroup array.</returns>
        private string GetObjectGroupString()
        {
            string result = "";
            if (this.ObjectGroup.Length > 1)
            {
                for (int objectGroupIndex = 0; objectGroupIndex < this.ObjectGroup.Length; objectGroupIndex++)
                {
                    result += this.ObjectGroup[objectGroupIndex];
                    if (objectGroupIndex < this.ObjectGroup.Length - 1)
                    {
                        result += ",\n";
                    }
                }
            }
            else if (this.ObjectGroup.Length == 1)
            {
                result += this.ObjectGroup[0];
            }
            else
            {
                Console.Error.WriteLine("Couldn\'t find any object groups.");
                Environment.Exit(1);
            }
            return result + "\n";
        }
    }
}