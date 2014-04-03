namespace SDRSharp.Radio
{
    public unsafe interface IRealProcessor : IBaseProcessor
    {
        void Process(float *buffer, int length);
    }
}
