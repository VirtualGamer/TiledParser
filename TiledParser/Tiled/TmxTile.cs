using GLMaths;

namespace AssetImporter.Tiled
{
    public class TmxTile
    {
        public readonly int TileId;
        public readonly TmxTileset Tileset;
        public readonly Vector2 Position;

        /// <summary>
        /// Constructs a new TmxTile with the specified data.
        /// </summary>
        /// <param name="id">the tile id.</param>
        /// <param name="tileset">the tileset.</param>
        /// <param name="position">the tile position.</param>
        public TmxTile(int id, TmxTileset tileset, Vector2 position)
        {
            this.TileId = id;
            this.Tileset = tileset;
            this.Position = position;
        }
    }
}