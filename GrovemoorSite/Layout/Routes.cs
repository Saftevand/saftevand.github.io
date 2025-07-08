using System.Collections.Immutable;

namespace GrovemoorSite.Layout
{
    public class Route
    {
        public string? MaterialIcon { get; init; }
        public required string SubPath { get; init; }
        public required string LocalizationNamePath { get; init; }
        public required bool IsPublished { get; init; }
    }

    public record AppRoutes(ImmutableArray<Route> Routes);
    public static class AppRouteConfig
    {
        public static AppRoutes NavigationMenuRoutes { get; } = new AppRoutes(
        [
            new Route
            {
                MaterialIcon = "Arrow_Back",
                SubPath = "",
                LocalizationNamePath = "NavLink_Home",
                IsPublished = true
            }
            ]);

        public static AppRoutes HeaderRoutes { get; } = new AppRoutes(
        [
            new Route {
                SubPath = "",
                LocalizationNamePath = "Header_Home",
                IsPublished = true
            }
        ]);
    }
}
