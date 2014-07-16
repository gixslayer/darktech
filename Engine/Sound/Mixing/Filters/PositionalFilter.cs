using DarkTech.Common.Math;
using DarkTech.Common.Utils;
using DarkTech.Engine.Scripting;

namespace DarkTech.Engine.Sound.Mixing.Filters
{
    internal sealed class PositionalFilter : SampleTransformer
    {
        public delegate float DistanceDelegate(float distance);

        public static DistanceDelegate DistanceModel { get; set; }

        private static readonly CachedCvar<float> DM_EXP_BIAS = new CachedCvar<float>("snd_distanceModel_exp_bias", 2f);
        private static readonly CachedCvar<float> DM_INVEXP_BIAS = new CachedCvar<float>("snd_distanceModel_invExp_bias", 2f);
        private static readonly CachedCvar<float> DM_MIN_GAIN = new CachedCvar<float>("snd_distanceModel_minGain", 0.01f);
        private static readonly CachedCvar<float> DM_MAX_GAIN = new CachedCvar<float>("snd_distanceModel_maxGain", 1f);

        private readonly SharedReference<Listener> listener;
        private readonly SharedReference<ActiveSound> activeSound;
        private float distance;
        private float maxDistance;
        private float normalizedDistance;

        public PositionalFilter(SharedReference<Listener> listener, SharedReference<ActiveSound> activeSound)
        {
            this.listener = listener;
            this.activeSound = activeSound;

            // Initialize distance member variables.
            RecomputeDistances();
        }

        protected override bool Transform(ref Sample input)
        {
            // If either the listener or active sound have changed then recompute the distance member variables.
            if (listener.Value.IsDirty || activeSound.Value.IsDirty)
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
            float gain = MathHelper.Clamp(DistanceModel(normalizedDistance), DM_MIN_GAIN.Value, DM_MAX_GAIN.Value);

            // Apply the gain to the current sample.
            input.left *= gain;
            input.right *= gain;

            return true;
        }

        private float SumToMono(ref Sample sample)
        {
            return (sample.left + sample.right) / 2f;
        }

        private void RecomputeDistances()
        {
            Vector3f distanceVector = listener.Value.Location - activeSound.Value.Location;

            distance = distanceVector.Length();
            maxDistance = listener.Value.Range + activeSound.Value.SoundDefinition.Range;
            normalizedDistance = distance / maxDistance; // Normalize distance to 0f (closest) <-> 1f (max distance).
        }

        #region Distance models
        public static float DM_Linear(float distance)
        {
            return 1f - distance;
        }

        public static float DM_Exp(float distance)
        {
            return 1f - MathHelper.Pow(distance, DM_EXP_BIAS.Value);
        }

        public static float DM_InvExp(float distance)
        {
            return 1f - MathHelper.Pow(distance, 1f / DM_INVEXP_BIAS.Value);
        }
        #endregion
    }
}
