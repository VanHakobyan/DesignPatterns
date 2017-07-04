namespace CompositeTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Component root = new Composite("root");
            Component branch1 = new Composite("br1");
            Component branch2 = new Composite("br2");
            Component leaf1 = new Leaf("leaf1");
            Component leaf2 = new Leaf("leaf2");
            Component leaf3 = new Leaf("leaf3");

            //Create tree

            root.Add(branch1);
            root.Add(branch2);

            //           *           //Root
            //        /     \
            //       *       *       //branch1 and branch2

            branch1.Add(leaf1);
            branch2.Add(leaf2);
            branch1.Add(leaf3);

            //           *           //Root
            //        /     \       
            //       *       *       //branch1 and branch2
            //     / |        \
            //    ~  ~         ~     // leaf1,leaf3 and leaf2
            //
            //
            root.Operation();        // Creating
        }
    }
}
