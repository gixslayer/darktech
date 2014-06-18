namespace DarkTech.Engine.Sound
{
    public interface ISampleProvider
    {
        ISampleConsumer Output { get; set; }

        void Process();
    }
}
