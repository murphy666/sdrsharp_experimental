namespace SDRSharp.Radio
{
    public unsafe interface IIQProcessor : IBaseProcessor
    {
        void Process(Complex* buffer, int length);
    }
}
