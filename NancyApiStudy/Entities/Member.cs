using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyApiStudy.Entities {
    public class Member {
        public string Name { get; set; }

        public List<string> Instruments { get; set; }
    }
}
