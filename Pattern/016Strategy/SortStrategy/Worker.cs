namespace SortStrategy
{
    class Worker
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }
        public override string ToString() => $"{Name} {Age} {Salary}";
    }
}
