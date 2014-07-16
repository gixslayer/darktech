namespace DarkTech.Engine.Sound.Mixing
{
    public interface ISampleProvider
    {
        ISampleConsumer Output { get; set; }

        void Process();
    }
}
