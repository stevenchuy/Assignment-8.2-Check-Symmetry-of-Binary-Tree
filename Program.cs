namespace Assignment_8._2_Check_Symmetry_of_Binary_Tree
{
    internal class Program
    {
        static public void Main(string[] args)
        {
            // Let us construct the Tree shown in the figure
            JMJ tree = new JMJ();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(2);
            tree.root.left.left = new Node(3);
            tree.root.left.right = new Node(4);
            tree.root.right.left = new Node(4);
            tree.root.right.right = new Node(3);
            Boolean output = tree.isSymmetric();
            if (output == true)
                Console.WriteLine("Symmetric");
            else
                Console.WriteLine("Not symmetric");
        }

        class Node
        {
            public int key;
            public Node left, right;

            // Constructor
            public Node(int item)
            {
                key = item;
                left = right = null;
            }
        }

        class JMJ
        {
            Node root;

            // returns true if trees with roots
            // as root1 and root2 are mirror
            Boolean isMirror(Node node1, Node node2)
            {
                // if both trees are empty,
                // then they are mirror image
                if (node1 == null && node2 == null)
                    return true;

                // For two trees to be mirror images,
                // the following three conditions must be true
                // 1 - Their root node's key must be same
                // 2 - left subtree of left tree and right 
                // subtree of right tree have to be mirror images
                // 3 - right subtree of left tree and left subtree
                // of right tree have to be mirror images
                if (node1 != null && node2 != null
                    && node1.key == node2.key)
                    return (isMirror(node1.left, node2.right)
                            && isMirror(node1.right, node2.left));

                // if none of the above conditions
                // is true then root1 and root2 are
                // mirror images
                return false;
            }

            // returns true if the tree is symmetric
            // i.e mirror image of itself
            public Boolean isSymmetric()
            {
                // check if tree is mirror of itself
                return isMirror(root, root);
            }
        }
    }
}
