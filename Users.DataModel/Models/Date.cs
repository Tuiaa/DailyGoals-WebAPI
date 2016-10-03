using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users.DataModel.Models
{
    public class Date
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public bool BrushTeethMorning { get; set; }
        public bool BrushTeethNight { get; set; }

        public int AmountOfWater { get; set; }

        public int AmoutOfExercise { get; set; }

        public bool EatenCandy { get; set; }
    }
}
