using ScientistStrategy.Skills;

namespace ScientistStrategy
{
    class Earthling
    {
        private ProfessionalPhysics physicsBehavior;
        private ProgrammerPascal programmerBehavior;
        private NoMusician musician;

        public IPhysicsBehavior PhysicsBehavior { get; set; }
        public IProgrammerBehavior ProgrammerBehavior{ get; set; }
        public IMusician Musician { get; set; }

        public Earthling(IPhysicsBehavior physicsBehavior,
                        IProgrammerBehavior programmerBehavior,
                        IMusician musician)
        {
            this.PhysicsBehavior = physicsBehavior;
            this.ProgrammerBehavior = programmerBehavior;
            this.Musician = musician;
        }

        public Earthling(ProfessionalPhysics physicsBehavior, ProgrammerPascal programmerBehavior, NoMusician musician)
        {
            this.physicsBehavior = physicsBehavior;
            this.programmerBehavior = programmerBehavior;
            this.musician = musician;
        }

        public void SolveTask() => PhysicsBehavior.SolvingPhysics();
        public void Coding() => ProgrammerBehavior.Programming();
        public void Hobby() => Musician.Play();
    }
}
