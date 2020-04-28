using System.Windows;
using Flyweight_WallTiles_Demo.Tiles;

namespace Flyweight_WallTiles_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TileFactory tileFactory;

        public MainWindow()
        {
            InitializeComponent();
            tileFactory = new TileFactory();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            FillWallWithTiles();
        }

        private void FillWallWithTiles()
        {
            var tileWidth = 60;
            var tileHeight = 60;


            var thirdWidth = (int)(wall.ActualWidth / 3);
            for (int x = 0; x < thirdWidth; x = x + tileWidth)
            {
                for (int y = 0; y < wall.ActualHeight; y = y + tileHeight)
                {
                    var tile = tileFactory.GetTileByType(TileType.Marble);
                    tile.AddTileOnWall(wall, x, y, tileWidth, tileHeight);
                };
            }

            for (int x = thirdWidth; x < 2 * thirdWidth; x = x + tileWidth)
            {
                for (int y = 0; y < wall.ActualHeight; y = y + tileHeight)
                {
                    var tile = tileFactory.GetTileByType(TileType.Squares);
                    tile.AddTileOnWall(wall, x, y, tileWidth, tileHeight);
                };
            }

            for (int x = 2 * thirdWidth; x < wall.ActualWidth; x = x + tileWidth)
            {
                for (int y = 0; y < wall.ActualHeight; y = y + tileHeight)
                {
                    var tile = tileFactory.GetTileByType(TileType.Dots);
                    tile.AddTileOnWall(wall, x, y, tileWidth, tileHeight);
                };
            }

            textBlockNumberOfTiles.Text = $"{Tile.InstancesCount} tiles were created";
        }
    }
}
