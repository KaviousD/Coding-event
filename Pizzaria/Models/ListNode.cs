namespace Pizzaria.Models
{
    public class ListNode
    {
        public int Value { get; set; }
        public ListNode Next { get; set; }

        public ListNode(int value, ListNode next = null)
        {
            Value = value;
            Next = next;
        }
    }
}
