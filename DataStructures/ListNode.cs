using System.Text;

namespace AlgorithmsAndDataStructures.DataStructures;

// Node of a singly-linked list
internal class ListNode
{
    public int Value { get; set; }
    public ListNode? Next { get; set; }

    public ListNode(int value = 0, ListNode? next = null)
    {
        Value = value;
        Next = next;
    }

    public override string ToString()
    {
        var current = this;
        var sb = new StringBuilder();

        while (current != null)
        {
            sb.Append($"{current.Value}, ");
            current = current.Next;
        }
        sb.AppendLine();
        return sb.ToString();
    }
}
