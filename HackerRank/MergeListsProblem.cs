namespace HackerRank
{
    public static class MergeListsProblem
    {
        //https://www.hackerrank.com/challenges/merge-two-sorted-linked-lists/problem

        public static SinglyLinkedListNode MergeLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {
            var arr1 = new List<SinglyLinkedListNode>();

            var headItems = head1;

            while (headItems != null)
            {
                arr1.Add(headItems);
                headItems = headItems.Next;
            }

            var head2Items = head2;
            while (head2Items != null)
            {
                arr1.Add(head2Items);
                head2Items = head2Items.Next;
            }

            var resultList = arr1.OrderBy(x => x.Data).ToList();

            for (var i = 0; i < resultList.Count; i++)
            {
                resultList[i].Next = i + 1 < resultList.Count && resultList[i + 1] != null ? resultList[i + 1] : null;
            }

            return resultList[0];
        }
    }

    public class SinglyLinkedListNode
    {
        public int Data { get; set; }
        public SinglyLinkedListNode? Next { get; set; }
        public SinglyLinkedListNode(int nodeData)
        {
            this.Data = nodeData;
            this.Next = null;
        }
    }
}
