using System;
using System.Collections.Generic;

public class TreeNode<T>
{
    // Contains the value of the node
    public T value;
    // Shows whether the current node has a parent or not
    public bool hasParent;
    // Contains the children of the node (zero or more)
    public List<TreeNode<T>> children;
    // Constructs a tree node, “value” is the value of the node
    public TreeNode(T value)
    {
        if (value != null)
        {
            this.value = value;
            this.children = new List<TreeNode<T>>();
        }
    }


    public void AddChild(TreeNode<T> child)
        {
            child.hasParent = true;
            this.children.Add(child);
        }
        public TreeNode<T> GetChild(int index)
        {
            return children[index];
        }
    }

}
