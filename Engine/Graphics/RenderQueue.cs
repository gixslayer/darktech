using System;
using System.Collections.Generic;
using System.Threading;

namespace DarkTech.Engine.Graphics
{
    internal sealed class RenderQueue : IDisposable
    {
        private static readonly Queue<RenderCommand> EMPTY_QUEUE = new Queue<RenderCommand>();

        private readonly object swapSync;
        private readonly ManualResetEvent dataBlock;
        private readonly Queue<Queue<RenderCommand>> consumer;
        private Queue<RenderCommand> producer;
        private bool disposed;        

        public RenderQueue()
        {
            this.producer = new Queue<RenderCommand>();
            this.consumer = new Queue<Queue<RenderCommand>>();
            this.disposed = false;
            this.swapSync = new object();
            this.dataBlock = new ManualResetEvent(false);
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
                    lock (swapSync)
                    {
                        // Signal the consumer thread to prevent it from blocking during shutdown.
                        consumer.Clear();
                        dataBlock.Set();
                    }
                }

                dataBlock.Dispose();

                disposed = true;
            }
        }

        /// <summary>
        /// Blocks the calling thread until render commands are available.
        /// </summary>
        public void WaitForData()
        {
            dataBlock.WaitOne();
        }

        /// <summary>
        /// Returns a queue of render commands available for the renderer back-end to process.
        /// </summary>
        /// <returns>Returns a queue of render commands available for the renderer back-end to process.</returns>
        public Queue<RenderCommand> GetCommands()
        {
            lock (swapSync)
            {
                // If this is the last collection of commands reset the dataSync signal.
                if (consumer.Count == 1)
                    dataBlock.Reset();

                // If no commands are available return an empty collection.
                return consumer.Count != 0 ? consumer.Dequeue() : EMPTY_QUEUE;
            }
        }

        /// <summary>
        /// Adds a render command to the current queue.
        /// </summary>
        /// <param name="command">The render command.</param>
        public void AddCommand(RenderCommand command)
        {
            producer.Enqueue(command);
        }

        /// <summary>
        /// Swap the render command queue so that all added commands through <see cref="AddCommand(RenderCommand)"/> are available to the renderer back-end.
        /// </summary>
        public void Swap()
        {
            lock (swapSync)
            {
                // Make sure commands were actually queued.
                if (producer.Count == 0)
                    return;

                // Add the producer queue to the consumer queue.
                consumer.Enqueue(producer);

                // Create a new instance for the producer.
                producer = new Queue<RenderCommand>();

                // Notify the consumer data is available.
                dataBlock.Set();
            }
        }
    }
}
