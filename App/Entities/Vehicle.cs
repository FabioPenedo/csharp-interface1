namespace App.Entities
{
    internal class Vehicle
    {
        public string Model { get; set; } = string.Empty;

        public Vehicle(string model)
        {
            Model = model;
        }
    }
}
