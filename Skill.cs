using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRD
{
    public class Skill
    {   //skillId, skillName, skillLevel
        public string skillId;
        public string skillName;
        public string skillLevel;
        public Skill(string skillId,string skillName, string skillLevel) {
            this.skillId = skillId;
            this.skillName = skillName;
            this.skillLevel = skillLevel;
        }
    }
}
