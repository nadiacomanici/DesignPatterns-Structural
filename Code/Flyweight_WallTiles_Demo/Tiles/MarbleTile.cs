namespace Flyweight_WallTiles_Demo.Tiles
{
    public class MarbleTile : Tile
    {
        public MarbleTile(int x, int y, int width, int height)
        {
            ImageUrl = @"Images/pattern-marble.jpeg";
            Width = width;
            Height = height;
            X = x;
            Y = y;
        }
    }
}
