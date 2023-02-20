using Avalonia.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTable.Models
{
    public class Student
    {
        private float sr_scores = 0;
        private ushort[] scores = {0, 0, 0, 0, 0, 0, 0};
        private string name = "";
        private SolidColorBrush[] colorBrush = new SolidColorBrush[8];

        private SolidColorBrush checkColor(ushort num)
        {
            if (num == 0) return new SolidColorBrush(Colors.Red);
            if (num == 1) return new SolidColorBrush(Colors.Yellow);
            else return new SolidColorBrush(Colors.Green);
        }

        private SolidColorBrush checkColor(float num)
        {
            if (num < 1) return new SolidColorBrush(Colors.Red);
            if (num < 1.5) return new SolidColorBrush(Colors.Yellow);
            else return new SolidColorBrush(Colors.Green);
        }

        public string Name 
        { 
            get => name; 
            set => name = value; 
        }

        public ushort Visual
        {
            get => scores[0];
            set { scores[0] = value; ColorVisual = checkColor(scores[0]); }
        }

        public SolidColorBrush ColorVisual
        {
            get => colorBrush[0];
            set => colorBrush[0] = value;
        }

        public ushort Architecture
        {
            get => scores[1];
            set { scores[1] = value; ColorArchitecture = checkColor(scores[1]); }
        }

        public SolidColorBrush ColorArchitecture
        {
            get => colorBrush[1];
            set => colorBrush[1] = value;
        }

        public ushort Networks
        {
            get => scores[2];
            set { scores[2] = value; ColorNetworks = checkColor(scores[2]); }
        }
        public SolidColorBrush ColorNetworks
        {
            get => colorBrush[2];
            set => colorBrush[2] = value;
        }

        public ushort Calculate_Math
        {
            get => scores[3];
            set { scores[3] = value; ColorCalculate_Math = checkColor(scores[3]); }
        }
        public SolidColorBrush ColorCalculate_Math
        {
            get => colorBrush[3];
            set => colorBrush[3] = value;
        }
        public ushort PI
        {
            get =>scores[4];
            set { scores[4] = value; ColorPI = checkColor(scores[4]); }
        }
        public SolidColorBrush ColorPI
        {
            get => colorBrush[4];
            set => colorBrush[4] = value;
        }
        public ushort Math
        {
            get => scores[5];
            set { scores[5] = value; ColorMath = checkColor(scores[5]); }
        }
        public SolidColorBrush ColorMath
        {
            get => colorBrush[5];
            set => colorBrush[5] = value;
        }
        public ushort Electric
        {
            get => scores[6];
            set { scores[6] = value; ColorElectric = checkColor(scores[6]); }
        }
        public SolidColorBrush ColorElectric
        {
            get => colorBrush[6];
            set { colorBrush[6] = value; Average_Score = 0; }
        }

        public float Average_Score
        {
            get => sr_scores;
            set
            {
                sr_scores = 0;
                foreach (ushort num in scores)
                {
                    sr_scores += num;
                }
                sr_scores /= 7;
                ColorAverage = checkColor(sr_scores);
            }
        }
        public SolidColorBrush ColorAverage
        {
            get => colorBrush[7];
            set => colorBrush[7] = value;
        }
    }
}
