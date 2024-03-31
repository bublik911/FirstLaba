namespace Tree
{
    public class Tree
    {
        public List<Tree> Child { get; set; }

        public string Value { get; set; }

        //private int Levels = 1;

        public Tree(string value)
        {
            this.Value = value;
            Child = new List<Tree>();
        }

        public Tree(string value, Tree prev)
        {
            //Levels++;
            this.Value = value;
            this.Child = new List<Tree>();
            prev.Child.Add(this);
        }

        public List<string> ToCollection()
        {
            var mas = new List<string>();
            mas.Add(Value);

            if (Child.Count == 0)
                return mas;

            foreach (var child in Child)
            {
                mas.AddRange(child.ToCollection());
            }

            return mas;
        }


        public void PrintGraf()
        {
            foreach (string Node in this.ToCollection())
            {
                Console.WriteLine(Node);
            }
        }

    }
}
