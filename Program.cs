// private static List<int> _dataList = new List<int>();
public static Node removeDuplicates(Node head)
{

	if (head == null || head.next == null)
	{
		return head;
	}
	if (head.data == head.next.data)
	{
		head.next = head.next.next;
		removeDuplicates(head);
	}
	if (head != head.next)

	{
		removeDuplicates(head.next);
	}

	return head;

}
