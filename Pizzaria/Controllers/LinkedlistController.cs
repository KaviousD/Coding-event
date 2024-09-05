using Microsoft.AspNetCore.Mvc;
using Pizzaria.Models;

namespace Pizzaria.Controllers
{
    public class LinkedListController : Controller
    {
        public IActionResult ReverseList()
        {
            var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
            var reversedHead = ReverseList(head);
            return View(reversedHead);
        }

        private ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;
            while (curr != null)
            {
                ListNode next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
            }
            return prev;
        }
    }
}
