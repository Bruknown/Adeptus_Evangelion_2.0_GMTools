using AdeptusEvangelionGmTools.Objects.AngelProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeptusEvangelionGmTools.Objects
{
    class Angel
    {
        #region Properties
        Random rnd = new Random();

        public List<BodyType> ComboBoxBodyType = new List<BodyType>();
        public List<Difficulty> ComboBoxDifficulty = new List<Difficulty>();
        public List<Locomotion> ComboBoxLocomotion = new List<Locomotion>();
        public List<BodySize> ComboBoxSize = new List<BodySize>();
        public List<Specialization> ComboBoxSpecialization = new List<Specialization>();

        
        public BodyType bodyType { get; set; }
        public Difficulty difficulty { get; set; }
        public Locomotion locomotion { get; set; }
        public BodySize size { get; set; }
        public Specialization specialization { get; set; }

        public int BallisticSkill { get; set; }
        public int WeaponSkill { get; set; }
        public int Strength { get; set; }
        public int Toughness { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }
        public int Perception { get; set; }
        public int Willpower { get; set; }
        public int Fellowship { get; set; }
        public int SynchRatio { get; set; }
        #endregion


        #region Constructor
        public Angel()
        {
            InitiateComponents();
        }
        public Angel(BodyType bodyType, Difficulty difficulty, Locomotion locomotion,
                    BodySize size, Specialization specialization, int ballisticSkill,
                    int weaponSkill, int strength, int toughness, int agility,
                    int intelligence, int perception, int willpower, int fellowship, int synchRatio)
        {
            InitiateComponents();
            if (difficulty == null)
            {
                this.difficulty = RandomDifficulty();
            }
            else
            {
                this.difficulty = difficulty;
            }

            if (specialization == null)
            {
                int randomSpecialization = rnd.Next(1, 101);
                this.specialization = RandomSpecialization(randomSpecialization);
            }
            else
            {
                this.specialization = specialization;
            }

            if (bodyType == null)
            {
                int randomBodyType = rnd.Next(1, 101);
                this.bodyType = RandomBodyType(randomBodyType);
            }
            else
            {
                this.bodyType = bodyType;
            }
            if (locomotion == null)
            {
                this.locomotion = RandomLocomotion();
            }
            else
            {
                this.locomotion = locomotion;
            }
            if (size == null)
            {
                this.size = RandomSize();
            }
            else
            {
                this.size = size;
            }
            BallisticSkill = ballisticSkill;
            WeaponSkill = weaponSkill;
            Strength = strength;
            Toughness = toughness;
            Agility = agility;
            Intelligence = intelligence;
            Perception = perception;
            Willpower = willpower;
            Fellowship = fellowship;
            SynchRatio = synchRatio;
        }

        #endregion
        #region Private Methods
        private void InitiateComponents()
        {
            ComboBoxBodyType = new List<BodyType>
            {
                new BodyType("Bipedal", "Bipedal Angels are of a vaguely humanoid shape, and are generally of equivalent size to the Evangelions. Often skilled at melee combat, their possession of powerful ranged attacks is neither impossible nor unlikely."),
                new BodyType("Insectile","Insectile Angels share some physical attributes with insects, though how much can vary wildly. They are often dangerous if not powerful in melee, and can combine an armored exoskeleton with speed surprising for its size. "),
                new BodyType("Orbital","Orbital Angels are often much larger than normal Angels, putting their less restrictive environment to good use. These Angels never focus on melee combat, though what they choose to use their advantage of range for can vary wildly.They also treat all directed ranged attacks as having sufficient range to shoot surface targets from orbit."),
                new BodyType("Bestial","Bestial Angels are powerful if simple in design. While they rarely resemble any creature from Earth, they are clearly some sort of predator, often one with a devastating melee attack."),
                new BodyType("Artificial","Despite their name, Artifical Angels are not actually more artificial than any other creation of Adam. Rather, they have physical forms that are of a design that is clearly not natural. This could be something that is crystalline in form, visibly warping reality around it, or it might even appear to be made of pure energy! In any event, such Angels usually posses abilities just as strange and impressive as their appearance."),
                new BodyType("Amorphous","Amorphous Angels have no defined physical form. This could be because the Angel is a large, amoeba-like blob or because its form is constantly shifting. This is often indicative of an exceptionally powerful A.T. Field that should not be underestimated. Such angels can increase or decrease its size as a free action. ")
            };
            ComboBoxDifficulty = new List<Difficulty>
            {
                new Difficulty("Introductory","Likely the first, perhaps second Angel your players will face, these should merely serve as an introduction to Adeptus Evangelion combat and throw no unusually challenging concepts"),
                new Difficulty("Easy","still easy due to being a part of the early game, these angels represent a step up from the fodder tossed at the players initially. "),
                new Difficulty("Medium","These angels make up the bulk of a campaign, with the end of this region possibly corresponding to a darker change in mood, or the final stretch of Angel attacks"),
                new Difficulty("Hard"," this level of difficulty would likely cause total player death if encountered at lower ranks, and occur as the campaign is beginning to draw near to the end"),
                new Difficulty("Apocalyptic","unlikely to have more than one or two of these in your campaign if at all, they are the final few, and by far the strongest,")
            };
            ComboBoxLocomotion = new List<Locomotion>
            {
                new Locomotion("Ground","The Angel moves on the ground. This may  be on two legs, on four legs, or even no legs at all. Whatever organs turn out to be at work, the Angel moves at a speed determined as normal by its Agility. Such angels are considered to be effected by difficult terrain."),
                new Locomotion("Ground + Burrowing","The Angel gains the Burrower Trait, with a speed equal to one half its normal speeds as determined by its Agility. They also add +10 to interception rolls."),
                new Locomotion("Ground + Swimming","Angels with this method of transportation can swim through a liquid medium at a speed equal to their ‘On the Ground’ speed. They are considered to be at home in such  places and hence do not suffer from sinking,"),
                new Locomotion("Hovering","These angels float marginally above the ground, but cannot ascend to such heights that it impedes Evangelions attempting to attack them: The main difference to ‘On the Ground’ is their ability to avoid relatively low lying obstacles such as small buildings."),
                new Locomotion("Flying","The angel gets the ability of flight"),
                new Locomotion("Teleportation","Angels that possess teleportation abilities can travel between two points instantaneously. In the event that this is the Angel’s sole method of transit it may hang in the air motionless between jumps. At the GMs discretion, targets such as Evangelions that are grappling with or otherwise in  physical contact with the angel may or may not be brought along on the jump. The amount of turns they must wait between  jumps If the angelsuccessfully rolls dodge the GM may decideat their discretion that this constitutes themteleporting out of the way and allow them tomake an additional jump under thesecircumstances")
            };
            ComboBoxSize = new List<BodySize> 
            { 
                new BodySize("Scrawny","Shorter than an Evangelion(- 10m-20m)"),
                new BodySize("Average","Equal to an Evangelion in size"),
                new BodySize("Hulking","Larger than an Evangelion(+ 10m-20m)"),
                new BodySize("Enormous","Double the size of an Evangelion(+ 30-40)"),
                new BodySize("Massive","Reserved to few body types, equivalent in size to Sahaquiel")
            };
            ComboBoxSpecialization = new List<Specialization> 
            { 
                new Specialization("Frontal Assault","Frontal Assault angels are dedicated fighters with focus on defeating Evangelions"),
                new Specialization("Distance Fighting","Distance Fighting angels have dedicated tools for keeping enemies at distance and dealing massive damage, usually squishy in close quarters"),
                new Specialization("Encroachment","Encroachment angels have specialized tools for dealing with pilots, attacking them directly"),
            };
        }

        private BodySize RandomSize()
        {
            return null;
        }

        private Locomotion RandomLocomotion()
        {
            return null;
        }

        private BodyType RandomBodyType(int randomBodyType)
        {
            if (specialization.Name.Equals("Frontal Assault"))
                return RandomBodyTypeFrontalAssault(randomBodyType);
            else if (specialization.Name.Equals("Distance Fighting"))
                return RandomBodyTypeDistanceFighting(randomBodyType);
            else if (specialization.Name.Equals("Encroachment"))
                return RandomBodyTypeEncroachment(randomBodyType);

            return RandomBodyType(rnd.Next(1, 101));
        }

        private BodyType RandomBodyTypeFrontalAssault(int randomBodyType)
        {
            if (randomBodyType >= 1 && randomBodyType <= 35)
                return ComboBoxBodyType[0];
            else if (randomBodyType >= 36 && randomBodyType <= 50)
                return ComboBoxBodyType[1];
            else if (randomBodyType >= 51 && randomBodyType <= 70)
                return ComboBoxBodyType[3];
            else if (randomBodyType >= 71 && randomBodyType <= 80)
                return ComboBoxBodyType[4];
            else if (randomBodyType >= 81 && randomBodyType <= 100)
                return ComboBoxBodyType[5];

            return RandomBodyTypeDistanceFighting(rnd.Next(1, 101));
        }
        private BodyType RandomBodyTypeDistanceFighting(int randomBodyType)
        {
            if (randomBodyType >= 1 && randomBodyType <= 5)
                return ComboBoxBodyType[0]; //bipedal
            else if (randomBodyType >= 6 && randomBodyType <= 20)
                return ComboBoxBodyType[1]; //insectile
            else if (randomBodyType >= 21 && randomBodyType <= 40)
                return ComboBoxBodyType[2]; //orbital
            else if (randomBodyType >= 41 && randomBodyType <= 45)
                return ComboBoxBodyType[3]; //bestial
            else if (randomBodyType >= 46 && randomBodyType <= 70)
                return ComboBoxBodyType[4]; //artificial
            else if (randomBodyType >= 71 && randomBodyType <= 100)
                return ComboBoxBodyType[5]; //amorphous

            return RandomBodyTypeDistanceFighting(rnd.Next(1, 101));
        }
        private BodyType RandomBodyTypeEncroachment(int randomBodyType)
        {
            if (randomBodyType >= 1 && randomBodyType <= 15)
                return ComboBoxBodyType[0];
            else if (randomBodyType >= 16 && randomBodyType <= 30)
                return ComboBoxBodyType[1];
            else if (randomBodyType >= 31 && randomBodyType <= 50)
                return ComboBoxBodyType[2];
            else if (randomBodyType >= 51 && randomBodyType <= 60)
                return ComboBoxBodyType[3];
            else if (randomBodyType >= 61 && randomBodyType <= 70)
                return ComboBoxBodyType[4];
            else if (randomBodyType >= 71 && randomBodyType <= 100)
                return ComboBoxBodyType[5];

            return RandomBodyTypeEncroachment(rnd.Next(1, 101));
        }

        private Specialization RandomSpecialization(int randomSpec)
        {
            if (difficulty.Name.Equals("Introductory") || difficulty.Name.Equals("Easy"))
            {
                return ComboBoxSpecialization[rnd.Next(0, 1)];
            }
            else
            {
                if (randomSpec >= 1 && randomSpec <= 40)
                {
                    return ComboBoxSpecialization[0];
                }
                if (randomSpec >= 41 && randomSpec <= 80)
                {
                    return ComboBoxSpecialization[1];
                }
                if (randomSpec >= 81 && randomSpec <= 100)
                {
                    return ComboBoxSpecialization[2];
                }
            }
            return RandomSpecialization(rnd.Next(1, 101));
        }

        private Difficulty RandomDifficulty()
        {
            return ComboBoxDifficulty[rnd.Next(0, ComboBoxDifficulty.Count())];
        }
        #endregion
    }
}
