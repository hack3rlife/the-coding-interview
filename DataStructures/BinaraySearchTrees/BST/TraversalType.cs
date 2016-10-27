namespace com.hack3rlife.datastructures
{
    /// <summary>
    /// Traversing type
    /// </summary>
    /// <see cref="http://en.wikipedia.org/wiki/Tree_traversal#Types"/>
    public enum TraversalType
    {
        /// <summary>
        /// Depth-first - Inorder: Left child, Root, Right child
        /// </summary>
        InOrder = 0,

        /// <summary>
        /// Depth-first - Preorder: Root, Left child, Right child
        /// </summary>
        PreOrder = 1,

        /// <summary>
        /// Depth-first - Postorder: Left Child, Right child, Root
        /// </summary>
        PostOrder = 2,

        /// <summary>
        /// Breadth-first - Bylevel
        /// </summary>
        InLevels = 4
    }
}
