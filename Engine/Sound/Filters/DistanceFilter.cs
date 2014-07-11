using DarkTech.Common.Math;

namespace DarkTech.Engine.Sound.Filters
{
    internal sealed class DistanceFilter : SampleTransformer
    {
        public delegate float DistanceDelegate(float distance);

        private readonly Listener listener;
        private readonly ActiveSound activeSound;
        private readonly DistanceDelegate distanceModel;
        private readonly float minGain;
        private readonly float maxGain;
        private float distance;
        private float maxDistance;
        private float normalizedDistance;

        public DistanceFilter(Listener listener, ActiveSound activeSound, DistanceDelegate distanceModel, float minGain, float maxGain)
        {
            this.listener = listener;
            this.activeSound = activeSound;
            this.distanceModel = distanceModel;
            this.minGain = minGain;
            this.maxGain = maxGain;

            // Initialize distance member variables.
            RecomputeDistances();
        }

        public override void Process() { }

        protected override bool Transform(ref Sample input)
        {
            // If either the listener or active sound have changed then recompute the distance member variables.
            if (listener.IsDirty || activeSound.IsDirty)
            {
                RecomputeDistances();
            }

            // Test if the sound is within audible range.
            if (distance > maxDistance)
            {
                // Cull sound, not in audible range.
                return false;
            }

            // Compute the gain based on the distance model which is then clamped between the min/max distance gain.
            float gain = MathHelper.Clamp(distanceModel(normalizedDistance), minGain, maxGain);

            // Apply the gain to the current sample.
            input.left *= gain;
            input.right *= gain;

            return true;
        }

        private void RecomputeDistances()
        {
            Vector3f distanceVector = listener.Location - activeSound.Location;

            distance = distanceVector.Length();
            maxDistance = listener.Range + activeSound.SoundDefinition.Range;
            normalizedDistance = distance / maxDistance; // Normalize distance to 0f (closest) <-> 1f (max distance).
        }

        #region Distance models
        public static float LerpModel(float distance)
        {
            // 0f distance = 1f gain.
            // 1f distance = 0f gain.
            // lerp between other distances.

            return 1f - distance;
        }
        #endregion
    }
}
