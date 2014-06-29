namespace DarkTech.Engine.Graphics.Render.FrontEnd
{
    public sealed class RenderFrontEnd : IRenderFrontEnd
    {
        private readonly RenderQueue renderQueue;

        internal RenderFrontEnd(RenderQueue renderQueue)
        {
            this.renderQueue = renderQueue;
        }
 
        public void BeginFrame()
        {

        }

        public void EndFrame()
        {
            // Make sure at least one command is in the buffer before swapping to prevent the back-end from blocking and not processing window messages.
            if (renderQueue.ProducerSize == 0)
            {
                renderQueue.AddCommand(RenderCommand.NOP);
            }

            renderQueue.Swap();
        }
    }
}
