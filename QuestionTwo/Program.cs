using QuestionTwo.Models;

Branch root = new();

//main root
root.branches.Add(new Branch());
//Two on the root
root.branches[0].branches.Add(new Branch());
root.branches[0].branches.Add(new Branch());

//one on the left of the root
root.branches[0].branches[0].branches.Add(new Branch());

//three on the second branch
root.branches[0].branches[1].branches.Add(new Branch());
root.branches[0].branches[1].branches.Add(new Branch());
root.branches[0].branches[1].branches.Add(new Branch());

//one on the right.. then on the left of the root
root.branches[0].branches[1].branches[0].branches.Add(new Branch());

//two on the middle.. of the right of the root..
root.branches[0].branches[1].branches[1].branches.Add(new Branch());
root.branches[0].branches[1].branches[1].branches.Add(new Branch());

//one on the right.. of the middle.. of the right of the root..
root.branches[0].branches[1].branches[1].branches[0].branches.Add(new Branch());

int depth = CalculateDepth(root);
Console.WriteLine("Depth of structure: " + depth);

int CalculateDepth(Branch branch)
{
    if (branch.branches.Count == 0)
        return 0;

    int maxDepth = 0;

    foreach (Branch sub in branch.branches)
    {
        int depth = CalculateDepth(sub);

        if (depth > maxDepth)
            maxDepth = depth;
    }

    return maxDepth + 1;
}