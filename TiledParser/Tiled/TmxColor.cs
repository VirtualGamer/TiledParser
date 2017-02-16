using System.Drawing;

namespace AssetImporter.Tiled
{
    public class TmxColor
    {
        public readonly float Red, Green, Blue;
        public readonly int HexColor;

        /// <summary>
        /// Constructs a new TmxColor from the specified color string.
        /// </summary>
        /// <param name="color">the color in string representation.</param>
        public TmxColor(string color)
        {
            if (!color.StartsWith("#"))
            {
                color = "#" + color;
            }
            Color tempColor = (Color) ColorTranslator.FromHtml(color);
            this.HexColor = tempColor.ToArgb();
            this.Red = (float) ((this.HexColor >> 16) & 0xff) / 255.0f;
            this.Green = (float) ((this.HexColor >> 8) & 0xff) / 255.0f;
            this.Blue = (float) ((this.HexColor) & 0xff) / 255.0f;
        }

        /// <summary>
        /// Retrieves a compact string representation of the TmxColor.
        /// </summary>
        /// <returns>a compact string representation of the TmxColor.</returns>
        public override string ToString()
        {
            return "(HexColor: " + this.HexColor + ", Red: " + this.Red + ", Green: " + this.Green + ", Blue: " + this.Blue + ")";
        }
    }
}