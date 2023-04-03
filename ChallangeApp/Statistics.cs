
namespace ChallangeApp
{
    public class Statistics
    {
        public Statistics()
        {
            Average = 0;
            Max = float.MinValue;
            Min = float.MaxValue;

        }
        public float Min { get; set; }
        public float Max{ get; set; }
        public float Average { get; set; }
        public char AverageLetter { get; set; }

    }
}
