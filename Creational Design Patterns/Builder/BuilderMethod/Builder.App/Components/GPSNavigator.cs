namespace Builder.App.Components
{
    public class GPSNavigator
    {
        private string route;

        public GPSNavigator()
        {
            this.route = "221b, Baker Street, London  to Scotland Yard, 8-10 Broadway, London";
        }

        public GPSNavigator(string manualRoute)
        {
            this.route = manualRoute;
        }

        public string getRoute()
        {
            return route;
        }
    }
}