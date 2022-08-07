
List<int> l3 = new List<int> { 1, 3, 4 };
List<int> l4 = new List<int> { 1, 2, 4 };

ListNode l1 = new ListNode(1);
ListNode l2 = new ListNode(2);

ListNode MergeTwoLists(ListNode l1, ListNode l2)
{
    ListNode dummy = new ListNode();
    ListNode tail = dummy;

    if (l1 == null) return l2;
    if (l2 == null) return l1;

    while (l1 != null && l2 != null)
    {
        if (l1.val < l2.val)
        {
            tail.next = l1;
            tail = tail.next;
            l1 = l1.next;
        }
        else
        {
            tail.next = l2;
            tail = tail.next;
            l2 = l2.next;
        }
    }

    if (l1 != null)
    {
        tail.next = l1;
    }
    else if (l2 != null)
    {
        tail.next = l2;
    }

    return dummy.next;
}


ListNode ans = MergeTwoLists(l1, l2);

while(ans.next != null)
{
    Console.WriteLine(ans.val);
    ans.val = ans.next.val;
    // break;
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }     

}

