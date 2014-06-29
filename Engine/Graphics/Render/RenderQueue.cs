using System;
using System.Collections.Generic;
using System.Threading;

namespace DarkTech.Engine.Graphics.Render
{
    internal sealed class RenderQueue : IDisposable
    {
        private readonly ManualResetEvent frontEndBlock;
        private readonly ManualResetEvent backEndBlock;
        private Queue<RenderCommand> consumer;
        private Queue<RenderCommand> producer;
        private bool disposed;

        public Queue<RenderCommand> Consumer { get { return consumer; } }
        public Queue<RenderCommand> Producer { get { return producer; } }
        public int ConsumerSize { get { return consumer.Count; } }
        public int ProducerSize { get { return producer.Count; } }

        public RenderQueue()
        {
            this.frontEndBlock = new ManualResetEvent(false);
            this.backEndBlock = new ManualResetEvent(true);
            this.producer = new Queue<RenderCommand>();
            this.consumer = new Queue<RenderCommand>();
            this.disposed = false;
        }

        ~RenderQueue()
        {
            Dispose(true);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            Dispose(false);
        }

        private void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (!disposing)
                {
                    // Allow the back-end to exit.
                    frontEndBlock.Set();

                    // Prevent the front-end from blocking on swap.
                    backEndBlock.Set();
                }

                frontEndBlock.Dispose();
                backEndBlock.Dispose();

                disposed = true;
            }
        }

        /// <summary>
        /// Begin a back-end frame. Will block the calling thread until the front-end has swapped command buffers.
        /// </summary>
        public void BeginFrame()
        {
            // Wait until the front-end has swapped the command queues.
            frontEndBlock.WaitOne();

            // Reset the front-end signal so that the back-end will block on the next BeginFrame call.
            frontEndBlock.Reset();
        }

        /// <summary>
        /// End a back-end frame.
        /// </summary>
        public void EndFrame()
        {
            // Signal the front-end the back-end has finished processing commands.
            backEndBlock.Set();
        }

        /// <summary>
        /// Adds a render command to the current producer queue.
        /// </summary>
        /// <param name="command">The render command.</param>
        public void AddCommand(RenderCommand command)
        {
            producer.Enqueue(command);
        }

        /// <summary>
        /// Swaps the producer and consumer command buffers so that the data is available to the back-end. 
        /// Will block the calling thread until the back-end has finished processing the current consumer buffer.
        /// </summary>
        public void Swap()
        {
            // Wait for the back-end to finish processing commands.
            backEndBlock.WaitOne();
            backEndBlock.Reset();

            // Swap the buffers.
            Queue<RenderCommand> temp = producer;

            producer = consumer; // The consumer should always be fully consumed (empty) at this point by the render back-end.
            consumer = temp; // Present the next set of instructions to the render back-end.

            // Signal the back-end the front-end has completed generating commands.
            frontEndBlock.Set();
        }
    }
}
