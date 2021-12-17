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
        public Body body { get; set; }

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

            this.difficulty     = (this.difficulty == null)     ? this.difficulty       = RandomDifficulty() : this.difficulty = difficulty;
            this.specialization = (this.specialization == null) ? this.specialization   = RandomSpecialization(rnd.Next(1, 101)) : this.specialization = specialization;
            this.bodyType       = (this.bodyType == null)       ? this.bodyType         = RandomBodyType(rnd.Next(1, 101)) : this.bodyType = bodyType;
            this.locomotion     = (this.locomotion == null)     ? this.locomotion       = RandomLocomotion(rnd.Next(1, 101), this.bodyType) : this.locomotion = locomotion;
            this.size           = (this.size == null)           ? this.size             = RandomSize(rnd.Next(1, 101), this.bodyType) : this.size = size;
            
            BallisticSkill  = (BallisticSkill == 0) ? BallisticSkill    = RandomBS(rnd.Next(1, 101), this.specialization)    : BallisticSkill = ballisticSkill;
            WeaponSkill     = (WeaponSkill == 0)    ? WeaponSkill       = RandomWS(rnd.Next(1, 101), this.specialization)    : WeaponSkill = weaponSkill;
            Strength        = (Strength == 0)       ? Strength          = RandomStr(rnd.Next(1, 101), this.specialization)   : Strength = strength;
            Toughness       = (Toughness == 0)      ? Toughness         = RandomTough(rnd.Next(1, 101), this.specialization) : Toughness = toughness;
            Agility         = (Agility == 0)        ? Agility           = RandomAgi(rnd.Next(1, 101), this.specialization)   : Agility = agility;
            Intelligence    = (Intelligence == 0)   ? Intelligence      = RandomInt(rnd.Next(1, 101), this.specialization)   : Intelligence = intelligence;
            Perception      = (Perception == 0)     ? Perception        = RandomPer(rnd.Next(1, 101), this.specialization)   : Perception = perception;
            Willpower       = (Willpower == 0)      ? Willpower         = RandomWP(rnd.Next(1, 101), this.specialization)    : Willpower = willpower;
            Fellowship      = (Fellowship == 0)     ? Fellowship        = RandomFel(rnd.Next(1, 101), this.specialization)   : Fellowship = fellowship;
            SynchRatio      = (SynchRatio == 0)     ? SynchRatio        = RandomSR(rnd.Next(1, 101), this.specialization)    : SynchRatio = synchRatio;

            body = new Body(Toughness, this.bodyType.Name);
            ArmorHandling(rnd.Next(1,101), this.specialization);

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
        private void ArmorHandling(int randomArmor, Specialization specialization)
        {
            switch(specialization.Name)
            {
                case "Frontal Assault":
                    if (randomArmor >= 11 || randomArmor <= 25)
                    {
                        if (body.Head != null)
                            body.Head.Armor = 2;
                        if (body.Torso != null)
                            body.Torso.Armor = 2;
                    }
                    else if (randomArmor >= 26 || randomArmor <= 60)
                    {
                        int armor = rnd.Next(1, 6);
                        if (body.Head != null)
                            body.Head.Armor = armor;
                        if (body.Torso != null)
                            body.Torso.Armor = armor;
                    }
                    else if (randomArmor >= 61 || randomArmor <= 85)
                    {
                        int armor = rnd.Next(1, 6)+2;
                        if (body.Head != null)
                            body.Head.Armor = armor;
                        if (body.Torso != null)
                            body.Torso.Armor = armor;
                        if (body.Core != null)
                            body.Core.Armor = armor;
                        if (body.LeftArm != null)
                            body.LeftArm.Armor = 2;
                        if (body.RightArm != null)
                            body.RightArm.Armor = 2;
                        if (body.RightLeg != null)
                            body.RightLeg.Armor = 2;
                        if (body.LeftLeg != null)
                            body.LeftLeg.Armor = 2;
                    }
                    else if (randomArmor >= 86 || randomArmor <= 95)
                    {
                        int armor = rnd.Next(1, 6) + 4;
                        int armorlimb = rnd.Next(1, 6);
                        if (body.Head != null)
                            body.Head.Armor = armor;
                        if (body.Torso != null)
                            body.Torso.Armor = armor;
                        if (body.Core != null)
                            body.Core.Armor = armor;
                        if (body.LeftArm != null)
                            body.LeftArm.Armor = armorlimb;
                        if (body.RightArm != null)
                            body.RightArm.Armor = armorlimb;
                        if (body.RightLeg != null)
                            body.RightLeg.Armor = armorlimb;
                        if (body.LeftLeg != null)
                            body.LeftLeg.Armor = armorlimb;
                    }
                    else if (randomArmor >= 96 || randomArmor <= 100)
                    {
                        int armor = rnd.Next(1, 11) + 5;
                        int armorlimb = rnd.Next(1, 6) +2;
                        if (body.Head != null)
                            body.Head.Armor = armor;
                        if (body.Torso != null)
                            body.Torso.Armor = armor;
                        if (body.Core != null)
                            body.Core.Armor = armor;
                        if (body.LeftArm != null)
                            body.LeftArm.Armor = armorlimb;
                        if (body.RightArm != null)
                            body.RightArm.Armor = armorlimb;
                        if (body.RightLeg != null)
                            body.RightLeg.Armor = armorlimb;
                        if (body.LeftLeg != null)
                            body.LeftLeg.Armor = armorlimb;
                    }
                    break;
                case "Distance Fighting":
                    if (randomArmor >= 01 || randomArmor <= 40)
                    {
                        int armor = rnd.Next(1, 6);
                        if (body.Head != null)
                            body.Head.Armor = armor;
                        if (body.Torso != null)
                            body.Torso.Armor = armor;
                    }
                    else if (randomArmor >= 41 || randomArmor <= 70)
                    {
                        int armor = rnd.Next(1, 6) + 2;
                        if (body.Head != null)
                            body.Head.Armor = armor;
                        if (body.Torso != null)
                            body.Torso.Armor = armor;
                        if (body.Core != null)
                            body.Core.Armor = armor;
                        if (body.LeftArm != null)
                            body.LeftArm.Armor = 2;
                        if (body.RightArm != null)
                            body.RightArm.Armor = 2;
                        if (body.RightLeg != null)
                            body.RightLeg.Armor = 2;
                        if (body.LeftLeg != null)
                            body.LeftLeg.Armor = 2;
                    }
                    else if (randomArmor >= 71 || randomArmor <= 90)
                    {
                        int armor = rnd.Next(1, 6) + 4;
                        int armorlimb = rnd.Next(1, 6);
                        if (body.Head != null)
                            body.Head.Armor = armor;
                        if (body.Torso != null)
                            body.Torso.Armor = armor;
                        if (body.Core != null)
                            body.Core.Armor = armor;
                        if (body.LeftArm != null)
                            body.LeftArm.Armor = armorlimb;
                        if (body.RightArm != null)
                            body.RightArm.Armor = armorlimb;
                        if (body.RightLeg != null)
                            body.RightLeg.Armor = armorlimb;
                        if (body.LeftLeg != null)
                            body.LeftLeg.Armor = armorlimb;
                    }
                    else if (randomArmor >= 91 || randomArmor <= 100)
                    {
                        int armor = rnd.Next(1, 11) + 5;
                        int armorlimb = rnd.Next(1, 6) + 2;
                        if (body.Head != null)
                            body.Head.Armor = armor;
                        if (body.Torso != null)
                            body.Torso.Armor = armor;
                        if (body.Core != null)
                            body.Core.Armor = armor;
                        if (body.LeftArm != null)
                            body.LeftArm.Armor = armorlimb;
                        if (body.RightArm != null)
                            body.RightArm.Armor = armorlimb;
                        if (body.RightLeg != null)
                            body.RightLeg.Armor = armorlimb;
                        if (body.LeftLeg != null)
                            body.LeftLeg.Armor = armorlimb;
                    }
                    break;
                case "Encroacher":
                    if (randomArmor >= 41 || randomArmor <= 80)
                    {
                        if (body.Head != null)
                            body.Head.Armor = 2;
                        if (body.Torso != null)
                            body.Torso.Armor = 2;
                    }
                    else if (randomArmor >= 81 || randomArmor <= 95)
                    {
                        int armor = rnd.Next(1, 6);
                        if (body.Head != null)
                            body.Head.Armor = armor;
                        if (body.Torso != null)
                            body.Torso.Armor = armor;
                    }
                    else if (randomArmor >= 96 || randomArmor <= 100)
                    {
                        int armor = rnd.Next(1, 6) + 2;
                        if (body.Head != null)
                            body.Head.Armor = armor;
                        if (body.Torso != null)
                            body.Torso.Armor = armor;
                        if (body.Core != null)
                            body.Core.Armor = armor;
                        if (body.LeftArm != null)
                            body.LeftArm.Armor = 2;
                        if (body.RightArm != null)
                            body.RightArm.Armor = 2;
                        if (body.RightLeg != null)
                            body.RightLeg.Armor = 2;
                        if (body.LeftLeg != null)
                            body.LeftLeg.Armor = 2;
                    }
                    break;
            }
        }
        private int RandomBS(int randomBS, Specialization spec)
        {
            switch (spec.Name)
            {
                case "Frontal Assault":
                    if (randomBS >= 1 && randomBS <= 40)
                        return 35;
                    if (randomBS >= 41 && randomBS <= 70)
                        return 40;
                    if (randomBS >= 71 && randomBS <= 90)
                        return 45;
                    if (randomBS >= 91 && randomBS <= 100)
                        return 50;
                    break;
                case "Distance Fighting":
                    if (randomBS >= 1 && randomBS <= 25)
                        return 10;
                    if (randomBS >= 26 && randomBS <= 50)
                        return 20;
                    if (randomBS >= 51 && randomBS <= 80)
                        return 35;
                    if (randomBS >= 81 && randomBS <= 100)
                        return 40;
                    break;
                case "Encroachment":
                    if (randomBS >= 1 && randomBS <= 10)
                        return 10;
                    if (randomBS >= 11 && randomBS <= 20)
                        return 20;
                    if (randomBS >= 21 && randomBS <= 40)
                        return 35;
                    if (randomBS >= 41 && randomBS <= 90)
                        return 40;
                    if (randomBS >= 91 && randomBS <= 95)
                        return 45;
                    if (randomBS >= 96 && randomBS <= 100)
                        return 50;
                    break;
            }
            return 0;
        }
        private int RandomWS(int randomWS, Specialization spec)
        {
            switch (spec.Name)
            {
                case "Frontal Assault":
                    if (randomWS >= 1 && randomWS <= 15)
                        return 10;
                    if (randomWS >= 16 && randomWS <= 40)
                        return 40;
                    if (randomWS >= 41 && randomWS <= 85)
                        return 45;
                    if (randomWS >= 86 && randomWS <= 100)
                        return 50;
                    break;
                case "Distance Fighting":
                    if (randomWS >= 1 && randomWS <= 5)
                        return 20;
                    if (randomWS >= 6 && randomWS <= 20)
                        return 35;
                    if (randomWS >= 21 && randomWS <= 60)
                        return 40;
                    if (randomWS >= 61 && randomWS <= 90)
                        return 45;
                    if (randomWS >= 91 && randomWS <= 100)
                        return 50;
                    break;
                case "Encroachment":
                    if (randomWS >= 1 && randomWS <= 10)
                        return 10;
                    if (randomWS >= 11 && randomWS <= 20)
                        return 20;
                    if (randomWS >= 21 && randomWS <= 40)
                        return 35;
                    if (randomWS >= 41 && randomWS <= 90)
                        return 40;
                    if (randomWS >= 91 && randomWS <= 95)
                        return 45;
                    if (randomWS >= 96 && randomWS <= 100)
                        return 50;
                    break;
            }
            return 0;
        }
        private int RandomStr(int randomStr, Specialization spec)
        {
            switch (spec.Name)
            {
                case "Frontal Assault":
                    if (randomStr >= 1 && randomStr <= 10)
                        return 20;
                    if (randomStr >= 11 && randomStr <= 20)
                        return 30;
                    if (randomStr >= 21 && randomStr <= 60)
                        return 40;
                    if (randomStr >= 61 && randomStr <= 75)
                        return 45;
                    if (randomStr >= 76 && randomStr <= 85)
                        return 50;
                    if (randomStr >= 86 && randomStr <= 95)
                        return 55;
                    if (randomStr >= 96 && randomStr <= 100)
                        return 60;
                    break;
                case "Distance Fighting":
                    if (randomStr >= 1 && randomStr <= 20)
                        return 10;
                    if (randomStr >= 21 && randomStr <= 50)
                        return 20;
                    if (randomStr >= 51 && randomStr <= 90)
                        return 30;
                    if (randomStr >= 91 && randomStr <= 100)
                        return 40;
                    break;
                case "Encroachment":
                    if (randomStr >= 1 && randomStr <= 15)
                        return 10;
                    if (randomStr >= 16 && randomStr <= 30)
                        return 20;
                    if (randomStr >= 31 && randomStr <= 65)
                        return 30;
                    if (randomStr >= 66 && randomStr <= 75)
                        return 40;
                    if (randomStr >= 76 && randomStr <= 85)
                        return 45;
                    if (randomStr >= 86 && randomStr <= 95)
                        return 50;
                    if (randomStr >= 96 && randomStr <= 100)
                        return 55;
                    break;
            }
            return 0;
        }
        private int RandomTough(int randomTough, Specialization spec)
        {
            switch (spec.Name)
            {
                case "Frontal Assault":
                    if (randomTough >= 1 && randomTough <= 5)
                        return 10;
                    if (randomTough >= 6 && randomTough <= 10)
                        return 20;
                    if (randomTough >= 11 && randomTough <= 40)
                        return 35;
                    if (randomTough >= 41 && randomTough <= 80)
                        return 40;
                    if (randomTough >= 81 && randomTough <= 95)
                        return 45;
                    if (randomTough >= 96 && randomTough <= 100)
                        return 50;
                    break;
                case "Distance Fighting":
                    if (randomTough >= 1 && randomTough <= 10)
                        return 10;
                    if (randomTough >= 11 && randomTough <= 20)
                        return 20;
                    if (randomTough >= 21 && randomTough <= 30)
                        return 35;
                    if (randomTough >= 31 && randomTough <= 70)
                        return 40;
                    if (randomTough >= 71 && randomTough <= 85)
                        return 45;
                    if (randomTough >= 86 && randomTough <= 100)
                        return 50;
                    break;
                case "Encroachment":
                    if (randomTough >= 1 && randomTough <= 35)
                        return 10;
                    if (randomTough >= 36 && randomTough <= 70)
                        return 20;
                    if (randomTough >= 71 && randomTough <= 99)
                        return 35;
                    if (randomTough == 100)
                        return 40;
                    break;
            }
            return 0;
        }
        private int RandomAgi(int randomAgi, Specialization spec)
        {
            switch (spec.Name)
            {
                case "Frontal Assault":
                    if (randomAgi >= 1 && randomAgi <= 15)
                        return 10;
                    if (randomAgi >= 16 && randomAgi <= 30)
                        return 20;
                    if (randomAgi >= 31 && randomAgi <= 50)
                        return 30;
                    if (randomAgi >= 51 && randomAgi <= 75)
                        return 40;
                    if (randomAgi >= 76 && randomAgi <= 90)
                        return 50;
                    if (randomAgi >= 91 && randomAgi <= 100)
                        return 60;
                    break;
                case "Distance Fighting":
                    if (randomAgi >= 1 && randomAgi <= 20)
                        return 10;
                    if (randomAgi >= 21 && randomAgi <= 45)
                        return 20;
                    if (randomAgi >= 46 && randomAgi <= 80)
                        return 30;
                    if (randomAgi >= 81 && randomAgi <= 100)
                        return 40;
                    break;
                case "Encroachment":
                    if (randomAgi >= 1 && randomAgi <= 5)
                        return 10;
                    if (randomAgi >= 6 && randomAgi <= 15)
                        return 20;
                    if (randomAgi >= 16 && randomAgi <= 40)
                        return 30;
                    if (randomAgi >= 41 && randomAgi <= 80)
                        return 40;
                    if (randomAgi >= 81 && randomAgi <= 95)
                        return 50;
                    if (randomAgi >= 96 && randomAgi <= 100)
                        return 60;
                    break;
            }
            return 0;
        }
        private int RandomInt(int randomInt, Specialization spec)
        {
            switch (spec.Name)
            {
                case "Frontal Assault":
                    if (randomInt >= 1 && randomInt <= 40)
                        return 20;
                    if (randomInt >= 41 && randomInt <= 75)
                        return 30;
                    if (randomInt >= 76 && randomInt <= 90)
                        return 40;
                    if (randomInt >= 91 && randomInt <= 100)
                        return 50;
                    break;
                case "Distance Fighting":
                    if (randomInt >= 1 && randomInt <= 30)
                        return 30;
                    if (randomInt >= 31 && randomInt <= 80)
                        return 40;
                    if (randomInt >= 81 && randomInt <= 100)
                        return 50;
                    break;
                case "Encroachment":
                    if (randomInt >= 1 && randomInt <= 20)
                        return 20;
                    if (randomInt >= 21 && randomInt <= 50)
                        return 30;
                    if (randomInt >= 51 && randomInt <= 75)
                        return 40;
                    if (randomInt >= 76 && randomInt <= 100)
                        return 50;
                    break;
            }
            return 0;
        }
        private int RandomPer(int randomPer, Specialization spec)
        {
            switch (spec.Name)
            {
                case "Frontal Assault":
                    if (randomPer >= 1 && randomPer <= 45)
                        return 30;
                    if (randomPer >= 46 && randomPer <= 90)
                        return 40;
                    if (randomPer >= 91 && randomPer <= 100)
                        return 50;
                    break;
                case "Distance Fighting":
                    if (randomPer >= 1 && randomPer <= 10)
                        return 30;
                    if (randomPer >= 11 && randomPer <= 50)
                        return 40;
                    if (randomPer >= 51 && randomPer <= 100)
                        return 50;
                    break;
                case "Encroachment":
                    if (randomPer >= 1 && randomPer <= 35)
                        return 30;
                    if (randomPer >= 36 && randomPer <= 85)
                        return 40;
                    if (randomPer >= 86 && randomPer <= 100)
                        return 50;
                    break;
            }
            return 0;
        }
        private int RandomWP(int randomWP, Specialization spec)
        {
            switch (spec.Name)
            {
                case "Frontal Assault":
                    if (randomWP >= 1 && randomWP <= 65)
                        return 20;
                    if (randomWP >= 66 && randomWP <= 80)
                        return 30;
                    if (randomWP >= 81 && randomWP <= 95)
                        return 40;
                    if (randomWP >= 96 && randomWP <= 100)
                        return 50;
                    break;
                case "Distance Fighting":
                    if (randomWP >= 1 && randomWP <= 25)
                        return 20;
                    if (randomWP >= 26 && randomWP <= 55)
                        return 30;
                    if (randomWP >= 56 && randomWP <= 80)
                        return 40;
                    if (randomWP >= 81 && randomWP <= 100)
                        return 50;
                    break;
                case "Encroachment":
                    if (randomWP >= 1 && randomWP <= 10)
                        return 20;
                    if (randomWP >= 11 && randomWP <= 40)
                        return 30;
                    if (randomWP >= 41 && randomWP <= 75)
                        return 40;
                    if (randomWP >= 76 && randomWP <= 100)
                        return 50;
                    break;
            }
            return 0;
        }
        private int RandomFel(int randomFel, Specialization spec)
        {
            switch (spec.Name)
            {
                case "Frontal Assault":
                    if (randomFel >= 1 && randomFel <= 50)
                        return 10;
                    if (randomFel >= 51 && randomFel <= 95)
                        return 20;
                    if (randomFel >= 96 && randomFel <= 100)
                        return 30;
                    break;
                case "Distance Fighting":
                    if (randomFel >= 1 && randomFel <= 70)
                        return 10;
                    if (randomFel >= 71 && randomFel <= 90)
                        return 20;
                    if (randomFel >= 91 && randomFel <= 100)
                        return 30;
                    break;
                case "Encroachment":
                    if (randomFel >= 1 && randomFel <= 35)
                        return 10;
                    if (randomFel >= 36 && randomFel <= 80)
                        return 20;
                    if (randomFel >= 81 && randomFel <= 100)
                        return 30;
                    break;
            }
            return 0;
        }
        private int RandomSR(int randomSR, Specialization spec)
        {
            switch (spec.Name)
            {
                case "Frontal Assault":
                    if (randomSR >= 1 && randomSR <= 20)
                        return (rnd.Next(1,6)+3)*10;
                    if (randomSR >= 21 && randomSR <= 50)
                        return (rnd.Next(1, 6) + 7) * 10;
                    if (randomSR >= 51 && randomSR <= 75)
                        return (rnd.Next(1, 6) + 9) * 10;
                    if (randomSR >= 76 && randomSR <= 90)
                        return (rnd.Next(1, 6) + 10) * 10;
                    if (randomSR >= 91 && randomSR <= 95)
                        return (rnd.Next(1, 11) + 10) * 10;
                    if (randomSR >= 96 && randomSR <= 100)
                        return 200;
                    break;
                case "Distance Fighting":
                    if (randomSR >= 1 && randomSR <= 10)
                        return (rnd.Next(1, 6) + 3) * 10;
                    if (randomSR >= 11 && randomSR <= 25)
                        return (rnd.Next(1, 6) + 7) * 10;
                    if (randomSR >= 26 && randomSR <= 50)
                        return (rnd.Next(1, 6) + 9) * 10;
                    if (randomSR >= 51 && randomSR <= 80)
                        return (rnd.Next(1, 6) + 10) * 10;
                    if (randomSR >= 81 && randomSR <= 90)
                        return (rnd.Next(1, 11) + 10) * 10;
                    if (randomSR >= 91 && randomSR <= 100)
                        return 200;
                    break;
                case "Encroachment":
                    if (randomSR >= 1 && randomSR <= 15)
                        return (rnd.Next(1, 6) + 7) * 10;
                    if (randomSR >= 16 && randomSR <= 50)
                        return (rnd.Next(1, 6) + 9) * 10;
                    if (randomSR >= 51 && randomSR <= 80)
                        return (rnd.Next(1, 6) + 10) * 10;
                    if (randomSR >= 81 && randomSR <= 90)
                        return (rnd.Next(1, 11) + 10) * 10;
                    if (randomSR >= 91 && randomSR <= 100)
                        return 200;
                    break;
            }
            return 0;
        }
        private BodySize RandomSize(int randomSize, BodyType bodyType)
        {
            switch (bodyType.Name)
            {
                case "Bipedal":
                    if (randomSize >= 1 && randomSize <= 10)
                        return ComboBoxSize[0];
                    else if (randomSize >= 11 && randomSize <= 80)
                        return ComboBoxSize[1];
                    else if (randomSize >= 81 && randomSize <= 99)
                        return ComboBoxSize[2];
                    else if (randomSize == 100)
                        return ComboBoxSize[3];
                    break;
                case "Insectile":
                    if (randomSize >= 1 && randomSize <= 10)
                        return ComboBoxSize[0];
                    else if (randomSize >= 11 && randomSize <= 60)
                        return ComboBoxSize[1];
                    else if (randomSize >= 61 && randomSize <= 95)
                        return ComboBoxSize[2];
                    else if (randomSize >= 96 && randomSize <= 100)
                        return ComboBoxSize[3];
                    break;
                case "Orbital":
                    if (randomSize >= 1 && randomSize <= 10)
                        return ComboBoxSize[2];
                    else if (randomSize >= 11 && randomSize <= 80)
                        return ComboBoxSize[3];
                    else if (randomSize >= 81 && randomSize <= 100)
                        return ComboBoxSize[4];
                    break;
                case "Bestial":
                    if (randomSize >= 1 && randomSize <= 15)
                        return ComboBoxSize[0];
                    else if (randomSize >= 16 && randomSize <= 65)
                        return ComboBoxSize[1];
                    else if (randomSize >= 66 && randomSize <= 90)
                        return ComboBoxSize[2];
                    else if (randomSize >= 91 && randomSize <= 100)
                        return ComboBoxSize[4];
                    break;
                case "Artificial":
                    if (randomSize >= 1 && randomSize <= 20)
                        return ComboBoxSize[0];
                    else if (randomSize >= 21 && randomSize <= 50)
                        return ComboBoxSize[1];
                    else if (randomSize >= 51 && randomSize <= 80)
                        return ComboBoxSize[2];
                    else if (randomSize >= 81 && randomSize <= 100)
                        return ComboBoxSize[3];
                    break;
                case "Amorphous":
                    if (randomSize >= 1 && randomSize <= 5)
                        return ComboBoxSize[0];
                    else if (randomSize >= 6 && randomSize <= 35)
                        return ComboBoxSize[1];
                    else if (randomSize >= 36 && randomSize <= 70)
                        return ComboBoxSize[2];
                    else if (randomSize >= 71 && randomSize <= 99)
                        return ComboBoxSize[3];
                    else if (randomSize == 100)
                        return ComboBoxSize[4];
                    break;
            }
            return null;
        }
        private Locomotion RandomLocomotion(int randomLocomotion, BodyType bodyType)
        {
            switch (bodyType.Name)
            {
                case "Bipedal":
                    if (randomLocomotion >= 1 && randomLocomotion <= 50)
                        return ComboBoxLocomotion[0];
                    else if (randomLocomotion >= 51 && randomLocomotion <= 75)
                        return ComboBoxLocomotion[2];
                    else if (randomLocomotion >= 76 && randomLocomotion <= 90)
                        return ComboBoxLocomotion[3];
                    else if (randomLocomotion >= 91 && randomLocomotion <= 95)
                        return ComboBoxLocomotion[4];
                    else if (randomLocomotion >= 96 && randomLocomotion <= 100)
                        return ComboBoxLocomotion[5];
                    break;
                case "Insectile":
                    if (randomLocomotion >= 1 && randomLocomotion <= 50)
                        return ComboBoxLocomotion[0];
                    else if (randomLocomotion >= 51 && randomLocomotion <= 60)
                        return ComboBoxLocomotion[1];
                    else if (randomLocomotion >= 61 && randomLocomotion <= 70)
                        return ComboBoxLocomotion[2];
                    else if (randomLocomotion >= 71 && randomLocomotion <= 100)
                        return ComboBoxLocomotion[4];
                    break;
                case "Orbital":
                    if (randomLocomotion >= 1 && randomLocomotion <= 90)
                        return ComboBoxLocomotion[4];
                    else if (randomLocomotion >= 91 && randomLocomotion <= 100)
                        return ComboBoxLocomotion[5];
                    break;
                case "Bestial":
                    if (randomLocomotion >= 1 && randomLocomotion <= 40)
                        return ComboBoxLocomotion[0];
                    else if (randomLocomotion >= 41 && randomLocomotion <= 75)
                        return ComboBoxLocomotion[1];
                    else if (randomLocomotion >= 76 && randomLocomotion <= 90)
                        return ComboBoxLocomotion[2];
                    else if (randomLocomotion >= 91 && randomLocomotion <= 100)
                        return ComboBoxLocomotion[4];
                    break;
                case "Artificial":
                    if (randomLocomotion >= 1 && randomLocomotion <= 15)
                        return ComboBoxLocomotion[0];
                    else if (randomLocomotion >= 16 && randomLocomotion <= 20)
                        return ComboBoxLocomotion[1];
                    else if (randomLocomotion >= 21 && randomLocomotion <= 25)
                        return ComboBoxLocomotion[2];
                    else if (randomLocomotion >= 26 && randomLocomotion <= 75)
                        return ComboBoxLocomotion[3];
                    else if (randomLocomotion >= 76 && randomLocomotion <= 80)
                        return ComboBoxLocomotion[4];
                    else if (randomLocomotion >= 81 && randomLocomotion <= 100)
                        return ComboBoxLocomotion[5];
                    break;
                case "Amorphous":
                    if (randomLocomotion >= 1 && randomLocomotion <= 15)
                        return ComboBoxLocomotion[0];
                    else if (randomLocomotion >= 16 && randomLocomotion <= 20)
                        return ComboBoxLocomotion[1];
                    else if (randomLocomotion >= 21 && randomLocomotion <= 30)
                        return ComboBoxLocomotion[2];
                    else if (randomLocomotion >= 31 && randomLocomotion <= 70)
                        return ComboBoxLocomotion[3];
                    else if (randomLocomotion >= 71 && randomLocomotion <= 75)
                        return ComboBoxLocomotion[4];
                    else if (randomLocomotion >= 76 && randomLocomotion <= 100)
                        return ComboBoxLocomotion[5];
                    break;
            }
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
