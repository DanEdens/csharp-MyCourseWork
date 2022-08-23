using System;
using System.Device.Location;

namespace WhereAmI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting GeoCoordinate Watcher...");

            var watcher = new GeoCoordinateWatcher();

            watcher.StatusChanged += (s, e) =>
            {
                Console.WriteLine($"GeoCoordinateWatcher:StatusChanged:{e.Status}");
            };

            watcher.PositionChanged += (s, e) =>
            {
                watcher.Stop();

                Console.WriteLine($"GeoCoordinateWatcher:PositionChanged:{e.Position.Location}");

                MapImage.Show(e.Position.Location);
            };

            watcher.MovementThreshold = 100;

            watcher.Start();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
