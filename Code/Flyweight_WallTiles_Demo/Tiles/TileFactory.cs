using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_WallTiles_Demo.Tiles
{
    public enum TileType
    {
        Dots,
        Marble,
        Squares
    }

    public class TileFactory
    {
        private Dictionary<TileType, Tile> tilePool;

        public TileFactory()
        {
            tilePool = new Dictionary<TileType, Tile>();
        }

        public Tile GetTileByType(TileType tileType)
        {
            if (!tilePool.ContainsKey(tileType))
            {
                Tile tile = null;
                switch (tileType)
                {
                    case TileType.Dots:
                        tile = new DotsTile();
                        break;

                    case TileType.Squares:
                        tile = new SquaresTile();
                        break;

                    case TileType.Marble:
                        tile = new MarbleTile();
                        break;
                }
                tilePool.Add(tileType, tile);
            }

            return tilePool[tileType];
        }
    }
}
