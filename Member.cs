  namespace heist {
       public class Member
    {
        public string name {get; set;}
        public int skill {get; set;}
        public double courage {get; set;}
//Create a constructor
        public Member(string name, int skill, double courage) {
            this.name = name;
            this.skill = skill;
            this.courage = courage;
        }

        public int GetSkillLevel()
        {
            return skill;
        }
  }
  }