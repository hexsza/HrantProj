using MyBubbleSort;
using MyInsertionSort;
using MySelectionSort;

namespace MainProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyStack<int> stack = new MyStack<int>();
            //MyQueue<int> queue = new MyQueue<int>();   
            //stack.Push(1);
            //stack.Push(2);  
            //stack.Push(3);
            //Console.WriteLine(stack);
            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Pop());

            //queue.Enqueue(1);
            //queue.Enqueue(2);   
            //queue.Enqueue(3);

            //Console.WriteLine(queue);

            //Console.WriteLine(queue.Peek());
            //Console.WriteLine(queue.Dequeue());


            //MyBinaryTree<int> tree = new MyBinaryTree<int>();

            //// Add
            //tree.Add(5);
            //tree.Add(3);
            //tree.Add(8);
            //tree.Add(9);
            //tree.Add(2);
            //tree.Add(6);
            //tree.Add(7);

            ////In-Order 
            //foreach (var item in tree.InOrder())
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine( );
            ////Pre-Order 
            //foreach (var item in tree.PreOrder())
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            ////Post-Order Traversal
            //foreach (var item in tree.PostOrder())
            //{
            //    Console.Write(item + " ");
            //}

            //// Remove
            //tree.Remove(2);

            //tree.Remove(3);

            //tree.Remove(5);

            //Console.WriteLine();

            ////PreOrder After Removals
            //foreach (var item in tree.PreOrder())
            //{
            //    Console.Write(item + " ");
            //}

            MyBubbleSort<int> bubble = new MyBubbleSort<int>();
            int[] items = { 5, 2, 9, 6, 3, 10, 4, 1 };
            Console.WriteLine(string.Join(", ", items));
            bubble.Sort(items);
            Console.WriteLine(string.Join(", ", items));

            MyInsertionSort<int> insertion = new MyInsertionSort<int>();
            int[] itemss = { 5, 2, 9, 6, 3, 10, 4, 1 };
            Console.WriteLine(string.Join(", ", itemss));
            insertion.Sort(itemss);
            Console.WriteLine(string.Join(", ", itemss));

            MySelectionSort<int> selection = new MySelectionSort<int>();
            int[] itemsss = { 5, 2, 9, 6, 3, 10, 4, 1 };
            Console.WriteLine(string.Join(", ", itemsss));
            selection.Sort(itemsss);
            Console.WriteLine(string.Join(", ", itemsss));
        }
    }
}