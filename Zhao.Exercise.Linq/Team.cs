using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhao.Exercise.Linq
{
    [Serializable]
    public class Team
    {
        public Team(string name, params int[] years)
        {
            this.Name = name;
            this.Yesrs = years;
        }
        public string Name { get; private set; }
        public IEnumerable<int> Yesrs { get; private set; }
    }
}
