namespace BlazorWASM.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
        }
        private void DecrementCount()
        {
            if (currentCount != 0) currentCount--;
        }
        private void ResetCount()
        {
            currentCount = 0;
        }
    }
}
