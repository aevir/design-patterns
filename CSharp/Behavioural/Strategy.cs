namespace DesignPatterns.Behavioural
{

    /*
     * IRouteStrategy is the strategy interface.
     * ShortestRouteStrategy, FastestRouteStrategy, and ScenicRouteStrategy are concrete strategies implementing IRouteStrategy.
     * NavigationSystem is the context class. It uses a route strategy and delegates the route calculation to it.
     */

    // Strategy interface
    public interface IRouteStrategy
    {
        void CalculateRoute(string pointA, string pointB);
    }

    // Concrete Strategies
    public class ShortestRouteStrategy : IRouteStrategy
    {
        public void CalculateRoute(string pointA, string pointB)
        {
            Console.WriteLine($"Calculating the shortest route from {pointA} to {pointB}");
        }
    }

    public class FastestRouteStrategy : IRouteStrategy
    {
        public void CalculateRoute(string pointA, string pointB)
        {
            Console.WriteLine($"Calculating the fastest route from {pointA} to {pointB}");
        }
    }

    public class ScenicRouteStrategy : IRouteStrategy
    {
        public void CalculateRoute(string pointA, string pointB)
        {
            Console.WriteLine($"Calculating the most scenic route from {pointA} to {pointB}");
        }
    }

    // Context Class
    public class NavigationSystem
    {
        private IRouteStrategy? _routeStrategy;

        public void SetRouteStrategy(IRouteStrategy routeStrategy)
        {
            _routeStrategy = routeStrategy;
        }

        public void Navigate(string pointA, string pointB)
        {
            _routeStrategy.CalculateRoute(pointA, pointB);
        }
    }
}
