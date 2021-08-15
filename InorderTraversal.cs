/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {        
       
       List<int> result = new List<int>();
       
       this.inorder(root, result) ;
        
       return result;
    }
    
    private void inorder(TreeNode root, List<int> result){
       
        if(root==null){
            return;
        }
        
        inorder(root.left, result);
        
        result.Add(root.val);
        
        inorder(root.right, result);
    }
}
