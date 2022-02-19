namespace VehicleOOPFactory
{
    public abstract class Tires
    {
        protected float Pressure { get; set; }
        public abstract string GetTiresInfo();
    }
}