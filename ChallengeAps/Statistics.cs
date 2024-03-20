﻿namespace ChallengeApp
{
    public class Statistics
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Average
        {
            get
            {
                return this.Sum / this.Count;
            }
        }
        public float Sum { get; private set; }
        public int Count { get; private set; }
        public char AverageLetter
        {
            get
            {
                switch (this.Average)
                {
                    case var a when a >= 90:
                        return 'A';

                    case var a when a >= 80:
                        return 'B';

                    case var a when a >= 70:
                        return 'C';

                    case var a when a >= 60:
                        return 'D';

                    default:
                        return 'E';
                }
            }
        }

        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Min = float.MaxValue;
            this.Max = float.MinValue;
        }

        public void AddGrade(float grade)   
        {
            this.Count++;
            this.Sum +=grade;
            this.Min = Math.Min(this.Min, grade);
            this.Max = Math.Max(this.Max, grade);
        }
    }
}
