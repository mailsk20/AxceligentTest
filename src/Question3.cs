using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxceligentTest
{
    public class Question3
    {
        public void JohnRobot()
        {
            var john = new Humanoid(new Dancing());
            Console.WriteLine(john.ShowSkill()); //print dancing

            var alex = new Humanoid(new Cooking());
            Console.WriteLine(alex.ShowSkill());//print cooking

            var bob = new Humanoid();
            Console.WriteLine(bob.ShowSkill());//print no skill is defined
        }
    }

    public interface ISkill
    {
        string ShowSkill();
    }
    public class Dancing : ISkill
    {
        public string ShowSkill()
        {
            return "Dancing";
        }
    }
    public class Cooking : ISkill
    {
        public string ShowSkill()
        {
            return "Cooking";
        }
    }
    public class Humanoid
    {
        private ISkill _skill;
        public Humanoid(ISkill skill = null)
        {
            if (skill != null)
                _skill = skill;
        }

        public string ShowSkill()
        {
            return _skill != null ? this._skill.ShowSkill() : "No skill is defined";
        }
    }
}
