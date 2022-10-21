using IteratorPattern;
using IteratorPattern.BinaryTree;

var numericalComparer = new BinaryTreeNumberComparer();
var binaryTreeBuilder = new BinaryTreeBuilder<int>(numericalComparer);

binaryTreeBuilder.Add(20);
binaryTreeBuilder.Add(10);
binaryTreeBuilder.Add(5);
binaryTreeBuilder.Add(11);
var tree = binaryTreeBuilder.Build();
var traverseTree = new BFSEnumerator<int>(tree);

var enumerator = traverseTree.GetEnumerator();

Console.WriteLine(enumerator.Current);
while (enumerator.MoveNext()) Console.WriteLine(enumerator.Current);
