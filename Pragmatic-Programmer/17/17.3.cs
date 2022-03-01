/**
* Write a function that traverses each node of a trie and prints each key, including all terminating ("*") keys.
*
* public class TrieNode 
* {
*     public Dictionary<char, TrieNode> children;

*     public TrieNode(Dictionary<char, TrieNode> children = null) 
*     {
*         this.children = children ?? new Dictionary<char, TrieNode>();
*     }
* }
*
*/


void TraverseTrieAndPrintKeys(TrieNode node)
{
    foreach(var key in node.children.Keys)
    {
        Console.WriteLine(key);
        
        if(!key.Equals('*'))
        {
            TraverseTrieAndPrintKeys(node.children[key]);
        }
    }
}