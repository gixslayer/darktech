namespace DarkTech.Engine.Sound
{
    public delegate float DistanceModelDelegate(float distance);

    public enum DistanceModel : int
    {
        Linear = 0,
        Exponential = 1,
        InverseExponential = 2
    }
}
