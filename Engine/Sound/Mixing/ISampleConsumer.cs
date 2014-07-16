namespace DarkTech.Engine.Sound.Mixing
{
    public interface ISampleConsumer
    {
        void Process(ref Sample sample);
    }
}
