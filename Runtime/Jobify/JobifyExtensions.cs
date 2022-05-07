using Unity.Burst;
using Unity.Jobs;

namespace Unity.Mathematics
{
    [BurstCompile]
    public static class JobifyExtensions
    {
        public static Jobify.Jobified Jobify(this OperationInterface.FloatInOut d, float input)
        {
            return new Jobify.Jobified(d, input);
        }
        
        public static void ExecuteAndComplete(this Jobify.Jobified j)
        {
            j.Schedule().Complete();
        }
    }
}