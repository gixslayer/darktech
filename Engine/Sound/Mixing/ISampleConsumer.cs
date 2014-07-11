namespace DarkTech.Engine.Sound
{
    public interface ISampleConsumer
    {
        void Process(ref Sample sample);
    }
}
