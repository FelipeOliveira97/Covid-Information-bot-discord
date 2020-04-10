using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidInformationCore.Model
{
    public class MGlobal
    {
        public string NewConfirmed { get; set; }
        public string TotalConfirmed { get; set; }
        public string NewDeaths { get; set; }
        public string TotalDeaths { get; set; }
        public string NewRecovered { get; set; }
        public string TotalRecovered { get; set; }
        public DateTime Date { get; set; }

    }
}
