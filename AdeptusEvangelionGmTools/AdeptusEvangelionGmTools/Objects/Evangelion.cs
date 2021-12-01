using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeptusEvangelionGmTools.Objects
{
    public class Evangelion
    {
        #region Properties
        Random rnd = new Random();
        private String Soul { get; set; }
        private List<String> Mutations { get; set; }
        private List<String> Construction { get; set; }
        private String History { get; set; }
        private String PrimaryColor { get; set; }
        private String SecondaryColor { get; set; }
        public int Strength { get; set; }
        public int Toughness { get; set; }
        public int WeaponSkill { get; set; }
        public int BallisticSkill { get; set; }
        public Body Body { get; set; }

        #endregion
        #region Constructors
        public Evangelion()
        {
            Soul = randomSoul();
            Mutations = randomMutation();
            Construction = randomConstruction();
            History = randomHistory();
            PrimaryColor = randomColor();
            SecondaryColor = randomColor();
            Strength = 30;
            Toughness = 30;
            WeaponSkill = 15;
            BallisticSkill = 15;
            Body = new Body(Toughness, "Evangelion");
        }
        public Evangelion(String soul, List<String> mutation, List<String> construction, String history, String primaryColor, String secondaryColor)
        {
            Soul = soul;
            Mutations = mutation;
            Construction = construction;
            History = history;
            PrimaryColor = primaryColor;
            SecondaryColor = secondaryColor;
            Strength = 30;
            Toughness = 30;
            WeaponSkill = 15;
            BallisticSkill = 15;
        }
        #endregion
        #region Private Methods
        private String randomSoul()
        {
            int soul = rnd.Next(1, 101);
            if      (soul >= 1 && soul <= 5)
                return "Fractured Mind";
            else if (soul >= 6 && soul <= 10)
                return "Weeping";
            else if (soul >= 11 && soul <= 15)
                return "Insane";
            else if (soul >= 16 && soul <= 25)
                return "Invasive";
            else if (soul >= 26 && soul <= 35)
                return "Dormant Soul";
            else if (soul >= 36 && soul <= 45)
                return "Destructive";
            else if (soul >= 46 && soul <= 60)
                return "Protective";
            else if (soul >= 61 && soul <= 70)
                return "Calm";
            else if (soul >= 71 && soul <= 80)
                return "Angelic";
            else if (soul >= 81 && soul <= 90)
                return "Skittish";
            else if (soul >= 91 && soul <= 100)
                return "Bonded";

            return "Fractured Mind";
        }
        private List<String> randomMutation()
        {
            int randomMutation = rnd.Next(1, 101);
            List<String> mutations = new List<String>();

            if (randomMutation == 100)
            {
                mutations.Add(mutation(rnd.Next(1, 100)));
                mutations.Add(mutation(rnd.Next(1, 100)));
            }
            else
            {
                mutations.Add(mutation(randomMutation));
            }

            return mutations;
        }
        private string mutation(int mutation)
        {
            if (mutation >= 1 && mutation <= 10)
                return "Pressurized Blood";
            else if (mutation >= 11 && mutation <= 20)
                return "Bioluminescent";
            else if (mutation >= 21 && mutation <= 25)
                return "Cyclopean";
            else if (mutation >= 26 && mutation <= 35)
                return "Hulking Frame";
            else if (mutation >= 36 && mutation <= 45)
                return "Redundant Organs";
            else if (mutation >= 46 && mutation <= 50)
                return "Regenerative";
            else if (mutation >= 51 && mutation <= 60)
                return "Photosynthetic";
            else if (mutation >= 61 && mutation <= 70)
                return "Angelsense";
            else if (mutation >= 71 && mutation <= 75)
                return "Cranial Horn";
            else if (mutation >= 76 && mutation <= 85)
                return "Unrestrained Jaw";
            else if (mutation >= 86 && mutation <= 90)
                return "Predatory";
            else if (mutation >= 91 && mutation <= 99)
                return "Extra Eyes";

            return "Pressurized Blood";
        }
        private List<String> randomConstruction()
        {
            int randomConstruction = rnd.Next(1, 101);
            List<String> constructions = new List<String>();

            if (randomConstruction == 100)
            {
                constructions.Add(mutation(rnd.Next(1, 100)));
                constructions.Add(mutation(rnd.Next(1, 100)));
            }
            else
            {
                constructions.Add(mutation(randomConstruction));
            }

            return constructions;
        }
        private string construction(int construction)
        {
            if (construction >= 1 && construction <= 15)
                return "Clinker";
            else if (construction >= 16 && construction <= 20)
                return "Single Winged";
            else if (construction >= 21 && construction <= 30)
                return "Marker Light Array";
            else if (construction >= 31 && construction <= 40)
                return "Feedback Suppressor";
            else if (construction >= 41 && construction <= 50)
                return "Odd Limbs";
            else if (construction >= 51 && construction <= 60)
                return "Lightweight Chassis";
            else if (construction >= 61 && construction <= 70)
                return "Heavy Armor";
            else if (construction >= 71 && construction <= 75)
                return "Stabilizers";
            else if (construction >= 76 && construction <= 80)
                return "Bakelite Infusion";
            else if (construction >= 81 && construction <= 85)
                return "Leg Pistons";
            else if (construction >= 86 && construction <= 90)
                return "Advanced Battery";
            else if (construction >= 91 && construction <= 99)
                return "Weapon Rack";

            return "Clinker";
        }
        private String randomHistory()
        {
            int history = rnd.Next(1, 101);

            if (history >= 1 && history <= 9)
                return "Badly Financed";
            else if (history >= 10 && history <= 25)
                return "Patchwork";
            else if (history >= 26 && history <= 36)
                return "Prototype";
            else if (history >= 37 && history <= 45)
                return "Haunted";
            else if (history >= 46 && history <= 54)
                return "Concept Model";
            else if (history >= 55 && history <= 63)
                return "Mysterious Source";
            else if (history >= 64 && history <= 72)
                return "Symbol";
            else if (history >= 73 && history <= 100)
                return "Flagship";

            return "Badly Financed";
        }
        private String randomColor()
        {
            int part1 = rnd.Next(1, 101);
            int part2 = rnd.Next(1, 101);

            String Color = "";

            if (part1 >= 1 && part1 <= 25)
                Color += "Bright ";
            else if (part1 >= 26 && part1 <= 50)
                Color += "Dull ";
            else if (part1 >= 51 && part1 <= 75)
                Color += "Dark ";
            else if (part1 >= 76 && part1 <= 100)
                Color += "Neon ";

            if (part2 >= 1 && part2 <= 11)
                Color += "Red";
            else if (part2 >= 12 && part2 <= 22)
                Color += "Orange";
            else if (part2 >= 23 && part2 <= 33)
                Color += "Yellow";
            else if (part2 >= 34 && part2 <= 44)
                Color += "Blue";
            else if (part2 >= 45 && part2 <= 55)
                Color += "Green";
            else if (part2 >= 56 && part2 <= 66)
            {
                if (!Color.Equals("Bright ") || !Color.Equals("Dark "))
                    Color += "White";
                else 
                    Color += "Grey";

            }
            else if (part2 >= 67 && part2 <= 77)
            {
                if (!Color.Equals("Bright ") || !Color.Equals("Dark "))
                    Color += "Black";
                else
                    Color += "Grey";
            }
            else if (part2 >= 78 && part2 <= 88)
                Color += "Purple";
            else if (part2 >= 89 && part2 <= 100)
                Color += "Grey";


            return Color;

        }
        #endregion
    }
}
